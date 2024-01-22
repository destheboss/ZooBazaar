namespace Desktop.Forms
{
    partial class ContractPage
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
            lblName = new Label();
            btDeleteContract = new Button();
            btnAddContract = new Button();
            lbContracts = new ListBox();
            label1 = new Label();
            numericUpDown_amountofhours = new NumericUpDown();
            numericUpDown_length = new NumericUpDown();
            label3 = new Label();
            tb_name = new TextBox();
            label2 = new Label();
            btnAddContractToEmployee = new Button();
            panel1 = new Panel();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amountofhours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_length).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(429, 492);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 27;
            // 
            // btDeleteContract
            // 
            btDeleteContract.BackColor = Color.FromArgb(0, 70, 0);
            btDeleteContract.FlatStyle = FlatStyle.Flat;
            btDeleteContract.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btDeleteContract.ForeColor = Color.White;
            btDeleteContract.Location = new Point(1406, 862);
            btDeleteContract.Margin = new Padding(3, 2, 3, 2);
            btDeleteContract.Name = "btDeleteContract";
            btDeleteContract.Size = new Size(249, 43);
            btDeleteContract.TabIndex = 26;
            btDeleteContract.Text = "Delete Contract";
            btDeleteContract.UseVisualStyleBackColor = false;
            btDeleteContract.Click += btDeleteContract_Click;
            // 
            // btnAddContract
            // 
            btnAddContract.BackColor = Color.FromArgb(0, 70, 0);
            btnAddContract.FlatStyle = FlatStyle.Flat;
            btnAddContract.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddContract.ForeColor = Color.White;
            btnAddContract.Location = new Point(1142, 862);
            btnAddContract.Margin = new Padding(3, 2, 3, 2);
            btnAddContract.Name = "btnAddContract";
            btnAddContract.Size = new Size(249, 44);
            btnAddContract.TabIndex = 25;
            btnAddContract.Text = "Create New Contract";
            btnAddContract.UseVisualStyleBackColor = false;
            btnAddContract.Click += btnAddContract_Click;
            // 
            // lbContracts
            // 
            lbContracts.FormattingEnabled = true;
            lbContracts.ItemHeight = 15;
            lbContracts.Location = new Point(303, 26);
            lbContracts.Margin = new Padding(4, 3, 4, 3);
            lbContracts.Name = "lbContracts";
            lbContracts.Size = new Size(1352, 829);
            lbContracts.TabIndex = 24;
            lbContracts.SelectedIndexChanged += lbContracts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 15;
            label1.Text = "Contract Name:";
            // 
            // numericUpDown_amountofhours
            // 
            numericUpDown_amountofhours.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_amountofhours.Location = new Point(16, 154);
            numericUpDown_amountofhours.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_amountofhours.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            numericUpDown_amountofhours.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_amountofhours.Name = "numericUpDown_amountofhours";
            numericUpDown_amountofhours.Size = new Size(255, 27);
            numericUpDown_amountofhours.TabIndex = 20;
            numericUpDown_amountofhours.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown_length
            // 
            numericUpDown_length.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown_length.Location = new Point(16, 92);
            numericUpDown_length.Margin = new Padding(3, 2, 3, 2);
            numericUpDown_length.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_length.Name = "numericUpDown_length";
            numericUpDown_length.Size = new Size(255, 27);
            numericUpDown_length.TabIndex = 21;
            numericUpDown_length.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 121);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 17;
            label3.Text = "Amount Of Hours:";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(16, 31);
            tb_name.Margin = new Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(255, 27);
            tb_name.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 16;
            label2.Text = "Length:";
            // 
            // btnAddContractToEmployee
            // 
            btnAddContractToEmployee.BackColor = Color.FromArgb(0, 70, 0);
            btnAddContractToEmployee.FlatStyle = FlatStyle.Flat;
            btnAddContractToEmployee.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddContractToEmployee.ForeColor = Color.White;
            btnAddContractToEmployee.Location = new Point(877, 862);
            btnAddContractToEmployee.Margin = new Padding(3, 2, 3, 2);
            btnAddContractToEmployee.Name = "btnAddContractToEmployee";
            btnAddContractToEmployee.Size = new Size(249, 44);
            btnAddContractToEmployee.TabIndex = 29;
            btnAddContractToEmployee.Text = "Add Contract";
            btnAddContractToEmployee.UseVisualStyleBackColor = false;
            btnAddContractToEmployee.Click += btnAddContractToEmployee_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDown_amountofhours);
            panel1.Controls.Add(numericUpDown_length);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_name);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 195);
            panel1.TabIndex = 28;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(0, 70, 0);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(622, 862);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(249, 44);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ContractPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 923);
            Controls.Add(btnRefresh);
            Controls.Add(lblName);
            Controls.Add(btDeleteContract);
            Controls.Add(btnAddContract);
            Controls.Add(lbContracts);
            Controls.Add(btnAddContractToEmployee);
            Controls.Add(panel1);
            Name = "ContractPage";
            Text = "ContractPage";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_amountofhours).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_length).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btDeleteContract;
        private Button btnAddContract;
        private ListBox lbContracts;
        private Label label1;
        private NumericUpDown numericUpDown_amountofhours;
        private NumericUpDown numericUpDown_length;
        private Label label3;
        private TextBox tb_name;
        private Label label2;
        private Button btnAddContractToEmployee;
        private Panel panel1;
        private Button btnRefresh;
    }
}