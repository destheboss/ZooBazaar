using BLL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.AutoSchedule
{
    public class AnimalShift
    {
        private int _id;
        private Animal _animal;
        private ANimalshiftStatus _shiftType;
        private Animalshiftworktype _careType;
        private DateTime _shiftTime;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public Animal Animal
        {
            get
            {
                return _animal;
            }
            set
            {
                _animal = value;
            }
        }
        public ANimalshiftStatus ShiftType
        {
            get
            {
                return _shiftType;
            }
            set
            {
                _shiftType = value;
            }
        }
        public Animalshiftworktype Caretype
        {
            get
            {
                return _careType;
            }
            set
            {
                _careType = value;
            }
        }
        public DateTime TimeShift
        {
            get
            {
                return _shiftTime;
            }
            set
            {
                _shiftTime = value;
            }
        }

        public AnimalShift(Animal animal, ANimalshiftStatus shiftType, Animalshiftworktype careType, DateTime shiftTime)
        {
            this.Animal = animal;
            this.ShiftType = shiftType;
            this.Caretype = careType;
            this.TimeShift = shiftTime;
        }
        public AnimalShift()
        {

        }
    }
}
