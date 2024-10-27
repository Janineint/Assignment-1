using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {

        /// <summary>
        /// Returns the start of a knock-knock joke.
        /// </summary>
        /// <returns>A string saying "Who's there?"</returns>
        /// <example>POST /api/q4/knockknock</example>
        [HttpPost("knockknock")]
        public IActionResult PostKnockKnock()
        {
            return Ok("Who's there?");
        }
    }
}