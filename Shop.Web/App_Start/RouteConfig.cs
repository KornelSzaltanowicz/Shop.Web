using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Shop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            

            //routes.MapRoute(
            //    name: "BookType",
            //    url: "{controller}/{action}/{bookType}",
            //    defaults: new { controller = "Book", action = "Type", bookType = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{bookType}",
                defaults: new { controller = "Book", action = "Index", bookType = UrlParameter.Optional }
            );
        }
    }
}
