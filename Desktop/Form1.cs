using BLL.Managers;
using BLL.Models;
using DAL;

namespace Desktop
{
    public partial class Form1 : Form
    {
        private UserManager userManager;
        private Employee? employee = null;
        private Form? activeForm;
        private Button? activeButton = null;
        public Form1()
        {
            userManager = new UserManager(new UserDataAccess());
            InitializeComponent();

            int? userId = (int?)userManager.GetSetting("loggedAs");
            if (userId == null)
            {
                OpenLogIn();
            }
            else
            {
                employee = userManager.GetEmployeeById((int)userId);
                if (employee == null)
                {
                    OpenLogIn();
                }
                else
                {
                    OpenChildForm(new Forms.EmployeeManagement(employee));
                    UpdateUserPrivilages();
                }

            }
        }
        private void OpenLogIn()
        {
            void CloseLogIn(Employee employee)
            {
                panelMenu.Visible = true;
                OpenChildForm(new Forms.EmployeeManagement(employee));
                this.employee = employee;
                UpdateUserPrivilages();
            }
            panelMenu.Visible = false;
            OpenChildForm(new Forms.LogIn(CloseLogIn));
        }
        private void UpdateUserPrivilages()
        {
            if (employee.Role == Role.Admin)
            {
                btnEmployees.Visible = true;
            }
            else
            {
                btnEmployees.Visible = false;
            }
        }
        private void ChangeButtonColor(Button pressedButton)
        {
            Color defaultBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            if (activeButton != null) activeButton.BackColor = defaultBtnColor;

            pressedButton.BackColor = Color.FromArgb(defaultBtnColor.A, defaultBtnColor.R + 57, defaultBtnColor.G + 57, defaultBtnColor.B + 57);
            activeButton = pressedButton;
        }

        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        { 
            OpenChildForm(new Forms.EmployeeManagement(employee));
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AnimalManagement());
        }
    }
}