using Microsoft.AspNetCore.Mvc;
using WebApi_Handson_4.Models;
namespace WebApi_Handson_4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Akshaya", Salary = 50000 },
            new Employee { Id = 2, Name = "Ravi", Salary = 45000 },
            new Employee { Id = 3, Name = "Priya", Salary = 60000 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(employees);
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp == null)
                return NotFound();

            return Ok(emp);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
                return BadRequest("Invalid employee id");
            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            return Ok(existingEmployee);
        }
    }
}
