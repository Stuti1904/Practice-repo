using hotstar.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hotstar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentService service { get; set; }

        public CommentController(ICommentService comment)
        {
            this.service = comment;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(service.GetByContentId(id));
        }
        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] Comment comment)
        {
            return Ok(service.Add(comment));
        }
    }
}
