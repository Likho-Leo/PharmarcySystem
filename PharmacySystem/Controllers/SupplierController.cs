using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class SupplierController : Controller
    {
    
        [HttpGet]
        public IActionResult AddSupplier()
        {
            return View(); 
        }

 
        [HttpGet]
        public async Task<IActionResult> EditSupplier(int id)
        {
  
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DisplayAllSupplier()
        {
            return View();
        }

        public async Task<IActionResult> DeleteSupplier(int id)
        {           
            return RedirectToAction(nameof(DisplayAllSupplier));
        }
       
    }
}
