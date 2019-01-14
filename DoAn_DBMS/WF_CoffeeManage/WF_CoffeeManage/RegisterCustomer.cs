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
    public partial class RegisterCustomer : UserControl
    {
        private static RegisterCustomer _instance;

        public static RegisterCustomer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegisterCustomer();
                return _instance;
            }
        }

        private CustomerBAL Customer = new CustomerBAL();

        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtgvCustomer.DataSource = Customer.GetCustomerList().Tables[0].DefaultView;
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvCustomer.CurrentCell.RowIndex;
            txtMaKH.Text = dtgvCustomer.Rows[index].Cells[0].Value.ToString();
            txtHoTen.Text = dtgvCustomer.Rows[index].Cells[1].Value.ToString();
            cbGioiTinh.Text = dtgvCustomer.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dtgvCustomer.Rows[index].Cells[3].Value.ToString();
            txtDienThoai.Text = dtgvCustomer.Rows[index].Cells[4].Value.ToString();
            txtThanhPho.Text = dtgvCustomer.Rows[index].Cells[5].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtMaKH.Text = "";
            txtHoTen.Text = "";
            cbGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtThanhPho.Text = "";
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int MaKH = int.Parse(txtMaKH.Text);
                string HoTen = txtHoTen.Text;
                string GioiTinh = cbGioiTinh.SelectedItem.ToString();
                string DiaChi = txtDiaChi.Text;
                string Phone = txtDienThoai.Text;
                string ThanhPho = txtThanhPho.Text;
                string status = "";
                status = Customer.Insert(MaKH, HoTen, GioiTinh, DiaChi, Phone, ThanhPho);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int MaKH = int.Parse(txtMaKH.Text);
                string HoTen = txtHoTen.Text;
                string GioiTinh = cbGioiTinh.SelectedItem.ToString();
                string DiaChi = txtDiaChi.Text;
                string Phone = txtDienThoai.Text;
                string ThanhPho = txtThanhPho.Text;
                string status = "";
                status = Customer.Update(MaKH, HoTen, GioiTinh, DiaChi, Phone, ThanhPho);
                if (status != "Successful")
                    throw new Exception(status);
                MessageBox.Show("Sửa thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int MaKH = int.Parse(txtMaKH.Text);
                string status = "";
                DialogResult result = MessageBox.Show("Có chắc chắn muốn xóa?", "STATUS", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    status = Customer.Delete(MaKH);
                    if (status != "Successful")
                        throw new Exception(status);
                    MessageBox.Show("Xóa thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
