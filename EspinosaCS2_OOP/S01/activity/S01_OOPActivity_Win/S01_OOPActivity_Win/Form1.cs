using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S01_OOPActivity_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Addition myAddition = new Addition();
            myAddition.addends1 = int.Parse(txtAddends1.Text);
            myAddition.addends2 = int.Parse(txtAddends2.Text);
            txtSum.Text = myAddition.Add();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtSum.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAddends1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
