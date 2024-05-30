using StarBook.Forms;
using StarBook.Manager;
using StarBook.Models;

namespace StarBook
{
    public partial class MainForm : Form
    {
        Library library = new Library();

        Librarian librarian = new Librarian();
        public MainForm()
        {
            InitializeComponent();
            library = librarian.LoadData(PATH_TO_DATA);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resultBox_DoubleClick(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                Star? star = resultList?.SelectedItem as Star;
                var starEditForm = new EditStarForm(star);
                starEditForm.Open();
                Search();
            };
        }
        const string PATH_TO_DATA = ".\\library.txt";

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            librarian.SaveData(library, PATH_TO_DATA);
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            library = librarian.LoadData(PATH_TO_DATA);
        }

        private void searchButton_Click_2(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var result = library.Search(nameBox.Text, constellationBox.Text,
               stellarBox.Text, distanceBox.Text, coordinateBox1.Text,
               coordinateBox2.Text, (int)hoursNumericUpDown.Value,
               (int)minuteNumericUpDown.Value);
            starBindingSource.DataSource = result;
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var starEditForm = new EditStarForm();
            var newStar = starEditForm.Open();
            library.AddStar(newStar);
            Search();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var starEditForm = new EditStarForm();
            var newStar = starEditForm.Open();
            library.AddStar(newStar);
            Search();
        }
    }

}