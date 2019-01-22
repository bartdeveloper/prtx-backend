using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace prtx_backend
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            config.MapHttpAttributeRoutes();

            config.EnableCors();

            config.Formatters.Clear();

            config.Formatters.Add(new JsonMediaTypeFormatter()
            {
                SerializerSettings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                }
            });

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
