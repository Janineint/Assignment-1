using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {

        /// <summary>
        /// Returns the date adjusted by a number of days.
        /// </summary>
        /// <param name="days">The number of days to add or subtract from today.</param>
        /// <returns>A string representing the adjusted date in the format yyyy-MM-dd.</returns>
        /// <example>GET /api/q7/timemachine?days=1</example>
        [HttpGet("timemachine")]
        public IActionResult GetAdjustedDate([FromQuery] int days)
        {
            
            DateTime adjustedDate = DateTime.Today.AddDays(days);

            
            string formattedDate = adjustedDate.ToString("yyyy-MM-dd");

            
            return Ok(formattedDate);
        }
    }
}
