using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class PharmacyDetailsController : Controller
    {
        

        public async Task<IActionResult> AddPharmacyDetail()
        {
            return View();
        }

        public async Task<IActionResult> EditPharmacyDetail(int id)
        {
            return View();
        }

        public async Task<IActionResult> DisplayAllPharmacyDetail()
        {
            return View();
        }

        public async Task<IActionResult> DeletPharmacyDetail(int id)
        {
            return RedirectToAction(nameof(DisplayAllPharmacyDetail));
        }
       
    }
}
