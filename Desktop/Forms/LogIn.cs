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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms
{
    public partial class LogIn : Form
    {
        private Action<Employee> closeForm;
        private UserManager userManager;

        public LogIn(Action<Employee> closeForm)
        {
            userManager = new UserManager(new UserDataAccess());
            this.closeForm = closeForm;
            InitializeComponent();
            CenterLogInPanel();

        }

        private void ValidateUser()
        {
            if (userManager.CheckLogIn(tbEmail.Text, tbPassword.Text, out int id))
            {
                closeForm(userManager.GetEmployeeById(id)!);
                userManager.SetSetting("loggedAs", id);
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
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ValidateUser();

        }
    }

}
