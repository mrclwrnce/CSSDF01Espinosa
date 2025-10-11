using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espinosa_EMS
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }

        private void frmMasterData_Load(object sender, EventArgs e)
        {
            string select_tblrequestorlist = "select * from tblEmployeeData ORDER BY EmployeeNumber DESC";
            CRUD.CRUD.RETRIEVEDTG(dgvMasterdata, select_tblrequestorlist);
        }

        private void dgvMasterdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTransactionNo.Text = dgvMasterdata.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            employeeNumber = dgvMasterdata.Rows[e.RowIndex].Cells["EmployeeNumber"].Value.ToString();
            requestorName = dgvMasterdata.Rows[e.RowIndex].Cells["RequestorName"].Value.ToString();
            requestorEmail = dgvMasterdata.Rows[e.RowIndex].Cells["RequestorEmail"].Value.ToString();
            localNumber = dgvMasterdata.Rows[e.RowIndex].Cells["LocalNumber"].Value.ToString();
            section = dgvMasterdata.Rows[e.RowIndex].Cells["Section"].Value.ToString();
        }

        public static string employeeNumber, requestorName, requestorEmail, localNumber, section;
        private void btnEditData_Click(object sender, EventArgs e)
        {

            
            frmAddEmployee editdata = new frmAddEmployee("addEmployee");
            editdata.ShowDialog();
            CRUD.CRUD.RETRIEVEDTG(dgvMasterdata, "Select * From [tblEmployeeData] ");

        }
    }
}
