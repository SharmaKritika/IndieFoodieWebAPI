using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IndieFoodieWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "MenuItemsApi",
                routeTemplate: "api/{controller}/{restaurantId}/menuItems",
                defaults: new { action = "GetMenuItems"}
            );

            config.Routes.MapHttpRoute(
                name: "ResturantsApi",
                routeTemplate: "api/{controller}",
                defaults: new { action = "GetRestaurants" }
            );
        }
    }
}
