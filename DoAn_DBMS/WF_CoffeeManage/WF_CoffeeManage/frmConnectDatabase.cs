using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CoffeeManage
{
    public partial class frmConnectDatabase : Form
    {
        public frmConnectDatabase()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string Database = "QLQuanCoffee";
            string UserName = txtUserName.Text;
            string IP = txtIP.Text;
            string Password = txtPassword.Text;
            string conStr = "Server=" + IP + ";Database=" + Database + ";User Id=" + UserName + ";Password=" +
                            Password + ";";
            try
            {
                SqlConnection connection = new SqlConnection(conStr);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    LoginForm login = new LoginForm();
                    this.Close();
                    login.ShowDialog();
                    this.Show();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
