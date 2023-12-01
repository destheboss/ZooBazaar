using Desktop.Forms.ShiftNeccessities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms
{
    public partial class ShiftForm : Form
    {
        private int month, year;

        public ShiftForm()
        {
            InitializeComponent();
            setupMY();
            DisplayDays();
        }
        private void setupMY()
        {
            DateTime _now = DateTime.Now;

            month = _now.Month;
            year = _now.Year;
        }
        public void refresh()
        {
            DayContainer.Controls.Clear();
            DisplayDays();
        }
        private void DisplayDays()
        {

            DateTime _startOfTheMonth = new DateTime(year, month, 1);

            int _days = DateTime.DaysInMonth(year, month) + 1;

            int _dayOfWeek = Convert.ToInt32(_startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < _dayOfWeek; i++)
            {
                DayContainer.Controls.Add(new UserControlBlank());
            }

            for (int i = 1; i < _days; i++)
            {
                DateTime current = new DateTime(year, month, i);
                DayContainer.Controls.Add(new UserControlDays(i, current, this));
            }

            LbDate.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;
        }

        private void Btnschedule_Click(object sender, EventArgs e)
        {
            AutoScheduleform form = new AutoScheduleform(this);
            form.ShowDialog();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            if (month == 1)
            {
                year--;
                month = 12;
            }
            else
            {
                month--;
            }
            DisplayDays();
        }
        public void RefreshInvoke()
        {
            if (Visible)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => refresh()));
                    return;
                }
                else
                {
                    refresh();
                }
            }
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            DayContainer.Controls.Clear();
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else
            {
                month++;
            }

            DisplayDays();
        }
    }
}
