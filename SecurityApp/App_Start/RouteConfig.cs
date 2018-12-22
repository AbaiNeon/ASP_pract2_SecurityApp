using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SecurityApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Admin",
               url: "adminpanel/{controller}/{action}/{id}",
               defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional },
               constraints: new {  }
            );

            routes.MapRoute(
               name: "DefaultWithId",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Default", action = "Index" }
            );
        }
    }
}
