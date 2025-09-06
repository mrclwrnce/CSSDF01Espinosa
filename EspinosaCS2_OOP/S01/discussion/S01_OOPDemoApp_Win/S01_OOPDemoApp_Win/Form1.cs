using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S01_OOPDemoApp_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void lblspecies_Click(object sender, EventArgs e)
        {

        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            Pet myPet = new Pet();

            myPet.Name = txtName.Text;
            myPet.Species = txtSpecies.Text;

            lblOutput.Text = myPet.Speak();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
