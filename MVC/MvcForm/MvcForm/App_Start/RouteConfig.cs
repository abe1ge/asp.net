using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcForm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");



            routes.MapRoute(
               name: "hello",
               url: "ProccessForm",
               defaults: new { controller = "Form", action = "Process", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                           name: "helo",
                           url: "",
                           defaults: new { controller = "Manchester", action = "ShowForm", id = UrlParameter.Optional }
                       );
        }
    }
}
