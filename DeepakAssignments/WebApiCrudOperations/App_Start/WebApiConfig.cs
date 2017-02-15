﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Tracing;
using WebApiCrudOperations.Common;
using WebApiCrudOperations.Helpers;

namespace WebApiCrudOperations
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

            config.Filters.Add(new CustomExceptionFilter());

            log4net.Config.XmlConfigurator.Configure();
            config.Services.Replace(typeof(ITraceWriter), new MyProjectTracer());
        }
    }
}
