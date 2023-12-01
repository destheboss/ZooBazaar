using BLL.Managers;
using BLL.Models;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB.Pages
{
    public class AnimalDetailsModel : PageModel
    {
        private readonly AnimalManager _animalManager;
        [BindProperty(SupportsGet = true)]
        public string AnimalId { get; set; }
        public Animal AnimalDetails { get; set; }
        public List<AnimalNotes> AnimalNotes { get; set; }
        public AnimalDetailsModel()
        {
            _animalManager = new AnimalManager(new AnimalDataAccess());
        }



        public void OnGet(int id)
        {
            // Fetch animal details
            AnimalDetails = _animalManager.GetAnimalById(Convert.ToInt32(id));

            // Fetch animal notes (you need to implement this method in your manager)
            AnimalNotes = _animalManager.GetNotesByAnimalId(Convert.ToInt32(id));
        }
    }
}
