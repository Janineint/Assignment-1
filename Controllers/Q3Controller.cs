using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {

        /// <summary>
        /// Returns the cube of the given integer base.
        /// </summary>
        /// <param name="baseValue">The integer to be cubed.</param>
        /// <returns>The cube of the base integer.</returns>
        /// <example>GET /api/q3/cube/4</example>
        [HttpGet("cube/{baseValue}")]
        public IActionResult GetCube([FromRoute] int baseValue)
        {
     
            var result = Math.Pow(baseValue, 3);

       
            return Ok(result);
        }
    }
}
