using hotstar.Models;
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
    public class SignUpController : ControllerBase
    {
        private ISignUpService service { get; set; }

        public SignUpController(ISignUpService signUpService)
        {
            service = signUpService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            return Ok(service.Add(user));
        }
    }
}
