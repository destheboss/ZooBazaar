namespace Desktop.Forms
{
    partial class ShiftForm
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
            DayContainer = new FlowLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            Btnschedule = new Button();
            LbDate = new Label();
            panel1 = new Panel();
            BtnPrevious = new Button();
            BtnNext = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DayContainer
            // 
            DayContainer.BackColor = Color.FromArgb(0, 70, 0);
            DayContainer.Location = new Point(139, 134);
            DayContainer.Margin = new Padding(10);
            DayContainer.Name = "DayContainer";
            DayContainer.Size = new Size(1422, 617);
            DayContainer.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1048, 11);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 3;
            label3.Text = "Friday";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 11);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 1;
            label1.Text = "Sunday";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1235, 11);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 2;
            label2.Text = "Saturday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(244, 11);
            label7.Name = "label7";
            label7.Size = new Size(103, 32);
            label7.TabIndex = 7;
            label7.Text = "Monday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(834, 11);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 4;
            label4.Text = "Thursday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(434, 11);
            label6.Name = "label6";
            label6.Size = new Size(101, 32);
            label6.TabIndex = 6;
            label6.Text = "Tuesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(604, 11);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 5;
            label5.Text = "Wednessday";
            // 
            // Btnschedule
            // 
            Btnschedule.BackColor = Color.FromArgb(0, 70, 0);
            Btnschedule.FlatAppearance.BorderSize = 0;
            Btnschedule.FlatStyle = FlatStyle.Flat;
            Btnschedule.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btnschedule.ForeColor = Color.White;
            Btnschedule.Location = new Point(139, 764);
            Btnschedule.Name = "Btnschedule";
            Btnschedule.Size = new Size(200, 56);
            Btnschedule.TabIndex = 18;
            Btnschedule.Text = "Autoschedule";
            Btnschedule.UseVisualStyleBackColor = false;
            Btnschedule.Click += Btnschedule_Click;
            // 
            // LbDate
            // 
            LbDate.AutoSize = true;
            LbDate.BackColor = Color.FromArgb(0, 70, 0);
            LbDate.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LbDate.ForeColor = Color.White;
            LbDate.Location = new Point(767, 4);
            LbDate.Name = "LbDate";
            LbDate.Size = new Size(101, 50);
            LbDate.TabIndex = 16;
            LbDate.Text = "Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(139, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 53);
            panel1.TabIndex = 17;
            // 
            // BtnPrevious
            // 
            BtnPrevious.BackColor = Color.FromArgb(0, 70, 0);
            BtnPrevious.FlatAppearance.BorderSize = 0;
            BtnPrevious.FlatStyle = FlatStyle.Flat;
            BtnPrevious.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPrevious.ForeColor = Color.White;
            BtnPrevious.Location = new Point(1155, 764);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(200, 56);
            BtnPrevious.TabIndex = 15;
            BtnPrevious.Text = "Previous";
            BtnPrevious.UseVisualStyleBackColor = false;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // BtnNext
            // 
            BtnNext.BackColor = Color.FromArgb(0, 70, 0);
            BtnNext.FlatAppearance.BorderSize = 0;
            BtnNext.FlatStyle = FlatStyle.Flat;
            BtnNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNext.ForeColor = Color.White;
            BtnNext.Location = new Point(1361, 764);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(200, 56);
            BtnNext.TabIndex = 14;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = false;
            BtnNext.Click += BtnNext_Click;
            // 
            // ShiftForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 871);
            Controls.Add(DayContainer);
            Controls.Add(Btnschedule);
            Controls.Add(LbDate);
            Controls.Add(panel1);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnNext);
            Name = "ShiftForm";
            Text = "ShiftForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel DayContainer;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button Btnschedule;
        private Label LbDate;
        private Panel panel1;
        private Button BtnPrevious;
        private Button BtnNext;
    }
}