using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRazor.Controllers
{
    public class LinksController : Controller
    {
        // GET: Links
        public ActionResult Index(int a)
        {
            ViewData["num"] = a * a;
            return View();
        }

        public ActionResult getThere()
        {
            return View();
        }
    }
}