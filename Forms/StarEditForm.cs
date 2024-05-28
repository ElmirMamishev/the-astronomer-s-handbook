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
    }
}
