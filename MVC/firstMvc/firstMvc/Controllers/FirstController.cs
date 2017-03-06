using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstMvc.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult hello()
        {
            ViewData["result"] = addThis(5);

            Session["myResult"] = addThis(8);
            return View();
        }

        public int addThis(int i)
        {
            return i * i;
        }
    }
}