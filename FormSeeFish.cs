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
    public partial class FormSeeFish : Form
    {

        private Fish _selectedFish;
        public string _fishDecision;
        public FormSeeFish(Fish selectedFish)
        {
            InitializeComponent();
            _selectedFish = selectedFish;
        }

        private void FormSeeFish_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //Show correct image
            switch (_selectedFish)
            {
                case Fish.Crappie:
                    fishPictureBox.Image = Properties.Resources.Crappie;
                    fishPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case Fish.Perch:
                    fishPictureBox.Image = Properties.Resources.Perch;
                    fishPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case Fish.Walleye:
                    fishPictureBox.Image = Properties.Resources.Walleye;
                    fishPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;     
            }
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonThrowItBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _fishDecision = "throw";
            this.Close();
        }

        private void buttonKeepIt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            _fishDecision = "keep";
            this.Close();
        }
    }
}
