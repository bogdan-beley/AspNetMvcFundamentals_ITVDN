using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace L02_Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = "DefaultId"}
            );

            routes.MapRoute(
                name: "PublicRoute",
                url: "public/{controller}/{action}",
                defaults: new { controller = "Home", action = "Index", id = "DefaultId"}
            );

            routes.MapRoute(
                name: "SegmentVariables",
                url: "{controller}/{action}/{x}/{y}",
                defaults: new { controller = "Home", action = "Index", x = 0, y = 0}
            );

            routes.MapRoute(
                name: "CatchAllSegments",
                url: "{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "Home", action = "Index", x = 0, y = 0 }
            );
        }
    }
}
