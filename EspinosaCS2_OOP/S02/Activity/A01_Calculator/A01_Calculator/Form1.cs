using System.Runtime.CompilerServices;

namespace A01_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isNewEntry = false;
        private int originalWidth;
        double firstNumber = 0;
        string operation = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 235;

            originalWidth = this.Width;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (this.Width >= 370)
            {
                this.Width = originalWidth;
            }
            else
            {
                this.Width = 370;
            }
        }

        private void textEquation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Key(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isNewEntry)
            {
                textDisplay.Text = "";
                isNewEntry = false;
            }

            if (textDisplay.Text == "0" && btn.Text != ".")
            {
                textDisplay.Text = "";
            }

            int dotCount = textDisplay.Text.Count(c => c == '.');
            if (dotCount > 1)
            {
                if (btn.Text != ".")
                {
                    textDisplay.Text += btn.Text;
                    textEquation.Text += btn.Text;
                }
            }
            else if (textDisplay.Text == "" && btn.Text == ".")
            {
                textDisplay.Text = "0.";
                textEquation.Text = "0.";
            }
            else
            {
                textDisplay.Text += btn.Text;
                if (textDisplay.Text.Contains(".."))
                {
                    textDisplay.Text = textDisplay.Text.Replace("..", ".");
                }
                textEquation.Text += btn.Text;
            }
        }

        private void Operator(object sender, EventArgs e)
        {
            Button btn = ( Button )sender;

            if (double.TryParse(textDisplay.Text, out firstNumber))
            {
                operation = btn.Text;
                isNewEntry = true;

                textEquation.Text = firstNumber.ToString() + " " + operation + " ";
            }
        }
    }
}
