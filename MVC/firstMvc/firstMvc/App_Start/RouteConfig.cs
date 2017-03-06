using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace firstMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "hello",
                url: "timetable",
                defaults: new { controller = "first", action = "hello", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{action}/{controller}/{id}",
                defaults: new { controller = "first", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
