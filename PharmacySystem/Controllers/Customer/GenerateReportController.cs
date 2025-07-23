using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Customer
{
    public class GenerateReportController : Controller
    {
        public IActionResult GenerateReport()
        {
            return View("~/Views/Customer/GenerateReport/GenerateReport.cshtml");
        }
    }
}
