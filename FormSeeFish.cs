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

        public Fish.FishType _selectedFish;
        public FormSeeFish(Fish.FishType selectedFish)
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
                case Fish.FishType.crappie:
                    pictureBox1.Image = Properties.Resources.Crappie;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case Fish.FishType.perch:
                    pictureBox1.Image = Properties.Resources.Perch;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case Fish.FishType.walleye:
                    pictureBox1.Image = Properties.Resources.Walleye;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;     
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
