using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hello_Jce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The website is a part of Jerusalem Engineering college";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ahuva's website contact page.";

            return View();
        }
    }
}