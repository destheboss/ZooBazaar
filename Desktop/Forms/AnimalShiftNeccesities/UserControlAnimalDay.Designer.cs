namespace Desktop.Forms.AnimalShiftNeccesities
{
    partial class UserControlAnimalDay
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
            panel21 = new Panel();
            LblDate = new Label();
            HourContainer = new FlowLayoutPanel();
            panel21.SuspendLayout();
            SuspendLayout();
            // 
            // panel21
            // 
            panel21.BackColor = Color.FromArgb(0, 70, 0);
            panel21.Controls.Add(LblDate);
            panel21.Location = new Point(6, 14);
            panel21.Name = "panel21";
            panel21.Size = new Size(226, 48);
            panel21.TabIndex = 22;
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LblDate.ForeColor = SystemColors.Control;
            LblDate.Location = new Point(3, 0);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(86, 45);
            LblDate.TabIndex = 17;
            LblDate.Text = "Date";
            // 
            // HourContainer
            // 
            HourContainer.Location = new Point(6, 68);
            HourContainer.Name = "HourContainer";
            HourContainer.Size = new Size(219, 690);
            HourContainer.TabIndex = 21;
            // 
            // UserControlAnimalDay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel21);
            Controls.Add(HourContainer);
            Name = "UserControlAnimalDay";
            Size = new Size(239, 772);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel21;
        private Label LblDate;
        private FlowLayoutPanel HourContainer;
    }
}
