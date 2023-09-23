using ClassLibrary;
using ClassLibrary.Dataaccess;
using ClassLibrary.Managers;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClassLibrary.Models;

namespace ZooBazaar.Forms
{
    public partial class LogIn : Form
    {
        private Action<Employee> closeForm;
        private EmployeeManager manager;
        public LogIn(Action<Employee> closeForm)
        {
            manager = new EmployeeManager();
            this.closeForm = closeForm;
            InitializeComponent();
            CenterLogInPanel();
        }

        private void ValidateUser()
        {
            if (manager.CheckLogIn(tbEmail.Text, tbPassword.Text, out int id))
            {
                closeForm(manager.GetEmployeeById(id)!);
                manager.SetSetting("loggedAs", id);
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }

        private void CenterLogInPanel()
        {
            loginPanel.Left = (this.ClientSize.Width - loginPanel.Width) / 2;
            loginPanel.Top = (this.ClientSize.Height - loginPanel.Height) / 2;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
    }
}
