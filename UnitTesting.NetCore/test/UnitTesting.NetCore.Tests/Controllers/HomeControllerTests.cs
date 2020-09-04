using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.NetCore.Controllers;
using UnitTesting.NetCore.Tests.MockServices;

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
            MockService service = new MockService();
            HomeController target = new HomeController(service);

            // Act
            var actual = target.Get(input) as OkObjectResult;

            // Assert
            Assert.IsNotNull(actual);
        }
    }
}
