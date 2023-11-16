using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Bu Catalog.API dan kelyapti");
        }
    }
}
