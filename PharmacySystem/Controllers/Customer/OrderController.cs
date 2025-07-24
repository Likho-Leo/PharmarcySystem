using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class OrderController : Controller
    {
        public IActionResult Order()
        {
            return View("~/Views/Customer/Order/Order.cshtml");
        }

        public IActionResult cust_viewOrder()
        {
            return View("~/Views/Customer/Order/cust_viewOrder.cshtml");
        }
    }
}
