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
      

        public Employees()
        {
            InitializeComponent();

        }

        
        
        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        { 
        }

        private void btnDeleteEmployee_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cbRoleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Employees_Load(object sender, EventArgs e)
        {
            CheckContractStatus();
        }
        private void CheckContractStatus()
        {
        }


        private void btnCreateEmployee_Click_1(object sender, EventArgs e)
        {
           

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
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {

        }


    }
}
