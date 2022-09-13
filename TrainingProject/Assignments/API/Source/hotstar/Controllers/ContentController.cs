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
    public class ContentController : ControllerBase
    {

        private IContentService contentService { get; set; }

        public ContentController(IContentService content)
        {
            contentService = content;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(contentService.GetAll());
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Post([FromBody] Content content)
        {
            return Ok(contentService.Add(content));
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Content content)
        {
            return Ok(contentService.Update(id, content));
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return Ok(contentService.Delete(id));
        }
        [HttpGet("{name}")]
        public IActionResult GetOne(string name)
        {
            return Ok(contentService.Getonecontent(name));
        }
        [HttpPut("like/{id}")]
        public IActionResult Put(int id)
        {
            return Ok(contentService.UpdateLikes(id));
        }
        [HttpPut("dislike/{id}")]
        public IActionResult PutDislikes(int id)
        {
            return Ok(contentService.UpdateDisLikes(id));
        }
        [HttpPut("view/{id}")]
        public IActionResult Putview(int id)
        {
            return Ok(contentService.UpdateViews(id));
        }
    }
}
