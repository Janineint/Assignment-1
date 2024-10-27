using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {

        /// <summary>
        /// Returns the area of a regular hexagon given the side length.
        /// </summary>
        /// <param name="side">The side length of the hexagon.</param>
        /// <returns>The area of the hexagon as a double.</returns>
        /// <example>GET /api/q6/hexagon?side=1</example>
        [HttpGet("hexagon")]
        public IActionResult GetHexagonArea([FromQuery] double side)
        {
            if (side <= 0)
            {
                return BadRequest("Side length must be greater than zero.");
            }

            
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);

            
            return Ok(area);
        }
    }
}
