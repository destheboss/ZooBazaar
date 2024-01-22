using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAnimalDataAccess
    {
        List<Animal> GetAllAnimals();
        List<Animal> GetAllAliveAnimals();
        Animal GetAnimalById(int ids);
        bool AddAnimal(Animal animal);
        bool RemoveAnimal(int id);
        bool UpdateAnimal(Animal animal);
        List<BLL.Models.Task> GetIncompleteTasks(int employeeId);
        bool AddNote(AnimalNotes newnote);
        List<AnimalNotes> GetNotesByAnimalId(int animalId);
        List<Animal> SearchAnimalsByName(string searchTerm);




    }
}
