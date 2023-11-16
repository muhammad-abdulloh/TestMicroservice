using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backet.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BacketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Bu Backet.API dan kelyapti");
        }
    }
}
