using BLL.Models.AutoSchedule;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;

namespace BLL.Managers
{
    public class AnimalShiftManager
    {
        public IAnimalShiftDataAccess Data;
        public AnimalShiftManager(IAnimalShiftDataAccess Data)
        {
            this.Data = Data;
        }
        public bool CreateShift(AnimalShift shift)
        {
            return Data.CreateShift(shift);
        }
        public List<AnimalShift> Getanimalshiftsbyanimal(Animal animal)
        {
            return Data.GetAnimalShiftsByanimal(animal);
        }
        public List<AnimalShift> GetAnimalShifts()
        {
            return Data.GetAnimalShifts();
        }
        public bool DeleteShift(AnimalShift shift)
        {
            return Data.Deleteshift(shift);
        }
    }
}
