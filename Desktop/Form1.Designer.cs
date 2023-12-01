namespace Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelDesktopPane = new Panel();
            panelMenu = new Panel();
            btnEmployeeShifts = new Button();
            btnLocationAndType = new Button();
            btnLogOut = new Button();
            btnAnimals = new Button();
            btnEmployees = new Button();
            panelLogo = new Panel();
            btnHome = new Button();
            btnAnimalShift = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelDesktopPane.Location = new Point(216, 0);
            panelDesktopPane.Margin = new Padding(3, 2, 3, 2);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(584, 450);
            panelDesktopPane.TabIndex = 5;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 70, 0);
            panelMenu.Controls.Add(btnAnimalShift);
            panelMenu.Controls.Add(btnEmployeeShifts);
            panelMenu.Controls.Add(btnLocationAndType);
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnAnimals);
            panelMenu.Controls.Add(btnEmployees);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(216, 450);
            panelMenu.TabIndex = 6;
            // 
            // btnEmployeeShifts
            // 
            btnEmployeeShifts.BackColor = Color.FromArgb(0, 70, 0);
            btnEmployeeShifts.Cursor = Cursors.Hand;
            btnEmployeeShifts.Dock = DockStyle.Top;
            btnEmployeeShifts.FlatAppearance.BorderSize = 0;
            btnEmployeeShifts.FlatStyle = FlatStyle.Flat;
            btnEmployeeShifts.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployeeShifts.ForeColor = Color.White;
            btnEmployeeShifts.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployeeShifts.Location = new Point(0, 221);
            btnEmployeeShifts.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeShifts.Name = "btnEmployeeShifts";
            btnEmployeeShifts.Padding = new Padding(10, 0, 0, 0);
            btnEmployeeShifts.Size = new Size(216, 45);
            btnEmployeeShifts.TabIndex = 9;
            btnEmployeeShifts.Text = "Employee Shifts";
            btnEmployeeShifts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployeeShifts.UseVisualStyleBackColor = false;
            btnEmployeeShifts.Click += btnEmployeeShifts_Click;
            // 
            // btnLocationAndType
            // 
            btnLocationAndType.BackColor = Color.FromArgb(0, 70, 0);
            btnLocationAndType.Cursor = Cursors.Hand;
            btnLocationAndType.Dock = DockStyle.Top;
            btnLocationAndType.FlatAppearance.BorderSize = 0;
            btnLocationAndType.FlatStyle = FlatStyle.Flat;
            btnLocationAndType.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLocationAndType.ForeColor = Color.White;
            btnLocationAndType.ImageAlign = ContentAlignment.MiddleLeft;
            btnLocationAndType.Location = new Point(0, 176);
            btnLocationAndType.Margin = new Padding(3, 2, 3, 2);
            btnLocationAndType.Name = "btnLocationAndType";
            btnLocationAndType.Padding = new Padding(10, 0, 0, 0);
            btnLocationAndType.Size = new Size(216, 45);
            btnLocationAndType.TabIndex = 8;
            btnLocationAndType.Text = "Location And Animal Type";
            btnLocationAndType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLocationAndType.UseVisualStyleBackColor = false;
            btnLocationAndType.Click += btnLocationAndType_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 403);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(10, 0, 0, 0);
            btnLogOut.Size = new Size(216, 47);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnAnimals
            // 
            btnAnimals.BackColor = Color.FromArgb(0, 70, 0);
            btnAnimals.Cursor = Cursors.Hand;
            btnAnimals.Dock = DockStyle.Top;
            btnAnimals.FlatAppearance.BorderSize = 0;
            btnAnimals.FlatStyle = FlatStyle.Flat;
            btnAnimals.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnimals.ForeColor = Color.White;
            btnAnimals.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnimals.Location = new Point(0, 131);
            btnAnimals.Margin = new Padding(3, 2, 3, 2);
            btnAnimals.Name = "btnAnimals";
            btnAnimals.Padding = new Padding(10, 0, 0, 0);
            btnAnimals.Size = new Size(216, 45);
            btnAnimals.TabIndex = 2;
            btnAnimals.Text = "Animals";
            btnAnimals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnimals.UseVisualStyleBackColor = false;
            btnAnimals.Click += btnAnimals_Click_1;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(0, 70, 0);
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 86);
            btnEmployees.Margin = new Padding(3, 2, 3, 2);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(10, 0, 0, 0);
            btnEmployees.Size = new Size(216, 45);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "Employees";
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.InfoText;
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(216, 86);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(1, 32, 15);
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Sitka Small", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(216, 86);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnAnimalShift
            // 
            btnAnimalShift.BackColor = Color.FromArgb(0, 70, 0);
            btnAnimalShift.Cursor = Cursors.Hand;
            btnAnimalShift.Dock = DockStyle.Top;
            btnAnimalShift.FlatAppearance.BorderSize = 0;
            btnAnimalShift.FlatStyle = FlatStyle.Flat;
            btnAnimalShift.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAnimalShift.ForeColor = Color.White;
            btnAnimalShift.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnimalShift.Location = new Point(0, 266);
            btnAnimalShift.Margin = new Padding(3, 2, 3, 2);
            btnAnimalShift.Name = "btnAnimalShift";
            btnAnimalShift.Padding = new Padding(10, 0, 0, 0);
            btnAnimalShift.Size = new Size(216, 45);
            btnAnimalShift.TabIndex = 10;
            btnAnimalShift.Text = "Animal Shift Overview";
            btnAnimalShift.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnimalShift.UseVisualStyleBackColor = false;
            btnAnimalShift.Click += btnAnimalShift_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDesktopPane;
        private Panel panelMenu;
        private Button btnLogOut;
        private Button btnAnimals;
        private Button btnEmployees;
        private Panel panelLogo;
        private Button btnHome;
        private Button btnLocationAndType;
        private Button btnEmployeeShifts;
        private Button btnAnimalShift;
    }
}