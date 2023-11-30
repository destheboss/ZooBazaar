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
            panel1 = new Panel();
            TbxFilterAssigned = new TextBox();
            label3 = new Label();
            label1 = new Label();
            LbxAssigned = new ListBox();
            panel2 = new Panel();
            label4 = new Label();
            TbxFilterAvailable = new TextBox();
            label2 = new Label();
            LbxAvailable = new ListBox();
            Btnunnasign = new Button();
            BtnAssign = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(TbxFilterAssigned);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LbxAssigned);
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 457);
            panel1.TabIndex = 4;
            // 
            // TbxFilterAssigned
            // 
            TbxFilterAssigned.Location = new Point(162, 80);
            TbxFilterAssigned.Name = "TbxFilterAssigned";
            TbxFilterAssigned.Size = new Size(255, 23);
            TbxFilterAssigned.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(15, 80);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 2;
            label3.Text = "Search by name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 15);
            label1.Name = "label1";
            label1.Size = new Size(315, 45);
            label1.TabIndex = 1;
            label1.Text = "Assigned employees";
            // 
            // LbxAssigned
            // 
            LbxAssigned.BackColor = Color.White;
            LbxAssigned.ForeColor = Color.Black;
            LbxAssigned.FormattingEnabled = true;
            LbxAssigned.ItemHeight = 15;
            LbxAssigned.Location = new Point(15, 109);
            LbxAssigned.Name = "LbxAssigned";
            LbxAssigned.Size = new Size(402, 334);
            LbxAssigned.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 70, 0);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TbxFilterAvailable);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LbxAvailable);
            panel2.Location = new Point(709, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 457);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(17, 82);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 5;
            label4.Text = "Search by name:";
            // 
            // TbxFilterAvailable
            // 
            TbxFilterAvailable.Location = new Point(164, 80);
            TbxFilterAvailable.Name = "TbxFilterAvailable";
            TbxFilterAvailable.Size = new Size(255, 23);
            TbxFilterAvailable.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(63, 15);
            label2.Name = "label2";
            label2.Size = new Size(314, 45);
            label2.TabIndex = 2;
            label2.Text = "Available employees";
            // 
            // LbxAvailable
            // 
            LbxAvailable.BackColor = Color.White;
            LbxAvailable.FormattingEnabled = true;
            LbxAvailable.ItemHeight = 15;
            LbxAvailable.Location = new Point(17, 109);
            LbxAvailable.Name = "LbxAvailable";
            LbxAvailable.Size = new Size(402, 334);
            LbxAvailable.TabIndex = 1;
            // 
            // Btnunnasign
            // 
            Btnunnasign.BackColor = Color.FromArgb(0, 70, 0);
            Btnunnasign.FlatAppearance.BorderSize = 0;
            Btnunnasign.FlatStyle = FlatStyle.Flat;
            Btnunnasign.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btnunnasign.ForeColor = Color.White;
            Btnunnasign.Location = new Point(442, 275);
            Btnunnasign.Name = "Btnunnasign";
            Btnunnasign.Size = new Size(261, 54);
            Btnunnasign.TabIndex = 7;
            Btnunnasign.Text = "Unnasign employee->";
            Btnunnasign.UseVisualStyleBackColor = false;
            Btnunnasign.Click += Btnunnasign_Click;
            // 
            // BtnAssign
            // 
            BtnAssign.BackColor = Color.FromArgb(0, 70, 0);
            BtnAssign.FlatAppearance.BorderSize = 0;
            BtnAssign.FlatStyle = FlatStyle.Flat;
            BtnAssign.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAssign.ForeColor = Color.White;
            BtnAssign.Location = new Point(442, 215);
            BtnAssign.Name = "BtnAssign";
            BtnAssign.Size = new Size(261, 54);
            BtnAssign.TabIndex = 6;
            BtnAssign.Text = "<-Assign employee";
            BtnAssign.UseVisualStyleBackColor = false;
            BtnAssign.Click += BtnAssign_Click;
            // 
            // ShiftAssignmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 563);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(Btnunnasign);
            Controls.Add(BtnAssign);
            Name = "ShiftAssignmentForm";
            Text = "ShiftAssignmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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