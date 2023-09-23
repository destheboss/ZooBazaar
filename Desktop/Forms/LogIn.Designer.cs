namespace ZooBazaar.Forms
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.AutoSize = true;
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.tbPassword);
            this.loginPanel.Controls.Add(this.tbEmail);
            this.loginPanel.Controls.Add(this.btnLogIn);
            this.loginPanel.Location = new System.Drawing.Point(269, 102);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(354, 330);
            this.loginPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(269, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 79);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(79, 136);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(202, 29);
            this.tbPassword.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(79, 101);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.Size = new System.Drawing.Size(202, 29);
            this.tbEmail.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(122, 230);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(130, 42);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(234)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(887, 443);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(903, 482);
            this.MinimumSize = new System.Drawing.Size(903, 482);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel loginPanel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Button btnLogIn;
    }
}