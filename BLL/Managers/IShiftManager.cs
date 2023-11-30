using BLL.Enums;
using BLL.Models.AutoSchedule;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public interface IShiftManager
    {
        public bool Create(Shift shift, out int id);
        public bool AssignEmployee(Shift S, Employee E);
        public bool UnAssignEmployee(Shift S, Employee E);
        public int GetAmountassigned(Shift S);
        public Shift? GetShift(DateTime date, Shifttime shifttime);
        public List<Shift> GetShiftsBetweenDates(DateTime Start, DateTime end);
        public List<Shift> GetAllShiftByEmp(int empid);
    }
}
