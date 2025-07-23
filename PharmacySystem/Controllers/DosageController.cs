using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class DosageController: Controller
    {

        [HttpGet]
        public IActionResult AddDosage()
        {
            return View(); 
        }


        [HttpGet]
        public async Task<IActionResult> EditDosage(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DisplayAllDosage()
        {    
            return View();
        }

        public async Task<IActionResult> DeleteDosage(int id)
        {           
            return RedirectToAction(nameof(DisplayAllDosage));
        }
       
    }
}
