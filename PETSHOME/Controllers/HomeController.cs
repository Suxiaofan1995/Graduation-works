using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PETSHOME.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pet()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Raise()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Talk()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Check()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Up()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Find()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Text()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}