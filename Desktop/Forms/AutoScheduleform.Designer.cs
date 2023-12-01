namespace Desktop.Forms
{
    partial class AutoScheduleform
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
            panel2 = new Panel();
            panel1 = new Panel();
            BtnAutoSchedule = new Button();
            label2 = new Label();
            label1 = new Label();
            DtpEndDate = new DateTimePicker();
            Dtpstartdate = new DateTimePicker();
            AutoscheduleLbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(689, 14);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(BtnAutoSchedule);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DtpEndDate);
            panel1.Controls.Add(Dtpstartdate);
            panel1.Controls.Add(AutoscheduleLbl);
            panel1.Location = new Point(23, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 393);
            panel1.TabIndex = 4;
            // 
            // BtnAutoSchedule
            // 
            BtnAutoSchedule.Location = new Point(27, 311);
            BtnAutoSchedule.Name = "BtnAutoSchedule";
            BtnAutoSchedule.Size = new Size(200, 47);
            BtnAutoSchedule.TabIndex = 5;
            BtnAutoSchedule.Text = "AutoSchedule";
            BtnAutoSchedule.UseVisualStyleBackColor = true;
            BtnAutoSchedule.Click += BtnAutoSchedule_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(27, 154);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 4;
            label2.Text = "End Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 86);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 3;
            label1.Text = "Start Date:";
            // 
            // DtpEndDate
            // 
            DtpEndDate.Location = new Point(27, 182);
            DtpEndDate.Name = "DtpEndDate";
            DtpEndDate.Size = new Size(200, 23);
            DtpEndDate.TabIndex = 2;
            // 
            // Dtpstartdate
            // 
            Dtpstartdate.Location = new Point(27, 114);
            Dtpstartdate.Name = "Dtpstartdate";
            Dtpstartdate.Size = new Size(200, 23);
            Dtpstartdate.TabIndex = 1;
            // 
            // AutoscheduleLbl
            // 
            AutoscheduleLbl.AutoSize = true;
            AutoscheduleLbl.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            AutoscheduleLbl.ForeColor = SystemColors.Control;
            AutoscheduleLbl.Location = new Point(13, 11);
            AutoscheduleLbl.Name = "AutoscheduleLbl";
            AutoscheduleLbl.Size = new Size(214, 38);
            AutoscheduleLbl.TabIndex = 0;
            AutoscheduleLbl.Text = "AutoSchedule";
            // 
            // AutoScheduler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 427);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AutoScheduler";
            Text = "AutoScheduler";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button BtnAutoSchedule;
        private Label label2;
        private Label label1;
        private DateTimePicker DtpEndDate;
        private DateTimePicker Dtpstartdate;
        private Label AutoscheduleLbl;
    }
}