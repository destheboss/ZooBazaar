using BLL.Managers;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class AnimalManagementModel : PageModel
    {
        private readonly UserManager _userManager;
        private readonly AnimalManager _animalManager;
        public AnimalManagementModel()
        {
            _userManager = new UserManager(new UserDataAccess());
            _animalManager = new AnimalManager(new AnimalDataAccess());
        }

        public List<Animal> AvailableAnimals { get; set; }
        public Animal Name { get; set; }
        public Animal AnimalType { get; set; }
        public Animal AliveAnimals { get; set; }

        public void OnGet()
        {
            AvailableAnimals = _animalManager.GetAllAliveAnimals();
            // Populate the AvailableAnimals property
        }

        public IActionResult OnGetAssign(int animalId)
        {
            // Logic to assign caretaker to the selected animal
            return RedirectToPage("./AnimalManagement");
        }
    }
}