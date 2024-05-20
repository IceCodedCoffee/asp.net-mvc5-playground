using System.Web.Mvc;

namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        [Route("~/Test", Name="TestRoute")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";

            return View("ActionName");
        }

        public string Create(string user, int id)
        {
            return $"User: {user}, ID: {id}";
        }

        public string ChangePass(string user, string password)
        {
            return $"ChangePass Method - User: {user}, Pass: {password}";
        }

        public ActionResult List()
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "List";

            return View("ActionName");
        }
    }
}