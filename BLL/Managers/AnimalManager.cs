using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class AnimalManager
    {
        private readonly IAnimalDataAccess animalData;

        public AnimalManager(IAnimalDataAccess animalData)
        {
            this.animalData = animalData;
        }

        public AnimalManager() { }

        public List<Animal> GetAllAnimals()
        {
            return animalData.GetAllAnimals();
        }

        public List<Animal> GetAllAliveAnimals()
        {
            return animalData.GetAllAliveAnimals();
        }

        public Animal GetAnimalById(int animalId)
        {
            return animalData.GetAnimalById(animalId);
        }
        //Implement for next itteration
        //public void AddAnimalNote(AnimalNotes newNote)
        //{
        //    AnimalNotes.Add(newNote);
        //}

        public void SaveChanges()
        {
            SaveChanges(); 
        }

        public bool AddAnimal(Animal animal)
        {
            return animalData.AddAnimal(animal);
        }

        public bool RemoveAnimal(Animal animal)
        {
            return animalData.RemoveAnimal(animal.Id);
        }

        public bool UpdateAnimal(Animal animal)
        {
            return animalData.UpdateAnimal(animal);
        }
    }
}
