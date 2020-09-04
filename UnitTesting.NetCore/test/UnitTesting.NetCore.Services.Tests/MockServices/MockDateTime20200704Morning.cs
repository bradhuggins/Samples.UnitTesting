using System;
using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Services.Tests.MockServices
{
    public class MockDateTime20200704Morning : IDateTime
    {
        public DateTime Now
        {
            get { return new DateTime(2020,7,4,8,0,0); }
        }
    }
}
