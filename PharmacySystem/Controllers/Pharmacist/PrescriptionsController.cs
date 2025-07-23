using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Pharmacist
{
    public class PrescriptionsController : Controller
    {
        public IActionResult Prescriptions()
        {
            return View();
        }

        public IActionResult AddDoc()
        {
            return View();
        }
        public IActionResult AllergyCheck()
        {
            return View();
        }
        public IActionResult DisplayAllPrescriptions()
        {
            // Mock data for all prescriptions
            var prescriptions = new[]
            {
                new {
                    PrescriptionID = 1,
                    PatientIdNumber = "8701015123085",
                    PatientName = "John Doe",
                    PrescriptionDate = new DateTime(2025, 07, 20),
                    DoctorName = "Dr. Smith",
                    Status = "Pending",
                    MedicationCount = 2
                },
                new {
                    PrescriptionID = 2,
                    PatientIdNumber = "9205123456789",
                    PatientName = "Jane Wilson",
                    PrescriptionDate = new DateTime(2025, 07, 22),
                    DoctorName = "Dr. Johnson",
                    Status = "Dispensed",
                    MedicationCount = 1
                },
                new {
                    PrescriptionID = 3,
                    PatientIdNumber = "7803087654321",
                    PatientName = "Mike Brown",
                    PrescriptionDate = new DateTime(2025, 07, 23),
                    DoctorName = "Dr. Davis",
                    Status = "Ready",
                    MedicationCount = 3
                }
            };

            return View(prescriptions);
        }

        public IActionResult EditLoadedPrescription(int id)
        {
            // Mock data for editing a prescription
            var mockPrescription = new
            {
                PrescriptionID = id,
                PatientIdNumber = "8701015123085",
                PatientName = "John Doe",
                PrescriptionDate = new DateTime(2025, 07, 20),
                DoctorId = 1,
                PrescriptionStatus = "Pending",
                PrescriptionPDF = true, // Indicates PDF is available

                // Available doctors for dropdown
                AvailableDoctors = new[]
                {
                    new { Id = 1, DisplayName = "Dr. Smith - Cardiology" },
                    new { Id = 2, DisplayName = "Dr. Johnson - Family Medicine" },
                    new { Id = 3, DisplayName = "Dr. Davis - Internal Medicine" },
                    new { Id = 4, DisplayName = "Dr. Wilson - Pediatrics" }
                },

                // Available prescription statuses
                PrescriptionStatuses = new[] { "Pending", "Ready", "Dispensed", "Cancelled" },

                // Available medications for dropdown
                AvailableMedications = new[]
                {
                    new { Id = 1, DisplayName = "Aspirin 81mg - Pain Relief" },
                    new { Id = 2, DisplayName = "Lisinopril 10mg - Blood Pressure" },
                    new { Id = 3, DisplayName = "Metformin 500mg - Diabetes" },
                    new { Id = 4, DisplayName = "Simvastatin 20mg - Cholesterol" },
                    new { Id = 5, DisplayName = "Omeprazole 20mg - Acid Reflux" },
                    new { Id = 6, DisplayName = "Amlodipine 5mg - Blood Pressure" }
                },

                // Current medication lines
                MedicationLines = new[]
                {
                    new {
                        MedicationId = 1,
                        MedicationName = "Aspirin 81mg",
                        Quantity = 30,
                        NumberOfRepeats = 2,
                        Instructions = "Take 1 tablet daily with food"
                    },
                    new {
                        MedicationId = 3,
                        MedicationName = "Metformin 500mg",
                        Quantity = 60,
                        NumberOfRepeats = 1,
                        Instructions = "Take 1 tablet twice daily with meals"
                    }
                }
            };

            return View(mockPrescription);
        }

        [HttpPost]
        public IActionResult UpdateFromPopup([FromBody] dynamic prescriptionData)
        {
            try
            {
                // In a real application, you would save to database
                // For mock purposes, we'll just return success

                // Simulate some processing time
                System.Threading.Thread.Sleep(1000);

                return Json(new { success = true, message = "Prescription updated successfully!" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error updating prescription: " + ex.Message });
            }
        }

        public IActionResult GetPdf(int id)
        {
            // Mock PDF generation - in reality you'd generate or retrieve actual PDF
            // For demo purposes, return a simple response or redirect to a sample PDF
            try
            {
                // You could return a sample PDF file or generate one
                // For now, we'll return a simple text response indicating PDF would be here
                var pdfContent = System.Text.Encoding.UTF8.GetBytes("Mock PDF Content for Prescription " + id);
                return File(pdfContent, "application/pdf", $"prescription_{id}.pdf");
            }
            catch
            {
                return NotFound("PDF not available");
            }
        }

        // Additional mock action for prescription search/filtering
        public IActionResult SearchPrescriptions(string searchTerm, string status)
        {
            var allPrescriptions = new[]
            {
                new {
                    PrescriptionID = 1,
                    PatientIdNumber = "8701015123085",
                    PatientName = "John Doe",
                    PrescriptionDate = new DateTime(2025, 07, 20),
                    DoctorName = "Dr. Smith",
                    Status = "Pending",
                    MedicationCount = 2
                },
                new {
                    PrescriptionID = 2,
                    PatientIdNumber = "9205123456789",
                    PatientName = "Jane Wilson",
                    PrescriptionDate = new DateTime(2025, 07, 22),
                    DoctorName = "Dr. Johnson",
                    Status = "Dispensed",
                    MedicationCount = 1
                },
                new {
                    PrescriptionID = 3,
                    PatientIdNumber = "7803087654321",
                    PatientName = "Mike Brown",
                    PrescriptionDate = new DateTime(2025, 07, 23),
                    DoctorName = "Dr. Davis",
                    Status = "Ready",
                    MedicationCount = 3
                }
            };

            // Filter based on search criteria
            var filteredPrescriptions = allPrescriptions.AsEnumerable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                filteredPrescriptions = filteredPrescriptions.Where(p =>
                    p.PatientName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    p.PatientIdNumber.Contains(searchTerm) ||
                    p.DoctorName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(status) && status != "All")
            {
                filteredPrescriptions = filteredPrescriptions.Where(p => p.Status == status);
            }

            return Json(filteredPrescriptions.ToArray());
        }
    }
}
