using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class PharmacyManagerController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
