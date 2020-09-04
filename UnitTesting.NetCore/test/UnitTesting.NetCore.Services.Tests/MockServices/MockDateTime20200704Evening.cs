﻿using System;
using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Services.Tests.MockServices
{
    public class MockDateTime20200704Evening : IDateTime
    {
        public DateTime Now
        {
            get { return new DateTime(2020,7,4,19,0,0); }
        }
    }
}
