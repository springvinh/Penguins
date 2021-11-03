using LOTO.Controllers;
using LOTO.Controllers.Random;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LOTO
{
    public partial class Main : Form
    {

        Random random = new Random();
        RandomController randomController = new RandomController();

        public Main()
        {
            InitializeComponent();
            labelEmployeeId.Text = random.Next(100000, 1000000).ToString();

            dataGridViewEmployees.DataSource = randomController.sourceEmployees;
            dataGridViewBingoEmployees.DataSource = randomController.sourceSelected;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripComboBoxPrizes.ComboBox.SelectedIndex = 0;
        }

        private void importEmployee_Click(object sender, EventArgs e)
        {
            randomController.LoadEmployeeFromFile();
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerRandom.Enabled = !timerRandom.Enabled;
            randomToolStripMenuItem.Text = randomToolStripMenuItem.Text == "Quay" ? "Dừng" : "Quay";

            if (!timerRandom.Enabled)
            {

                string id = randomController.GetRandomEmployee(toolStripComboBoxPrizes.ComboBox.SelectedItem.ToString());

                if (id != null)
                {
                    labelEmployeeId.Text = id;
                }

            }
        }

        private void Main_Activated(object sender, EventArgs e)
        {
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomController.ExportToExcel();
        }

        private void timerRandom_Tick(object sender, EventArgs e)
        {
            labelEmployeeId.Text = random.Next(100000, 1000000).ToString();
        }
    }
}
