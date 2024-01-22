using BLL.Managers;
using BLL.Models;
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
    public partial class ContractPage : Form
    {
        ContractManager contractManager;
        List<Contract> contracts;
        private bool openedEmployees;
        public ContractPage(bool openedEmployees)
        {
            InitializeComponent();
            contractManager = new ContractManager(new ContractDataAccess());
            contracts = contractManager.GetContracts();
            this.openedEmployees = openedEmployees;
        }

        private void btnAddContractToEmployee_Click(object sender, EventArgs e)
        {
            if (lbContracts.SelectedItem == null)
            {
                MessageBox.Show("Please select a contract.");
                return;
            }

            int selectedContractId = GetSelectedContractIdFromListBox();



            EmployeeManagement employeeForm = (EmployeeManagement)Application.OpenForms["EmployeeManagement"];
            employeeForm.HandleContractCreation();
            employeeForm.SelectedContractId = selectedContractId;
            employeeForm.Show();
            Refresh();
            MessageBox.Show("Success !", "Success", MessageBoxButtons.OK);
            this.DialogResult = DialogResult.OK;
        }
        private void ContractPage_Load(object sender, EventArgs e)
        {
            Refresh();
            if (openedEmployees)
            {
                btnAddContractToEmployee.Visible = true;
                btnAddContract.Visible = false;
            }
            else
            {
                btnAddContractToEmployee.Visible = false;
                btnAddContract.Visible = true;
            }
        }
        private void lbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract contract = contracts[lbContracts.SelectedIndex];

            tb_name.Text = contract.ContractName;
            numericUpDown_length.Value = contract.Length;
            numericUpDown_amountofhours.Value = contract.AmountOfHours;
        }
        private int GetSelectedContractIdFromListBox()
        {
            Contract selectedContract = (Contract)lbContracts.SelectedItem;
            if (selectedContract != null)
            {
                int selectedContractId = selectedContract.ContractId;
                return selectedContractId;
            }

            return 0;
        }
        private void btnAddContract_Click(object sender, EventArgs e)
        {
            string contractName = tb_name.Text;
            int length = Convert.ToInt32(numericUpDown_length.Value);
            int amountofhours = Convert.ToInt32(numericUpDown_amountofhours.Value);

            if (string.IsNullOrEmpty(contractName) || length == null || amountofhours == null)
            {
                MessageBox.Show("please fill in all the fields");
            }
            else
            {
                bool result = contractManager.CreateContract(0, contractName, length, amountofhours);
                if (result)
                {

                    Refresh();
                    MessageBox.Show("Success !", "Success");
                }
                else
                {
                    MessageBox.Show("fail !");
                }
            }
        }
        private void btDeleteContract_Click(object sender, EventArgs e)
        {
            if (lbContracts.SelectedIndex != -1)
            {
                int index = lbContracts.SelectedIndex;
                bool result = contractManager.DeleteContract(contracts[index].ContractId);
                if (result)
                {
                    MessageBox.Show("Success !");
                }
                else
                {
                    MessageBox.Show("Error !");
                }
            }
            else
            {
                MessageBox.Show("Please select a contract first !");
            }
            Refresh();
        }
        private void Refresh()
        {
            lbContracts.Items.Clear();
            tb_name.Clear();
            numericUpDown_amountofhours.ResetText();
            numericUpDown_length.ResetText();
            List<Contract> contracts1 = contractManager.GetContracts();

            foreach (Contract contract in contracts1)
            {
                lbContracts.Items.Add(contract);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
