using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModel3.Models;

namespace MvcModel3.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult process(Info x)
        {
            return View(x);
        }
    }
}