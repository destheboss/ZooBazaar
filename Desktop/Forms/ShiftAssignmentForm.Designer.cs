namespace Desktop.Forms
{
    partial class ShiftAssignmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbxFilterAssigned = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbxAssigned = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxFilterAvailable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbxAvailable = new System.Windows.Forms.ListBox();
            this.Btnunnasign = new System.Windows.Forms.Button();
            this.BtnAssign = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.TbxFilterAssigned);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LbxAssigned);
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 457);
            this.panel1.TabIndex = 4;
            // 
            // TbxFilterAssigned
            // 
            this.TbxFilterAssigned.Location = new System.Drawing.Point(162, 80);
            this.TbxFilterAssigned.Name = "TbxFilterAssigned";
            this.TbxFilterAssigned.Size = new System.Drawing.Size(255, 23);
            this.TbxFilterAssigned.TabIndex = 4;
            this.TbxFilterAssigned.TextChanged += new System.EventHandler(this.TbxFilterAssigned_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search by name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned employees";
            // 
            // LbxAssigned
            // 
            this.LbxAssigned.BackColor = System.Drawing.Color.White;
            this.LbxAssigned.ForeColor = System.Drawing.Color.Black;
            this.LbxAssigned.FormattingEnabled = true;
            this.LbxAssigned.ItemHeight = 15;
            this.LbxAssigned.Location = new System.Drawing.Point(15, 109);
            this.LbxAssigned.Name = "LbxAssigned";
            this.LbxAssigned.Size = new System.Drawing.Size(402, 334);
            this.LbxAssigned.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TbxFilterAvailable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LbxAvailable);
            this.panel2.Location = new System.Drawing.Point(709, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 457);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search by name:";
            // 
            // TbxFilterAvailable
            // 
            this.TbxFilterAvailable.Location = new System.Drawing.Point(164, 80);
            this.TbxFilterAvailable.Name = "TbxFilterAvailable";
            this.TbxFilterAvailable.Size = new System.Drawing.Size(255, 23);
            this.TbxFilterAvailable.TabIndex = 3;
            this.TbxFilterAvailable.TextChanged += new System.EventHandler(this.TbxFilterAvailable_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available employees";
            // 
            // LbxAvailable
            // 
            this.LbxAvailable.BackColor = System.Drawing.Color.White;
            this.LbxAvailable.FormattingEnabled = true;
            this.LbxAvailable.ItemHeight = 15;
            this.LbxAvailable.Location = new System.Drawing.Point(17, 109);
            this.LbxAvailable.Name = "LbxAvailable";
            this.LbxAvailable.Size = new System.Drawing.Size(402, 334);
            this.LbxAvailable.TabIndex = 1;
            this.LbxAvailable.SelectedIndexChanged += new System.EventHandler(this.LbxAvailable_SelectedIndexChanged);
            // 
            // Btnunnasign
            // 
            this.Btnunnasign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.Btnunnasign.FlatAppearance.BorderSize = 0;
            this.Btnunnasign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnunnasign.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btnunnasign.ForeColor = System.Drawing.Color.White;
            this.Btnunnasign.Location = new System.Drawing.Point(442, 275);
            this.Btnunnasign.Name = "Btnunnasign";
            this.Btnunnasign.Size = new System.Drawing.Size(261, 54);
            this.Btnunnasign.TabIndex = 7;
            this.Btnunnasign.Text = "Unnasign employee->";
            this.Btnunnasign.UseVisualStyleBackColor = false;
            this.Btnunnasign.Click += new System.EventHandler(this.Btnunnasign_Click_1);
            // 
            // BtnAssign
            // 
            this.BtnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.BtnAssign.FlatAppearance.BorderSize = 0;
            this.BtnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAssign.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAssign.ForeColor = System.Drawing.Color.White;
            this.BtnAssign.Location = new System.Drawing.Point(442, 215);
            this.BtnAssign.Name = "BtnAssign";
            this.BtnAssign.Size = new System.Drawing.Size(261, 54);
            this.BtnAssign.TabIndex = 6;
            this.BtnAssign.Text = "<-Assign employee";
            this.BtnAssign.UseVisualStyleBackColor = false;
            this.BtnAssign.Click += new System.EventHandler(this.BtnAssign_Click_1);
            // 
            // ShiftAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btnunnasign);
            this.Controls.Add(this.BtnAssign);
            this.Name = "ShiftAssignmentForm";
            this.Text = "ShiftAssignmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox TbxFilterAssigned;
        private Label label3;
        private Label label1;
        private ListBox LbxAssigned;
        private Panel panel2;
        private Label label4;
        private TextBox TbxFilterAvailable;
        private Label label2;
        private ListBox LbxAvailable;
        private Button Btnunnasign;
        private Button BtnAssign;
    }
}