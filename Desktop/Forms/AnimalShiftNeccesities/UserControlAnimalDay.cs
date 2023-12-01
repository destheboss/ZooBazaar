using BLL.Models.AutoSchedule;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.AnimalShiftNeccesities
{
    public partial class UserControlAnimalDay : UserControl
    {
        private readonly Animal Animal;
        private List<AnimalShift> Shifts = new List<AnimalShift>();
        private readonly DateTime date;
        public UserControlAnimalDay(Animal animal, DateTime date, List<AnimalShift> Shifts = null)
        {
            this.Animal = animal;
            this.Shifts = Shifts;
            this.date = date;
            InitializeComponent();
            SetupHoursWithanimal();
        }
        public UserControlAnimalDay(DateTime date, List<AnimalShift> Shifts = null)
        {
            this.Shifts = Shifts;
            this.date = date;
            InitializeComponent();
            SetupHoursWithoutanimal();
        }
        private void SetupHoursWithanimal()
        {
            LblDate.Text = date.ToString("dd");
            for (int i = 0; i < 19; i++)
            {
                AnimalShift shift = null;
                if (Shifts != null)
                {
                    shift = Shifts.FirstOrDefault(X => X.TimeShift.Hour == i + 4);
                }
                DateTime togive = new DateTime(date.Year, date.Month, date.Day, i + 4, 0, 0);
                if (shift == null)
                {
                    HourContainer.Controls.Add(new UserControlAnimalHour(Animal, togive));
                }
                else
                {
                    HourContainer.Controls.Add(new UserControlAnimalHour(Animal, togive, shift));
                }
            }
        }
        private void SetupHoursWithoutanimal()
        {
            LblDate.Text = date.ToString("dd");
            for (int i = 0; i < 19; i++)
            {
                List<AnimalShift> shift = null;
                if (Shifts != null)
                {
                    shift = Shifts.Where(X => X.TimeShift.Hour == i + 4).ToList();
                }
                DateTime togive = new DateTime(date.Year, date.Month, date.Day, i + 4, 0, 0);
                if (shift == null)
                {
                    HourContainer.Controls.Add(new UserControlAnimalHour(togive, new List<AnimalShift>()));
                }
                else
                {
                    HourContainer.Controls.Add(new UserControlAnimalHour(togive, shift));
                }
            }
        }
    }
}
