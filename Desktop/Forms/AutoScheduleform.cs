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

namespace Desktop.Forms
{
    public partial class AutoScheduleform : Form
    {
        private ShiftForm form;
        private readonly AnimalShiftManager ASM;
        private readonly ShiftManager SM;
        private readonly UserManager EM;

        public AutoScheduleform(ShiftForm form)
        {
            InitializeComponent();
            this.form = form;
            ASM = new AnimalShiftManager(new AnimalshiftDataAccess());
            SM = new ShiftManager(new ShiftDataAccess());
            EM = new UserManager(new UserDataAccess());
        }

        private async void BtnAutoSchedule_Click(object sender, EventArgs e)
        {
            if (Dtpstartdate.Value.Date > DtpEndDate.Value.Date)
            {
                MessageBox.Show("Start date cannot be after end date");
                return;
            }
            AutoScheduler Scheduler = new AutoScheduler(SM, EM);
            var val = await Task.Run(() => Scheduler.Schedule(Dtpstartdate.Value, DtpEndDate.Value));

            if (val != null)
            {
                form.refresh();
            }   
        }
    }
}
