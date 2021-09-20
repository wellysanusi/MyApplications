using System.Web.Http;

namespace Clock
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Web API Global Filter
            //config.Filters.Add(new GlobalExpiryValidator());
        }
    }
}
