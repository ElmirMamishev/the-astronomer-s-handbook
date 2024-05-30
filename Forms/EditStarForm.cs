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

        public EditStarForm(Star? star = null)
        {
            InitializeComponent();
            this.CurrentStar = star ?? new Star();

            nameEditBox.DataBindings.Add("Text", CurrentStar, "Name");
            constellationEditBox.DataBindings.Add("Text", CurrentStar, "Constellation");
            stellarEditBox.DataBindings.Add("Text", CurrentStar, "StellarMagnitude");
            distanceEditBox.DataBindings.Add("Text", CurrentStar, "Distance");
            coordinateEditBox1.DataBindings.Add("Text", CurrentStar, "CoordinateX");
            coordinateEditBox2.DataBindings.Add("Text", CurrentStar, "CoordinateY");
            hoursStartEditNumericUpDown.DataBindings.Add("Text", CurrentStar, "StartHour");
            minuteStartEditNumericUpDown.DataBindings.Add("Text", CurrentStar, "StartMinute");
            hoursEndEditNumericUpDown.DataBindings.Add("Text", CurrentStar, "EndHour");
            minuteEndtEditNumericUpDown.DataBindings.Add("Text", CurrentStar, "EndMinute"); ;
        }

        private void nameEditBox_Validating(object sender, CancelEventArgs e)
        {
            if (nameEditBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Назва не може бути пустою.");
                e.Cancel = true;
            }
        }

        private void distanceEditBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(distanceEditBox.Text, out double distance);
            if (distance < 0)
            {
                MessageBox.Show("Відстань має бути числом більше 0.");
                e.Cancel = true;
            }
            if (!isNumber)
            {
                MessageBox.Show("Відстань має бути числом");
                e.Cancel = true;
            }
        }

        private void stellarEditBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = float.TryParse(stellarEditBox.Text, out float magnitude);
            if (!isNumber)
            {
                MessageBox.Show("Зоряна величина має бути числом.");
                e.Cancel = true;
            }
        }
        private void coordinateEditBox1_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = float.TryParse(coordinateEditBox1.Text, out float coordinateX);
            {
                if (!isNumber)
                {
                    MessageBox.Show("Координата 'X' має бути числом.");
                    e.Cancel = true;
                }
            }
        }

        private void coordinateEditBox2_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = float.TryParse(coordinateEditBox2.Text, out float coordinateY);
            {
                if (!isNumber)
                {
                    MessageBox.Show("Координата 'Y' має бути числом.");
                    e.Cancel = true;
                }
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
