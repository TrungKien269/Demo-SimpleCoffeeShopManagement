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
    public partial class EditProfiles : UserControl
    {
        private static EditProfiles _instance;
        public static EditProfiles Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EditProfiles();
                return _instance;
            }
        }

        private EmployeeBAL Employee = new EmployeeBAL();
        private JobBAL Job = new JobBAL();
        private AccountBAL Account = new AccountBAL();

        public EditProfiles()
        {
            InitializeComponent();
            LoadData();
        }

        private void EditProfiles_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtgvNhanVien.DataSource = Employee.GetEmployeeList().Tables[0].DefaultView;

            cbJob.DataSource = Job.GetJobList().Tables[0].DefaultView;
            cbJob.DisplayMember = "Tên Công Việc";
            cbJob.ValueMember = "Mã Công Việc";

            cbUserName.DataSource = Account.GetAccountList().Tables[0].DefaultView;
            cbUserName.DisplayMember = "UserName";
            cbUserName.ValueMember = "UserName";

        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvNhanVien.CurrentCell.RowIndex;
            cbRegisterAs.Text = dtgvNhanVien.Rows[index].Cells[7].Value.ToString();
            txtFullName.Text = dtgvNhanVien.Rows[index].Cells[1].Value.ToString();
            txtAge.Text = dtgvNhanVien.Rows[index].Cells[3].Value.ToString();
            txtHomeAddress.Text = dtgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtEmpID.Text = dtgvNhanVien.Rows[index].Cells[0].Value.ToString();
            cbGender.Text = dtgvNhanVien.Rows[index].Cells[2].Value.ToString();
            cbJob.Text = dtgvNhanVien.Rows[index].Cells[8].Value.ToString();
            dtpkNgayBD.Text = dtgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtLuong.Text = dtgvNhanVien.Rows[index].Cells[6].Value.ToString();
            cbUserName.Text = dtgvNhanVien.Rows[index].Cells[7].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbRegisterAs.Enabled = true;
            txtFullName.Enabled = true;
            txtAge.Enabled = true;
            txtHomeAddress.Enabled = true;
            txtEmpID.Enabled = true;
            cbGender.Enabled = true;
            cbJob.Enabled = true;
            dtpkNgayBD.Enabled = true;
            txtLuong.Enabled = true;
            cbUserName.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int MaNV = int.Parse(txtEmpID.Text);
                string HoTen = txtFullName.Text;
                int MaCV = int.Parse(cbJob.SelectedValue.ToString());
                string UserName = cbUserName.SelectedValue.ToString();
                string GioiTinh = cbGender.SelectedItem.ToString();
                int Luong = int.Parse(txtLuong.Text);
                string DiaChi = txtHomeAddress.Text;
                int Tuoi = int.Parse(txtAge.Text);
                DateTime NgayBD = dtpkNgayBD.Value;

                string status = Employee.Update(MaNV, HoTen, GioiTinh, Tuoi, DiaChi, NgayBD, Luong, UserName, MaCV);
                if (status != "Successful")
                    throw new Exception(status);
                MessageBox.Show("Cập nhật thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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

        private void Reset()
        {
            cbRegisterAs.Text = "";
            txtFullName.Text = "";
            txtAge.Text = "";
            txtHomeAddress.Text = "";
            txtEmpID.Text = "";
            cbGender.Text = "";
            cbJob.Text = "";
            dtpkNgayBD.Value = DateTime.Now;
            txtLuong.Text = "";
            cbUserName.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int MaNV = int.Parse(txtEmpID.Text);
                string status = "";
                DialogResult result = MessageBox.Show("Có chắc chắn muốn xóa?", "STATUS", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    status = Employee.Delete(MaNV);
                    if (status != "Successful")
                        throw new Exception(status);
                    MessageBox.Show("Xóa thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    Reset();
                }
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string property = cbSearch.SelectedItem.ToString();
            string value = txtSearch.Text;
            if (txtSearch.Text == "")
            {
                dtgvNhanVien.DataSource = Employee.GetEmployeeList().Tables[0].DefaultView;
            }
            else
            {
                dtgvNhanVien.DataSource = Employee.GetEmployeeFromProperty(property, value).Tables[0].DefaultView;
            }
        }
    }
}
