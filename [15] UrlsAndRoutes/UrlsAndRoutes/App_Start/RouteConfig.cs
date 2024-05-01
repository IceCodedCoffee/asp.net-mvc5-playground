using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1b.
            Route homeIndex = new Route("Home/Index",
                              new RouteValueDictionary(new { controller = "Home", action = "Index" }),
                              new MvcRouteHandler());

            routes.Add("HomeIndex", homeIndex);

            // 1c.
            routes.MapRoute("CustomerIndex", "Customer/Index", new { controller = "Customer", action = "Index"});

            // 1d.
            routes.MapRoute(
                name: "AdminIndex",
                url: "Admin/Index",
                defaults: new { controller = "Admin", action = "Index" }
            );
        }
    }
}
