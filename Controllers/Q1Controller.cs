using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Returns a welcome message.
        /// </summary>
        /// <returns>A welcome message string.</returns>
        /// <example>GET /api/q1/welcome</example>
        [HttpGet("welcome")]
        public IActionResult GetWelcomeMessage()
        {
            return Ok("Welcome to 5125!");
        }
    }
}
