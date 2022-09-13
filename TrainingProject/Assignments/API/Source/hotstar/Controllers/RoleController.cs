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
    public class RoleController : ControllerBase
    {
        private IRoleService service { get; set; }

        public RoleController(IRoleService repository)
        {
            service = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }
    }
}
