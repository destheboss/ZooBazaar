using BLL.Enums;
using BLL.Managers;
using BLL.Models.AutoSchedule;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms.ShiftNeccessities
{
    public partial class UserControlDays : UserControl
    {
        private readonly IShiftManager _manager;
        private readonly DateTime _current;
        private Shift? _morningshift;
        private Shift? _afternoonshift;
        private Shift? _evening;
        private ShiftForm form;
        public UserControlDays(int day, DateTime current, ShiftForm form)
        {
            InitializeComponent();
            Setdays(day);
            _current = current;
            _manager = new ShiftManager(new ShiftDataAccess());
            Setupshifts();
            this.form = form;
        }
        private void Setupshifts()
        {
            _morningshift = _manager.GetShift(_current, Shifttime.Morning);
            _afternoonshift = _manager.GetShift(_current, Shifttime.AfterNoon);
            _evening = _manager.GetShift(_current, Shifttime.Evening);

            int morningAssigned = _morningshift != null ? _manager.GetAmountassigned(_morningshift) : 0;
            int afternoonAssigned = _afternoonshift != null ? _manager.GetAmountassigned(_afternoonshift) : 0;
            int eveningAssigned = _evening != null ? _manager.GetAmountassigned(_evening) : 0;

            BtnMorning.Text = $"Morning {morningAssigned}/4";
            btnafternoon.Text = $"Afternoon {afternoonAssigned}/4";
            btnEvening.Text = $"Evening {eveningAssigned}/3";

            if (_morningshift != null)
            {
                switch (_manager.GetAmountassigned(_morningshift))
                {
                    case > 3:
                        BtnMorning.BackColor = Color.Green;
                        break;
                    case < 3:
                        BtnMorning.BackColor = Color.Blue;
                        break;
                }
            }
            else
            {
                BtnMorning.BackColor = Color.Red;
            }
            if (_afternoonshift != null)
            {
                switch (_manager.GetAmountassigned(_afternoonshift))
                {
                    case > 3:
                        btnafternoon.BackColor = Color.Green;
                        break;
                    case < 3:
                        btnafternoon.BackColor = Color.Blue;
                        break;
                }
            }
            else
            {
                btnafternoon.BackColor = Color.Red;
            }
            if (_evening != null)
            {
                switch (_manager.GetAmountassigned(_evening))
                {
                    case >= 3:
                        btnEvening.BackColor = Color.Green;
                        break;
                    case < 3:
                        btnEvening.BackColor = Color.Blue;
                        break;
                }
            }
            else
            {
                btnEvening.BackColor = Color.Red;
            }
        }
        private void Setdays(int day)
        {
            LbDay.Text = day.ToString();
        }


        private void btnafternoon_Click_1(object sender, EventArgs e)
        {
            if (_afternoonshift != null)
            {
                var t = new Thread(() => Application.Run(new ShiftAssignmentForm(_afternoonshift, form)));
                t.Start();
            }
            else
            {
                _afternoonshift = new Shift(_current, Shifttime.AfterNoon);
                _manager.Create(_afternoonshift, out int id);
                _afternoonshift.Id = id;
                var t = new Thread(() => Application.Run(new ShiftAssignmentForm(_afternoonshift, form)));
                t.Start();
                form.refresh();
            }

        }

        private void BtnMorning_Click_1(object sender, EventArgs e)
        {
            if (_morningshift != null)
            {
                var t = new Thread(() => Application.Run(new ShiftAssignmentForm(_morningshift, form)));
                t.Start();
            }
            else
            {
                _morningshift = new Shift(_current, Shifttime.Morning);
                _manager.Create(_morningshift, out int id);
                _morningshift.Id = id;
                var t = new Thread(() => Application.Run(new ShiftAssignmentForm(_morningshift, form)));
                t.Start();
                form.refresh();
            }
        }

        private void btnEvening_Click_1(object sender, EventArgs e)
        {
            if (_evening != null)
            {
                var t = new Thread(() => Application.Run(new ShiftAssignmentForm(_evening, form)));
                t.Start();
            }
            else
            {
                _evening = new Shift(_current, Shifttime.Evening);
                _manager.Create(_evening, out int id);
                _evening.Id = id;
                var t = new Thread(() => Application.Run(new ShiftAssignmentForm(_evening, form)));
                t.Start();
                form.refresh();
            }
        }
    }
}
