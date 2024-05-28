using StarBook.Forms;
using StarBook.Models;

namespace StarBook
{
    public partial class MainForm : Form
    {
        Library library = new Library();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = library.Search(nameBox.Text, constellationBox.Text, stellarBox.Text, distanceBox.Text, coordinateBox.Text);
            starBindingSource.DataSource = result;
        }

        private void resultBox_DoubleClick(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                Star star = resultList.SelectedItem as Star;
                var starEditForm = new StarEditForm(star);
                if (starEditForm.ShowDialog() == DialogResult.OK)
                {
                    searchButton_Click(null, null);
                }
            };
        }

        private void resultList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}