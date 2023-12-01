using BLL.Managers;
using BLL.Models;
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
    public partial class ShiftAssignmentForm : Form
    {
        private readonly IShiftManager shiftManager;
        private readonly UserManager employeeManager;
        private readonly Shift SelectedShift;
        private ShiftForm Sform;
        public ShiftAssignmentForm(Shift Selected, ShiftForm form)
        {
            InitializeComponent();
            employeeManager = new UserManager(new UserDataAccess());
            shiftManager = new ShiftManager(new ShiftDataAccess());
            SelectedShift = Selected;
            Updatelistboxes();
            Sform = form;
        }
        private void Updatelistboxes()
        {
            LbxAssigned.Items.Clear();

            foreach (var t in employeeManager.GetAllAssignedEmployees(SelectedShift))
            {
                LbxAssigned.Items.Add(t);
            }
            LbxAvailable.Items.Clear();
            foreach (var t in employeeManager.GetallAvailableEmployees(SelectedShift))
            {
                LbxAvailable.Items.Add(t);
            }
        }

        private void BtnAssign_Click_1(object sender, EventArgs e)
        {
            if (LbxAvailable.SelectedItem != null && LbxAvailable.SelectedItem is Employee)
            {
                shiftManager.AssignEmployee(SelectedShift, (Employee)LbxAvailable.SelectedItem);
                Updatelistboxes();
                MessageBox.Show("Employee assigned");
                if (employeeManager.GetAllAssignedEmployees(SelectedShift).Count() > 2)
                {
                    Sform.RefreshInvoke();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to assign");
            }
        }

        private void LbxAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btnunnasign_Click_1(object sender, EventArgs e)
        {
            if (LbxAssigned.SelectedItem != null && LbxAssigned.SelectedItem is Employee)
            {
                shiftManager.UnAssignEmployee(SelectedShift, (Employee)LbxAssigned.SelectedItem);
                Updatelistboxes();
            }
            else
            {
                MessageBox.Show("Please select an employee to unassign");
            }
        }

        private void TbxFilterAvailable_TextChanged_1(object sender, EventArgs e)
        {
            List<Employee> Employees = employeeManager.GetallAvailableEmployees(SelectedShift);
            LbxAvailable.Items.Clear();
            List<Employee> Filtered = Employees.Where(x => (x.FirstName.Trim().ToLower() + " " + x.LastName.Trim().ToLower()).Contains(TbxFilterAvailable.Text.ToLower())).ToList();
            foreach (var t in Filtered)
            {
                LbxAvailable.Items.Add(t);
            }
        }

        private void TbxFilterAssigned_TextChanged_1(object sender, EventArgs e)
        {
            List<Employee> Employees = employeeManager.GetallAvailableEmployees(SelectedShift);
            LbxAvailable.Items.Clear();
            List<Employee> Filtered = Employees.Where(x => (x.FirstName.Trim().ToLower() + " " + x.LastName.Trim().ToLower()).Contains(TbxFilterAssigned.Text.ToLower())).ToList();
            foreach (var t in Filtered)
            {
                LbxAssigned.Items.Add(t);
            }
        }
    }
}
