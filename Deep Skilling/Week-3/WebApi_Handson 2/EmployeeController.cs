using Microsoft.AspNetCore.Mvc;
using WebApi_Handson_2.Models;
namespace WebApi_Handson_2.Controllers
{
    [ApiController]
    [Route("api/Emp")]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=1,Name="Akshaya",Salary=50000},
            new Employee{Id=2,Name="Ravi",Salary=45000},
            new Employee{Id=3,Name="Priya",Salary=60000}
        };
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
        public IActionResult Post(Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }
    }
}
