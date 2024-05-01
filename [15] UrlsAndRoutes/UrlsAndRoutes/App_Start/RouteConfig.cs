using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1.
            routes.MapRoute("ControllerDefaultActionDefault", "{controller}/{action}", new { controller = "Customer", action = "List" });

            // 2.
            routes.MapRoute("ControllerAction", "{controller}/{action}");

            // 3.
            routes.MapRoute("ShopIndex", "Shop/Index", new { controller = "Customer", action = "List" });

            // 4.
            routes.MapRoute("ControllerActionDefault", "{controller}/{action}", new { action = "List" });

            // 5.
            routes.MapRoute("ShopMixed", "Shop/{action}", new { controller = "Customer" });

            // 7.
            routes.MapRoute("PublicMixed", "Public/{controller}/{action}");

            // 8.
            routes.MapRoute("XMixed", "X{controller}/{action}");

            // 9.
            routes.MapRoute("CustomerIndex", "Customer/Index", new { controller = "Customer", action = "Index" });
        }
    }
}