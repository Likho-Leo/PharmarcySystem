using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace PharmacySystem.Controllers.Customer
{
    public class LoadPrescriptionController : Controller
    {
        public IActionResult LoadPrescription()
        {
            return View("~/Views/Customer/LoadPrescription/LoadPrescription.cshtml");
        }
        public IActionResult UnprocessedScript()
        {
            return View("~/Views/Customer/LoadPrescription/UnprocessedScript.cshtml");
        }
        public IActionResult ProcessedScript()
        {
            return View("~/Views/Customer/LoadPrescription/ProcessedScript.cshtml");
        }

    }
}
