using Microsoft.EntityFrameworkCore;

namespace Day3_02.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string Employee_Name { get; set; }
        public string Job { get; set; }
        public int Sal { get; set; }
        public int Deptno { get; set; }

    }

    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
         : base(options)
        {

        }
    }
}