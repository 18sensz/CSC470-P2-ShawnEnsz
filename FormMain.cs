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
    public partial class FormMain : Form
    {
        public FormMain()
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

        private void buttonSeeFish_Click(object sender, EventArgs e)
        {
            var selectedFish = Fish.Undefined;
            if (crappieRadioButton.Checked)
            {
                selectedFish = Fish.Crappie;
            }
            else if (perchRadioButton.Checked)
            {
                selectedFish = Fish.Perch;
            }
            else if (walleyeRadioButton.Checked)
            {
                selectedFish = Fish.Walleye;
            }

            FormSeeFish fishForm = new FormSeeFish(selectedFish);
            DialogResult result = fishForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                switch (fishForm._fishDecision)
                {
                    case "throw":
                        MessageBox.Show("Decision is to Throw it back!");
                        break;
                    case "keep":
                        MessageBox.Show("Decision is to Keep it!");
                        break;
                    default:
                        MessageBox.Show("Invalid Decision!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Decision was canceled!");
            }
        }
    }
}
