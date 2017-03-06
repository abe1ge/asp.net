using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcModel.Models;

namespace MvcModel.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult process(string n, int R, int M)
        {
            Info stuff = new Info();
            stuff.name = n;
            stuff.reg = R;
            stuff.marks = M;

            return View(stuff);
        }
    }
}