using Microsoft.AspNetCore.Mvc;
using Day3_02.Models;

namespace Day3_02.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context, ILogger<EmployeeController> logger)
        {
            _context = context;
            _logger = logger;

        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Action is Processed.");

            List<Employee> stList = _context.Employees.ToList();
            return View(stList);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Employee obj = _context.Employees.Find(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = _context.Employees.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _context.Employees.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = _context.Employees.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            Employee obj = _context.Employees.Find(id);
            _context.Employees.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}