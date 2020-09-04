using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting.NetCore.Services.Tests
{
    [TestClass]
    public class SystemDateTimeTests
    {
        [TestMethod]
        public void NowTest()
        {
            // Arrange
            SystemDateTime target = new SystemDateTime();

            // Act
            var actual = target.Now;

            // Assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.GetType() == typeof(DateTime));
        }
    }
}
