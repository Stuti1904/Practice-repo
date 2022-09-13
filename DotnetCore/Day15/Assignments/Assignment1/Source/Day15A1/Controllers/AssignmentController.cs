using Day15A1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15A1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private IAssignments Assignments { get; set; }

        public AssignmentController(IAssignments assignments)
        {
            Assignments = assignments;
        }
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(Assignments.GetAssignments());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Assignment assignments)
        {
            return Ok(Assignments.Add(assignments));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Assignment assignment)
        {
            return Ok(Assignments.UpdateAssignment(id, assignment));
        }


    }
}
