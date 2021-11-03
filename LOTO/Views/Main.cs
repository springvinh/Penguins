using LOTO.Controllers.Random;
using System;
using System.Windows.Forms;

namespace LOTO
{
    public partial class Main : Form
    {


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripComboBoxPrizes.ComboBox.SelectedIndex = 0;
        }

        private void importEmployee_Click(object sender, EventArgs e)
        {
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {   

        }

        private void Main_Activated(object sender, EventArgs e)
        {
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timerRandom_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
