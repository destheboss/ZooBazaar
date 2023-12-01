using BLL.Managers;
using BLL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Forms
{
    public partial class AnimalCRUD : Form
    {
        private Animal Animal;
        private AnimalType animalType;
        private AnimalLocation location;
        private AnimalManager animalManager = new AnimalManager(new AnimalDataAccess());
        private List<Animal> AnimalList;

        private readonly AnimalTypeManager animalTypeManager = new AnimalTypeManager(new AnimalTypeDataAccess());
        private readonly LocationManager locationManager = new LocationManager(new LocationDataAccess());


        public AnimalCRUD()
        {
            InitializeComponent();
        }

        public AnimalCRUD(Animal animal)
        {
            InitializeComponent();
            Animal = animal;
            AnimalList = animalManager.GetAllAnimals();
        }

        private void AnimalCRUD_Load(object sender, EventArgs e)
        {
            DisplayAllAnimals();
            PopulateAnimalTypeComboBox();
            PopulateAnimalLocationComboBox();
            //PopulateAnimalStatusComboBox();

        }

        private void ResetAnimalField()
        {
            name_tb.Text = " ";
            animalType_cb.Text = " ";
            weight_tb.Text = " ";
            animalLocation_cb.Text = " ";
            DtpDob.Value = DateTime.Now;
            animalStatus_cb.SelectedIndex = -1;
        }

        private void DisplayAllAnimals()
        {
            AnimalManager animalManager = new AnimalManager(new AnimalDataAccess());
            viewAllAnimals_dgv.Rows.Clear();
            viewAllAnimals_dgv.Columns.Clear();
            List<Animal> animals = animalManager.GetAllAnimals();
            viewAllAnimals_dgv.Columns.Add("id", "ID");
            viewAllAnimals_dgv.Columns.Add("Name", "Name");
            viewAllAnimals_dgv.Columns.Add("Type", "Type");
            viewAllAnimals_dgv.Columns.Add("Weight", "Weight");
            viewAllAnimals_dgv.Columns.Add("Location", "Location");
            viewAllAnimals_dgv.Columns.Add("DateOfBirth", "Date of Birth");
            viewAllAnimals_dgv.Columns.Add("AnimalStatus", "Animal Status");
            foreach (Animal animal in animals)
            {

                int rowIndex = viewAllAnimals_dgv.Rows.Add();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Id"].Value = animal.Id;
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Name"].Value = animal.AnimalName;
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Type"].Value = animal.AnimalType.GetName();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Weight"].Value = animal.AnimalWeight.ToString();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Location"].Value = animal.AnimalLocation.GetName();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["DateOfBirth"].Value = animal.DateOfBirth.ToShortDateString();
                //viewAllAnimals_dgv.Rows[rowIndex].Cells["AnimalStatus"].Value = animal.AnimalStatus.ToString();
            }
        }

        private void DisplayAliveAnimal()
        {
            AnimalManager animalManager = new AnimalManager(new AnimalDataAccess());
            viewAllAnimals_dgv.Rows.Clear();
            viewAllAnimals_dgv.Columns.Clear();
            List<Animal> animals = animalManager.GetAllAliveAnimals();
            viewAllAnimals_dgv.Columns.Add("id", "ID");
            viewAllAnimals_dgv.Columns.Add("Name", "Name");
            viewAllAnimals_dgv.Columns.Add("Type", "Type");
            viewAllAnimals_dgv.Columns.Add("Weight", "Weight");
            viewAllAnimals_dgv.Columns.Add("Location", "Location");
            viewAllAnimals_dgv.Columns.Add("DateOfBirth", "Date of Birth");
            viewAllAnimals_dgv.Columns.Add("AnimalStatus", "Animal Status");
            foreach (Animal animal in animals)
            {

                int rowIndex = viewAllAnimals_dgv.Rows.Add();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Id"].Value = animal.Id;
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Name"].Value = animal.AnimalName;
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Type"].Value = animal.AnimalType.GetName();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Weight"].Value = animal.AnimalWeight.ToString();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["Location"].Value = animal.AnimalLocation.GetName();
                viewAllAnimals_dgv.Rows[rowIndex].Cells["DateOfBirth"].Value = animal.DateOfBirth.ToShortDateString();
                //viewAllAnimals_dgv.Rows[rowIndex].Cells["AnimalStatus"].Value = animal.AnimalStatus.ToString();
            }
        }

        private void PopulateAnimalTypeComboBox()
        {
            List<AnimalType> animalTypes = animalTypeManager.GetAnimalSubTypes();

            foreach (AnimalType type in animalTypes)
            {
                animalType_cb.Items.Add(type);
            }
        }

        private void PopulateAnimalLocationComboBox()
        {
            List<AnimalLocation> locations = locationManager.GetAnimalSubLocation();

            foreach (AnimalLocation location in locations)
            {
                animalLocation_cb.Items.Add(location);
            }
        }

        //private void PopulateAnimalStatusComboBox()
        //{
        //    BindingList<AnimalStatus> Status = new BindingList<AnimalStatus>();
        //    animalStatus_cb.Items.Clear();
        //    foreach (var status in Enum.GetValues(typeof(AnimalStatus)))
        //    {
        //        animalStatus_cb.Items.Add(status);
        //    }
        //}

        private void animalType_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAnimalTypeComboBox();
        }

        private void animalLocation_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAnimalLocationComboBox();
        }

        private void displayAllAnimals_btn_Click(object sender, EventArgs e)
        {
            DisplayAllAnimals();
        }

        private void saveAnimal_btn_Click_1(object sender, EventArgs e)
        {
            if (viewAllAnimals_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to edit.");
                return;
            }

            try
            {
                int animalId = Convert.ToInt32(viewAllAnimals_dgv.SelectedRows[0].Cells["Id"].Value);

                var animal = new Animal(animalId, name_tb.Text, DtpDob.Value, Convert.ToDecimal(weight_tb.Text),
                                        (AnimalType)animalType_cb.SelectedItem, (AnimalLocation)animalLocation_cb.SelectedItem)
                                        /*(AnimalStatus)animalStatus_cb.SelectedItem)*/;

                var animalManager = new AnimalManager(new AnimalDataAccess());
                var result = animalManager.UpdateAnimal(animal);

                if (!result)
                {
                    MessageBox.Show("Failed to update animal information.");
                }
                else
                {
                    DisplayAliveAnimal();
                    ResetAnimalField();
                    saveAnimal_btn.Hide();
                    addAnimal_btn.Show();
                    removeAnimal_btn.Show();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid weight.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeAnimal_btn_Click_1(object sender, EventArgs e)
        {
            if (viewAllAnimals_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = viewAllAnimals_dgv.SelectedRows[0];
                int animalId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string animalName = Convert.ToString(selectedRow.Cells["Name"].Value);
                AnimalManager animalManager = new AnimalManager(new AnimalDataAccess());

                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to remove animal with Name: {animalName}?", "Confirm Deletion",
                    MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool result = animalManager.RemoveAnimal(new Animal(animalId));

                    if (result)
                    {
                        MessageBox.Show("Animal removed successfully.");
                        DisplayAliveAnimal();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove animal.");
                    }
                }
            }
        }

        private void editAnimal_btn_Click_1(object sender, EventArgs e)
        {
            if (viewAllAnimals_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = viewAllAnimals_dgv.SelectedRows[0];

                name_tb.Text = selectedRow.Cells["Name"].Value.ToString();
                animalType_cb.SelectedIndex = animalType_cb.FindStringExact(selectedRow.Cells["Type"].Value.ToString());
                weight_tb.Text = selectedRow.Cells["Weight"].Value.ToString();
                animalLocation_cb.SelectedIndex = animalLocation_cb.FindStringExact(selectedRow.Cells["Location"].Value.ToString());
                DtpDob.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                //animalStatus_cb.SelectedIndex = animalStatus_cb.FindStringExact(selectedRow.Cells["AnimalStatus"].Value.ToString());

                addAnimal_btn.Hide();
                removeAnimal_btn.Hide();
                saveAnimal_btn.Show();
            }
            else
            {
                MessageBox.Show("Please select an animal to edit.");
            }
        }

        private void addAnimal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string animalName = name_tb.Text;
                DateTime dateOfBirth = DtpDob.Value;
                decimal animalWeight = Convert.ToDecimal(weight_tb.Text);
                AnimalType animalType = (AnimalType)animalType_cb.SelectedItem;
                AnimalLocation animalLocation = (AnimalLocation)animalLocation_cb.SelectedItem;
                //AnimalStatus animalStatus = (AnimalStatus)animalStatus_cb.SelectedItem;

                Animal animal = new Animal(0, animalName, dateOfBirth, animalWeight, animalType, animalLocation/*, animalStatus*/);

                bool isAdded = animalManager.AddAnimal(animal);

                if (isAdded)
                {
                    List<Animal> allAnimals = animalManager.GetAllAnimals();
                }
                else
                {
                    MessageBox.Show("Error occurred while adding animal.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetAnimalField();
            DisplayAliveAnimal();
        }



        private void BtnAnimalschedule_Click(object sender, EventArgs e)
        {
            if (viewAllAnimals_dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = viewAllAnimals_dgv.SelectedRows[0];
                int animalId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                AnimalShiftForm animalShiftForm = new AnimalShiftForm(new Animal() { Id = animalId });
                animalShiftForm.Show();
            }
        }


        //private void BtnAnimalschedule_Click(object sender, EventArgs e)
        //{
        //    if (viewAllAnimals_dgv.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = viewAllAnimals_dgv.SelectedRows[0];
        //        int animalId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

        //        AnimalShiftForm animalShiftForm = new AnimalShiftForm(new Animal() { Id = animalId });
        //        animalShiftForm.Show();
        //    }
        //}
    }
}
