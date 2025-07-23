using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult AddDoctor()
        {
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> EditDoctor()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> DisplayAllDoctor()
        {
            return View();
        }

        public async Task<IActionResult> DeleteDoctor()
        {
            return RedirectToAction(nameof(DisplayAllDoctor));
        }

    }
}
