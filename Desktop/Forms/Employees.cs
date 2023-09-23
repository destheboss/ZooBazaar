using ClassLibrary;
using ClassLibrary.Dataaccess;
using ClassLibrary.Enums;
using ClassLibrary.Managers;
using ClassLibrary.Models;
using DalClassLibrary;
using DalClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZooBazaar.Forms
{
    public partial class Employees : Form
    {
        public EmployeeManager Manager = new EmployeeManager();
        private List<Role> roles = new List<Role>();
        private List<Employee> employees1;
        public ContractManager contractManager = new ContractManager(new ContractDataAccess());
        private bool isContractCreated = false;
        public int SelectedContractId { get; set; }

        public Employees()
        {
            employees1 = Manager.GetAllEmployees();
            InitializeComponent();
            DisplayEmployee();
            lbAccountCreate.Visible = false;
            lbInfo.Visible = true;
            cbRoleSearch.Items.Insert(0, "Select All");
            foreach (Role role in Enum.GetValues(typeof(Role)))
            {
                roles.Add(role);
                cbRoleSearch.Items.Add(role);
            }
            cbRole.DataSource = roles;

            //selectedContractID = contractID;

        }

        private void DisplayEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            dgvEmployee.Rows.Clear();
            dgvEmployee.Columns.Clear();
            List<Employee> employees = employeeManager.GetAllEmployees();

            dgvEmployee.Columns.Add("Id", "id");
            dgvEmployee.Columns.Add("FirstName", "First Name");
            dgvEmployee.Columns.Add("LastName", "Last Name");
            dgvEmployee.Columns.Add("PhoneNumber", "Phone Number");
            dgvEmployee.Columns.Add("Email", "Email");
            dgvEmployee.Columns.Add("Wage", "Wage");
            dgvEmployee.Columns.Add("Bsn", "Bsn");
            dgvEmployee.Columns.Add("BankAccount", "Bank Account");
            dgvEmployee.Columns.Add("Role", "Role");

            foreach (Employee emp in employees)
            {
                int rowIndex = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[rowIndex].Cells["Id"].Value = emp.Id;
                dgvEmployee.Rows[rowIndex].Cells["FirstName"].Value = emp.FirstName;
                dgvEmployee.Rows[rowIndex].Cells["LastName"].Value = emp.LastName;
                dgvEmployee.Rows[rowIndex].Cells["PhoneNumber"].Value = emp.PhoneNumber.ToString();
                dgvEmployee.Rows[rowIndex].Cells["Email"].Value = emp.Email;
                dgvEmployee.Rows[rowIndex].Cells["Wage"].Value = emp.wage.ToString();
                dgvEmployee.Rows[rowIndex].Cells["Bsn"].Value = emp.bsn.ToString();
                dgvEmployee.Rows[rowIndex].Cells["BankAccount"].Value = emp.bankAccount;
                dgvEmployee.Rows[rowIndex].Cells["Role"].Value = emp.role;
            }
        }
        private void Refresh()
        {
            dgvEmployee.Rows.Clear();
            DisplayEmployee();
        }
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to edit.");
                return;
            }

            try
            {
                int employeeId = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["Id"].Value);

                var employee = new Employee(employeeId, tbFirstNameEdit.Text, tbLastNameEdit.Text, Convert.ToInt32(tbPhoneNumberEdit.Text),
                                        tbEmailEdit.Text, Convert.ToInt32(tbWageEdit.Text));

                var employeeManager = new EmployeeManager();
                var result = employeeManager.UpdateEmployee(employee);

                if (!result)
                {
                    MessageBox.Show("Failed to update employee information.");
                }
                else {
                    MessageBox.Show("The Employee Has Been Updated");
                    Refresh();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid data.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];

                tbFirstNameEdit.Text = selectedRow.Cells["FirstName"].Value.ToString();
                tbLastNameEdit.Text = selectedRow.Cells["LastName"].Value.ToString();
                tbPhoneNumberEdit.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                tbEmailEdit.Text = selectedRow.Cells["Email"].Value.ToString();
                tbWageEdit.Text = selectedRow.Cells["Wage"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

        private void btnDeleteEmployee_Click_1(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployee.SelectedRows[0];
                int employeeId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string employeeName = Convert.ToString(selectedRow.Cells["FirstName"].Value);

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to remove employee with Name: {employeeName}?", "Confirm Deletion",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool result2 = Manager.DeleteEmployeeShift(employeeId);
                    bool result = Manager.DeleteEmployee(employeeId);

                    if (result2)
                    {
                        if (result)
                        {
                            MessageBox.Show("Employee removed successfully.");
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Failed to remove employee.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There was a problem");
                    }
                }
            }
            Refresh();
        }

        private void cbRoleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoleSearch.SelectedIndex == -1) return;

            dgvEmployee.Rows.Clear();
            foreach (Employee employee in employees1.Where(emp => cbRoleSearch.SelectedIndex == 0 || emp.role == (Role)(cbRoleSearch.SelectedIndex - 1)))
            {
                int rowIndex = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[rowIndex].Cells["Id"].Value = employee.Id;
                dgvEmployee.Rows[rowIndex].Cells["FirstName"].Value = employee.FirstName;
                dgvEmployee.Rows[rowIndex].Cells["LastName"].Value = employee.LastName;
                dgvEmployee.Rows[rowIndex].Cells["PhoneNumber"].Value = employee.PhoneNumber.ToString();
                dgvEmployee.Rows[rowIndex].Cells["Email"].Value = employee.Email;
                dgvEmployee.Rows[rowIndex].Cells["Wage"].Value = employee.wage.ToString();
                dgvEmployee.Rows[rowIndex].Cells["Bsn"].Value = employee.bsn.ToString();
                dgvEmployee.Rows[rowIndex].Cells["BankAccount"].Value = employee.bankAccount;
                dgvEmployee.Rows[rowIndex].Cells["Role"].Value = employee.role;

            }
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            CheckContractStatus();
        }
        private void CheckContractStatus()
        {
            if (isContractCreated)
            {
                btnCreateEmployee.Enabled = true;
            }
            else
            {
                btnCreateEmployee.Enabled = false;
            }
        }

        public void HandleContractCreation()
        {
            isContractCreated = true;
            CheckContractStatus();
        }

        private void btnCreateEmployee_Click_1(object sender, EventArgs e)
        {
            try
            {
                Role role = (Role)cbRole.SelectedItem;
                if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) ||
                    string.IsNullOrEmpty(nudPhoneNumber.Text) || string.IsNullOrEmpty(tbEmail.Text) ||
                    string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(nudBSN.Text) ||
                    string.IsNullOrEmpty(tbBankAccount.Text) || string.IsNullOrEmpty(nudWage.Text) ||
                    string.IsNullOrEmpty(tbCity.Text) || string.IsNullOrEmpty(tbStreet.Text) ||
                    string.IsNullOrEmpty(nudHouseNumber.Text) || string.IsNullOrEmpty(tbZipCode.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }
                else
                {
                    //var contractId = contractManager.GetLastAssignedContractId();
                    Employee Save = new Employee(0, tbFirstName.Text, tbLastName.Text, Convert.ToInt32(nudPhoneNumber.Text), tbEmail.Text,
                         tbPassword.Text, Convert.ToInt32(nudBSN.Value), tbBankAccount.Text, Convert.ToInt32(nudWage.Value), role, tbCity.Text,
                         tbStreet.Text, Convert.ToInt32(nudHouseNumber.Value), tbZipCode.Text, SelectedContractId);
                    if (isContractCreated)
                    {
                        lbInfo.Visible = false;
                        bool employeeCreated = Manager.CreateEmployee(Save);
                        if (employeeCreated)
                        {
                            lbAccountCreate.Visible = true;

                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            timer.Interval = 5000;
                            timer.Tick += (sender, e) =>
                            {
                                lbAccountCreate.Visible = false;
                                timer.Stop();
                                timer.Dispose();
                            };
                            timer.Start();

                            tbFirstName.Clear();
                            tbLastName.Clear();
                            tbEmail.Clear();
                            tbPassword.Clear();
                            tbZipCode.Clear();
                            tbCity.Clear();
                            tbStreet.Clear();
                            tbBankAccount.Clear();
                            isContractCreated = false;

                            CheckContractStatus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contract must be created first.");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Check All Empty Places");
            }

        }
        private void RefreshPage()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmail.Clear();
            tbPassword.Clear();
            tbZipCode.Clear();
            tbCity.Clear();
            tbStreet.Clear();
            tbBankAccount.Clear();
            CheckContractStatus();
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            dgvEmployee.Rows.Clear();
            List<Employee> FilteredEmployees = employees1.Where(X => (X.FirstName.Trim().ToLower() + " " + X.LastName.Trim().ToLower()).Contains(tbSearchName.Text.Trim().ToLower())).ToList();
            foreach (Employee emp in FilteredEmployees)
            {
                int rowIndex = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[rowIndex].Cells["Id"].Value = emp.Id;
                dgvEmployee.Rows[rowIndex].Cells["FirstName"].Value = emp.FirstName;
                dgvEmployee.Rows[rowIndex].Cells["LastName"].Value = emp.LastName;
                dgvEmployee.Rows[rowIndex].Cells["PhoneNumber"].Value = emp.PhoneNumber.ToString();
                dgvEmployee.Rows[rowIndex].Cells["Email"].Value = emp.Email;
                dgvEmployee.Rows[rowIndex].Cells["Wage"].Value = emp.wage.ToString();
                dgvEmployee.Rows[rowIndex].Cells["Bsn"].Value = emp.bsn.ToString();
                dgvEmployee.Rows[rowIndex].Cells["BankAccount"].Value = emp.bankAccount;
                dgvEmployee.Rows[rowIndex].Cells["Role"].Value = emp.role;
            }
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            var ContractPage = new ContractPage(true);

            this.Hide();
            ContractPage.ShowDialog();
            this.Show();

        }


    }
}
