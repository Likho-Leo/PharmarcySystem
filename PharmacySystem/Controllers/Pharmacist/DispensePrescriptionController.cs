using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers.Pharmacist
{
    public class DispensePrescriptionController : Controller
    {
        public IActionResult DispensePrescription()
        {
            return View();
        }

        public IActionResult DisplayHistory()
        {
            return View();
        }

        public IActionResult ViewHistory(int id)
        {
            // Mock data for prototyping
            var model = new
            {
                Id = id,
                PatientId = "8701015123085",
                PatientName = "John Doe",
                Medication = "Amoxicillin",
                Dosage = "500mg",
                DateDispensed = "2025-05-08",
                Pharmacist = "Dr. Mokoena"
            };

            return View(model);
        }

        public IActionResult FulfillOrders()
        {
            // No model needed since we're using mock data in the view
            return View();
        }

        public IActionResult ViewFullDetails(int id)
        {
            // Mock data based on the order ID
            var model = GetMockOrderDetails(id);
            return View(model);
        }

        private object GetMockOrderDetails(int id)
        {
            // Mock data for different orders
            switch (id)
            {
                case 1:
                    return new
                    {
                        OrderId = "PRC001",
                        Id = 1,
                        Status = "Pending",
                        Priority = "Today",
                        PriorityClass = "text-danger",
                        SubmittedDate = "23/07/2025",
                        SubmittedTime = "09:15",
                        Patient = new
                        {
                            Name = "John Smith",
                            Id = "8502156789012",
                            Phone = "011-123-4567",
                            Email = "john.smith@email.com",
                            Address = "123 Main Street, Johannesburg, 2001"
                        },
                        Doctor = new
                        {
                            Name = "Dr. Sarah Johnson",
                            PracticeNumber = "MP12345",
                            Phone = "011-987-6543",
                            Email = "s.johnson@medicalpractice.co.za"
                        },
                        Medication = new
                        {
                            Name = "Amoxicillin 500mg",
                            Code = "AMX500",
                            Quantity = 20,
                            UnitPrice = 15.50m,
                            Total = 310.00m,
                            Batch = "BAT001",
                            Expiry = "15/12/2025",
                            Notes = "Take with food",
                            Instructions = "Take one capsule three times daily with meals for 7 days"
                        },
                        Prescription = new
                        {
                            Number = "RX2025001234",
                            DateIssued = "22/07/2025",
                            ValidUntil = "22/08/2025",
                            Repeats = "0 repeats remaining"
                        }
                    };

                case 2:
                    return new
                    {
                        OrderId = "PRC002",
                        Id = 2,
                        Status = "Processing",
                        Priority = "Yesterday",
                        PriorityClass = "text-warning",
                        SubmittedDate = "22/07/2025",
                        SubmittedTime = "14:30",
                        Patient = new
                        {
                            Name = "Mary Wilson",
                            Id = "7803125896321",
                            Phone = "021-456-7890",
                            Email = "mary.wilson@email.com",
                            Address = "456 Oak Avenue, Cape Town, 8001"
                        },
                        Doctor = new
                        {
                            Name = "Dr. Michael Brown",
                            PracticeNumber = "MP67890",
                            Phone = "021-654-3210",
                            Email = "m.brown@cardiaccare.co.za"
                        },
                        Medication = new
                        {
                            Name = "Lisinopril 10mg",
                            Code = "LIS010",
                            Quantity = 30,
                            UnitPrice = 8.75m,
                            Total = 262.50m,
                            Batch = "BAT002",
                            Expiry = "20/11/2025",
                            Notes = "",
                            Instructions = "Take one tablet daily in the morning"
                        },
                        Prescription = new
                        {
                            Number = "RX2025001235",
                            DateIssued = "21/07/2025",
                            ValidUntil = "21/08/2025",
                            Repeats = "2 repeats remaining"
                        }
                    };

                case 3:
                    return new
                    {
                        OrderId = "PRC003",
                        Id = 3,
                        Status = "Ready",
                        Priority = "Standard",
                        PriorityClass = "text-success",
                        SubmittedDate = "21/07/2025",
                        SubmittedTime = "11:45",
                        Patient = new
                        {
                            Name = "David Lee",
                            Id = "9012034567890",
                            Phone = "031-789-0123",
                            Email = "david.lee@email.com",
                            Address = "789 Pine Road, Durban, 4001"
                        },
                        Doctor = new
                        {
                            Name = "Dr. Lisa White",
                            PracticeNumber = "MP11111",
                            Phone = "031-321-0987",
                            Email = "l.white@diabetesclinic.co.za"
                        },
                        Medication = new
                        {
                            Name = "Metformin 850mg",
                            Code = "MET850",
                            Quantity = 60,
                            UnitPrice = 4.20m,
                            Total = 252.00m,
                            Batch = "BAT003",
                            Expiry = "08/10/2025",
                            Notes = "Take twice daily",
                            Instructions = "Take one tablet twice daily with breakfast and dinner"
                        },
                        Prescription = new
                        {
                            Number = "RX2025001236",
                            DateIssued = "20/07/2025",
                            ValidUntil = "20/08/2025",
                            Repeats = "5 repeats remaining"
                        }
                    };

                case 4:
                    return new
                    {
                        OrderId = "PRC004",
                        Id = 4,
                        Status = "Pending",
                        Priority = "Today",
                        PriorityClass = "text-danger",
                        SubmittedDate = "23/07/2025",
                        SubmittedTime = "13:20",
                        Patient = new
                        {
                            Name = "Emma Thompson",
                            Id = "8901234567812",
                            Phone = "012-345-6789",
                            Email = "emma.thompson@email.com",
                            Address = "321 Elm Street, Pretoria, 0001"
                        },
                        Doctor = new
                        {
                            Name = "Dr. James Davis",
                            PracticeNumber = "MP22222",
                            Phone = "012-876-5432",
                            Email = "j.davis@heartclinic.co.za"
                        },
                        Medication = new
                        {
                            Name = "Atorvastatin 20mg",
                            Code = "ATO020",
                            Quantity = 28,
                            UnitPrice = 12.30m,
                            Total = 344.40m,
                            Batch = "BAT004",
                            Expiry = "30/01/2026",
                            Notes = "",
                            Instructions = "Take one tablet daily in the evening with or without food"
                        },
                        Prescription = new
                        {
                            Number = "RX2025001237",
                            DateIssued = "22/07/2025",
                            ValidUntil = "22/08/2025",
                            Repeats = "3 repeats remaining"
                        }
                    };

                default:
                    return new
                    {
                        OrderId = "PRC000",
                        Id = id,
                        Status = "Unknown",
                        Priority = "Standard",
                        PriorityClass = "text-muted",
                        SubmittedDate = "23/07/2025",
                        SubmittedTime = "00:00",
                        Patient = new
                        {
                            Name = "Unknown Patient",
                            Id = "0000000000000",
                            Phone = "N/A",
                            Email = "N/A",
                            Address = "N/A"
                        },
                        Doctor = new
                        {
                            Name = "Unknown Doctor",
                            PracticeNumber = "N/A",
                            Phone = "N/A",
                            Email = "N/A"
                        },
                        Medication = new
                        {
                            Name = "Unknown Medication",
                            Code = "N/A",
                            Quantity = 0,
                            UnitPrice = 0.00m,
                            Total = 0.00m,
                            Batch = "N/A",
                            Expiry = "N/A",
                            Notes = "",
                            Instructions = "N/A"
                        },
                        Prescription = new
                        {
                            Number = "N/A",
                            DateIssued = "N/A",
                            ValidUntil = "N/A",
                            Repeats = "N/A"
                        }
                    };
            }
        }
    }
}