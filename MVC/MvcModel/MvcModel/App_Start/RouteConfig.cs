using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcModel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "hello",
                url: "processForm",
                defaults: new { controller = "Data", action = "process", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Data", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
