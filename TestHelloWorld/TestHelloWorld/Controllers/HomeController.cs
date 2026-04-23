using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Task_1()
        {
            return View();
        }

        public ActionResult Task_2()
        {
            return View();
        }

        public ActionResult Task_3()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
    }
}