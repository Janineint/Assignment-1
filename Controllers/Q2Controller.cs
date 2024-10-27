using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {

        /// <summary>
        /// Returns a greeting message with the given name.
        /// </summary>
        /// <param name="name">The name to include in the greeting.</param>
        /// <returns>A greeting string.</returns>
        /// <example>GET /api/q2/greeting?name=Gary</example>
        [HttpGet("greeting")]
        public IActionResult GetGreeting([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Name is required");
            }

            
            var decodedName = HttpUtility.UrlDecode(name);
            var greetingMessage = $"Hi {decodedName}!";
            return Ok(greetingMessage);
        }
    }
}
