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
    public partial class CreateStarForm : Form
    {
        Star NewStar = new Star();

        public CreateStarForm()
        {
            InitializeComponent();
        }

        public Star Open()
        {
            ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                return NewStar;
            }

            return null;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public List<Star> Create(string name, string constallation, string stellarMagnitude,
            string distance, string coordinateX, string coordinateY,
            int hour, int minute)
        {
            var result = new List<Star>();
            foreach (var s in result)
            {
                TimeOnly time = new TimeOnly(hour, minute);

                if (s.Name.Contains(name) &&
                    s.Constellation.Contains(constallation) &&
                    s.StellarMagnitude.ToString().Contains(stellarMagnitude) &&
                    s.Distance.ToString().Contains(distance) 
                    && s.CoordinateX.ToString().Contains(coordinateX)
                    && s.CoordinateY.ToString().Contains(coordinateY)
                    && (s.StartTime < s.EndTime && time >= s.StartTime
                    && time <= s.EndTime || 
                    s.StartTime >= s.EndTime && time <= s.EndTime))
                {
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
