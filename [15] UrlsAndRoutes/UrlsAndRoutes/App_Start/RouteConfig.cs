﻿using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 3.
            routes.MapRoute("ControllerAction", "{controller}/{action}", new { action = "List"});
        }
    }
}
