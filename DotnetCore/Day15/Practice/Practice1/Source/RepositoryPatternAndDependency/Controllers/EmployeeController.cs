using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternAndDependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAndDependency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
      
        private IEmployeeService EmployeeService { get; set; }
        public EmployeeController(IEmployeeService employeeService)
        {
            EmployeeService = employeeService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] DemoEmployee employee)
        {
            var arr = new List<String>();
            if (string.IsNullOrEmpty(employee.EmpName))
            {
                arr.Add("NAME IS REQUIRED");
            }
            if (arr.Count > 0)
                return BadRequest(arr);
            else
                return Ok(EmployeeService.Add(employee));
        }

        [HttpGet]
        public IActionResult Get()
        {
         
            return Ok(EmployeeService.GetAllEmployees());
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            return Ok(EmployeeService.GetByID(id));
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DemoEmployee employee)
        {
            return Ok(EmployeeService.UpdateEmployee(id, employee));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return Ok(EmployeeService.Delete(id));
        }
    }
}
