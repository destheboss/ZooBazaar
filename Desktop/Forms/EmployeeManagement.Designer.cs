namespace Desktop.Forms
{
    partial class EmployeeManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel123 = new Panel();
            btnAddProfile = new Button();
            label14 = new Label();
            label13 = new Label();
            tbID = new TextBox();
            tbPass = new TextBox();
            dgvEmployee = new DataGridView();
            panel4 = new Panel();
            cbRoleSearch = new ComboBox();
            label8 = new Label();
            tbSearchName = new TextBox();
            panel3 = new Panel();
            btnDeleteEmployee = new Button();
            label7 = new Label();
            tbEmailEdit = new TextBox();
            buttonEdit = new Button();
            label2 = new Label();
            btnSaveInfo = new Button();
            tbWageEdit = new TextBox();
            label5 = new Label();
            tbFirstNameEdit = new TextBox();
            label4 = new Label();
            tbPhoneNumberEdit = new TextBox();
            label3 = new Label();
            tbLastNameEdit = new TextBox();
            tabPage2 = new TabPage();
            lbInfo = new Label();
            lbAccountCreate = new Label();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            nudPhoneNumber = new NumericUpDown();
            btnAddContract = new Button();
            nudHouseNumber = new NumericUpDown();
            nudWage = new NumericUpDown();
            nudBSN = new NumericUpDown();
            tbFirstName = new TextBox();
            tbPassword = new TextBox();
            tbZipCode = new TextBox();
            tbEmail = new TextBox();
            tbStreet = new TextBox();
            tbLastName = new TextBox();
            tbCity = new TextBox();
            label1 = new Label();
            cbRole = new ComboBox();
            panel2 = new Panel();
            label6 = new Label();
            btnCreateEmployee = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel123.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPhoneNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHouseNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBSN).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1629, 941);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(252, 234, 222);
            tabPage1.Controls.Add(panel123);
            tabPage1.Controls.Add(dgvEmployee);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1269, 908);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Information";
            // 
            // panel123
            // 
            panel123.BackColor = Color.FromArgb(0, 70, 0);
            panel123.Controls.Add(btnAddProfile);
            panel123.Controls.Add(label14);
            panel123.Controls.Add(label13);
            panel123.Controls.Add(tbID);
            panel123.Controls.Add(tbPass);
            panel123.Location = new Point(13, 656);
            panel123.Name = "panel123";
            panel123.Size = new Size(288, 203);
            panel123.TabIndex = 15;
            // 
            // btnAddProfile
            // 
            btnAddProfile.FlatStyle = FlatStyle.Flat;
            btnAddProfile.ForeColor = Color.White;
            btnAddProfile.Location = new Point(17, 128);
            btnAddProfile.Margin = new Padding(3, 2, 3, 2);
            btnAddProfile.Name = "btnAddProfile";
            btnAddProfile.Size = new Size(255, 44);
            btnAddProfile.TabIndex = 18;
            btnAddProfile.Text = "Add Web Profile";
            btnAddProfile.UseVisualStyleBackColor = true;
            btnAddProfile.Click += btnAddProfile_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(17, 14);
            label14.Name = "label14";
            label14.Size = new Size(27, 20);
            label14.TabIndex = 17;
            label14.Text = "ID:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(17, 65);
            label13.Name = "label13";
            label13.Size = new Size(73, 20);
            label13.TabIndex = 16;
            label13.Text = "Password:";
            // 
            // tbID
            // 
            tbID.Location = new Point(17, 36);
            tbID.Margin = new Padding(3, 2, 3, 2);
            tbID.Name = "tbID";
            tbID.Size = new Size(255, 27);
            tbID.TabIndex = 15;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(17, 87);
            tbPass.Margin = new Padding(3, 2, 3, 2);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(255, 27);
            tbPass.TabIndex = 14;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(336, 16);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowTemplate.Height = 25;
            dgvEmployee.Size = new Size(1307, 843);
            dgvEmployee.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 70, 0);
            panel4.Controls.Add(cbRoleSearch);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(tbSearchName);
            panel4.Location = new Point(13, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(288, 155);
            panel4.TabIndex = 13;
            // 
            // cbRoleSearch
            // 
            cbRoleSearch.FormattingEnabled = true;
            cbRoleSearch.Location = new Point(17, 103);
            cbRoleSearch.Name = "cbRoleSearch";
            cbRoleSearch.Size = new Size(255, 28);
            cbRoleSearch.TabIndex = 16;
            cbRoleSearch.SelectedIndexChanged += cbRoleSearch_SelectedIndexChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 37);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 15;
            label8.Text = "Search by name:";
            // 
            // tbSearchName
            // 
            tbSearchName.Location = new Point(17, 60);
            tbSearchName.Name = "tbSearchName";
            tbSearchName.Size = new Size(255, 27);
            tbSearchName.TabIndex = 0;
            tbSearchName.TextChanged += tbSearchName_TextChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 70, 0);
            panel3.Controls.Add(btnDeleteEmployee);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(tbEmailEdit);
            panel3.Controls.Add(buttonEdit);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnSaveInfo);
            panel3.Controls.Add(tbWageEdit);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(tbFirstNameEdit);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbPhoneNumberEdit);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(tbLastNameEdit);
            panel3.Location = new Point(13, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 456);
            panel3.TabIndex = 12;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.ForeColor = Color.White;
            btnDeleteEmployee.Location = new Point(17, 398);
            btnDeleteEmployee.Margin = new Padding(3, 2, 3, 2);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(255, 46);
            btnDeleteEmployee.TabIndex = 15;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(17, 216);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 14;
            label7.Text = "Email:";
            // 
            // tbEmailEdit
            // 
            tbEmailEdit.Location = new Point(17, 238);
            tbEmailEdit.Margin = new Padding(3, 2, 3, 2);
            tbEmailEdit.Name = "tbEmailEdit";
            tbEmailEdit.Size = new Size(255, 27);
            tbEmailEdit.TabIndex = 13;
            // 
            // buttonEdit
            // 
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(17, 281);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(255, 44);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Edit Info";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.FlatStyle = FlatStyle.Flat;
            btnSaveInfo.ForeColor = Color.White;
            btnSaveInfo.Location = new Point(17, 339);
            btnSaveInfo.Margin = new Padding(3, 2, 3, 2);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(255, 44);
            btnSaveInfo.TabIndex = 3;
            btnSaveInfo.Text = "Save Info";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click_1;
            // 
            // tbWageEdit
            // 
            tbWageEdit.Location = new Point(17, 187);
            tbWageEdit.Margin = new Padding(3, 2, 3, 2);
            tbWageEdit.Name = "tbWageEdit";
            tbWageEdit.Size = new Size(255, 27);
            tbWageEdit.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 165);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "Wage:";
            // 
            // tbFirstNameEdit
            // 
            tbFirstNameEdit.Location = new Point(17, 34);
            tbFirstNameEdit.Margin = new Padding(3, 2, 3, 2);
            tbFirstNameEdit.Name = "tbFirstNameEdit";
            tbFirstNameEdit.Size = new Size(255, 27);
            tbFirstNameEdit.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 114);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 10;
            label4.Text = "Phone number: ";
            // 
            // tbPhoneNumberEdit
            // 
            tbPhoneNumberEdit.Location = new Point(17, 136);
            tbPhoneNumberEdit.Margin = new Padding(3, 2, 3, 2);
            tbPhoneNumberEdit.Name = "tbPhoneNumberEdit";
            tbPhoneNumberEdit.Size = new Size(255, 27);
            tbPhoneNumberEdit.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 63);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 9;
            label3.Text = "Last Name";
            // 
            // tbLastNameEdit
            // 
            tbLastNameEdit.Location = new Point(17, 85);
            tbLastNameEdit.Margin = new Padding(3, 2, 3, 2);
            tbLastNameEdit.Name = "tbLastNameEdit";
            tbLastNameEdit.Size = new Size(255, 27);
            tbLastNameEdit.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(252, 234, 222);
            tabPage2.Controls.Add(lbInfo);
            tabPage2.Controls.Add(lbAccountCreate);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(btnCreateEmployee);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1621, 908);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Create Employees";
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(691, 588);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(276, 20);
            lbInfo.TabIndex = 31;
            lbInfo.Text = "First Create a Contract for the Employee.";
            // 
            // lbAccountCreate
            // 
            lbAccountCreate.AutoSize = true;
            lbAccountCreate.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lbAccountCreate.Location = new Point(502, 688);
            lbAccountCreate.Name = "lbAccountCreate";
            lbAccountCreate.Size = new Size(659, 54);
            lbAccountCreate.TabIndex = 30;
            lbAccountCreate.Text = "The Account Has Just Been Created!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(nudPhoneNumber);
            panel1.Controls.Add(btnAddContract);
            panel1.Controls.Add(nudHouseNumber);
            panel1.Controls.Add(nudWage);
            panel1.Controls.Add(nudBSN);
            panel1.Controls.Add(tbFirstName);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbZipCode);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(tbStreet);
            panel1.Controls.Add(tbLastName);
            panel1.Controls.Add(tbCity);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbRole);
            panel1.Location = new Point(399, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 240);
            panel1.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(565, 83);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 27;
            label12.Text = "House Number: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(304, 83);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 26;
            label11.Text = "Wage: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(304, 2);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 25;
            label10.Text = "BSN:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(43, 83);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 24;
            label9.Text = "Phone Number: ";
            // 
            // nudPhoneNumber
            // 
            nudPhoneNumber.Location = new Point(43, 101);
            nudPhoneNumber.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            nudPhoneNumber.Name = "nudPhoneNumber";
            nudPhoneNumber.Size = new Size(255, 27);
            nudPhoneNumber.TabIndex = 23;
            // 
            // btnAddContract
            // 
            btnAddContract.Location = new Point(440, 183);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(259, 28);
            btnAddContract.TabIndex = 22;
            btnAddContract.Text = "Add Contract";
            btnAddContract.UseVisualStyleBackColor = true;
            btnAddContract.Click += btnAddContract_Click;
            // 
            // nudHouseNumber
            // 
            nudHouseNumber.Location = new Point(565, 101);
            nudHouseNumber.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            nudHouseNumber.Name = "nudHouseNumber";
            nudHouseNumber.Size = new Size(255, 27);
            nudHouseNumber.TabIndex = 21;
            // 
            // nudWage
            // 
            nudWage.Location = new Point(304, 101);
            nudWage.Maximum = new decimal(new int[] { 1419065408, 2, 0, 0 });
            nudWage.Name = "nudWage";
            nudWage.Size = new Size(254, 27);
            nudWage.TabIndex = 20;
            // 
            // nudBSN
            // 
            nudBSN.Location = new Point(304, 20);
            nudBSN.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            nudBSN.Name = "nudBSN";
            nudBSN.Size = new Size(254, 27);
            nudBSN.TabIndex = 19;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstName.Location = new Point(43, 20);
            tbFirstName.Margin = new Padding(3, 2, 3, 2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.PlaceholderText = "First Name";
            tbFirstName.Size = new Size(255, 24);
            tbFirstName.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(304, 141);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(255, 24);
            tbPassword.TabIndex = 18;
            // 
            // tbZipCode
            // 
            tbZipCode.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbZipCode.Location = new Point(565, 141);
            tbZipCode.Margin = new Padding(3, 2, 3, 2);
            tbZipCode.Name = "tbZipCode";
            tbZipCode.PlaceholderText = "ZipCode";
            tbZipCode.Size = new Size(255, 24);
            tbZipCode.TabIndex = 9;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(43, 141);
            tbEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(255, 24);
            tbEmail.TabIndex = 17;
            // 
            // tbStreet
            // 
            tbStreet.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbStreet.Location = new Point(565, 59);
            tbStreet.Margin = new Padding(3, 2, 3, 2);
            tbStreet.Name = "tbStreet";
            tbStreet.PlaceholderText = "Street";
            tbStreet.Size = new Size(255, 24);
            tbStreet.TabIndex = 7;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbLastName.Location = new Point(43, 59);
            tbLastName.Margin = new Padding(3, 2, 3, 2);
            tbLastName.Name = "tbLastName";
            tbLastName.PlaceholderText = "Last Name";
            tbLastName.Size = new Size(255, 24);
            tbLastName.TabIndex = 1;
            // 
            // tbCity
            // 
            tbCity.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCity.Location = new Point(565, 20);
            tbCity.Margin = new Padding(3, 2, 3, 2);
            tbCity.Name = "tbCity";
            tbCity.PlaceholderText = "City";
            tbCity.Size = new Size(255, 24);
            tbCity.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 18);
            label1.TabIndex = 16;
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(150, 183);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(255, 28);
            cbRole.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(1, 32, 15);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(399, 195);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(857, 83);
            panel2.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(236, 0);
            label6.Name = "label6";
            label6.Size = new Size(384, 65);
            label6.TabIndex = 0;
            label6.Text = "Create Employee";
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.FromArgb(1, 32, 15);
            btnCreateEmployee.FlatAppearance.BorderSize = 0;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.ForeColor = Color.White;
            btnCreateEmployee.Location = new Point(660, 528);
            btnCreateEmployee.Margin = new Padding(3, 2, 3, 2);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(345, 54);
            btnCreateEmployee.TabIndex = 12;
            btnCreateEmployee.Text = "Create";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click_1;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1629, 941);
            Controls.Add(tabControl1);
            Name = "EmployeeManagement";
            Text = "EmployeeManagement";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel123.ResumeLayout(false);
            panel123.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPhoneNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHouseNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWage).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBSN).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvEmployee;
        private Panel panel4;
        private ComboBox cbRoleSearch;
        private Label label8;
        private TextBox tbSearchName;
        private Panel panel3;
        private Button btnDeleteEmployee;
        private Label label7;
        private TextBox tbEmailEdit;
        private Button buttonEdit;
        private Label label2;
        private Button btnSaveInfo;
        private TextBox tbWageEdit;
        private Label label5;
        private TextBox tbFirstNameEdit;
        private Label label4;
        private TextBox tbPhoneNumberEdit;
        private Label label3;
        private TextBox tbLastNameEdit;
        private TabPage tabPage2;
        private Label lbInfo;
        private Label lbAccountCreate;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private NumericUpDown nudPhoneNumber;
        private Button btnAddContract;
        private NumericUpDown nudHouseNumber;
        private NumericUpDown nudWage;
        private NumericUpDown nudBSN;
        private TextBox tbFirstName;
        private TextBox tbPassword;
        private TextBox tbZipCode;
        private TextBox tbEmail;
        private TextBox tbStreet;
        private TextBox tbLastName;
        private TextBox tbCity;
        private Label label1;
        private ComboBox cbRole;
        private Panel panel2;
        private Label label6;
        private Button btnCreateEmployee;
        private Panel panel123;
        private Button btnAddProfile;
        private Label label14;
        private Label label13;
        private TextBox tbID;
        private TextBox tbPass;
    }
}