using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string verbosity = null)
        {
            return Ok("Health check passed");
        }
    }
}