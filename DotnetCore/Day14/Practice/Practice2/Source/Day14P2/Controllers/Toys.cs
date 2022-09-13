using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Toys : ControllerBase
    {
        private ToyFunction toyf { get; set; }
        public Toys()
        {
            toyf = new ToyFunction();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await toyf.GetToys());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await toyf.SearchToy(id));
        }
    }
}
