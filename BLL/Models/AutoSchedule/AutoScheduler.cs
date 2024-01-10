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
        private const int requiredEmployeesPerShift = 2;

        //public AutoScheduler(AnimalShiftManager aSM, ShiftManager sM, UserManager eM)
        //{
        //    ASM = aSM;
        //    SM = sM;
        //    EM = eM;
        //}

        public AutoScheduler(ShiftManager sM, UserManager eM)
        {
            SM = sM;
            EM = eM;
        }
        public AutoScheduler()
        {
        }

        public int Schedule(DateTime StartDate, DateTime EndDate)
        {
            try
            {
                //List<AnimalShift> Animalshifts = ASM.GetAnimalShifts();

                //Animalshifts = Animalshifts.Where(X => X.TimeShift.Date >= StartDate.Date && X.TimeShift.Date <= EndDate.Date || X.ShiftType == Enums.ANimalshiftStatus.Repeat).ToList();

                List<Employee> Employees = EM.GetAllEmployees();

                List<Shift> shifts = SM.GetShiftsBetweenDates(StartDate, EndDate);

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
                            if (!todaysShifts.Any(s => s.Shifttime == shiftTime))
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

                Dictionary<Shift, int> ShiftRequirements = new Dictionary<Shift, int>(); // CREATE SHIFT REQUIREMENTS

                foreach (Shift Chosen in shifts)
                {
                    //int Requirement = GetRequirement(Animalshifts, Chosen); Original method
                    int Requirement = GetRequirement(Chosen);
                    Chosen.Employee = EM.GetAllAssignedEmployees(Chosen);
                    ShiftRequirements.Add(Chosen, Requirement);
                }

                int amountassigned = 0;
                foreach (KeyValuePair<Shift, int> Requirement in ShiftRequirements)
                {
                    if (Requirement.Key.Employee.Count() < Requirement.Value + 3)
                    {
                        List<Employee> Assignedcaretaker = Requirement.Key.Employee.Where(X => X.Role == Role.Caretaker).ToList();
                        List<Employee> BestsuitedCaretaker = GetBestSuitedEmployees(Employees, Requirement.Key.Date, Role.Caretaker);
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
                            List<Employee> BestSuitedSecurity = GetBestSuitedEmployees(Employees, Requirement.Key.Date, Role.Security);
                            SM.AssignEmployee(Requirement.Key, BestSuitedSecurity[0]);
                            amountassigned++;
                        }
                        if (Requirement.Key.Employee.FirstOrDefault(X => X.Role == Role.Vet) == null)
                        {
                            List<Employee> BestSuitedVet = GetBestSuitedEmployees(Employees, Requirement.Key.Date, Role.Vet);
                            SM.AssignEmployee(Requirement.Key, BestSuitedVet[0]);
                            amountassigned++;
                        }
                        if (Requirement.Key.Employee.FirstOrDefault(X => X.Role == Role.Cashier) == null && Requirement.Key.Shifttime != Enums.Shifttime.Evening)
                        {
                            List<Employee> BestSuitedCashier = GetBestSuitedEmployees(Employees, Requirement.Key.Date, Role.Cashier);
                            SM.AssignEmployee(Requirement.Key, BestSuitedCashier[0]);
                            amountassigned++;
                        }

                    }
                }

                return amountassigned;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private int GetRequirement(Shift Chosen)
        {
            switch (Chosen.Shifttime)
            {
                case Enums.Shifttime.Morning:
                    return requiredEmployeesPerShift;
                case Enums.Shifttime.AfterNoon:
                    return requiredEmployeesPerShift;
                case Enums.Shifttime.Evening:
                    return requiredEmployeesPerShift;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Chosen.Shifttime), "Invalid shift time.");
            }
        }

        //private int GetRequirement(List<AnimalShift> Shifts, Shift Chosen)
        //{
        //    DateTime Starttime = Chosen.Date.AddHours(4);
        //    switch (Chosen.Shifttime)
        //    {
        //        case Enums.Shifttime.AfterNoon:
        //            Starttime = Starttime.AddHours(6);
        //            break;
        //        case Enums.Shifttime.Evening:
        //            Starttime = Starttime.AddHours(12);
        //            break;
        //        default:
        //            break;
        //    }

        //    List<AnimalShift> RQ = Shifts.Where(X => X.TimeShift.Date == Starttime.Date && X.TimeShift.Hour >= Starttime.Hour && X.TimeShift.Hour <= Starttime.AddHours(6).Hour).ToList();
        //    List<int> Maxsizelist = new List<int>();
        //    for (int i = 0; i < 6; i++)
        //    {
        //        List<AnimalShift> intermediate = RQ.Where(X => X.TimeShift.Hour == Starttime.AddHours(i).Hour).ToList();
        //        Maxsizelist.Add(intermediate.Count);
        //    }
        //    if (Maxsizelist != null)
        //    {
        //        return Maxsizelist.Max();
        //    }
        //    return 0;
        //}

        private List<Employee> GetBestSuitedEmployees(List<Employee> AllEmployees, DateTime date, Role role)
        {
            try
            {

                DateTime firstdayofweek = date.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
                Dictionary<int, double> Empscores = new Dictionary<int, double>();
                double i = 1;
                foreach (int I in EM.GetEmployeeswithleastshifts(firstdayofweek))
                {

                    double s = 1;
                    Empscores.Add(I, i + s);

                    i -= 0.1;
                    if (DoesEmployeeHaveMaxHours(I, firstdayofweek))
                    {

                        Empscores.Remove(I);
                    }
                    if (!EM.CanEmpBeScheduled(date, I))
                    {
                        Empscores.Remove(I);
                    }



                }
                List<Employee> Optimal = new List<Employee>();
                int amounttodo = Empscores.Count();
                for (int c = 0; c < amounttodo; c++)
                {
                    Optimal.Add(AllEmployees.Where(M => M.Id == Empscores.OrderByDescending(M => M.Value).First().Key).First());
                    Empscores.Remove(Optimal[c].Id);
                }
                Optimal = Optimal.Where(X => X.Role == role).ToList();
                return Optimal;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool DoesEmployeeHaveMaxHours(int E, DateTime Startofweek)
        {
            int maxhours = 40;
            int hoursthisweek = 0;
            hoursthisweek = EM.DoesEmployeehaveMaxHours(Startofweek, E) * 6;
            return hoursthisweek >= maxhours;
        }
    }
}