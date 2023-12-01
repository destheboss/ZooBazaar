using BLL.Enums;
using BLL.Managers;
using BLL.Models;
using BLL.Models.AutoSchedule;
using DAL;
using Desktop.Forms.AnimalShiftNeccesities;
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
    public partial class AnimalShiftView : Form
    {
        private readonly Animal animal;
        private readonly AnimalShift shift;
        private readonly DateTime dateofshift;
        private readonly UserControlAnimalHour control;
        private readonly AnimalShiftManager manager = new AnimalShiftManager(new AnimalshiftDataAccess());
        public AnimalShiftView(UserControlAnimalHour controlAnimalHour, Animal animal, DateTime dateofshift, AnimalShift shift = null)
        {
            InitializeComponent();
            control = controlAnimalHour;
            this.animal = animal;
            this.shift = shift;
            this.dateofshift = dateofshift;
            setupbutton();
            setupcmb();
        }
        private void setupcmb()
        {
            CmbShifttype.DataSource = Enum.GetValues(typeof(ANimalshiftStatus));
            CmbWorktype.DataSource = Enum.GetValues(typeof(Animalshiftworktype));
        }
        private void setupbutton()
        {
            if (shift != null)
            {
                BtnCreateShift.Text = "Delete shift";
                CmbShifttype.SelectedIndex = CmbShifttype.FindStringExact(shift.ShiftType.ToString());
                CmbWorktype.SelectedIndex = CmbWorktype.FindStringExact(shift.Caretype.ToString());
            }
        }
        private void BtnCreateShift_Click(object sender, EventArgs e)
        {
            if (shift == null)
            {
                if (CmbShifttype.SelectedItem is null)
                {
                    MessageBox.Show("Please select a type");
                }
                if (CmbWorktype.SelectedItem is null)
                {
                    MessageBox.Show("please Select some Work type");
                }
                AnimalShift shift = new AnimalShift(animal, (ANimalshiftStatus)CmbShifttype.SelectedItem, (Animalshiftworktype)CmbWorktype.SelectedItem, dateofshift);
                manager.CreateShift(shift);
                control.ChangeColour(true, shift);
            }
            else
            {
                manager.DeleteShift(shift);
                control.ChangeColour(false);
            }
            this.Close();
        }
    }
}
