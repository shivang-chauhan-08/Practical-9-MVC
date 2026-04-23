using System.Web.Mvc;
using TestHelloWorld.Controllers;
using Xunit;

namespace HelloWorld.Test
{
    public class HelloWorld
    {
        [Fact]
        public void TestHelloWorld()
        {
            HomeController controller = new HomeController();

            var result = controller.Task_3() as ViewResult;

            Assert.NotNull(result);
            Assert.Equal("Hello World", result.ViewBag.Message);
        }
    }
}