using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcForm.Controllers
{
    public class ManchesterController : Controller
    {
        // GET: Manchester
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowForm()
        {

            return View();
        }
    }
}