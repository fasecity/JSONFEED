using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace JsonFeedApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //------------content negotiation---------------------------------------//

            //Return only json  : remove xml
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            //change formaters json : indented
            // config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            //change to camel case
            //config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            //only return json in browsers but anything in fiddler :
            // config.Formatters.JsonFormatter.SupportedMediaTypes
            //   .Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
