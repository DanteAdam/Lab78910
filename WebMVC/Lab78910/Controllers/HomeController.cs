using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab78910.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AL()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SS()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}