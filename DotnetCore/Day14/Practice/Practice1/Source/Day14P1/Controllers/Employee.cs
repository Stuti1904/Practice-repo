using Day14P1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
namespace Day14P1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        private DataHelper DataHelper { get; set; }
        public Employee()
        {
            DataHelper = new DataHelper();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await DataHelper.GetDemoEmployees());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await DataHelper.GetEmployee(id));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DemoEmployee employee)
        {
            var arr = new List<String>();
            if (string.IsNullOrEmpty(employee.EmpName))
            {
                arr.Add("NAME IS REQUIRED");
            }
            if (arr.Count > 0)
                return BadRequest(arr);
            else
                return Ok(await DataHelper.AddEmployee(employee));
        }

        [HttpPatch("{id}")]
        public async Task <IActionResult> Patch(int id, [FromBody] JsonPatchDocument<DemoEmployee> patchEmployee)
        {
            var employee = await DataHelper.GetEmployee(id);
            patchEmployee.ApplyTo(employee);
            return Ok(await DataHelper.UpdateEmployee(employee));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok( await DataHelper.DeleteEmployee(id));
        }
    }
}
