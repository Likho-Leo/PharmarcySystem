using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class OrderController : Controller
    {
        public IActionResult Order()
        {
            return View("~/Views/Customer/Order/Order.cshtml");
        }
    }
}
