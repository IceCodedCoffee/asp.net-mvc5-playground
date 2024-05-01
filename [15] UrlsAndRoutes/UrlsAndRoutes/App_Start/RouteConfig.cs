﻿using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //// 1.
            //routes.MapRoute("CustomerIndex", "Customer/Index", new { controller = "Customer", action = "Index" });

            //// 2.
            //routes.MapRoute("ShopIndex", "Shop/Index", new { controller = "Customer", action = "List" });

            //// 3.
            //routes.MapRoute("ControllerAction", "{controller}/{action}");

            //// 4.
            //routes.MapRoute("ControllerActionDefault", "{controller}/{action}", new { action = "List" });

            //// 5.
            //routes.MapRoute("ControllerDefaultActionDefault", "{controller}/{action}", new { controller = "Customer", action = "List"});

            //// 7.
            routes.MapRoute("PublicMixed","Public/{controller}/{action}");
        }
    }
}