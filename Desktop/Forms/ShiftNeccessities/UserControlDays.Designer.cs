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
            this.btnEvening = new System.Windows.Forms.Button();
            this.btnafternoon = new System.Windows.Forms.Button();
            this.BtnMorning = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbDay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEvening
            // 
            this.btnEvening.FlatAppearance.BorderSize = 0;
            this.btnEvening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvening.Location = new System.Drawing.Point(72, 71);
            this.btnEvening.Name = "btnEvening";
            this.btnEvening.Size = new System.Drawing.Size(125, 25);
            this.btnEvening.TabIndex = 9;
            this.btnEvening.Text = "Evening";
            this.btnEvening.UseVisualStyleBackColor = true;
            this.btnEvening.Click += new System.EventHandler(this.btnEvening_Click_1);
            // 
            // btnafternoon
            // 
            this.btnafternoon.FlatAppearance.BorderSize = 0;
            this.btnafternoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnafternoon.Location = new System.Drawing.Point(72, 40);
            this.btnafternoon.Name = "btnafternoon";
            this.btnafternoon.Size = new System.Drawing.Size(125, 25);
            this.btnafternoon.TabIndex = 8;
            this.btnafternoon.Text = "Afternoon";
            this.btnafternoon.UseVisualStyleBackColor = true;
            this.btnafternoon.Click += new System.EventHandler(this.btnafternoon_Click_1);
            // 
            // BtnMorning
            // 
            this.BtnMorning.FlatAppearance.BorderSize = 0;
            this.BtnMorning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMorning.Location = new System.Drawing.Point(72, 7);
            this.BtnMorning.Name = "BtnMorning";
            this.BtnMorning.Size = new System.Drawing.Size(125, 25);
            this.BtnMorning.TabIndex = 7;
            this.BtnMorning.Text = "Morning";
            this.BtnMorning.UseVisualStyleBackColor = true;
            this.BtnMorning.Click += new System.EventHandler(this.BtnMorning_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(56, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 90);
            this.panel1.TabIndex = 6;
            // 
            // LbDay
            // 
            this.LbDay.AutoSize = true;
            this.LbDay.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbDay.Location = new System.Drawing.Point(3, 30);
            this.LbDay.Name = "LbDay";
            this.LbDay.Size = new System.Drawing.Size(56, 45);
            this.LbDay.TabIndex = 5;
            this.LbDay.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEvening);
            this.Controls.Add(this.btnafternoon);
            this.Controls.Add(this.BtnMorning);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbDay);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(201, 104);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEvening;
        private Button btnafternoon;
        private Button BtnMorning;
        private Panel panel1;
        private Label LbDay;
    }
}
