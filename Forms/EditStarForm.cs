using StarBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarBook.Forms
{
    public partial class EditStarForm : Form
    {
        readonly Star CurrentStar;

        public EditStarForm(Star star = null)
        {
            InitializeComponent();
            this.CurrentStar = star ?? new Star();

            nameEditBox.DataBindings.Add("Text", CurrentStar, "Name");
            constellationEditBox.DataBindings.Add("Text", CurrentStar, "Constellation");
            stellarEditBox.DataBindings.Add("Text", CurrentStar, "StellarMagnitude");
            distanceEditBox.DataBindings.Add("Text", CurrentStar, "Distance");
            coordinateEditBox1.DataBindings.Add("Text", CurrentStar, "CoordinateX");
            coordinateEditBox2.DataBindings.Add("Text", CurrentStar, "CoordinateY");
            hoursEditNumericUpDown.DataBindings.Add("Text", CurrentStar, "StartHour");
            minuteEditNumericUpDown.DataBindings.Add("Text", CurrentStar, "StartMinute");
        }

        private void nameBoxEdit_Validating(object sender, CancelEventArgs e)
        {
            if (nameEditBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name can't be empty.");
                e.Cancel = true;
            }
        }

        private void distanceBoxEdit_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(distanceEditBox.Text, out int distance);
            if (!isNumber || distance < 0)
            {
                MessageBox.Show("Distance must be a number more then 0");
                e.Cancel = true;
            }
        }

        private void stellarBoxEdit_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(stellarEditBox.Text, out int magnitude);
            if (!isNumber || magnitude < 0)
            {
                MessageBox.Show("Stellar magnitude must be a number more then 0");
                e.Cancel = true;
            }
        }

        public Star Open()
        {
            ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                return CurrentStar;
            }

            return null;
        }
    }
}
