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
            coordinateEditHBox.DataBindings.Add("Text", CurrentStar, "CoordinateH");
            coordinateEditMBox.DataBindings.Add("Text", CurrentStar, "CoordinateM");
            coordinateEditSBox.DataBindings.Add("Text", CurrentStar, "CoordinateS");
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
            }
        }

        private void distanceEditBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = double.TryParse(distanceEditBox.Text, out double distance);
            if (distance < 0)
            {
                MessageBox.Show("Відстань має бути числом більше 0.");
            }
            if (!isNumber)
            {
                MessageBox.Show("Відстань має бути числом");
            }
        }

        private void stellarEditBox_Validating(object sender, CancelEventArgs e)
        {
            string input = stellarEditBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!float.TryParse(input, out _))
                {
                    MessageBox.Show("Зоряна величина має бути числом.");
                }
            }
        }
        private void coordinateEditBox1_Validating(object sender, CancelEventArgs e)
        {
            string input = coordinateEditBox1.Text.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!float.TryParse(input, out _))
                {
                    MessageBox.Show("Довогота має бути числом.");
                    e.Cancel = true;
                }
            }
        }

        private void coordinateEditBox2_Validating(object sender, CancelEventArgs e)
        {
            string input = coordinateEditBox2.Text.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!float.TryParse(input, out _))
                {
                    MessageBox.Show("Широта має бути числом.");
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

        private void coordinateEditHBox_Validating(object sender, CancelEventArgs e)
        {
            string input = coordinateEditHBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!float.TryParse(input, out _))
                {
                    MessageBox.Show("Координата '°' має бути числом.");
                }
            }
        }

        private void coordinateEditMBox_Validating(object sender, CancelEventArgs e)
        {
            string input = coordinateEditMBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!float.TryParse(input, out _))
                {
                    MessageBox.Show("Координата '′' має бути числом.");
                }
            }
        }

        private void coordinateEditSBox_Validating(object sender, CancelEventArgs e)
        {
            string input = coordinateEditSBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (!float.TryParse(input, out _))
                {
                    MessageBox.Show("Координата '″' має бути числом.");
                }
            }
        }
    }
}
