using DAL;
using BLL.Managers;
using BLL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class CaretakerModel : PageModel
    {
        private readonly UserManager _userManager;
        private readonly AnimalManager _animalManager;

        public CaretakerModel()
        {
            _userManager = new UserManager(new UserDataAccess());
            _animalManager = new AnimalManager(new AnimalDataAccess());
        }

        public List<Employee> Employees { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public Role EmployeeRole { get; set; }
        public AnimalNotes? NewNote { get; set; }
        public int EmployeeId { get; set; }

        public void OnGet()
        {
            var userIdClaim = HttpContext.User.FindFirst("empID");

            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
            {
                var employee = _userManager.GetEmployeeById(userId);

                if (employee != null)
                {
                    InitializeEmployeeProperties(employee);
                }
                else
                {
                    // Handle the case where the employee isn't found
                }
            }
            else
            {
                // Handle the case where the user ID claim is missing or invalid
            }
        }

        private void InitializeEmployeeProperties(Employee employee)
        {
            Email = employee.Email;
            EmployeeRole = employee.Role;
            FirstName = employee.FirstName;
            // Set other properties here
        }
    }

    //public IActionResult OnPost()
    //{
    //    var userIdClaim = HttpContext.User.FindFirst("empID");
    //    if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int employeeId))
    //    {
    //        if (!string.IsNullOrEmpty(NewNote))
    //        {
    //            // Fetch caretaker ID from claims
    //            var caretakerId = employeeId;
    //            var animalId = animalId;

    //            // Fetch animal ID (you need to define or retrieve animalId from somewhere)

    //            AnimalNotes newNote = new AnimalNotes
    //            {
    //                CaretakerId = caretakerId,
    //                AnimalId = animalId,
    //                Note = newNote,
    //                CreatedAt = DateTime.Now
    //            };

    //            _animalmanager.AnimalNotes.Add(newNote);
    //            _animalmanager.SaveChanges();
    //            return RedirectToPage("./CaretakerDashboard");
    //        }
    //    }

    // Handle cases where user ID or note is not valid or missing
    // You might want to add appropriate error handling or redirection here
    //    return Page();
    //}}

}