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
                message = "Data Remove Successfully";
            }
            TempData["msg"] = message;
            return RedirectToAction("AllEmployee");
        }
    }
}
