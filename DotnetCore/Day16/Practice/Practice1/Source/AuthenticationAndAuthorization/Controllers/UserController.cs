using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorization.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJWTManagerRepository jWTManagerRepository;

        public UserController(IJWTManagerRepository jWTManagerRepository)
        {
            this.jWTManagerRepository = jWTManagerRepository;

        }
        [HttpGet]
        public List<string> Get()
        {
            var users = new List<string>
            {
                "stuti shahu",
                "Hritika Shahu",
                "Dhananjay Shahu"
            };
            return users;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(Users users)
        {
            var token = jWTManagerRepository.Authenticate(users);
            if(token== null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
