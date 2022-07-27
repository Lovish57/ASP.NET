namespace Day2_03.Models
{
    public class EmployeeManager
    {
        public static List<Employee> employee = new List<Employee>();
        public EmployeeManager()
        {
            employee = new List<Employee>() {
                new Employee(){ EmployeeId = 1, EmployeeName = "Phil Jones", Job = "Sde", Sal = 5000 ,Deptno=1},
                new Employee(){ EmployeeId = 2, EmployeeName = "Matic", Job = "accountant", Sal = 3000,Deptno=1 },
                new Employee(){ EmployeeId = 3, EmployeeName = "Maguire", Job = "Salesman", Sal = 40000,Deptno=1 },
                new Employee(){ EmployeeId = 4, EmployeeName = "Wan Bissaka", Job = "manager", Sal = 2000,Deptno=1 },
                new Employee(){ EmployeeId = 5, EmployeeName = "Shaw", Job = "IT", Sal = 60000,Deptno=1 }
            };
        }
        public List<Employee> GetAllDets()
        {
            return employee;
        }
        public Employee GetEmployeeById(int id)
        {
            return employee.Find(item => item.EmployeeId == id);
        }
        public void AddEmployee(Employee obj)
        {
            employee.Add(obj);
        }
        public void DeleteEmployee(int id)
        {
            Employee obj = employee.Find(item => item.EmployeeId == id);
            employee.Remove(obj);
        }
        public void UpdateEmployee(Employee updateObj)
        {
            Employee obj = employee.Find(item => item.EmployeeId == updateObj.EmployeeId);
            employee.Remove(obj);
            employee.Add(updateObj);
        }

    }
}