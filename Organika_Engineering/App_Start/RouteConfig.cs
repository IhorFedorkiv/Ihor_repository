using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace organika_engineering
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                namespaces: new[] { "organika_engineering.Controllers" },
                defaults: 
                new 
                { 
                    controller = "UA", action = "Home", id = UrlParameter.Optional 
                }

            );
        }
    }
}