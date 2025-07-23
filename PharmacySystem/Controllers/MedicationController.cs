using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class MedicationController : Controller
    {      

        [HttpGet]
        public IActionResult AddMedication()
        {
            return View();
        }   

        [HttpGet]
        public IActionResult EditMedication()
        {        
            return View();
        }

       
        [HttpGet]
        public async Task<IActionResult> DisplayAllMedication()
        {
            return View();
        }

        public IActionResult DeleteMedication()
        {       
            return RedirectToAction(nameof(DisplayAllMedication));
        }

        public IActionResult PrintStockReport()
        {
            return View();
        }

    }
}
