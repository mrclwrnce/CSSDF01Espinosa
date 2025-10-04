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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public static string fullname, Section, Age;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void lblSysName_Click(object sender, EventArgs e)
        {

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Username and Password.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql = $"SELECT [FullName], [Section], [Age] FROM Users WHERE Username='{username}' AND [Password]= '{password}'";
            bool isLogin = CRUD.CRUD.RETRIEVESINGLE(sql);


            if (isLogin)
            {
                fullname = CRUD.CRUD.dt.Rows[0]["FullName"].ToString();
                Section = CRUD.CRUD.dt.Rows[0]["Section"].ToString();
                Age = CRUD.CRUD.dt.Rows[0]["Age"].ToString();

                MessageBox.Show(
                    $"Welcome {fullname}",
                    "LOGIN SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Hide();
                Form1 main = new Form1();
                main.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
