using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedFish = Fish.FishType.undefined;
            if (crappieRadioButton.Checked)
            {
                selectedFish = Fish.FishType.crappie;
            }
            else if (perchRadioButton.Checked)
            {
                selectedFish = Fish.FishType.perch;
            }
            else if (walleyeRadioButton.Checked)
            {
                selectedFish = Fish.FishType.walleye;
            }

            FormSeeFish fishForm = new FormSeeFish(selectedFish);
            DialogResult result = fishForm.ShowDialog();
        }
    }
}
