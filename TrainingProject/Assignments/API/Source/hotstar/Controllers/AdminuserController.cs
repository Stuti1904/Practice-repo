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
    public class AdminuserController : ControllerBase
    {
        private IAdminUserService contentService { get; set; }

        public AdminuserController(IAdminUserService content)
        {
            contentService = content;
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok(contentService.getadmin());
        }
        [HttpPost]
        public IActionResult post([FromBody] AdminUser admin)
        {
            return Ok(contentService.Add(admin));
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AdminUser user)
        {
            return Ok(contentService.Update(id, user));
        }
    }
}
