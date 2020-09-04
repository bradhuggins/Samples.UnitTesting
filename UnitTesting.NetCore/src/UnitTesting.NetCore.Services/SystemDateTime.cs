using System;
using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Services
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
