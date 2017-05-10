using System.Web.Mvc;

namespace testing.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}