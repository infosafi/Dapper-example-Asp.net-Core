using Dapper_example.Models;
using Dapper_example.Repository;
using Dapper_example.Repository.Helper;
using Dapper_example.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dapper_example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStoreProcedureAccess _dbAcccess;

        public HomeController(ILogger<HomeController> logger, IStoreProcedureAccess dbAcccess)
        {
            _logger = logger;
            _dbAcccess= dbAcccess;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [Route("/employee-list")]
        public async Task<IActionResult> AllEmployee()
        {
            var parms = new SPParameters();
            parms.StoredProcedure = "dbo.SP_EMPLOYEE_MGT";           
            parms.Calltype = "GET_ALL_EMPLOYEE";           
            var emplist = await Task.FromResult(_dbAcccess.DataListMax20<VMEmployee>(parms));
                
            ViewBag.Employees = emplist;
            _logger.LogInformation("Data Found! Employee List Loaded");
            return View();
        }

        [HttpGet]
        //[Route("/delete-employee/{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var parms = new SPParameters();
            parms.StoredProcedure = "dbo.SP_EMPLOYEE_MGT";
            parms.Calltype = "DELETE_SINGLE_EMPLOYEE";
            parms.Desc01 = id.ToString();
            bool result = await Task.FromResult(_dbAcccess.ExecuteMax20(parms));
            string message = "";
            if (result)
            {
                _logger.LogInformation("Employee Removed {id}", id);
                message = "Data Remove Successfully";
            }
            TempData["msg"] = message;

            return RedirectToAction("AllEmployee");
        }

        [HttpGet]
        [Route("/add-employee")]
        public IActionResult AddEmployee()
        {

            return  View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveEmployee(VMEmployee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee == null)
                {
                    TempData["msg"] = "Update Failed No data found to save";
                    TempData["msgtype"] = "alert alert-danger";
                    return RedirectToAction("AddEmployee");
                }
                var parms = new SPParameters();
                parms.StoredProcedure = "dbo.SP_EMPLOYEE_MGT";
                parms.Calltype = "UPDATE_EMPLOYEE";
                parms.Desc01 = employee.employeeid ?? "";
                parms.Desc02 = employee.firstname??"";
                parms.Desc03 = employee.lastname ?? "";
                parms.Desc04 = employee.jobtitle ?? "";
                parms.Desc05 = employee.salary.ToString();
                parms.Desc06 = employee.hiredate.ToString();

                bool result = await Task.FromResult(_dbAcccess.ExecuteMax20(parms));


                if (result) {
                    _logger.LogInformation("Data Update Successfully");

                    TempData["msg"] = "Update Successfully";
                    TempData["msgtype"] = "alert alert-success";
                    return RedirectToAction("AddEmployee");
                    
                }
                else
                {
                    TempData["msg"] = "Update Failed";
                    TempData["msgtype"] = "alert alert-danger";
                    return RedirectToAction("AddEmployee");
                }
            }
            else
            {
                TempData["msg"] = "Unknown Validation";
                TempData["msgtype"] = "alert alert-danger";
                return RedirectToAction("AddEmployee");
            }

        }
    }
}
