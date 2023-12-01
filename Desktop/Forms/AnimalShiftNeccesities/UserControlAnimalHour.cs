using BLL.Models.AutoSchedule;
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
using BLL.Enums;

namespace Desktop.Forms.AnimalShiftNeccesities
{
    public partial class UserControlAnimalHour : UserControl
    {
        private readonly Animal _animal;
        private AnimalShift _shift;
        private readonly DateTime dateofshift;
        private List<AnimalShift> Shifts;
        public UserControlAnimalHour(Animal animal, DateTime shiftdate, AnimalShift Shift = null)
        {
            this._animal = animal;
            this._shift = Shift;
            Shifts = new List<AnimalShift>();
            dateofshift = shiftdate;
            InitializeComponent();
            setup();
        }
        public UserControlAnimalHour(DateTime shiftdate, List<AnimalShift> shifts)
        {
            dateofshift = shiftdate;
            this.Shifts = shifts;
            InitializeComponent();
            setup();
        }
        private void setup()
        {
            Lbldate.Text = dateofshift.ToString(@"hh:mm");
            if (Shifts.Count > 0)
            {
                BtnOpen.Text = "Total shifts:" + Shifts.Count.ToString();
            }
            else
            {
                if (_shift != null)
                {
                    ChangeColour(true, _shift);
                    BtnOpen.Text = _shift.Caretype.ToString();

                }
            }
        }
        private void UserControlAnimalHour_Click(object sender, EventArgs e)
        {

            AnimalShiftView form;
            if (_shift == null)
            {
                form = new AnimalShiftView(this, _animal, dateofshift);
            }
            else
            {
                form = new AnimalShiftView(this, _animal, dateofshift, _shift);
            }
            form.ShowDialog();
        }
        public void ChangeColour(bool toblue, AnimalShift shift = null)
        {
            if (toblue)
            {

                BtnOpen.BackColor = Color.Blue;
                if (shift != null)
                {
                    BtnOpen.ForeColor = Color.White;
                    this._shift = shift;
                    if (shift.Caretype == Animalshiftworktype.Doctor)
                    {

                        BtnOpen.ForeColor = Color.Black;
                        BtnOpen.BackColor = Color.White;
                    }
                    if (shift.Caretype == Animalshiftworktype.Feeding)
                    {
                        BtnOpen.BackColor = Color.Green;
                    }
                    if (shift.Caretype == Animalshiftworktype.Cleaning)
                    {

                        BtnOpen.BackColor = Color.Gray;
                    }
                    BtnOpen.Text = _shift.Caretype.ToString();
                }
            }
            else
            {
                BtnOpen.BackColor = Color.FromArgb(0, 70, 0);
            }
        }





        private void BtnOpen_Click(object sender, EventArgs e)
        {
            AnimalShiftView form;
            if (_shift == null)
            {
                form = new AnimalShiftView(this, _animal, dateofshift);
            }
            else
            {
                form = new AnimalShiftView(this, _animal, dateofshift, _shift);
            }
            form.ShowDialog();
        }
    }
}
