using Day3_02.Models;

namespace Day3_02.Repositries
{
    public class EmployeeRepos : IEmployeeRepos
    {
        EmployeeDbContext _context;

        public EmployeeRepos(EmployeeDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee obj = _context.Employees.Find(id);
            _context.Employees.Remove(obj);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> stList = _context.Employees.ToList();
            return stList;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee obj = _context.Employees.Find(id);
            return obj;
        }
        
        /*
        public IEnumerable<Employee> GetEmployeeByJob(string Job)
        {
            IEnumerable<Employee> lst = _context.Employees.Where(i => i.Job == Job);
            return lst;
        }

        public IEnumerable<Employee> GetEmployeeByDeptno(int Deptno)
        {
            IEnumerable<Employee> lst = _context.Employees.Where(i => i.Deptno == Deptno);
            return lst;
        } */

         public void UpdateEmployee(Employee obj)
        {
            _context.Employees.Update(obj);
            _context.SaveChanges();
        }
    }
}