using BLL.Enums;
using BLL.Models.AutoSchedule;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IShiftDataAccess
    {
        public bool CreateShift(Shift shift, out int id);
        public bool Assignemployee(Shift shift, Employee employee);
        public bool UnAssignEmployee(Shift shift, Employee employee);
        public int GetAmountassigned(Shift shift);
        public Shift? GetShift(DateTime date, Shifttime shifttime);
        public List<Shift> GetShiftsBetweenDates(DateTime Start, DateTime end);
        public List<Shift> GetAllShifts();
        public List<Shift> GetAllShiftsByemp(int Empid);
    }
}
