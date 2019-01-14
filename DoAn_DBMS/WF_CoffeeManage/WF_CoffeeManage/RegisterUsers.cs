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
    public partial class RegisterUsers : UserControl
    {
        private static RegisterUsers _instance;
        public static RegisterUsers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegisterUsers();
                return _instance;
            }
        }

        public RegisterUsers()
        {
            InitializeComponent();
        }

        private AccountBAL Account = new AccountBAL();
        private EmployeeBAL Employee = new EmployeeBAL();
        private JobBAL Job = new JobBAL();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            cbUserName.DataSource = Account.GetAccountList().Tables[0].DefaultView;
            cbUserName.DisplayMember = "UserName";
            cbUserName.ValueMember = "UserName";

            cbCongViec.DataSource = Job.GetJobList().Tables[0].DefaultView;
            cbCongViec.DisplayMember = "Tên Công Việc";
            cbCongViec.ValueMember = "Mã Công Việc";
        }

        private void Reset()
        {
            txtConfirmPass.Text = "";
            txtAge.Text = "";
            txtEmpID.Text = "";
            txtFullName.Text = "";
            txtHomeAddress.Text = "";
            txtPassword.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int MaNV = int.Parse(txtEmpID.Text);
                string HoTen = txtFullName.Text;
                int MaCV = int.Parse(cbCongViec.SelectedValue.ToString());
                string UserName = cbUserName.SelectedValue.ToString();
                string GioiTinh = cbGender.SelectedItem.ToString();
                string DiaChi = txtHomeAddress.Text;
                int Tuoi = int.Parse(txtAge.Text);
                DateTime NgayBD = dtpkNgayBD.Value;

                string status = Employee.Insert(MaNV, HoTen, GioiTinh, Tuoi, DiaChi, NgayBD, UserName, MaCV);
                if (status != "Successful")
                    throw new Exception(status);
                MessageBox.Show("Thêm thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Mã không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
