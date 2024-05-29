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
        readonly Star star = new Star();
        public EditStarForm(Star star)
        {
            InitializeComponent();

            this.star = star;
            nameEditBox.Text = star.Name.ToString();
            constellationEditBox.Text = star.Constellation.ToString();
            stellarEditBox.Text = star.StellarMagnitude.ToString();
            distanceEditBox.Text = star.Distance.ToString();
            coordinateEditBox1.Text = star.CoordinateX.ToString();
            coordinateEditBox2.Text = star.CoordinateY.ToString();
            hoursEditNumericUpDown.Text = star.StartTime.Hour.ToString();
            minuteEditNumericUpDown.Text = star.StartTime.Minute.ToString();
        }

        private void okButtonEdit_Click(object sender, EventArgs e)
        {
            star.Name = nameEditBox.Text;
            star.Constellation = constellationEditBox.Text;
            star.StellarMagnitude = Convert.ToInt32(stellarEditBox.Text);
            star.Distance = Convert.ToInt32(distanceEditBox.Text);
            star.CoordinateX = Convert.ToInt32(coordinateEditBox1.Text);
            star.CoordinateY = Convert.ToInt32(coordinateEditBox2.Text);
            star.StartTime =  new TimeOnly ((int)hoursEditNumericUpDown.Value);
            star.StartTime = new TimeOnly((int)minuteEditNumericUpDown.Value);
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
    }
}
