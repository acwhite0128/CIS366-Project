using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBLoginForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=acw7323.database.windows.net;Initial Catalog=CIS366TeamProject1;User ID=acwhite0128;Password=S3cur!ty;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "Select * from Users where userName ='" + userNameTextBox.Text.Trim() + "'and password ='" + passwordTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                loggedInForm objfrmLoggedIn = new loggedInForm();
                this.Hide();
                objfrmLoggedIn.Show();
            }
            else
            {
                MessageBox.Show("Please re-enter username and password.");
            }


        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
