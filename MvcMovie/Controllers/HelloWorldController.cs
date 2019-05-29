using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public String  helloworld()
        {
            return "This is the default action";
        }
        public ActionResult  Index()
        {
            return View();
        }
    }
}