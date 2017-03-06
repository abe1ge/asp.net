using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcCalculator.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult Addition(int a, int b)
        {
            ViewData["opp"] = "+";
            ViewData["first"] = a.ToString();
            ViewData["second"] = b.ToString();
            ViewData["result"] = (a + b).ToString();
            return View("Result");
        }

        public ActionResult Subtraction(int a, int b)
        {
            ViewData["opp"] = "-";
            ViewData["first"] = a.ToString();
            ViewData["second"] = b.ToString();
            ViewData["result"] = (a - b).ToString();
            return View("Result");
        }

        public ActionResult Times(int a, int b)
        {
            ViewData["opp"] = "x";
            ViewData["first"] = a.ToString();
            ViewData["second"] = b.ToString();
            ViewData["result"] = (a * b).ToString();
            return View("Result");
        }

        public ActionResult Division(int a, int b)
        {
            int result;

            try
            {
                result = a / b;
            }
            catch (Exception)
            {
                @ViewData["error"] = "Can not devide by 0";
                return View("error");
            }
            ViewData["opp"] = "/";
            ViewData["first"] = a.ToString();
            ViewData["second"] = b.ToString();
           
            ViewData["result"] = result.ToString();
            return View("Result");
        }
    }
}
