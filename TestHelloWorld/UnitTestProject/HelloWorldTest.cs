using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using TestHelloWorld.Controllers;
using Xunit;

namespace UnitTestProject
{
    [TestClass]
    public class HelloWorldTest
    {
        [Fact]
        public void TestHelloWorld()
        {
            var controller = new HomeController();

            var result = controller.Task_3() as ViewResult;

            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal("Hello World", result.ViewData["Message"]);
        }
    }
}
