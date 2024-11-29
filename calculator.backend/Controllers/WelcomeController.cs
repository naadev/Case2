using Microsoft.AspNetCore.Mvc;

namespace calculator.backend.Controllers
{
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult Welcome()
        {
            return Ok(new { message = "welcome" });
        }
    }
}