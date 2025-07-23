using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult ValidationPage()
        {
            return View();
        }

        public IActionResult CreateNewPassword()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
