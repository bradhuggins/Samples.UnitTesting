using Microsoft.AspNetCore.Mvc;
using System;

namespace UnitTesting.NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("{input}")]
        public IActionResult Get(string input)
        {
            string toReturn = string.Empty;
            
            //Generate Greeting
            var serverTime = DateTime.Now;
            if (serverTime.Hour < 12)
            {
                toReturn = "Good Morning, ";
            }
            else if (serverTime.Hour < 17)
            {
                toReturn = "Good Afternoon, ";
            }
            else
            {
                toReturn = "Good Evening, ";
            }
            toReturn += Environment.NewLine;

            //Generate Days in Year Remaining
            DateTime end = new DateTime(serverTime.Year + 1, 1, 1);
            int daysLeftInYear = (int)(end - serverTime).TotalDays;
            toReturn += "There are " + daysLeftInYear.ToString() + " days remaining in the year.";

            return Ok(toReturn);
        }
    }
}
