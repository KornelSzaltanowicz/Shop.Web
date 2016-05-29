using System.Web.Mvc;
using System.Web.Routing;

namespace Shop.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //exclude template folder from routing
            routes.IgnoreRoute("Scripts/app/templates/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{bookType}",
                defaults: new { controller = "Book", action = "Index", bookType = UrlParameter.Optional }
            );
        }
    }
}
