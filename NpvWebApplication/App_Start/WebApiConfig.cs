﻿using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using NpvWebApplication.DIPlumbing;

namespace NpvWebApplication
{
    using System.Web.Http.Dispatcher;
    using Castle.Windsor;
    using DIPlumbing;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IWindsorContainer container)
        {            
            MapRoutes(config);
            RegisterControllerActivator(container);
        }

        private static void MapRoutes(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void RegisterControllerActivator(IWindsorContainer container)
        {
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                new WindsorCompositionRoot(container));
        }
    }
}
