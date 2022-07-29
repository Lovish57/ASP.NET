using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day5_01.Model;
using Microsoft.EntityFrameworkCore;
namespace Day5_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeDbContext _context;
        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var stdList = await _context.Employees.ToListAsync();
            return Ok(stdList);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var stdObj = await _context.Employees.FindAsync(id);

            if (stdObj != null)
                return Ok(stdObj);
            else
                return NotFound("Requested Employee Id does not exists.");
        }


        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee obj)
        {
            await _context.Employees.AddAsync(obj);
            await _context.SaveChangesAsync();
            return Ok("New Employee details are saved in database.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee obj)
        {
            _context.Employees.Update(obj);
            await _context.SaveChangesAsync();
            return Ok("Employee details are updated in database.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var stdObj = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(stdObj);
            await _context.SaveChangesAsync();
            return Ok("Employee details are deleted from database.");
        }
    }
}
