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

        public void OnGet()
        {
            AvailableAnimals = _animalManager.GetAllAliveAnimals();
        }

    

        public IActionResult OnGetAnimalDetails(int animalId)
        {
            // Redirect to the AnimalDetails page with the selected animalId
            return RedirectToPage("/AnimalDetails", new { animalId });
        }
    }
}