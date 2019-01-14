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
    public partial class Supply : UserControl
    {

        private static Supply _instance;
        public static Supply Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Supply();
                return _instance;
            }
        }

        private SupplierBAL Supplier = new SupplierBAL();

        public Supply()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Supply_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtgvSuppliers.DataSource = Supplier.GetSupplierList().Tables[0].DefaultView;
        }

        private void dtgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvSuppliers.CurrentCell.RowIndex;

            txtMaNCC.Text = dtgvSuppliers.Rows[index].Cells[0].Value.ToString();
            txtTenNCC.Text = dtgvSuppliers.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dtgvSuppliers.Rows[index].Cells[2].Value.ToString();
            txtDienThoai.Text = dtgvSuppliers.Rows[index].Cells[3].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            LoadData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = txtMaNCC.Text;
                string TenNCC = txtTenNCC.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDT = txtDienThoai.Text;
                string status = "";
                status = Supplier.Insert(int.Parse(MaNCC), TenNCC, DiaChi, SoDT);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int MaNCC = int.Parse(txtMaNCC.Text);
                string status = "";
                DialogResult result = MessageBox.Show("Có chắc chắn muốn xóa?", "STATUS", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    status = Supplier.Delete(MaNCC);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = txtMaNCC.Text;
                string TenNCC = txtTenNCC.Text;
                string DiaChi = txtDiaChi.Text;
                string SoDT = txtDienThoai.Text;
                string status = "";
                status = Supplier.Update(int.Parse(MaNCC), TenNCC, DiaChi, SoDT);
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
    }
}
