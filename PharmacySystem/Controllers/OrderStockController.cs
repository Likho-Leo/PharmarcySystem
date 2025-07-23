using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class OrderStockController: Controller
    {
 
        [HttpGet]
        public IActionResult AddOrderStock()
        {
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> EditOrderStock(int id)
        {        

            return View();
        }
    
        [HttpGet]
        public async Task<IActionResult> DisplayAllOrderStock()
        {
            return View("OrderMedication");
        }

        public async Task<IActionResult> DeleteOrderStock(int id)
        {         
            return RedirectToAction(nameof(DisplayAllOrderStock));
        }

        [HttpPost]
        public IActionResult ConfirmOrder(List<int> MedicationIDs, List<int> OrderQuantities, DateTime OrderDate)
        {
            if (MedicationIDs == null || OrderQuantities == null || MedicationIDs.Count != OrderQuantities.Count)
            {
                TempData["msg"] = "Invalid data. Please try again.";
                return RedirectToAction("DisplayAllOrderStock");
            }

            TempData["msg"] = $"Order placed successfully for {MedicationIDs.Count} medications on {OrderDate:yyyy-MM-dd}.";
            return RedirectToAction("DisplayAllOrderStock");
        }

        [HttpGet]
        public IActionResult ViewPlacedOrders()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ViewOrderDetails(int id)
        {
            ViewBag.OrderID = id;
            return View();
        }

        [HttpPost]
        public IActionResult UpdateMedicationStatus(int OrderID, List<string> MedicationNames, List<string> MedicationStatuses)
        {
            TempData["msg"] = $"Updated status for {MedicationNames.Count} medications in Order #{OrderID}.";
            return RedirectToAction("ViewOrderDetails", new { id = OrderID });
        }
    }
}
