using System;
using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Services
{
    public class Service : IService
    {
        IDateTime _dateTime;
        public Service(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public string GenerateMessage(string input)
        {
            string toReturn = string.Empty;
            toReturn += this.GenerateGreeting(input) + Environment.NewLine;
            toReturn += this.GenerateDaysInYearRemaining();
            return toReturn;
        }

        private string GenerateGreeting(string input)
        {
            string toReturn = string.Empty;
            var serverTime = _dateTime.Now;
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
            return toReturn + input;
        }

        private string GenerateDaysInYearRemaining()
        {
            DateTime now = _dateTime.Now;
            DateTime end = new DateTime(now.Year + 1, 1, 1);
            int daysLeftInYear = (int)(end - now).TotalDays;
            return "There are " + daysLeftInYear.ToString() + " days remaining in the year.";
        }


    }
}
