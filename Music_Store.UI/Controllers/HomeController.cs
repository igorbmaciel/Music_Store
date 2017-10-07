using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music_Store.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Artist()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Album()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}