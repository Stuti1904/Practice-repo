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
    public class Customers : ControllerBase
    {

        private CustomerFunction customerFunction { get; set; }

        public Customers()
        {
            customerFunction = new CustomerFunction();
        }
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await customerFunction.GetCustomers());
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Customer customers)
        {
            var arr = new List<String>();
            if (string.IsNullOrEmpty(customers.CustomerName))
            {
                arr.Add("NAME IS REQUIRED");
            }
            if (arr.Count > 0)
            {
                return BadRequest(arr);
            }
            else
            {
                return Ok(await customerFunction.AddCustomer(customers));
            }
        }
     
        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, [FromBody] Customer customer)
        {
            return Ok(await customerFunction.UpdateCustomer(id, customer));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            return Ok(await customerFunction.DeleteCustomer(id));
        }

    }
}
