using System.ComponentModel.DataAnnotations;

namespace Day2_03.Models
{
    public class Employee
    {   
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string EmployeeName { get; set; }
        public string Job { get; set; }
        public int Sal { get; set; }
        public int Deptno { get; set; }

    }
}