using System.Web.Mvc;
using System.Web.Routing;

namespace AdvancedRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });
        }
    }
}