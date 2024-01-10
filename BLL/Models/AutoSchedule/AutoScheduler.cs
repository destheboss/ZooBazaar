using BLL.Interfaces;
using BLL.Managers;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum = System.Enum;

namespace BLL.Models.AutoSchedule
{
    public class AutoScheduler
    {
        private readonly AnimalShiftManager ASM;
        private readonly ShiftManager SM;
        private readonly UserManager EM;
        private List<Employee> _cachedEmployees;
        private const int maxHours = 40;

        public AutoScheduler(AnimalShiftManager aSM, ShiftManager sM, UserManager eM)
        {
            ASM = aSM;
            SM = sM;
            EM = eM;
            _cachedEmployees = EM.GetAllEmployees();
        }

        public AutoScheduler()
        {
        }

        public int Schedule(DateTime StartDate, DateTime EndDate)
        {
            try
            {
                List<AnimalShift> Animalshifts = ASM.GetAnimalShifts();
                Animalshifts = Animalshifts.Where(X => X.TimeShift.Date >= StartDate.Date && X.TimeShift.Date <= EndDate.Date || X.ShiftType == Enums.ANimalshiftStatus.Repeat).ToList();

                List<Shift> shifts = SM.GetShiftsBetweenDates(StartDate, EndDate);

                InitializeShiftsIfNeeded(StartDate, EndDate, shifts);

                Dictionary<Shift, int> ShiftRequirements = new Dictionary<Shift, int>();

                foreach (Shift Chosen in shifts)
                {
                    int Requirement = GetRequirement(Animalshifts, Chosen);
                    Chosen.Employee = EM.GetAllAssignedEmployees(Chosen);
                    ShiftRequirements.Add(Chosen, Requirement);
                }

                int amountassigned = AssignEmployees(ShiftRequirements);

                return amountassigned;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void InitializeShiftsIfNeeded(DateTime StartDate, DateTime EndDate, List<Shift> shifts)
        {
            int daysBetweenDates = (EndDate - StartDate).Days + 1;

            if (shifts.Count != daysBetweenDates * 3) // check if all shifts are here already
            {
                for (int i = 0; i < daysBetweenDates; i++)
                {
                    DateTime currentDate = StartDate.AddDays(i);

                    // Get all shifts for the current day once instead of querying three times
                    List<Shift> todaysShifts = shifts.Where(s => s.Date.Date == currentDate.Date).ToList();

                    foreach (Enums.Shifttime shiftTime in Enum.GetValues(typeof(Enums.Shifttime)))
                    {
                        // Check if a shift for the current shift time already exists
                        if (!todaysShifts.Any(s => s.Date.Date == currentDate.Date && s.Shifttime == shiftTime))
                        {
                            // If it doesn't exist, create the shift
                            Shift newShift = new Shift(currentDate, shiftTime);
                            if (SM.Create(newShift, out int id)) // Only add to the list if creation is successful
                            {
                                newShift.Id = id;
                                shifts.Add(newShift);
                            }
                            else
                            {
                                throw new Exception($"Error creating shift");
                            }
                        }
                    }
                }
            }
        }

        private int AssignEmployees(Dictionary<Shift, int> ShiftRequirements)
        {
            int amountassigned = 0;

            foreach (KeyValuePair<Shift, int> Requirement in ShiftRequirements)
            {
                if (Requirement.Key.Employee.Count() < Requirement.Value + 3)
                {
                    List<Employee> Assignedcaretaker = Requirement.Key.Employee.Where(X => X.Role == Role.Caretaker).ToList();
                    List<Employee> BestsuitedCaretaker = GetBestSuitedEmployees(Requirement.Key.Date, Role.Caretaker);
                    foreach (Employee employee in Assignedcaretaker)
                    {
                        BestsuitedCaretaker = BestsuitedCaretaker.Where(X => X.Id != employee.Id).ToList();
                    }
                    int stillrequired = Requirement.Value - Assignedcaretaker.Count();
                    for (int i = 0; i < stillrequired + 1; i++)
                    {
                        SM.AssignEmployee(Requirement.Key, BestsuitedCaretaker[i]);
                        amountassigned++;
                    }
                    if (Requirement.Key.Employee.FirstOrDefault(X => X.Role == Role.Security) == null)
                    {
                        List<Employee> BestSuitedSecurity = GetBestSuitedEmployees(Requirement.Key.Date, Role.Security);
                        SM.AssignEmployee(Requirement.Key, BestSuitedSecurity[0]);
                        amountassigned++;
                    }
                    if (Requirement.Key.Employee.FirstOrDefault(X => X.Role == Role.Vet) == null)
                    {
                        List<Employee> BestSuitedVet = GetBestSuitedEmployees(Requirement.Key.Date, Role.Vet);
                        SM.AssignEmployee(Requirement.Key, BestSuitedVet[0]);
                        amountassigned++;
                    }
                    if (Requirement.Key.Employee.FirstOrDefault(X => X.Role == Role.Cashier) == null && Requirement.Key.Shifttime != Enums.Shifttime.Evening)
                    {
                        List<Employee> BestSuitedCashier = GetBestSuitedEmployees(Requirement.Key.Date, Role.Cashier);
                        SM.AssignEmployee(Requirement.Key, BestSuitedCashier[0]);
                        amountassigned++;
                    }
                }
            }

            return amountassigned;
        }

        private int GetRequirement(List<AnimalShift> Shifts, Shift Chosen)
        {
            DateTime Starttime = Chosen.Date.AddHours(4);
            switch (Chosen.Shifttime)
            {
                case Enums.Shifttime.AfterNoon:
                    Starttime = Starttime.AddHours(6);
                    break;
                case Enums.Shifttime.Evening:
                    Starttime = Starttime.AddHours(12);
                    break;
                default:
                    break;
            }

            List<AnimalShift> RQ = Shifts.Where(X => X.TimeShift.Date == Starttime.Date && X.TimeShift.Hour >= Starttime.Hour && X.TimeShift.Hour <= Starttime.AddHours(6).Hour).ToList();
            List<int> Maxsizelist = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                List<AnimalShift> intermediate = RQ.Where(X => X.TimeShift.Hour == Starttime.AddHours(i).Hour).ToList();
                Maxsizelist.Add(intermediate.Count);
            }
            if (Maxsizelist != null)
            {
                return Maxsizelist.Max();
            }
            return 0;
        }

        private List<Employee> GetBestSuitedEmployees(DateTime date, Role role)
        {
            try
            {
                DateTime firstDayOfWeek = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday);
                var employeesWithLeastShifts = new HashSet<int>(EM.GetEmployeeswithleastshifts(firstDayOfWeek));

                return _cachedEmployees
                    .Where(e => e.Role == role)
                    .Where(e => !DoesEmployeeHaveMaxHours(e.Id, firstDayOfWeek))
                    .Where(e => EM.CanEmpBeScheduled(date, e.Id))
                    .Select(e => new { Employee = e, Score = employeesWithLeastShifts.Contains(e.Id) ? 1 : 0 })
                    .OrderByDescending(e => e.Score)
                    .Select(e => e.Employee)
                    .ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool DoesEmployeeHaveMaxHours(int E, DateTime Startofweek)
        {
            int hoursthisweek = 0;
            hoursthisweek = EM.DoesEmployeehaveMaxHours(Startofweek, E) * 6;
            return hoursthisweek >= maxHours;
        }
    }
}