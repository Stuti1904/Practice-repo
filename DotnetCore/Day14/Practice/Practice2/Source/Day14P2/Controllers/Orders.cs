using Day14P2.Models;
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
    public class Orders : ControllerBase
    {
        private OrderFunction orderFunction { get; set; }
        public Orders()
        {
            orderFunction = new OrderFunction();
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await orderFunction.GetOrders());
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {        
           return Ok(await orderFunction.AddOrder(order));
            
        }
    }
}
