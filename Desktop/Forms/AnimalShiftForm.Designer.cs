namespace Desktop.Forms
{
    partial class AnimalShiftForm
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
            BtnBack = new Button();
            BtnPreviousWeek = new Button();
            BtnNextWeek = new Button();
            DayContainer = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(0, 70, 0);
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Popup;
            BtnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBack.ForeColor = SystemColors.Control;
            BtnBack.Location = new Point(1522, 21);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(140, 83);
            BtnBack.TabIndex = 7;
            BtnBack.Text = "Back to animal";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnPreviousWeek
            // 
            BtnPreviousWeek.BackColor = Color.FromArgb(0, 70, 0);
            BtnPreviousWeek.FlatAppearance.BorderSize = 0;
            BtnPreviousWeek.FlatStyle = FlatStyle.Popup;
            BtnPreviousWeek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPreviousWeek.ForeColor = SystemColors.Control;
            BtnPreviousWeek.Location = new Point(1086, 21);
            BtnPreviousWeek.Name = "BtnPreviousWeek";
            BtnPreviousWeek.Size = new Size(212, 83);
            BtnPreviousWeek.TabIndex = 6;
            BtnPreviousWeek.Text = "Previous Week";
            BtnPreviousWeek.UseVisualStyleBackColor = false;
            BtnPreviousWeek.Click += BtnPreviousWeek_Click;
            // 
            // BtnNextWeek
            // 
            BtnNextWeek.BackColor = Color.FromArgb(0, 70, 0);
            BtnNextWeek.FlatAppearance.BorderSize = 0;
            BtnNextWeek.FlatStyle = FlatStyle.Popup;
            BtnNextWeek.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNextWeek.ForeColor = SystemColors.Control;
            BtnNextWeek.Location = new Point(1304, 21);
            BtnNextWeek.Name = "BtnNextWeek";
            BtnNextWeek.Size = new Size(212, 83);
            BtnNextWeek.TabIndex = 5;
            BtnNextWeek.Text = "Next week";
            BtnNextWeek.UseVisualStyleBackColor = false;
            BtnNextWeek.Click += BtnNextWeek_Click;
            // 
            // DayContainer
            // 
            DayContainer.BackColor = Color.FromArgb(0, 70, 0);
            DayContainer.Location = new Point(14, 155);
            DayContainer.Name = "DayContainer";
            DayContainer.Padding = new Padding(3, 0, 3, 0);
            DayContainer.Size = new Size(1648, 753);
            DayContainer.TabIndex = 4;
            // 
            // AnimalShiftForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 987);
            Controls.Add(BtnBack);
            Controls.Add(BtnPreviousWeek);
            Controls.Add(BtnNextWeek);
            Controls.Add(DayContainer);
            Name = "AnimalShiftForm";
            Text = "AnimalShiftForm";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnPreviousWeek;
        private Button BtnNextWeek;
        private FlowLayoutPanel DayContainer;
    }
}