using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class AccountController : Controller
    {
        public IActionResult Account()
        {
            return View("~/Views/Customer/Account/Account.cshtml");
        }
    }
}
