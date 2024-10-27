using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {

        /// <summary>
        /// Acknowledges the secret number sent in the request body.
        /// </summary>
        /// <param name="secret">The secret integer value from the request body.</param>
        /// <returns>A message acknowledging the secret.</returns>
        /// <example>POST /api/q5/secret</example>
        [HttpPost("secret")]
        public IActionResult PostSecret([FromBody] int secret)
        {
            var responseMessage = $"Shh.. the secret is {secret}";
            return Ok(responseMessage);
        }
    }
}
