using Day3_02.Models;

namespace Day3_02.Repositries
{
    public interface IEmployeeRepos
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void AddEmployee(Employee obj);
        void UpdateEmployee(Employee obj);
        void DeleteEmployee(int id);
    }
}