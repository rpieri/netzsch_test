using Microsoft.AspNetCore.Mvc;

namespace NetzschTestServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class MessageController : ControllerBase
    {

        public MessageController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
