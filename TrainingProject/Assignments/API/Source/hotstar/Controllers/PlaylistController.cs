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
    public class PlaylistController : ControllerBase
    {
        private IPlaylistService service { get; set; }

        public PlaylistController(IPlaylistService serv)
        {
            service = serv;
        }
        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] Playlist list)
        {
            return Ok(service.Add(list));
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetByUserId(id));
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            return Ok(service.Delete(id));
        }
    }
}
