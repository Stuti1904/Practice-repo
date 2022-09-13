using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotstar.Models;

namespace hotstar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationObjectController : ControllerBase
    {
        private IApplicationObjectService service { get; set; }

        public ApplicationObjectController(IApplicationObjectService repository)
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
