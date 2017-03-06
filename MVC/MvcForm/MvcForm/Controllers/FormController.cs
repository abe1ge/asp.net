using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcForm.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Process(string name, string RegNo,string Marks)
        {
            ViewData["name"] = name;
            ViewData["RegNo"] = RegNo;
            ViewData["Marks"] = Marks;
            return View();
        }
    }
}