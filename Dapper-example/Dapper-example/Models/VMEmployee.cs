using System.ComponentModel.DataAnnotations;

namespace Dapper_example.Models
{
    public class VMEmployee
    {
        public string? employeeid { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? jobtitle { get; set; }
        [Required(ErrorMessage = "Salary required")]
        public double? salary { get; set; }
        public DateTime? hiredate { get; set; }
    

    }
}
