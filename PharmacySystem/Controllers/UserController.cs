using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult AddUser()
        {
            return View(); // Initialize a new user
        }


        [HttpGet]
        public async Task<IActionResult> EditUser(int id)
        {
            
            return View();
        }


        [HttpGet]
        public IActionResult DisplayAllUser(string search)
        {
            var users = new List<dynamic>
            {
            new {
                UserID= 1, EmployeeNumber = "2245565", Name="Shantel", Surname="Van", Title = "Mrs.", Gender = "Female", IDNumber = "1901085648879",
                DOB = "1919-01-08", CellPhoneNumber = "0785645676", AddressLine1 = "23 Marine Drive", AddressLine2 = "Summerstrand", Country = "South Africa",
                Province = "Eastern Cape", City = "Gqeberha", TownSurburb = "Summerstrand", PostalCode = "6001", Role = "Pharmacist",
                EmploymentDate = "2022-02-23", EmailAddress = "shantel5@gmail.com", Password = "ShantelVan5@", HealthCouncilRegNO = 134326
            },
            new {
                UserID = 2, EmployeeNumber = "2245566", Name = "Jason", Surname = "Mokoena", Title = "Mr.", Gender = "Male", IDNumber = "8802125045086",
                DOB = "1988-02-12", CellPhoneNumber = "0721234567", AddressLine1 = "15 West Street", AddressLine2 = "Central", Country = "South Africa",
                Province = "Gauteng", City = "Johannesburg", TownSurburb = "CBD", PostalCode = "2001", Role = "Nurse",
                EmploymentDate = "2021-06-10", EmailAddress = "jason.mokoena@example.com", Password = "JasonM88!", HealthCouncilRegNO = 239874
            },
            new {
                UserID = 3, EmployeeNumber = "2245567", Name = "Anele", Surname = "Nkosi", Title = "Ms.", Gender = "Female", IDNumber = "9503056789083",
                DOB = "1995-03-05", CellPhoneNumber = "0839876543", AddressLine1 = "12 Long Street", AddressLine2 = "Observatory", Country = "South Africa",
                Province = "Western Cape", City = "Cape Town", TownSurburb = "Observatory", PostalCode = "7925", Role = "Administrator",
                EmploymentDate = "2023-01-15", EmailAddress = "anele.nkosi@example.com", Password = "AneleN95#", HealthCouncilRegNO = 567321
            }
            };

            if (!string.IsNullOrWhiteSpace(search))
            {
                users = users.Where(u => u.EmployeeNumber.Contains(search)).ToList();
            }

            ViewBag.Users = users;
            return View();
        }
        public async Task<IActionResult> DeleteUser(int id)
        {
            return RedirectToAction(nameof(DisplayAllUser));
        }

    }
}
