using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
               
            routes.MapRoute("ShopIndex", "Shop/Index", new { controller = "Customer", action = "List" });

            routes.MapRoute("ShopMixed", "Shop/{action}", new { controller = "Customer" });
            
            routes.MapRoute("PublicMixed", "Public/{controller}/{action}");
            
            routes.MapRoute("XMixed", "X{controller}/{action}");
                        
            routes.MapRoute("ControllerDefaultActionDefault", "{controller}/{action}", new { controller = "Customer", action = "List" });
        }
    }
}