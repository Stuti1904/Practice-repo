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
    public class ResourceController : ControllerBase
    {

        private IResourceService resourceService { get; set; }

        public ResourceController(IResourceService resource)
        {
            resourceService = resource;
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(resourceService.GetAll());
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Post([FromBody] Resource resource)
        {
            return Ok(resourceService.Add(resource));
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Resource resource)
        {
            return Ok(resourceService.Update(id, resource));
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(resourceService.Delete(id));
        }
    }
}

