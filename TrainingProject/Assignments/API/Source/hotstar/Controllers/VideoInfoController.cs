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
    public class VideoInfoController : ControllerBase
    {
        private IVideoService service { get; set; }

        public VideoInfoController(IVideoService serv)
        {
            service = serv;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(service.GetAll());
        }

    }
}
