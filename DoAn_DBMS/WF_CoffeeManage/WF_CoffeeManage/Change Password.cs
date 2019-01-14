using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace WF_CoffeeManage
{
    public partial class Change_Password : UserControl
    {
        //private static Change_Password _instance;
        //public static Change_Password Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new Change_Password();
        //        return _instance;
        //    }
        //}

        private string UserName;
        private AccountBAL Account = new AccountBAL();

        public Change_Password(string username)
        {
            this.UserName = username;
            InitializeComponent();
        }

        private void ResetGroupBoxAccount()
        {
            txtPass.Text = "";
            txtUserName.Text = "";
            cbLoaiTK.Text = "";
        }

        private void ResetPassword()
        {
            txtConfirmPass.Text = "";
            txtNewPass.Text = "";
            txtOldPass.Text = "";
        }

        private void chkbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }
        
        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Pass = txtPass.Text;
            string Type = cbLoaiTK.SelectedItem.ToString();
            try
            {
                int type = 1;
                if (Type.Equals("Employee"))
                    type = 2;
                string status = Account.InsertAccount(UserName, Pass, type);
                if (status != "Successful")
                    throw new Exception(status);
                MessageBox.Show("Thêm thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGroupBoxAccount();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkbShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtOldPass.UseSystemPasswordChar = false;
                txtNewPass.UseSystemPasswordChar = false;
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
                txtNewPass.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPass.Text.Equals(txtOldPass.Text))
                    throw new Exception("Mật khẩu trùng với mật khẩu cũ!");
                if (txtNewPass.Text.Equals(txtConfirmPass.Text) == false)
                    throw new Exception("Mật khẩu mới cần được xác thực đúng!");
                if (txtOldPass.Text.Equals(Account.GetPassword(UserName)) == false)
                    throw new Exception("Mật khẩu cũ không chính xác!");
                string status = Account.UpdateAccount(UserName, txtNewPass.Text);
                if (status != "Successful")
                    throw new Exception(status);
                MessageBox.Show("Cập nhật thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetPassword();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
