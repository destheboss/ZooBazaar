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
            panel1 = new Panel();
            searchTextBox = new TextBox();
            searchlbl = new Label();
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
            saveAnimal_btn = new Button();
            viewAllAnimals_dgv = new DataGridView();
            ShowAnimals_btn = new Button();
            DeleteAnimal_btn = new Button();
            Add_animal_btn = new Button();
            Edit_Animal_btn = new Button();
            searchButton = new Button();
            ShowNotesButton_Click = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)viewAllAnimals_dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 0);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchlbl);
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
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(16, 292);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(255, 27);
            searchTextBox.TabIndex = 23;
            // 
            // searchlbl
            // 
            searchlbl.AutoSize = true;
            searchlbl.BackColor = Color.FromArgb(0, 70, 0);
            searchlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchlbl.ForeColor = Color.White;
            searchlbl.Location = new Point(16, 266);
            searchlbl.Name = "searchlbl";
            searchlbl.Size = new Size(107, 20);
            searchlbl.TabIndex = 22;
            searchlbl.Text = "Search Animal:";
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
            animalLocation_cb.SelectedIndexChanged += animalLocation_cb_SelectedIndexChanged_1;
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
            animalType_cb.SelectedIndexChanged += animalType_cb_SelectedIndexChanged_1;
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
            // saveAnimal_btn
            // 
            saveAnimal_btn.BackColor = Color.FromArgb(0, 70, 0);
            saveAnimal_btn.FlatStyle = FlatStyle.Flat;
            saveAnimal_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveAnimal_btn.ForeColor = Color.White;
            saveAnimal_btn.Location = new Point(848, 817);
            saveAnimal_btn.Margin = new Padding(3, 2, 3, 2);
            saveAnimal_btn.Name = "saveAnimal_btn";
            saveAnimal_btn.Size = new Size(362, 83);
            saveAnimal_btn.TabIndex = 29;
            saveAnimal_btn.Text = "Save";
            saveAnimal_btn.UseVisualStyleBackColor = false;
            saveAnimal_btn.Click += saveAnimal_btn_Click;
            // 
            // viewAllAnimals_dgv
            // 
            viewAllAnimals_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewAllAnimals_dgv.Location = new Point(322, 12);
            viewAllAnimals_dgv.Margin = new Padding(3, 2, 3, 2);
            viewAllAnimals_dgv.Name = "viewAllAnimals_dgv";
            viewAllAnimals_dgv.RowHeadersWidth = 51;
            viewAllAnimals_dgv.RowTemplate.Height = 29;
            viewAllAnimals_dgv.Size = new Size(1338, 462);
            viewAllAnimals_dgv.TabIndex = 25;
            // 
            // ShowAnimals_btn
            // 
            ShowAnimals_btn.BackColor = Color.FromArgb(0, 70, 0);
            ShowAnimals_btn.ForeColor = Color.White;
            ShowAnimals_btn.Location = new Point(655, 579);
            ShowAnimals_btn.Margin = new Padding(2);
            ShowAnimals_btn.Name = "ShowAnimals_btn";
            ShowAnimals_btn.Size = new Size(214, 78);
            ShowAnimals_btn.TabIndex = 33;
            ShowAnimals_btn.Text = "Show all animals";
            ShowAnimals_btn.UseVisualStyleBackColor = false;
            ShowAnimals_btn.Click += ShowAnimals_btn_Click;
            // 
            // DeleteAnimal_btn
            // 
            DeleteAnimal_btn.BackColor = Color.FromArgb(0, 70, 0);
            DeleteAnimal_btn.ForeColor = Color.White;
            DeleteAnimal_btn.Location = new Point(913, 690);
            DeleteAnimal_btn.Margin = new Padding(2);
            DeleteAnimal_btn.Name = "DeleteAnimal_btn";
            DeleteAnimal_btn.Size = new Size(226, 73);
            DeleteAnimal_btn.TabIndex = 34;
            DeleteAnimal_btn.Text = "Delete animal";
            DeleteAnimal_btn.UseVisualStyleBackColor = false;
            DeleteAnimal_btn.Click += DeleteAnimal_btn_Click;
            // 
            // Add_animal_btn
            // 
            Add_animal_btn.BackColor = Color.FromArgb(0, 70, 0);
            Add_animal_btn.ForeColor = Color.White;
            Add_animal_btn.Location = new Point(913, 579);
            Add_animal_btn.Margin = new Padding(2);
            Add_animal_btn.Name = "Add_animal_btn";
            Add_animal_btn.Size = new Size(226, 78);
            Add_animal_btn.TabIndex = 35;
            Add_animal_btn.Text = "Add animal";
            Add_animal_btn.UseVisualStyleBackColor = false;
            Add_animal_btn.Click += Add_animal_btn_Click;
            // 
            // Edit_Animal_btn
            // 
            Edit_Animal_btn.BackColor = Color.FromArgb(0, 70, 0);
            Edit_Animal_btn.ForeColor = Color.White;
            Edit_Animal_btn.Location = new Point(1184, 579);
            Edit_Animal_btn.Margin = new Padding(2);
            Edit_Animal_btn.Name = "Edit_Animal_btn";
            Edit_Animal_btn.Size = new Size(223, 78);
            Edit_Animal_btn.TabIndex = 36;
            Edit_Animal_btn.Text = " Edit Animal";
            Edit_Animal_btn.UseVisualStyleBackColor = false;
            Edit_Animal_btn.Click += Edit_Animal_btn_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(0, 70, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1184, 690);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(223, 73);
            searchButton.TabIndex = 37;
            searchButton.Text = "Search for animal";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // ShowNotesButton_Click
            // 
            ShowNotesButton_Click.BackColor = Color.FromArgb(0, 70, 0);
            ShowNotesButton_Click.ForeColor = Color.White;
            ShowNotesButton_Click.Location = new Point(655, 690);
            ShowNotesButton_Click.Margin = new Padding(2);
            ShowNotesButton_Click.Name = "ShowNotesButton_Click";
            ShowNotesButton_Click.Size = new Size(214, 73);
            ShowNotesButton_Click.TabIndex = 38;
            ShowNotesButton_Click.Text = "Show animal notes";
            ShowNotesButton_Click.UseVisualStyleBackColor = false;
            ShowNotesButton_Click.Click += ShowNotesButton_Click_Click;
            // 
            // AnimalCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1693, 955);
            Controls.Add(ShowNotesButton_Click);
            Controls.Add(searchButton);
            Controls.Add(Edit_Animal_btn);
            Controls.Add(Add_animal_btn);
            Controls.Add(DeleteAnimal_btn);
            Controls.Add(ShowAnimals_btn);
            Controls.Add(panel1);
            Controls.Add(saveAnimal_btn);
            Controls.Add(viewAllAnimals_dgv);
            Name = "AnimalCRUD";
            Text = "AnimalManagement";
            Load += AnimalCRUD_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)viewAllAnimals_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
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