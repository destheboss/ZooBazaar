namespace Desktop.Forms
{
    partial class AnimalManagement
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
            BtnAnimalschedule = new Button();
            displayAllAnimals_btn = new Button();
            panel1 = new Panel();
            animalStatus_cb = new ComboBox();
            label1 = new Label();
            name_tb = new TextBox();
            DtpDob = new DateTimePicker();
            animalLocation_cb = new ComboBox();
            name_lbl = new Label();
            birthday_lbl = new Label();
            animalType_lbl = new Label();
            weight_tb = new TextBox();
            animalType_cb = new ComboBox();
            weight_lbl = new Label();
            animalLocation_lbl = new Label();
            removeAnimal_btn = new Button();
            editAnimal_btn = new Button();
            addAnimal_btn = new Button();
            saveAnimal_btn = new Button();
            viewAllAnimals_dgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAllAnimals_dgv).BeginInit();
            SuspendLayout();
            // 
            // BtnAnimalschedule
            // 
            BtnAnimalschedule.BackColor = Color.FromArgb(0, 70, 0);
            BtnAnimalschedule.FlatStyle = FlatStyle.Flat;
            BtnAnimalschedule.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAnimalschedule.ForeColor = Color.White;
            BtnAnimalschedule.Location = new Point(112, 856);
            BtnAnimalschedule.Margin = new Padding(3, 2, 3, 2);
            BtnAnimalschedule.Name = "BtnAnimalschedule";
            BtnAnimalschedule.Size = new Size(261, 44);
            BtnAnimalschedule.TabIndex = 32;
            BtnAnimalschedule.Text = "Show Animal schedule";
            BtnAnimalschedule.UseVisualStyleBackColor = false;
            // 
            // displayAllAnimals_btn
            // 
            displayAllAnimals_btn.BackColor = Color.FromArgb(0, 70, 0);
            displayAllAnimals_btn.FlatStyle = FlatStyle.Flat;
            displayAllAnimals_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            displayAllAnimals_btn.ForeColor = Color.White;
            displayAllAnimals_btn.Location = new Point(379, 856);
            displayAllAnimals_btn.Margin = new Padding(3, 2, 3, 2);
            displayAllAnimals_btn.Name = "displayAllAnimals_btn";
            displayAllAnimals_btn.Size = new Size(261, 44);
            displayAllAnimals_btn.TabIndex = 31;
            displayAllAnimals_btn.Text = "Show all animal";
            displayAllAnimals_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(animalStatus_cb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(name_tb);
            panel1.Controls.Add(DtpDob);
            panel1.Controls.Add(animalLocation_cb);
            panel1.Controls.Add(name_lbl);
            panel1.Controls.Add(birthday_lbl);
            panel1.Controls.Add(animalType_lbl);
            panel1.Controls.Add(weight_tb);
            panel1.Controls.Add(animalType_cb);
            panel1.Controls.Add(weight_lbl);
            panel1.Controls.Add(animalLocation_lbl);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 331);
            panel1.TabIndex = 30;
            // 
            // animalStatus_cb
            // 
            animalStatus_cb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            animalStatus_cb.FormattingEnabled = true;
            animalStatus_cb.Location = new Point(16, 288);
            animalStatus_cb.Margin = new Padding(3, 2, 3, 2);
            animalStatus_cb.Name = "animalStatus_cb";
            animalStatus_cb.Size = new Size(255, 28);
            animalStatus_cb.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 70, 0);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 266);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 22;
            label1.Text = "AnimalStatus:";
            // 
            // name_tb
            // 
            name_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_tb.Location = new Point(16, 31);
            name_tb.Margin = new Padding(3, 2, 3, 2);
            name_tb.Name = "name_tb";
            name_tb.Size = new Size(255, 27);
            name_tb.TabIndex = 12;
            // 
            // DtpDob
            // 
            DtpDob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DtpDob.Location = new Point(16, 237);
            DtpDob.Margin = new Padding(3, 2, 3, 2);
            DtpDob.Name = "DtpDob";
            DtpDob.Size = new Size(255, 27);
            DtpDob.TabIndex = 21;
            // 
            // animalLocation_cb
            // 
            animalLocation_cb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            animalLocation_cb.FormattingEnabled = true;
            animalLocation_cb.Location = new Point(16, 185);
            animalLocation_cb.Margin = new Padding(3, 2, 3, 2);
            animalLocation_cb.Name = "animalLocation_cb";
            animalLocation_cb.Size = new Size(255, 28);
            animalLocation_cb.TabIndex = 16;
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.BackColor = Color.FromArgb(0, 70, 0);
            name_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            name_lbl.ForeColor = Color.White;
            name_lbl.Location = new Point(16, 9);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(52, 20);
            name_lbl.TabIndex = 7;
            name_lbl.Text = "Name:";
            // 
            // birthday_lbl
            // 
            birthday_lbl.AutoSize = true;
            birthday_lbl.BackColor = Color.FromArgb(0, 70, 0);
            birthday_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            birthday_lbl.ForeColor = Color.White;
            birthday_lbl.Location = new Point(16, 215);
            birthday_lbl.Name = "birthday_lbl";
            birthday_lbl.Size = new Size(97, 20);
            birthday_lbl.TabIndex = 11;
            birthday_lbl.Text = "Date of Birth:";
            // 
            // animalType_lbl
            // 
            animalType_lbl.AutoSize = true;
            animalType_lbl.BackColor = Color.FromArgb(0, 70, 0);
            animalType_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            animalType_lbl.ForeColor = Color.White;
            animalType_lbl.Location = new Point(16, 60);
            animalType_lbl.Name = "animalType_lbl";
            animalType_lbl.Size = new Size(94, 20);
            animalType_lbl.TabIndex = 8;
            animalType_lbl.Text = "Animal Type:";
            // 
            // weight_tb
            // 
            weight_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            weight_tb.Location = new Point(16, 134);
            weight_tb.Margin = new Padding(3, 2, 3, 2);
            weight_tb.Name = "weight_tb";
            weight_tb.Size = new Size(255, 27);
            weight_tb.TabIndex = 13;
            // 
            // animalType_cb
            // 
            animalType_cb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            animalType_cb.FormattingEnabled = true;
            animalType_cb.Location = new Point(16, 82);
            animalType_cb.Margin = new Padding(3, 2, 3, 2);
            animalType_cb.Name = "animalType_cb";
            animalType_cb.Size = new Size(255, 28);
            animalType_cb.TabIndex = 15;
            // 
            // weight_lbl
            // 
            weight_lbl.AutoSize = true;
            weight_lbl.BackColor = Color.FromArgb(0, 70, 0);
            weight_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            weight_lbl.ForeColor = Color.White;
            weight_lbl.Location = new Point(16, 112);
            weight_lbl.Name = "weight_lbl";
            weight_lbl.Size = new Size(59, 20);
            weight_lbl.TabIndex = 9;
            weight_lbl.Text = "Weight:";
            // 
            // animalLocation_lbl
            // 
            animalLocation_lbl.AutoSize = true;
            animalLocation_lbl.BackColor = Color.FromArgb(0, 70, 0);
            animalLocation_lbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            animalLocation_lbl.ForeColor = Color.White;
            animalLocation_lbl.Location = new Point(16, 163);
            animalLocation_lbl.Name = "animalLocation_lbl";
            animalLocation_lbl.Size = new Size(120, 20);
            animalLocation_lbl.TabIndex = 10;
            animalLocation_lbl.Text = "Animal Location:";
            // 
            // removeAnimal_btn
            // 
            removeAnimal_btn.BackColor = Color.FromArgb(0, 70, 0);
            removeAnimal_btn.FlatStyle = FlatStyle.Flat;
            removeAnimal_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            removeAnimal_btn.ForeColor = Color.White;
            removeAnimal_btn.Location = new Point(646, 856);
            removeAnimal_btn.Margin = new Padding(3, 2, 3, 2);
            removeAnimal_btn.Name = "removeAnimal_btn";
            removeAnimal_btn.Size = new Size(249, 44);
            removeAnimal_btn.TabIndex = 27;
            removeAnimal_btn.Text = "Remove Animal";
            removeAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // editAnimal_btn
            // 
            editAnimal_btn.BackColor = Color.FromArgb(0, 70, 0);
            editAnimal_btn.FlatStyle = FlatStyle.Flat;
            editAnimal_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editAnimal_btn.ForeColor = Color.White;
            editAnimal_btn.Location = new Point(1156, 856);
            editAnimal_btn.Margin = new Padding(3, 2, 3, 2);
            editAnimal_btn.Name = "editAnimal_btn";
            editAnimal_btn.Size = new Size(249, 44);
            editAnimal_btn.TabIndex = 28;
            editAnimal_btn.Text = "Edit Animal";
            editAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // addAnimal_btn
            // 
            addAnimal_btn.BackColor = Color.FromArgb(0, 70, 0);
            addAnimal_btn.FlatStyle = FlatStyle.Flat;
            addAnimal_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            addAnimal_btn.ForeColor = Color.White;
            addAnimal_btn.Location = new Point(901, 856);
            addAnimal_btn.Margin = new Padding(3, 2, 3, 2);
            addAnimal_btn.Name = "addAnimal_btn";
            addAnimal_btn.Size = new Size(249, 44);
            addAnimal_btn.TabIndex = 26;
            addAnimal_btn.Text = " Add Animal";
            addAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // saveAnimal_btn
            // 
            saveAnimal_btn.BackColor = Color.FromArgb(0, 70, 0);
            saveAnimal_btn.FlatStyle = FlatStyle.Flat;
            saveAnimal_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveAnimal_btn.ForeColor = Color.White;
            saveAnimal_btn.Location = new Point(1411, 856);
            saveAnimal_btn.Margin = new Padding(3, 2, 3, 2);
            saveAnimal_btn.Name = "saveAnimal_btn";
            saveAnimal_btn.Size = new Size(249, 44);
            saveAnimal_btn.TabIndex = 29;
            saveAnimal_btn.Text = "Save";
            saveAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // viewAllAnimals_dgv
            // 
            viewAllAnimals_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAllAnimals_dgv.Location = new Point(322, 12);
            viewAllAnimals_dgv.Margin = new Padding(3, 2, 3, 2);
            viewAllAnimals_dgv.Name = "viewAllAnimals_dgv";
            viewAllAnimals_dgv.RowHeadersWidth = 51;
            viewAllAnimals_dgv.RowTemplate.Height = 29;
            viewAllAnimals_dgv.Size = new Size(1338, 840);
            viewAllAnimals_dgv.TabIndex = 25;
            // 
            // AnimalManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1588, 820);
            Controls.Add(BtnAnimalschedule);
            Controls.Add(displayAllAnimals_btn);
            Controls.Add(panel1);
            Controls.Add(removeAnimal_btn);
            Controls.Add(editAnimal_btn);
            Controls.Add(addAnimal_btn);
            Controls.Add(saveAnimal_btn);
            Controls.Add(viewAllAnimals_dgv);
            Name = "AnimalManagement";
            Text = "AnimalManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewAllAnimals_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAnimalschedule;
        private Button displayAllAnimals_btn;
        private Panel panel1;
        private ComboBox animalStatus_cb;
        private Label label1;
        private TextBox name_tb;
        private DateTimePicker DtpDob;
        private ComboBox animalLocation_cb;
        private Label name_lbl;
        private Label birthday_lbl;
        private Label animalType_lbl;
        private TextBox weight_tb;
        private ComboBox animalType_cb;
        private Label weight_lbl;
        private Label animalLocation_lbl;
        private Button removeAnimal_btn;
        private Button editAnimal_btn;
        private Button addAnimal_btn;
        private Button saveAnimal_btn;
        private DataGridView viewAllAnimals_dgv;
    }
}