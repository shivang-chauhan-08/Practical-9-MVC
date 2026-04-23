using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TestHelloWorld.Controllers;

namespace UnitTest
{
    public class HelloWorld
    {
        HomeController controller = new HomeController();

        var result = controller.Task_3() as ViewResult;

        Assert.NotNull(result);
        Assert.Equal("Hello World", result.ViewBag.Message);
    }
}
