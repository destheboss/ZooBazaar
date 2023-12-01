using BLL.Enums;
using BLL.Managers;
using BLL.Models;
using BLL.Models.AutoSchedule;
using DAL;
using Desktop.Forms.AnimalShiftNeccesities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms
{
    public partial class AnimalShiftForm : Form
    {
        private readonly Animal Animal;
        private readonly AnimalShiftManager manager = new AnimalShiftManager(new AnimalshiftDataAccess());
        private DateTime timetoshow;
        public AnimalShiftForm(Animal Animal = null)
        {
            InitializeComponent();
            this.Animal = Animal;
            //this.Animal = new Animal()
            //{
            //    Id = 14
            //};
            timetoshow = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            SetupDays();
            if (Animal == null)
            {
                BtnBack.Visible = false;
            }
        }
        private void SetupDays()
        {
            DayContainer.Controls.Clear();
            DateTime Monday = timetoshow;
            if (Animal != null)
            {
                for (int i = 0; i < 7; i++)
                {
                    DateTime currentday = Monday.AddDays(i);
                    if (manager.Getanimalshiftsbyanimal(Animal) != null)
                    {
                        List<AnimalShift> sd = manager.Getanimalshiftsbyanimal(Animal);
                        DateTime lastaday = Monday.AddDays(7);
                        DayOfWeek current = currentday.DayOfWeek;
                        switch (i)
                        {
                            case 0:
                                current = DayOfWeek.Monday;
                                break;
                            case 1:
                                current = DayOfWeek.Tuesday;
                                break;
                            case 2:
                                current = DayOfWeek.Wednesday;
                                break;
                            case 3:
                                current = DayOfWeek.Thursday;
                                break;
                            case 4:
                                current = DayOfWeek.Friday;
                                break;
                            case 5:
                                current = DayOfWeek.Saturday;
                                break;
                            case 6:
                                current = DayOfWeek.Sunday;
                                break;

                        }
                        List<AnimalShift> FilteredShifts = sd.Where(X => X.TimeShift.Day == currentday.Day || X.TimeShift.DayOfWeek == current && X.ShiftType == ANimalshiftStatus.Repeat).ToList();
                        if (FilteredShifts.Count != 0)
                        {
                            DayContainer.Controls.Add(new UserControlAnimalDay(Animal, currentday, FilteredShifts));
                        }
                        else
                        {
                            DayContainer.Controls.Add(new UserControlAnimalDay(Animal, currentday));

                        }
                    }
                    else
                    {
                        DayContainer.Controls.Add(new UserControlAnimalDay(Animal, currentday));

                    }
                }
            }
            else
            {
                List<AnimalShift> sd = manager.GetAnimalShifts();
                for (int i = 0; i < 7; i++)
                {
                    DateTime currentday = Monday.AddDays(i);
                    if (manager.GetAnimalShifts() != null)
                    {
                        DateTime lastaday = Monday.AddDays(7);
                        DayOfWeek current = currentday.DayOfWeek;
                        switch (i)
                        {
                            case 0:
                                current = DayOfWeek.Monday;
                                break;
                            case 1:
                                current = DayOfWeek.Tuesday;
                                break;
                            case 2:
                                current = DayOfWeek.Wednesday;
                                break;
                            case 3:
                                current = DayOfWeek.Thursday;
                                break;
                            case 4:
                                current = DayOfWeek.Friday;
                                break;
                            case 5:
                                current = DayOfWeek.Saturday;
                                break;
                            case 6:
                                current = DayOfWeek.Sunday;
                                break;

                        }
                        List<AnimalShift> FilteredShifts = sd.Where(X => X.TimeShift.Day == currentday.Day || X.TimeShift.DayOfWeek == current && X.ShiftType == ANimalshiftStatus.Repeat).ToList();
                        if (FilteredShifts.Count != 0)
                        {
                            DayContainer.Controls.Add(new UserControlAnimalDay(currentday, FilteredShifts));
                        }
                        else
                        {
                            DayContainer.Controls.Add(new UserControlAnimalDay(currentday));

                        }
                    }
                    else
                    {
                        DayContainer.Controls.Add(new UserControlAnimalDay(Animal, currentday));

                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPreviousWeek_Click(object sender, EventArgs e)
        {
            timetoshow = timetoshow.AddDays(-7);
            SetupDays();
        }

        private void BtnNextWeek_Click(object sender, EventArgs e)
        {
            timetoshow = timetoshow.AddDays(7);
            SetupDays();
        }
    }
}
