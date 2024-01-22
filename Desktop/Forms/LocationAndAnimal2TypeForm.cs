using BLL.Managers;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace ZooBazaar
{
    public partial class LocationAndAnimalTypeForm : Form
    {
		List<AnimalLocation> parentLocations = new List<AnimalLocation>();
		List<AnimalType> parentTypes = new List<AnimalType>();

        private LocationManager Lm = new LocationManager(new LocationDataAccess());
        private AnimalTypeManager Atm = new AnimalTypeManager(new AnimalTypeDataAccess());
		public LocationAndAnimalTypeForm()
        {
            InitializeComponent();
        }

        private void LocationAndAnimalTypeForm_Load(object sender, EventArgs e)
        {
			panel2.Hide();
			panel4.Hide();
			label2.Hide();
			cbMainLocation.Hide();
			label1.Hide();
			cbMainType.Hide();
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
           
        }

        private void chbSubLocation_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chbSubType_CheckedChanged(object sender, EventArgs e)
        {
			label1.Show();
			cbMainType.Show();
			panel4.Show();

			var types = Atm.GetAnimalTypes();

			foreach (var type in types)
			{
				if (type.GetParentID() == null)
				{
					parentTypes.Add(type);
					cbMainType.Items.Add(type.GetName());
				}
			}
		}

        private void btnAddType_Click(object sender, EventArgs e)
        {
			string typeName;
			int parentId;
			bool isSubType;


			if (chbSubType.Checked == false)
			{
				typeName = tbAnimalType.Text;
				Atm.AddParentTypeToDB(typeName);
			}
			else
			{
				var type = parentTypes[cbMainType.SelectedIndex];
				int? parentID = type.GetID();
				typeName = tbAnimalType.Text;
				Atm.AddChildTypeToDB(typeName, parentID);
			}
		}

        private void btnRefreshLocation_Click(object sender, EventArgs e)
        {
        }

        private void btnRefreshType_Click(object sender, EventArgs e)
        {
			dataGridView2.DataSource = Atm.LoadTypes().DefaultView;
		}

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblLocationName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    int id = Convert.ToInt16(selectedRow.Cells["Id"].Value);

                    // Check if there are any animals associated with the type
                    if (!Atm.AreAnimalsOfTypeExist(id))
                    {
                        Atm.RemoveTypeFromDB(id);

                        // Refresh data after deletion
                        dataGridView2.DataSource = Atm.LoadTypes().DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete type. There are animals associated with this type.");
                    }
                }
                catch (Exception ex)
                {
                    // Log the error or handle it appropriately
                    Console.WriteLine($"Error deleting type: {ex.Message}");
                    MessageBox.Show("An error occurred while deleting the type. Please check the logs for details.");
                }
            }
        }

        private void cbMainType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteLocation_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt16(selectedRow.Cells["Id"].Value);

                    // Check if there are any child locations
                    if (Lm.AreChildLocationsExist(id))
                    {
                        MessageBox.Show("Cannot delete location. There are child locations associated with this location.");
                    }
                    else if (!Lm.AreAnimalsInLocationExist(id))
                    {
                        Lm.RemoveLocationFromDB(id);
                        dataGridView1.DataSource = Lm.LoadLocations().DefaultView;
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete location. There are animals associated with this location.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting location: {ex.Message}");
                }
            }
        }

        private void btnRefreshLocation_Click_1(object sender, EventArgs e)
        {
			dataGridView1.DataSource = Lm.LoadLocations().DefaultView;
		}

        private void btnAddLocation_Click_1(object sender, EventArgs e)
        {
			string locationName;
			int parentId;
			bool isSubLocation;


			if (chbSubLocation.Checked == false)
			{
				locationName = tbLocationName.Text;
				Lm.AddParentLocationToDB(locationName);
			}
			else
			{
				var loc = parentLocations[cbMainLocation.SelectedIndex];
				int? parentID = loc.GetID();
				locationName = tbLocationName.Text;
				Lm.AddChildLocationToDB(locationName, parentID);
			}
		}

        private void chbSubLocation_CheckedChanged_1(object sender, EventArgs e)
        {
			label2.Show();
			cbMainLocation.Show();
			panel2.Show();

			var locations = Lm.GetLocations();

			foreach (var location in locations)
			{
				if (location.GetParentID() == null)
				{
					parentLocations.Add(location);
					cbMainLocation.Items.Add(location.GetName());
				}
			}
		}
    }
}
