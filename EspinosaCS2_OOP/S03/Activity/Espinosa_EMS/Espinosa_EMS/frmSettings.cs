using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espinosa_EMS
{
    public partial class frmSettings : Form
    {
        Boolean passwordCheck = false;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            CRUD.CRUD.RETRIEVECBO(cmbSection, "SELECT [ID], [Section] FROM [tblSection] ORDER BY [Section] asc", "Section", "ID");
            CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [Users]");
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (passwordCheck == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = "Insert into [Users] ([UserName], [Password],[Section],[Age], [FullName]) values ('" + txtUserName.Text + "','" + txtPassword.Text + "','" + cmbSection.Text + "','" + txtAge.Text + "','" + txtFullName.Text + "')";
                    CRUD.CRUD.CUD(query);
                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CRUD.CRUD.RETRIEVEDTG(dgvUsers, "Select * From [Users] ");
                }

            }
            else
            {
                MessageBox.Show("Password does not match","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Match()
        {
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                lblMatch.Text = "✔ Match";
                lblMatch.ForeColor = Color.Green;
                passwordCheck = true;
            }
            else
            {
                lblMatch.Text = "❌ Match";
                lblMatch.ForeColor = Color.Red;
                passwordCheck = false;
            }
        }


        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPassword_TextChange(object sender, EventArgs e)
        {
            Match();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Match();    
        }
    }
}
