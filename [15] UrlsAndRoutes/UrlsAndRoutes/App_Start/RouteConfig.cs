﻿using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 2.
            routes.MapRoute("ShopIndex", "Shop/Index", new { controller = "Customer", action = "List" });
        }
    }
}
