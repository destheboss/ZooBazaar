using BLL.Managers;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class AnimalManagementModel : PageModel
    {
        private readonly AnimalManager _animalmanager; 

        public List<Animal> AvailableAnimals { get; set; }
        public Animal Id { get;  set; }
        public Animal AnimalType { get;  set; }

        public void OnGet()
        {
            _animalmanager.GetAllAliveAnimals();
            // Populate the AvailableAnimals property
        }

        public IActionResult OnGetAssign(int animalId)
        {
            // Logic to assign caretaker to the selected animal
            return RedirectToPage("./AnimalManagement");
        }
    }
}
