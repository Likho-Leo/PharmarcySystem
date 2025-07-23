using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Pharmacist
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
