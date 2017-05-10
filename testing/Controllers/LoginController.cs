using System.Linq;
using System.Web.Mvc;
using testing.Models;

namespace testing.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        readonly UserContext context = new UserContext();
        readonly Authenticator authenticator = new Authenticator();

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel loginModel)
        {
            var findUser =
                context.Clients.FirstOrDefault(
                user => user.Login == loginModel.Login && user.Password == loginModel.Password);
            if (findUser == null)
            {
                ViewBag.LoginResult = "Невірний пароль або логін";
                return View(loginModel);
            }
            else
            {
                authenticator.DoAuthentication(findUser.Login, true);
                return RedirectToAction("Index", "Test");
            }
        }
    }
}