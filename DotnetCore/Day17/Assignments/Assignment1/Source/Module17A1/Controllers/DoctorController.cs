using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module17A1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module17A1.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private DataHelper dataHelper { get; set; }
        private readonly IJWTManagerRepository jwTManagerRepository;
        public DoctorController(IJWTManagerRepository jWTManagerRepository)
        {
            this.jwTManagerRepository = jWTManagerRepository;
            dataHelper = new DataHelper();
        }
        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] Doctor doctor)
        //{

        //    return Ok(await dataHelper.AddDoctor(doctor));
        //}

        [Authorize]
        [HttpPost]
        
        public async Task<IActionResult> Post([FromBody] Doctor doctor)
        {
            return Ok(await dataHelper.AddDoctor(doctor));
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put( int id, [FromBody] Doctor doctor)
        {
            return Ok(await dataHelper.UpdateDoctor(id, doctor));
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            return Ok( await dataHelper.DeleteDoctor(id));
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await dataHelper.GetDoctor());
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Authenticate(Users users)
        {
            var token = jwTManagerRepository.Authenticate(users);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        
        
        }
       
    }
}
