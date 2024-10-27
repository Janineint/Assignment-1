using Microsoft.AspNetCore.Mvc;
using System;

namespace Assignment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {

        /// <summary>
        /// Processes an order for SquashFellows plushies and returns the order summary.
        /// </summary>
        /// <param name="Small">Number of Small plushies ordered.</param>
        /// <param name="Large">Number of Large plushies ordered.</param>
        /// <returns>A summary of the order including subtotal, tax, and total.</returns>
        /// <example>POST /api/q8/squashfellows</example>
        [HttpPost("squashfellows")]
        public IActionResult PostSquashFellows([FromForm] int Small, [FromForm] int Large)
        {
         
            const double smallPrice = 25.50;
            const double largePrice = 45.50;
            const double taxRate = 0.13;

          
            double subtotal = (Small * smallPrice) + (Large * largePrice);

        
            double tax = subtotal * taxRate;

         
            double total = subtotal + tax;

            
            subtotal = Math.Round(subtotal, 2);
            tax = Math.Round(tax, 2);
            total = Math.Round(total, 2);

            
            var orderSummary = $"{Small} Small @ ${smallPrice} = ${Small * smallPrice}; " +
                               $"{Large} Large @ ${largePrice} = ${Large * largePrice}; " +
                               $"Subtotal = ${subtotal}; Tax = ${tax} HST; Total = ${total}";

            return Ok(orderSummary);
        }
    }
}
