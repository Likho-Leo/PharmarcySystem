using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class RequestPrescriptionController : Controller
    {
        public IActionResult RequestPrescription()
        {
            return View("~/Views/Customer/RequestPrescription/RequestPrescription.cshtml");
        }
    }
}
