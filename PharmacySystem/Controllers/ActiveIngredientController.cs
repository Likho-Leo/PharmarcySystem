using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class ActiveIngredientController : Controller
    {
        
        [HttpGet]
        public IActionResult AddActiveIngredient()
        {
            return View();
        }

       

        [HttpGet]
        public async Task<IActionResult> EditActiveIngredient(int id)
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> DisplayAllActiveIngredient()
        {
            return View();
        }

        public async Task<IActionResult> DeleteActiveIngredient(int id)
        {                 
            return RedirectToAction(nameof(DisplayAllActiveIngredient));
        }
        
    }
}
