namespace Desktop.Forms
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            loginPanel = new Panel();
            pictureBox1 = new PictureBox();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            btnLogIn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Anchor = AnchorStyles.None;
            loginPanel.AutoSize = true;
            loginPanel.BackColor = Color.FromArgb(0, 70, 0);
            loginPanel.Controls.Add(pictureBox1);
            loginPanel.Controls.Add(tbPassword);
            loginPanel.Controls.Add(tbEmail);
            loginPanel.Controls.Add(btnLogIn);
            loginPanel.Location = new Point(223, 103);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(354, 330);
            loginPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(79, 136);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(202, 29);
            tbPassword.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.Location = new Point(79, 101);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(202, 29);
            tbEmail.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.BackgroundImageLayout = ImageLayout.None;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(122, 230);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(130, 42);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 32, 15);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(223, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 79);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(89, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 71);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPanel);
            Controls.Add(panel1);
            Name = "LogIn";
            Text = "LogIn";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private PictureBox pictureBox1;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Button btnLogIn;
        private Panel panel1;
        private Label label1;
    }
}