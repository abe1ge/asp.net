using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcRazor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "search",
                url: "Second/{a}",
                defaults: new {controller = "Links", action = "Index"}
                );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Links", action = "getThere", id = UrlParameter.Optional }
            );
        }
    }
}
