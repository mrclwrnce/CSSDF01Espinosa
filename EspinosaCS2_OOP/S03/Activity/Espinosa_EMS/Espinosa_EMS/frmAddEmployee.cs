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
    public partial class frmAddEmployee : Form
    {
        private string mode;
        public frmAddEmployee(string mode)
        {
            InitializeComponent();
            this.mode = mode;
        }

        private void lblEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            if (tbEmailAddress.Text.Contains("@firstasia.edu.ph") == true)
            {
                bool dtg_addrequestor = false;
                string EMS_data = string.Empty;
                EMS_data = "Select * from [tblEmployeeData] where [EmployeeNumber] = '" + tbEmployeeNumber.Text + "'";
                dtg_addrequestor = CRUD.CRUD.RETRIEVESINGLE(EMS_data);
                if (dtg_addrequestor == true)
                {
                    DialogResult result = MessageBox.Show("This account '" + tbRequestorName.Text + "' is already exist. Do you wish to update the account?", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.Yes)
                    {
                        string update_requestor = "UPDATE [tblEmployeeData] " +
                             "SET [RequestorName] = '" + tbRequestorName.Text + "', " +
                             "[RequestorEmail] = '" + tbEmailAddress.Text + "', " +
                             "[Section] = '" + cmbSection.Text + "', " +
                             "[LocalNumber] = '" + tbLocalNumber.Text + "' " +
                             "WHERE [EmployeeNumber] = '" + tbEmployeeNumber.Text + "'";

                        CRUD.CRUD.CUD(update_requestor);

                        MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        
                    }
                    else
                    {
                        tbRequestorName.Text = "";
                        tbEmailAddress.Text = "";
                        tbLocalNumber.Text = "";
                        this.Close();
                    }

                }
                else
                {
                    string add_requestor = "Insert into [tblEmployeeData] ([EmployeeNumber], [RequestorName],[RequestorEmail],[Section],[LocalNumber]) values ('" + tbEmployeeNumber.Text + "','" + tbRequestorName.Text + "','" + tbEmailAddress.Text + "','" + cmbSection.Text + "', '" + tbLocalNumber.Text + "')";
                    CRUD.CRUD.CUD(add_requestor);
                    MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please check the email format", "Invalid Email", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

            if (mode == "addEmployee")
            {

                tbEmployeeNumber.Text = frmMasterData.employeeNumber;
                tbRequestorName.Text = frmMasterData.requestorName;
                tbEmailAddress.Text = frmMasterData.requestorEmail;
                tbLocalNumber.Text = frmMasterData.localNumber;
                cmbSection.Text = frmMasterData.section;

            }
            else
            {
                btnDelete.Hide();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete_requestor = "DELETE FROM [tblEmployeeData] WHERE [EmployeeNumber] = '" + tbEmployeeNumber.Text + "'";
            CRUD.CRUD.CUD(delete_requestor);
            MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
