using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class CustomerController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
