using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PETSHOME.Controllers
{
    public class SecController : Controller
    {
        // GET: Sec
        public ActionResult one()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult two()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult three()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}