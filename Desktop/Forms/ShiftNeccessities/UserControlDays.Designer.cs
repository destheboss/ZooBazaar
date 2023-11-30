namespace Desktop.Forms.ShiftNeccessities
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEvening = new Button();
            btnafternoon = new Button();
            BtnMorning = new Button();
            panel1 = new Panel();
            LbDay = new Label();
            SuspendLayout();
            // 
            // btnEvening
            // 
            btnEvening.FlatAppearance.BorderSize = 0;
            btnEvening.FlatStyle = FlatStyle.Flat;
            btnEvening.Location = new Point(72, 71);
            btnEvening.Name = "btnEvening";
            btnEvening.Size = new Size(125, 25);
            btnEvening.TabIndex = 9;
            btnEvening.Text = "Evening";
            btnEvening.UseVisualStyleBackColor = true;
            btnEvening.Click += btnEvening_Click;
            // 
            // btnafternoon
            // 
            btnafternoon.FlatAppearance.BorderSize = 0;
            btnafternoon.FlatStyle = FlatStyle.Flat;
            btnafternoon.Location = new Point(72, 40);
            btnafternoon.Name = "btnafternoon";
            btnafternoon.Size = new Size(125, 25);
            btnafternoon.TabIndex = 8;
            btnafternoon.Text = "Afternoon";
            btnafternoon.UseVisualStyleBackColor = true;
            btnafternoon.Click += btnafternoon_Click;
            // 
            // BtnMorning
            // 
            BtnMorning.FlatAppearance.BorderSize = 0;
            BtnMorning.FlatStyle = FlatStyle.Flat;
            BtnMorning.Location = new Point(72, 7);
            BtnMorning.Name = "BtnMorning";
            BtnMorning.Size = new Size(125, 25);
            BtnMorning.TabIndex = 7;
            BtnMorning.Text = "Morning";
            BtnMorning.UseVisualStyleBackColor = true;
            BtnMorning.Click += BtnMorning_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(56, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(4, 90);
            panel1.TabIndex = 6;
            // 
            // LbDay
            // 
            LbDay.AutoSize = true;
            LbDay.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LbDay.Location = new Point(3, 30);
            LbDay.Name = "LbDay";
            LbDay.Size = new Size(56, 45);
            LbDay.TabIndex = 5;
            LbDay.Text = "00";
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEvening);
            Controls.Add(btnafternoon);
            Controls.Add(BtnMorning);
            Controls.Add(panel1);
            Controls.Add(LbDay);
            Name = "UserControlDays";
            Size = new Size(201, 104);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEvening;
        private Button btnafternoon;
        private Button BtnMorning;
        private Panel panel1;
        private Label LbDay;
    }
}
