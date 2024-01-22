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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel123 = new System.Windows.Forms.Panel();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbRoleSearch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmailEdit = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.tbWageEdit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirstNameEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastNameEdit = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbAccountCreate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudPhoneNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.nudHouseNumber = new System.Windows.Forms.NumericUpDown();
            this.nudWage = new System.Windows.Forms.NumericUpDown();
            this.nudBSN = new System.Windows.Forms.NumericUpDown();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel123.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBSN)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1277, 941);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(234)))), ((int)(((byte)(222)))));
            this.tabPage1.Controls.Add(this.panel123);
            this.tabPage1.Controls.Add(this.dgvEmployee);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1269, 908);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // panel123
            // 
            this.panel123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel123.Controls.Add(this.btnAddProfile);
            this.panel123.Controls.Add(this.label14);
            this.panel123.Controls.Add(this.label13);
            this.panel123.Controls.Add(this.tbID);
            this.panel123.Controls.Add(this.tbPass);
            this.panel123.Location = new System.Drawing.Point(13, 656);
            this.panel123.Name = "panel123";
            this.panel123.Size = new System.Drawing.Size(288, 203);
            this.panel123.TabIndex = 15;
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProfile.ForeColor = System.Drawing.Color.White;
            this.btnAddProfile.Location = new System.Drawing.Point(17, 128);
            this.btnAddProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(255, 44);
            this.btnAddProfile.TabIndex = 18;
            this.btnAddProfile.Text = "Add Web Profile";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(17, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(17, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Password:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(17, 36);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(255, 27);
            this.tbID.TabIndex = 15;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(17, 87);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(255, 27);
            this.tbPass.TabIndex = 14;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(336, 16);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(1307, 843);
            this.dgvEmployee.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.cbRoleSearch);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.tbSearchName);
            this.panel4.Location = new System.Drawing.Point(13, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 155);
            this.panel4.TabIndex = 13;
            // 
            // cbRoleSearch
            // 
            this.cbRoleSearch.FormattingEnabled = true;
            this.cbRoleSearch.Location = new System.Drawing.Point(17, 103);
            this.cbRoleSearch.Name = "cbRoleSearch";
            this.cbRoleSearch.Size = new System.Drawing.Size(255, 28);
            this.cbRoleSearch.TabIndex = 16;
            this.cbRoleSearch.SelectedIndexChanged += new System.EventHandler(this.cbRoleSearch_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Search by name:";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(17, 60);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(255, 27);
            this.tbSearchName.TabIndex = 0;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnDeleteEmployee);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbEmailEdit);
            this.panel3.Controls.Add(this.buttonEdit);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSaveInfo);
            this.panel3.Controls.Add(this.tbWageEdit);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbFirstNameEdit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tbPhoneNumberEdit);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbLastNameEdit);
            this.panel3.Location = new System.Drawing.Point(13, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 456);
            this.panel3.TabIndex = 12;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(17, 398);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(255, 46);
            this.btnDeleteEmployee.TabIndex = 15;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Email:";
            // 
            // tbEmailEdit
            // 
            this.tbEmailEdit.Location = new System.Drawing.Point(17, 238);
            this.tbEmailEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmailEdit.Name = "tbEmailEdit";
            this.tbEmailEdit.Size = new System.Drawing.Size(255, 27);
            this.tbEmailEdit.TabIndex = 13;
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(17, 281);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(255, 44);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit Info";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name:";
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Location = new System.Drawing.Point(17, 339);
            this.btnSaveInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(255, 44);
            this.btnSaveInfo.TabIndex = 3;
            this.btnSaveInfo.Text = "Save Info";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click_1);
            // 
            // tbWageEdit
            // 
            this.tbWageEdit.Location = new System.Drawing.Point(17, 187);
            this.tbWageEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWageEdit.Name = "tbWageEdit";
            this.tbWageEdit.Size = new System.Drawing.Size(255, 27);
            this.tbWageEdit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wage:";
            // 
            // tbFirstNameEdit
            // 
            this.tbFirstNameEdit.Location = new System.Drawing.Point(17, 34);
            this.tbFirstNameEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstNameEdit.Name = "tbFirstNameEdit";
            this.tbFirstNameEdit.Size = new System.Drawing.Size(255, 27);
            this.tbFirstNameEdit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone number: ";
            // 
            // tbPhoneNumberEdit
            // 
            this.tbPhoneNumberEdit.Location = new System.Drawing.Point(17, 136);
            this.tbPhoneNumberEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhoneNumberEdit.Name = "tbPhoneNumberEdit";
            this.tbPhoneNumberEdit.Size = new System.Drawing.Size(255, 27);
            this.tbPhoneNumberEdit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // tbLastNameEdit
            // 
            this.tbLastNameEdit.Location = new System.Drawing.Point(17, 85);
            this.tbLastNameEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastNameEdit.Name = "tbLastNameEdit";
            this.tbLastNameEdit.Size = new System.Drawing.Size(255, 27);
            this.tbLastNameEdit.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(234)))), ((int)(((byte)(222)))));
            this.tabPage2.Controls.Add(this.lbInfo);
            this.tabPage2.Controls.Add(this.lbAccountCreate);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btnCreateEmployee);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1269, 908);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Employees";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(691, 588);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(276, 20);
            this.lbInfo.TabIndex = 31;
            this.lbInfo.Text = "First Create a Contract for the Employee.";
            // 
            // lbAccountCreate
            // 
            this.lbAccountCreate.AutoSize = true;
            this.lbAccountCreate.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAccountCreate.Location = new System.Drawing.Point(502, 688);
            this.lbAccountCreate.Name = "lbAccountCreate";
            this.lbAccountCreate.Size = new System.Drawing.Size(659, 54);
            this.lbAccountCreate.TabIndex = 30;
            this.lbAccountCreate.Text = "The Account Has Just Been Created!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nudPhoneNumber);
            this.panel1.Controls.Add(this.btnAddContract);
            this.panel1.Controls.Add(this.nudHouseNumber);
            this.panel1.Controls.Add(this.nudWage);
            this.panel1.Controls.Add(this.nudBSN);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbZipCode);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbStreet);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Location = new System.Drawing.Point(399, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 240);
            this.panel1.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(565, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "House Number: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(304, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Wage: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(304, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "BSN:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(43, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Phone Number: ";
            // 
            // nudPhoneNumber
            // 
            this.nudPhoneNumber.Location = new System.Drawing.Point(43, 101);
            this.nudPhoneNumber.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudPhoneNumber.Name = "nudPhoneNumber";
            this.nudPhoneNumber.Size = new System.Drawing.Size(255, 27);
            this.nudPhoneNumber.TabIndex = 23;
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(440, 183);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(259, 28);
            this.btnAddContract.TabIndex = 22;
            this.btnAddContract.Text = "Add Contract";
            this.btnAddContract.UseVisualStyleBackColor = true;
            // 
            // nudHouseNumber
            // 
            this.nudHouseNumber.Location = new System.Drawing.Point(565, 101);
            this.nudHouseNumber.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudHouseNumber.Name = "nudHouseNumber";
            this.nudHouseNumber.Size = new System.Drawing.Size(255, 27);
            this.nudHouseNumber.TabIndex = 21;
            // 
            // nudWage
            // 
            this.nudWage.Location = new System.Drawing.Point(304, 101);
            this.nudWage.Maximum = new decimal(new int[] {
            1419065408,
            2,
            0,
            0});
            this.nudWage.Name = "nudWage";
            this.nudWage.Size = new System.Drawing.Size(254, 27);
            this.nudWage.TabIndex = 20;
            // 
            // nudBSN
            // 
            this.nudBSN.Location = new System.Drawing.Point(304, 20);
            this.nudBSN.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.nudBSN.Name = "nudBSN";
            this.nudBSN.Size = new System.Drawing.Size(254, 27);
            this.nudBSN.TabIndex = 19;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.Location = new System.Drawing.Point(43, 20);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.Size = new System.Drawing.Size(255, 24);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(304, 141);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(255, 24);
            this.tbPassword.TabIndex = 18;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZipCode.Location = new System.Drawing.Point(565, 141);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.PlaceholderText = "ZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(255, 24);
            this.tbZipCode.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(43, 141);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(255, 24);
            this.tbEmail.TabIndex = 17;
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreet.Location = new System.Drawing.Point(565, 59);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.PlaceholderText = "Street";
            this.tbStreet.Size = new System.Drawing.Size(255, 24);
            this.tbStreet.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.Location = new System.Drawing.Point(43, 59);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.PlaceholderText = "Last Name";
            this.tbLastName.Size = new System.Drawing.Size(255, 24);
            this.tbLastName.TabIndex = 1;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.Location = new System.Drawing.Point(565, 20);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "City";
            this.tbCity.Size = new System.Drawing.Size(255, 24);
            this.tbCity.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 16;
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(150, 183);
            this.cbRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(255, 28);
            this.cbRole.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(399, 195);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 83);
            this.panel2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(236, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(384, 65);
            this.label6.TabIndex = 0;
            this.label6.Text = "Create Employee";
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(15)))));
            this.btnCreateEmployee.FlatAppearance.BorderSize = 0;
            this.btnCreateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnCreateEmployee.Location = new System.Drawing.Point(660, 528);
            this.btnCreateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(345, 54);
            this.btnCreateEmployee.TabIndex = 12;
            this.btnCreateEmployee.Text = "Create";
            this.btnCreateEmployee.UseVisualStyleBackColor = false;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click_1);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 941);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel123.ResumeLayout(false);
            this.panel123.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBSN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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