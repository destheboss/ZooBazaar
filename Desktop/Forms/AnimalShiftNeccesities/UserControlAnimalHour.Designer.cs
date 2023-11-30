namespace Desktop.Forms.AnimalShiftNeccesities
{
    partial class UserControlAnimalHour
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
            Lbldate = new Label();
            BtnOpen = new Button();
            Lbltext = new Label();
            SuspendLayout();
            // 
            // Lbldate
            // 
            Lbldate.AutoSize = true;
            Lbldate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbldate.Location = new Point(15, 7);
            Lbldate.Name = "Lbldate";
            Lbldate.RightToLeft = RightToLeft.Yes;
            Lbldate.Size = new Size(49, 21);
            Lbldate.TabIndex = 5;
            Lbldate.Text = "00:00";
            // 
            // BtnOpen
            // 
            BtnOpen.BackColor = Color.FromArgb(0, 70, 0);
            BtnOpen.BackgroundImageLayout = ImageLayout.None;
            BtnOpen.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 0);
            BtnOpen.FlatAppearance.BorderSize = 0;
            BtnOpen.FlatStyle = FlatStyle.Flat;
            BtnOpen.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOpen.ForeColor = Color.White;
            BtnOpen.Location = new Point(71, 2);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(151, 30);
            BtnOpen.TabIndex = 4;
            BtnOpen.UseVisualStyleBackColor = false;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // Lbltext
            // 
            Lbltext.AutoSize = true;
            Lbltext.ForeColor = SystemColors.Control;
            Lbltext.Location = new Point(17, 7);
            Lbltext.Name = "Lbltext";
            Lbltext.Size = new Size(0, 15);
            Lbltext.TabIndex = 3;
            // 
            // UserControlAnimalHour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Lbldate);
            Controls.Add(BtnOpen);
            Controls.Add(Lbltext);
            Name = "UserControlAnimalHour";
            Size = new Size(225, 31);
            Click += UserControlAnimalHour_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbldate;
        private Button BtnOpen;
        private Label Lbltext;
    }
}
