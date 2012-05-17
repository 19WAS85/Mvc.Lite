using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Lite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            object model = "With Razor View!";

            return View(model);
        }
    }
}