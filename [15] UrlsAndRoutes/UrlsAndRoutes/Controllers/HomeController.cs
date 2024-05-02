using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";

            return View("ActionName");
        }

        public ActionResult CustomVariables(string order)
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariables";
            ViewBag.CustomVariableId = RouteData.Values["id"];
            ViewBag.CustomVariableOrder = order;

            return View();
        }
    }
}