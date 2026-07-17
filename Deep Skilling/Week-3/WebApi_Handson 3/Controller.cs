using Microsoft.AspNetCore.Mvc;
using WebApi_Handson_3.Filters;
using WebApi_Handson_3.Models;
namespace WebApi_Handson_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id=1,
                    Name="Akshaya",
                    Salary=50000,
                    Permanent=true,
                    DateOfBirth=new DateTime(2003,5,20),
                    Department=new Department{Id=1,Name="IT"},
                    Skills=new List<Skill>
                    {
                        new Skill{Id=1,Name="C#"},
                        new Skill{Id=2,Name="SQL"}
                    }
                }
            };
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }
    }
}
