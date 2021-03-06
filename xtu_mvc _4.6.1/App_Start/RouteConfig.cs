﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace xtu_mvc__4._6._1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                  name: "Default1",
                  url: "{controller}/{action}"
              );
            routes.MapRoute(
                name: "Default2",
                url: "{action}",
                defaults: new { controller = "Home",Action="Index"}
            );
            /*  routes.MapRoute(
                  name: "Default",
                  url: "{controller}/{action}/{id}",
                  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
              );*/
            // routes.MapRoute("sim","{action}",new { Controller="Home"});
        }
    }
}
