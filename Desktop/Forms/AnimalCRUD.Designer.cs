namespace Desktop.Forms
{
    partial class AnimalCRUD
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
            this.BtnAnimalschedule = new System.Windows.Forms.Button();
            this.displayAllAnimals_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.DtpDob = new System.Windows.Forms.DateTimePicker();
            this.animalLocation_cb = new System.Windows.Forms.ComboBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.birthday_lbl = new System.Windows.Forms.Label();
            this.animalType_lbl = new System.Windows.Forms.Label();
            this.weight_tb = new System.Windows.Forms.TextBox();
            this.animalType_cb = new System.Windows.Forms.ComboBox();
            this.weight_lbl = new System.Windows.Forms.Label();
            this.animalLocation_lbl = new System.Windows.Forms.Label();
            this.removeAnimal_btn = new System.Windows.Forms.Button();
            this.editAnimal_btn = new System.Windows.Forms.Button();
            this.addAnimal_btn = new System.Windows.Forms.Button();
            this.saveAnimal_btn = new System.Windows.Forms.Button();
            this.viewAllAnimals_dgv = new System.Windows.Forms.DataGridView();
            this.ShowAnimals_btn = new System.Windows.Forms.Button();
            this.DeleteAnimal_btn = new System.Windows.Forms.Button();
            this.Add_animal_btn = new System.Windows.Forms.Button();
            this.Edit_Animal_btn = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.ShowNotesButton_Click = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllAnimals_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAnimalschedule
            // 
            this.BtnAnimalschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.BtnAnimalschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimalschedule.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnimalschedule.ForeColor = System.Drawing.Color.White;
            this.BtnAnimalschedule.Location = new System.Drawing.Point(160, 1427);
            this.BtnAnimalschedule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAnimalschedule.Name = "BtnAnimalschedule";
            this.BtnAnimalschedule.Size = new System.Drawing.Size(373, 73);
            this.BtnAnimalschedule.TabIndex = 32;
            this.BtnAnimalschedule.Text = "Show Animal schedule";
            this.BtnAnimalschedule.UseVisualStyleBackColor = false;
            // 
            // displayAllAnimals_btn
            // 
            this.displayAllAnimals_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.displayAllAnimals_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayAllAnimals_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayAllAnimals_btn.ForeColor = System.Drawing.Color.White;
            this.displayAllAnimals_btn.Location = new System.Drawing.Point(541, 1427);
            this.displayAllAnimals_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.displayAllAnimals_btn.Name = "displayAllAnimals_btn";
            this.displayAllAnimals_btn.Size = new System.Drawing.Size(373, 73);
            this.displayAllAnimals_btn.TabIndex = 31;
            this.displayAllAnimals_btn.Text = "Show all animal";
            this.displayAllAnimals_btn.UseVisualStyleBackColor = false;
            this.displayAllAnimals_btn.Click += new System.EventHandler(this.displayAllAnimals_btn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchlbl);
            this.panel1.Controls.Add(this.name_tb);
            this.panel1.Controls.Add(this.DtpDob);
            this.panel1.Controls.Add(this.animalLocation_cb);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.birthday_lbl);
            this.panel1.Controls.Add(this.animalType_lbl);
            this.panel1.Controls.Add(this.weight_tb);
            this.panel1.Controls.Add(this.animalType_cb);
            this.panel1.Controls.Add(this.weight_lbl);
            this.panel1.Controls.Add(this.animalLocation_lbl);
            this.panel1.Location = new System.Drawing.Point(17, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 552);
            this.panel1.TabIndex = 30;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTextBox.Location = new System.Drawing.Point(23, 486);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(363, 37);
            this.searchTextBox.TabIndex = 23;
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.searchlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchlbl.ForeColor = System.Drawing.Color.White;
            this.searchlbl.Location = new System.Drawing.Point(23, 443);
            this.searchlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(165, 31);
            this.searchlbl.TabIndex = 22;
            this.searchlbl.Text = "Search Animal:";
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_tb.Location = new System.Drawing.Point(23, 52);
            this.name_tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(363, 37);
            this.name_tb.TabIndex = 12;
            // 
            // DtpDob
            // 
            this.DtpDob.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpDob.Location = new System.Drawing.Point(23, 395);
            this.DtpDob.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpDob.Name = "DtpDob";
            this.DtpDob.Size = new System.Drawing.Size(363, 37);
            this.DtpDob.TabIndex = 21;
            // 
            // animalLocation_cb
            // 
            this.animalLocation_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.animalLocation_cb.FormattingEnabled = true;
            this.animalLocation_cb.Location = new System.Drawing.Point(23, 308);
            this.animalLocation_cb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalLocation_cb.Name = "animalLocation_cb";
            this.animalLocation_cb.Size = new System.Drawing.Size(363, 39);
            this.animalLocation_cb.TabIndex = 16;
            this.animalLocation_cb.SelectedIndexChanged += new System.EventHandler(this.animalLocation_cb_SelectedIndexChanged_1);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.name_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_lbl.ForeColor = System.Drawing.Color.White;
            this.name_lbl.Location = new System.Drawing.Point(23, 15);
            this.name_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(80, 31);
            this.name_lbl.TabIndex = 7;
            this.name_lbl.Text = "Name:";
            // 
            // birthday_lbl
            // 
            this.birthday_lbl.AutoSize = true;
            this.birthday_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.birthday_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday_lbl.ForeColor = System.Drawing.Color.White;
            this.birthday_lbl.Location = new System.Drawing.Point(23, 358);
            this.birthday_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthday_lbl.Name = "birthday_lbl";
            this.birthday_lbl.Size = new System.Drawing.Size(147, 31);
            this.birthday_lbl.TabIndex = 11;
            this.birthday_lbl.Text = "Date of Birth:";
            // 
            // animalType_lbl
            // 
            this.animalType_lbl.AutoSize = true;
            this.animalType_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.animalType_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.animalType_lbl.ForeColor = System.Drawing.Color.White;
            this.animalType_lbl.Location = new System.Drawing.Point(23, 100);
            this.animalType_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animalType_lbl.Name = "animalType_lbl";
            this.animalType_lbl.Size = new System.Drawing.Size(145, 31);
            this.animalType_lbl.TabIndex = 8;
            this.animalType_lbl.Text = "Animal Type:";
            // 
            // weight_tb
            // 
            this.weight_tb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight_tb.Location = new System.Drawing.Point(23, 223);
            this.weight_tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.weight_tb.Name = "weight_tb";
            this.weight_tb.Size = new System.Drawing.Size(363, 37);
            this.weight_tb.TabIndex = 13;
            // 
            // animalType_cb
            // 
            this.animalType_cb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.animalType_cb.FormattingEnabled = true;
            this.animalType_cb.Location = new System.Drawing.Point(23, 137);
            this.animalType_cb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.animalType_cb.Name = "animalType_cb";
            this.animalType_cb.Size = new System.Drawing.Size(363, 39);
            this.animalType_cb.TabIndex = 15;
            this.animalType_cb.SelectedIndexChanged += new System.EventHandler(this.animalType_cb_SelectedIndexChanged_1);
            // 
            // weight_lbl
            // 
            this.weight_lbl.AutoSize = true;
            this.weight_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.weight_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight_lbl.ForeColor = System.Drawing.Color.White;
            this.weight_lbl.Location = new System.Drawing.Point(23, 187);
            this.weight_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weight_lbl.Name = "weight_lbl";
            this.weight_lbl.Size = new System.Drawing.Size(92, 31);
            this.weight_lbl.TabIndex = 9;
            this.weight_lbl.Text = "Weight:";
            // 
            // animalLocation_lbl
            // 
            this.animalLocation_lbl.AutoSize = true;
            this.animalLocation_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.animalLocation_lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.animalLocation_lbl.ForeColor = System.Drawing.Color.White;
            this.animalLocation_lbl.Location = new System.Drawing.Point(23, 272);
            this.animalLocation_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.animalLocation_lbl.Name = "animalLocation_lbl";
            this.animalLocation_lbl.Size = new System.Drawing.Size(184, 31);
            this.animalLocation_lbl.TabIndex = 10;
            this.animalLocation_lbl.Text = "Animal Location:";
            // 
            // removeAnimal_btn
            // 
            this.removeAnimal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.removeAnimal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAnimal_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeAnimal_btn.ForeColor = System.Drawing.Color.White;
            this.removeAnimal_btn.Location = new System.Drawing.Point(923, 1427);
            this.removeAnimal_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeAnimal_btn.Name = "removeAnimal_btn";
            this.removeAnimal_btn.Size = new System.Drawing.Size(356, 73);
            this.removeAnimal_btn.TabIndex = 27;
            this.removeAnimal_btn.Text = "Remove Animal";
            this.removeAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // editAnimal_btn
            // 
            this.editAnimal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.editAnimal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editAnimal_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editAnimal_btn.ForeColor = System.Drawing.Color.White;
            this.editAnimal_btn.Location = new System.Drawing.Point(1651, 1427);
            this.editAnimal_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editAnimal_btn.Name = "editAnimal_btn";
            this.editAnimal_btn.Size = new System.Drawing.Size(356, 73);
            this.editAnimal_btn.TabIndex = 28;
            this.editAnimal_btn.Text = "Edit Animal";
            this.editAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // addAnimal_btn
            // 
            this.addAnimal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.addAnimal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAnimal_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addAnimal_btn.ForeColor = System.Drawing.Color.White;
            this.addAnimal_btn.Location = new System.Drawing.Point(1287, 1427);
            this.addAnimal_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addAnimal_btn.Name = "addAnimal_btn";
            this.addAnimal_btn.Size = new System.Drawing.Size(356, 73);
            this.addAnimal_btn.TabIndex = 26;
            this.addAnimal_btn.Text = " Add Animal";
            this.addAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // saveAnimal_btn
            // 
            this.saveAnimal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.saveAnimal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAnimal_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveAnimal_btn.ForeColor = System.Drawing.Color.White;
            this.saveAnimal_btn.Location = new System.Drawing.Point(2016, 1427);
            this.saveAnimal_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveAnimal_btn.Name = "saveAnimal_btn";
            this.saveAnimal_btn.Size = new System.Drawing.Size(356, 73);
            this.saveAnimal_btn.TabIndex = 29;
            this.saveAnimal_btn.Text = "Save";
            this.saveAnimal_btn.UseVisualStyleBackColor = false;
            // 
            // viewAllAnimals_dgv
            // 
            this.viewAllAnimals_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllAnimals_dgv.Location = new System.Drawing.Point(460, 20);
            this.viewAllAnimals_dgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewAllAnimals_dgv.Name = "viewAllAnimals_dgv";
            this.viewAllAnimals_dgv.RowHeadersWidth = 51;
            this.viewAllAnimals_dgv.RowTemplate.Height = 29;
            this.viewAllAnimals_dgv.Size = new System.Drawing.Size(1911, 770);
            this.viewAllAnimals_dgv.TabIndex = 25;
            // 
            // ShowAnimals_btn
            // 
            this.ShowAnimals_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.ShowAnimals_btn.ForeColor = System.Drawing.Color.White;
            this.ShowAnimals_btn.Location = new System.Drawing.Point(460, 831);
            this.ShowAnimals_btn.Name = "ShowAnimals_btn";
            this.ShowAnimals_btn.Size = new System.Drawing.Size(261, 100);
            this.ShowAnimals_btn.TabIndex = 33;
            this.ShowAnimals_btn.Text = "Show all animals";
            this.ShowAnimals_btn.UseVisualStyleBackColor = false;
            this.ShowAnimals_btn.Click += new System.EventHandler(this.ShowAnimals_btn_Click);
            // 
            // DeleteAnimal_btn
            // 
            this.DeleteAnimal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.DeleteAnimal_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteAnimal_btn.Location = new System.Drawing.Point(753, 959);
            this.DeleteAnimal_btn.Name = "DeleteAnimal_btn";
            this.DeleteAnimal_btn.Size = new System.Drawing.Size(261, 100);
            this.DeleteAnimal_btn.TabIndex = 34;
            this.DeleteAnimal_btn.Text = "Delete animal";
            this.DeleteAnimal_btn.UseVisualStyleBackColor = false;
            this.DeleteAnimal_btn.Click += new System.EventHandler(this.DeleteAnimal_btn_Click);
            // 
            // Add_animal_btn
            // 
            this.Add_animal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.Add_animal_btn.ForeColor = System.Drawing.Color.White;
            this.Add_animal_btn.Location = new System.Drawing.Point(753, 831);
            this.Add_animal_btn.Name = "Add_animal_btn";
            this.Add_animal_btn.Size = new System.Drawing.Size(261, 100);
            this.Add_animal_btn.TabIndex = 35;
            this.Add_animal_btn.Text = "Add animal";
            this.Add_animal_btn.UseVisualStyleBackColor = false;
            this.Add_animal_btn.Click += new System.EventHandler(this.Add_animal_btn_Click);
            // 
            // Edit_Animal_btn
            // 
            this.Edit_Animal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.Edit_Animal_btn.ForeColor = System.Drawing.Color.White;
            this.Edit_Animal_btn.Location = new System.Drawing.Point(1058, 822);
            this.Edit_Animal_btn.Name = "Edit_Animal_btn";
            this.Edit_Animal_btn.Size = new System.Drawing.Size(261, 109);
            this.Edit_Animal_btn.TabIndex = 36;
            this.Edit_Animal_btn.Text = "Edit animal";
            this.Edit_Animal_btn.UseVisualStyleBackColor = false;
            this.Edit_Animal_btn.Click += new System.EventHandler(this.Edit_Animal_btn_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(1058, 959);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(261, 100);
            this.searchButton.TabIndex = 37;
            this.searchButton.Text = "Search for animal";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ShowNotesButton_Click
            // 
            this.ShowNotesButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.ShowNotesButton_Click.ForeColor = System.Drawing.Color.White;
            this.ShowNotesButton_Click.Location = new System.Drawing.Point(460, 959);
            this.ShowNotesButton_Click.Name = "ShowNotesButton_Click";
            this.ShowNotesButton_Click.Size = new System.Drawing.Size(261, 100);
            this.ShowNotesButton_Click.TabIndex = 38;
            this.ShowNotesButton_Click.Text = "Show animal notes";
            this.ShowNotesButton_Click.UseVisualStyleBackColor = false;
            this.ShowNotesButton_Click.Click += new System.EventHandler(this.ShowNotesButton_Click_Click);
            // 
            // AnimalCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2277, 1410);
            this.Controls.Add(this.ShowNotesButton_Click);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.Edit_Animal_btn);
            this.Controls.Add(this.Add_animal_btn);
            this.Controls.Add(this.DeleteAnimal_btn);
            this.Controls.Add(this.ShowAnimals_btn);
            this.Controls.Add(this.BtnAnimalschedule);
            this.Controls.Add(this.displayAllAnimals_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.removeAnimal_btn);
            this.Controls.Add(this.editAnimal_btn);
            this.Controls.Add(this.addAnimal_btn);
            this.Controls.Add(this.saveAnimal_btn);
            this.Controls.Add(this.viewAllAnimals_dgv);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnimalCRUD";
            this.Text = "AnimalManagement";
            this.Load += new System.EventHandler(this.AnimalCRUD_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllAnimals_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnAnimalschedule;
        private Button displayAllAnimals_btn;
        private Panel panel1;
        private Label searchlbl;
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
        private Button DisplayAllAnimals_btn;
        private Button ShowAnimals_btn;
        private Button DeleteAnimal_btn;
        private Button Add_animal_btn;
        private Button Edit_Animal_btn;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button ShowNotesButton_Click;
    }
}