using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WF_CoffeeManage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private AccountBAL Account = new AccountBAL();

        private void LoadForm()
        {
            txtUser.Focus();
            lbUserName.Parent = pictureBox2;
            lbUserName.BackColor = Color.Transparent;
            lbPassword.Parent = pictureBox2;
            lbPassword.BackColor = Color.Transparent;
            lbUserLogin.Parent = pictureBox2;
            lbUserLogin.BackColor = Color.Transparent;
            lbForgotPassword.Parent = pictureBox2;
            lbForgotPassword.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox2;
            pictureBox3.BackColor = Color.Transparent;
            ckbShowPass.Parent = pictureBox2;
            ckbShowPass.BackColor = Color.Transparent;
            timeFlashing.Start();
            timeFlashing.Enabled = true;
            this.AcceptButton = btnLogin;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void timeFlashing_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            lbTittle.ForeColor = Color.FromArgb(A, R, G, B);
            lbASROMA.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private string AccountValidation(string username, string password)
        {
            string flag = "";
            DataSet ds = Account.GetAccountList();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string user = ds.Tables[0].Rows[i][0].ToString().Split(' ')[0];
                string pass = ds.Tables[0].Rows[i][1].ToString().Split(' ')[0];
                if (user.Equals(username) && pass.Equals(password))
                {
                    flag = ds.Tables[0].Rows[i][2].ToString();
                    break;
                }
            }
            return flag;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string typeID = AccountValidation(txtUser.Text, txtPass.Text);
                switch (typeID)
                {
                    case "Admin":
                        {
                            MessageBox.Show("Đăng nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmAdmin frm = new frmAdmin();
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                            LoadForm();
                            break;
                        }
                    case "Employee":
                        {
                            MessageBox.Show("Đăng nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string id = txtUser.Text;
                            frmEmployee frm = new frmEmployee(id);
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                            LoadForm();
                            break;
                        }
                    default:
                        {
                            throw new Exception("Đăng nhập thất bại!");
                        }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //frmEmployee frm = new frmEmployee("NV001");
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
            //LoadForm();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbUserName_Click(object sender, EventArgs e)
        {

        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
                txtPass.UseSystemPasswordChar = false;
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
