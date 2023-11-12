using BLL.Managers;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class CaretakerModel : PageModel
    {
        private readonly UserManager _usermanager;
        private readonly AnimalManager _animalmanager;
        public List<Employee> employees { get; set; }
        public Person id { get; set; }
        public Employee firstName { get; set; }
        public AnimalNotes NewNote { get; set; }

        public Role role { get; set; }
        public Employee lastName { get; set; }
        public string email { get; set; }
        public Role Role { get; set; }

        public void OnGet(int id)
        {
            _usermanager.GetEmployeeById(id);
            Employee employee = employees.FirstOrDefault(e => e.id == id);
            if (employee != null)
            {
                role = employee.Role;
                //FirstName = employee.FirstName
                //LastName = employee.LastName
                //Expertise = employee.Expertise;
                //Availability = employee.Availability;

                // Fetch assigned tasks for the caretaker
                //AssignedTasks = _usermanager.Tasks.Where(t => t.CaretakerId == caretakerId).ToList();
            }
        }
        public IActionResult OnPost()
        {
            if (!string.IsNullOrEmpty(NewNote))
            {
                // Save NewNote to the database for the respective animal
                // Assuming there's an AnimalNotes table with columns for caretaker ID, animal ID, and notes.
                AnimalNotes newNote = new AnimalNotes
                {
                    PersonId = employeeid, // Fetch caretaker ID
                    AnimalId = animalId, // Fetch animal ID
                    Note = NewNote,
                    CreatedAt = DateTime.Now
                };

                _animalmanager.AnimalNotes.Add(newNote);
                _animalmanager.SaveChanges();
                return RedirectToPage("./CaretakerDashboard");
            }
        }
    }
}
