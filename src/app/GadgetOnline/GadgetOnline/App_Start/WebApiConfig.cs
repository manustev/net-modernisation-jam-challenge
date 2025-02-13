﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace GadgetOnline
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

            config.Formatters.JsonFormatter
                  .SupportedMediaTypes
                  .Add(new MediaTypeHeaderValue(ConfigurationManager.AppSettings["SupportedMedia"]));
            //config.EnableSwagger()
            //    .EnableSwaggerUi();
            SwaggerConfig.Register(config);
        }
    }
}
