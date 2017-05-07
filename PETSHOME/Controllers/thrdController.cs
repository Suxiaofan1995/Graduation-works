using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PETSHOME.Controllers
{
    public class thrdController : Controller
    {
        // GET: thrd
        public ActionResult up1()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult up2()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult up3()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}