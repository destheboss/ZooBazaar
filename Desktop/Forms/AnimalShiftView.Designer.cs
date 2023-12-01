namespace Desktop.Forms
{
    partial class AnimalShiftView
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
            label1 = new Label();
            CmbShifttype = new ComboBox();
            panel1 = new Panel();
            CmbWorktype = new ComboBox();
            BtnCreateShift = new Button();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(234, 35);
            label1.TabIndex = 1;
            label1.Text = "Create new shift";
            // 
            // CmbShifttype
            // 
            CmbShifttype.FormattingEnabled = true;
            CmbShifttype.Location = new Point(16, 30);
            CmbShifttype.Name = "CmbShifttype";
            CmbShifttype.Size = new Size(121, 23);
            CmbShifttype.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(CmbWorktype);
            panel1.Controls.Add(BtnCreateShift);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CmbShifttype);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 200);
            panel1.TabIndex = 4;
            // 
            // CmbWorktype
            // 
            CmbWorktype.FormattingEnabled = true;
            CmbWorktype.Location = new Point(16, 91);
            CmbWorktype.Name = "CmbWorktype";
            CmbWorktype.Size = new Size(121, 23);
            CmbWorktype.TabIndex = 5;
            // 
            // BtnCreateShift
            // 
            BtnCreateShift.BackColor = Color.White;
            BtnCreateShift.Location = new Point(17, 134);
            BtnCreateShift.Name = "BtnCreateShift";
            BtnCreateShift.Size = new Size(239, 57);
            BtnCreateShift.TabIndex = 4;
            BtnCreateShift.Text = "Create shift";
            BtnCreateShift.UseVisualStyleBackColor = false;
            BtnCreateShift.Click += BtnCreateShift_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(16, 71);
            label3.Name = "label3";
            label3.Size = new Size(150, 17);
            label3.TabIndex = 3;
            label3.Text = "Select shift Work type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(16, 12);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 1;
            label2.Text = "Select shift type";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 70, 0);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(295, 54);
            panel2.TabIndex = 5;
            // 
            // AnimalShiftView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 285);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AnimalShiftView";
            Text = "AnimalShiftView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox CmbShifttype;
        private Panel panel1;
        private ComboBox CmbWorktype;
        private Button BtnCreateShift;
        private Label label3;
        private Label label2;
        private Panel panel2;
    }
}