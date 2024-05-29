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
    public partial class StarEditForm : Form
    {
        readonly Star star = new Star();
        public StarEditForm(Star star)
        {
            InitializeComponent();

            this.star = star;
            nameBoxEdit.Text = star.Name.ToString();
            constellationBoxEdit.Text = star.Constellation.ToString();
            stellarBoxEdit.Text = star.StellarMagnitude.ToString();
            distanceBoxEdit.Text = star.Distance.ToString();
            coordinateBoxEdit.Text = star.Coordinate.ToString();
        }

        private void okButtonEdit_Click(object sender, EventArgs e)
        {
            star.Constellation = constellationBoxEdit.Text;
            star.StellarMagnitude = Convert.ToInt32(stellarBoxEdit.Text);
            star.Distance = Convert.ToInt32(distanceBoxEdit.Text);
            star.Coordinate = coordinateBoxEdit.Text;
        }

        private void nameBoxEdit_Validating(object sender, CancelEventArgs e)
        {
            if (nameBoxEdit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Name can't be empty.");
                e.Cancel = true;
            }
        }

        private void distanceBoxEdit_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(distanceBoxEdit.Text, out int distance);
            if (!isNumber || distance < 0)
            {
                MessageBox.Show("Distance must be a number more then 0");
                e.Cancel = true;
            }
        }
    }
}
