using Day15A1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15A1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private DataHelper dataHelper { get; set; }
        public EmployeeController()
        {
            dataHelper = new DataHelper();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await dataHelper.GetEmployees());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await dataHelper.GetEmployee(id));
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeFifteen employee)
        {
                return Ok(await dataHelper.AddEmployee(employee));
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<EmployeeFifteen> patchEmployee)
        {
            var employee = await dataHelper.GetEmployee(id);
            patchEmployee.ApplyTo(employee);
            return Ok(await dataHelper.UpdateEmployee(employee));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await dataHelper.DeleteEmployee(id));
        }
        [Route("Controller/{id}/Assignment/{childID}")]
        [HttpGet("{id},{ChidlID}")]
        public ActionResult GetChild(int id, int childId)
        {
            return Ok(dataHelper.GetAssignmentByEmployee(id, childId));
        }
    }
}
