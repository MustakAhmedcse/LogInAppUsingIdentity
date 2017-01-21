using System.Web.Mvc;

namespace LogInApp.Controllers
{
    public partial class PagesController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
    }
}