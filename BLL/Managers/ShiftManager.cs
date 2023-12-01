using BLL.Enums;
using BLL.Interfaces;
using BLL.Models;
using BLL.Models.AutoSchedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class ShiftManager : IShiftManager
    {
        public IShiftDataAccess shiftDataAccess;

        public ShiftManager(IShiftDataAccess shiftDataAccess)
        {
            this.shiftDataAccess = shiftDataAccess;
        }

        public bool Create(Shift shift, out int id)
        {
            return shiftDataAccess.CreateShift(shift, out id);
        }

        public bool AssignEmployee(Shift S, Employee E)
        {
            return shiftDataAccess.Assignemployee(S, E);
        }
        public bool UnAssignEmployee(Shift S, Employee E)
        {
            return shiftDataAccess.UnAssignEmployee(S, E);
        }
        public List<Shift> GetAllShiftByEmp(int empid)
        {
            return shiftDataAccess.GetAllShiftsByemp(empid);
        }
        public int GetAmountassigned(Shift S)
        {
            return shiftDataAccess.GetAmountassigned(S);
        }
        public Shift? GetShift(DateTime date, Shifttime shifttime)
        {
            return shiftDataAccess.GetShift(date, shifttime);
        }
        public List<Shift> GetShiftsBetweenDates(DateTime Start, DateTime end)
        {
            return shiftDataAccess.GetShiftsBetweenDates(Start, end);
        }
    }
}
