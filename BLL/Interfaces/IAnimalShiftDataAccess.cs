using BLL.Models;
using BLL.Models.AutoSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IAnimalShiftDataAccess
    {
        bool CreateShift(AnimalShift shift);
        List<AnimalShift> GetAnimalShiftsByanimal(Animal animal);
        List<AnimalShift> GetAnimalShifts();
        bool Deleteshift(AnimalShift shift);
    }
}
