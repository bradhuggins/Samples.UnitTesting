using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.NetCore.Controllers;

namespace UnitTesting.NetCore.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void GetTest()
        {
            // Arrange
            string input = "student";
            HomeController target = new HomeController();

            // Act
            var actual = target.Get(input) as OkObjectResult;

            // Assert
            Assert.IsNotNull(actual);
        }
    }
}
