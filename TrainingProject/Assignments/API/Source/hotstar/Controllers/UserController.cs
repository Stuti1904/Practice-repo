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
    public class UserController : ControllerBase
    {
        private IUserService Service { get; set; }

        public UserController(IUserService content)
        {
            Service = content;
        }
        
        [HttpGet]
        public IActionResult get()
        {
            return Ok(Service.get());
        }
        [Authorize(Roles ="Admin")]
        [HttpPost]
        public IActionResult post([FromBody] User user)
        {
            return Ok(Service.Add(user));
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            return Ok(Service.Update(id, user));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(Service.Delete(id));
        }

        [HttpGet("{phone}")]

        public IActionResult GetByPhone(string phone)
        {
            return Ok(Service.GetByPhone(phone));
        }

    }
}
