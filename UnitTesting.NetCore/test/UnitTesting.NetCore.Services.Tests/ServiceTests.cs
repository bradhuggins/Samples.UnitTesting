using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using UnitTesting.NetCore.Interfaces;

namespace UnitTesting.NetCore.Services.Tests
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void GenerateMessage_Test()
        {
            // Arrange
            string input = "student";
            IDateTime dateTime = new MockServices.MockDateTime20200704Morning();
            Service target = new Service(dateTime);

            // Act
            var actual = target.GenerateMessage(input);

            // Assert
            //Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Length > 0);
        }

        [TestMethod]
        public void GenerateGreeting_Morning_Test()
        {
            // Arrange
            string input = "student";
            IDateTime dateTime = new MockServices.MockDateTime20200704Morning();
            Service target = new Service(dateTime);
            Type t = typeof(Service);
            MethodInfo methodInfo = t.GetMethod("GenerateGreeting", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { input };

            string expected = "Good Morning, student";

            // Act
            var actual = (string)methodInfo.Invoke(target, parameters);

            // Assert
            Assert.IsTrue(actual ==  expected);
        }

        [TestMethod]
        public void GenerateGreeting_Afternoon_Test()
        {
            // Arrange
            string input = "student";
            IDateTime dateTime = new MockServices.MockDateTime20200704Afternoon();
            Service target = new Service(dateTime);
            Type t = typeof(Service);
            MethodInfo methodInfo = t.GetMethod("GenerateGreeting", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { input  };

            string expected = "Good Afternoon, student";

            // Act
            var actual = (string)methodInfo.Invoke(target, parameters);

            // Assert
            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void GenerateGreeting_Evening_Test()
        {
            // Arrange
            string input = "student";
            IDateTime dateTime = new MockServices.MockDateTime20200704Evening();
            Service target = new Service(dateTime);
            Type t = typeof(Service);
            MethodInfo methodInfo = t.GetMethod("GenerateGreeting", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { input };

            string expected = "Good Evening, student";

            // Act
            var actual = (string)methodInfo.Invoke(target, parameters);

            // Assert
            Assert.IsTrue(actual == expected);
        }


        [TestMethod]
        public void GenerateDaysInYearRemaining()
        {
            // Arrange
            string input = "student";
            IDateTime dateTime = new MockServices.MockDateTime20200704Morning();
            Service target = new Service(dateTime);
            Type t = typeof(Service);
            MethodInfo methodInfo = t.GetMethod("GenerateDaysInYearRemaining", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { };

            int expected = 180;

            // Act
            var actual = (string)methodInfo.Invoke(target, parameters);

            // Assert
            Assert.IsTrue(actual == "There are " + expected.ToString() + " days remaining in the year.");
        }


    }
}
