using ContentNegotiationInASPDOTNETCoreWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContentNegotiationInASPDOTNETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //GET api/employee
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            var listEmployees = new List<Employee>()
            {
                new Employee(){ Id = 1001, Name = "Anurag", Age = 28, Gender = "Male", Department = "IT" },
                new Employee(){ Id = 1002, Name = "Pranaya", Age = 28, Gender = "Male", Department = "IT" },
            };
            return Ok(listEmployees);
        }
    }
}
