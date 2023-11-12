using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public string AnimalName { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public decimal AnimalWeight { get; private set; }

        public AnimalType AnimalType { get; private set; }

        public AnimalLocation AnimalLocation { get; private set; }

        //public AnimalStatus AnimalStatus { get; private set; }

        public Animal(int id)
        {
            Id = id;
        }

        public Animal(int id, string animalName)
        {
            Id = id;
            SetAnimalName(animalName);
        }

        public Animal(int id, string animalName, DateTime dateOfBirth, decimal animalWeight, AnimalType animalType, AnimalLocation animalLocation/*AnimalStatus animalStatus*/)
        {
            Id = id;
            SetAnimalName(animalName);
            SetDateOfBirth(dateOfBirth);
            SetAnimalWeight(animalWeight);
            AnimalType = animalType;
            AnimalLocation = animalLocation;
            //AnimalStatus = animalStatus;
        }

        public void SetAnimalName(string animalName)
        {
            if (string.IsNullOrWhiteSpace(animalName))
                throw new ArgumentException("Animal name cannot be null or whitespace.");
            AnimalName = animalName.Trim();
        }

        public void SetAnimalWeight(decimal animalWeight)
        {
            if (animalWeight < 0.0m)
                throw new ArgumentException("Weight cannot be negative.");
            AnimalWeight = animalWeight;
        }

        public void SetDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Now)
                throw new ArgumentException("Date of birth cannot be in the future.");
            DateOfBirth = dateOfBirth;
        }
    }
}
