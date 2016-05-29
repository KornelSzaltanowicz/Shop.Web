using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace Shop.Web.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            ((DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;

            // Attribute routing.
            config.MapHttpAttributeRoutes();

            // Convention-based routing.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{bookType}",
                defaults: new { bookType = RouteParameter.Optional }
            );
        }
    }
}