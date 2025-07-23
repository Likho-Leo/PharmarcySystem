using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Pharmacist
{
    public class PharmacistReportController : Controller
    {
        public IActionResult PharmacistReport()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Generate(string StartDate, string EndDate, string GroupBy,
                                    string ReportFormat, string StatusFilter,
                                    bool IncludeSummary = false, bool IncludeCharts = false,
                                    bool IncludeDetails = false, bool IncludePatientInfo = false,
                                    bool IncludePricing = false, bool IncludeAllergies = false)
        {
            // For prototyping – mock filtered data based on GroupBy
            var reports = new List<dynamic>();

            switch (GroupBy?.ToLower())
            {
                case "patient":
                    reports = GetPatientReports(StatusFilter);
                    break;
                case "medication":
                    reports = GetMedicationReports(StatusFilter);
                    break;
                case "schedule":
                    reports = GetScheduleReports(StatusFilter);
                    break;
                case "date":
                    reports = GetDateReports(StatusFilter);
                    break;
                default:
                    reports = GetPatientReports(StatusFilter);
                    break;
            }

            // Set ViewBag values for the results view
            ViewBag.GroupBy = GroupBy;
            ViewBag.StartDate = StartDate;
            ViewBag.EndDate = EndDate;
            ViewBag.ReportFormat = ReportFormat;
            ViewBag.StatusFilter = StatusFilter;
            ViewBag.IncludeSummary = IncludeSummary;
            ViewBag.IncludeCharts = IncludeCharts;
            ViewBag.IncludeDetails = IncludeDetails;
            ViewBag.IncludePatientInfo = IncludePatientInfo;
            ViewBag.IncludePricing = IncludePricing;
            ViewBag.IncludeAllergies = IncludeAllergies;

            return View("ReportResults", reports);
        }

        private List<dynamic> GetPatientReports(string statusFilter)
        {
            var allPatients = new List<dynamic>
            {
                new { Name = "John Doe", PatientId = "8701015123085", Gender = "Male", TotalPrescriptions = 3, Status = "Dispensed", LastVisit = "2024-05-20", TotalValue = "R 450.00" },
                new { Name = "Jane Smith", PatientId = "9902154786081", Gender = "Female", TotalPrescriptions = 2, Status = "Pending", LastVisit = "2024-05-22", TotalValue = "R 320.00" },
                new { Name = "Michael Johnson", PatientId = "8505123789012", Gender = "Male", TotalPrescriptions = 1, Status = "Ready", LastVisit = "2024-05-21", TotalValue = "R 185.00" },
                new { Name = "Sarah Williams", PatientId = "9201084567890", Gender = "Female", TotalPrescriptions = 4, Status = "Dispensed", LastVisit = "2024-05-19", TotalValue = "R 720.00" }
            };

            return string.IsNullOrEmpty(statusFilter)
                ? allPatients
                : allPatients.Where(p => p.Status == statusFilter).ToList();
        }

        private List<dynamic> GetMedicationReports(string statusFilter)
        {
            return new List<dynamic>
            {
                new { Group = "Paracetamol 500mg", TotalPrescriptions = 12, TotalQuantity = 240, TotalValue = "R 360.00", Status = "Active" },
                new { Group = "Ibuprofen 400mg", TotalPrescriptions = 8, TotalQuantity = 160, TotalValue = "R 480.00", Status = "Active" },
                new { Group = "Amoxicillin 250mg", TotalPrescriptions = 6, TotalQuantity = 180, TotalValue = "R 540.00", Status = "Active" },
                new { Group = "Omeprazole 20mg", TotalPrescriptions = 4, TotalQuantity = 120, TotalValue = "R 720.00", Status = "Active" }
            };
        }

        private List<dynamic> GetScheduleReports(string statusFilter)
        {
            return new List<dynamic>
            {
                new { Group = "Morning (8:00 AM)", TotalPrescriptions = 15, AverageWaitTime = "12 mins", Status = "Active" },
                new { Group = "Afternoon (2:00 PM)", TotalPrescriptions = 10, AverageWaitTime = "8 mins", Status = "Active" },
                new { Group = "Evening (6:00 PM)", TotalPrescriptions = 8, AverageWaitTime = "15 mins", Status = "Active" }
            };
        }

        private List<dynamic> GetDateReports(string statusFilter)
        {
            return new List<dynamic>
            {
                new { Group = "2024-05-22", TotalPrescriptions = 12, TotalValue = "R 1,200.00", Status = "Completed" },
                new { Group = "2024-05-21", TotalPrescriptions = 15, TotalValue = "R 1,450.00", Status = "Completed" },
                new { Group = "2024-05-20", TotalPrescriptions = 9, TotalValue = "R 980.00", Status = "Completed" },
                new { Group = "2024-05-19", TotalPrescriptions = 18, TotalValue = "R 1,680.00", Status = "Completed" }
            };
        }
    }
}