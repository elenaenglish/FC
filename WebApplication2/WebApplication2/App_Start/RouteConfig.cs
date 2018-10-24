using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             "Main",                                           // Route name
             "",                            // URL with parameters
             new { controller = "Main", action = "Index" }  // Parameter defaults
         );
            routes.MapRoute(
             "Platform",                                           // Route name
             "Platform",                            // URL with parameters
             new { controller = "Main", action = "Platform" }  // Parameter defaults
         );
            routes.MapRoute(
             "Token-Sale",                                           // Route name
             "token-sale",                            // URL with parameters
             new { controller = "Main", action = "TokenSale" }  // Parameter defaults
         );
            routes.MapRoute(
             "Partners",                                           // Route name
             "Partners",                            // URL with parameters
             new { controller = "Main", action = "Partners" }  // Parameter defaults
         );
            routes.MapRoute(
             "Community",                                           // Route name
             "Community",                            // URL with parameters
             new { controller = "Main", action = "Community" }  // Parameter defaults
         );
            routes.MapRoute(
             "Academy",                                           // Route name
             "forum-academy",                            // URL with parameters
             new { controller = "Main", action = "ForumAcademy" }  // Parameter defaults
         );
         routes.MapRoute(
             "News",                                           // Route name
             "news",                            // URL with parameters
             new { controller = "Main", action = "News" }  // Parameter defaults
         );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
