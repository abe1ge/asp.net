using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace mvcCalculator
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Division",
                url: "Division/{A}/{B}",
                defaults: new { controller = "Math", action = "Division", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Times",
                url: "Times/{A}/{B}",
                defaults: new { controller = "Math", action = "Times", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "sub",
                url: "Subtraction/{A}/{B}",
                defaults: new { controller = "Math", action = "Subtraction", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "add",
                url: "Addition/{A}/{B}",
                defaults: new { controller = "Math", action = "Addition", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
