using System.Web.Mvc;

namespace Party_Invites.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}