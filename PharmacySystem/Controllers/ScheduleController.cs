using Microsoft.AspNetCore.Mvc;

namespace PrescriptionManagementSystem.Controllers
{
    public class ScheduleController : Controller
    {

        [HttpGet]
        public IActionResult AddSchedule()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> EditSchedule(int id)
        {
            
            return View();
        }

       
        [HttpGet]
        public async Task<IActionResult> DisplayAllSchedule()
        {

            return View();
        }

        public async Task<IActionResult> DeleteSchedule(int id)
        {         
            return RedirectToAction(nameof(DisplayAllSchedule));
        }

    }
}
