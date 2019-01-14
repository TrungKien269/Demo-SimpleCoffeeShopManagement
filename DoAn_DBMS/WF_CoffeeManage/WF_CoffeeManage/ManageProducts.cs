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
    public partial class ManageProducts : UserControl
    {
        private static ManageProducts _instance;
        public static ManageProducts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ManageProducts();
                return _instance;
            }
        }

        private DrinkBAL Drink = new DrinkBAL();
        private DrinkCategoryBAL DrinkCate = new DrinkCategoryBAL();

        public ManageProducts()
        {
            InitializeComponent();
        }

        private string imagelink = "";
        private string imagechosen = "";

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtgvProducts.DataSource = Drink.GetDrinkList().Tables[0].DefaultView;

            cbDanhMuc.DataSource = DrinkCate.GetDrinkCategoryList().Tables[0].DefaultView;
            cbDanhMuc.DisplayMember = "Tên Mục";
            cbDanhMuc.ValueMember = "Mã Mục";
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    dialog.Dispose();
                    throw new Exception("Không chọn Image!");
                }
                ptbImage.Image = Image.FromFile(dialog.FileName);
                imagelink = dialog.FileName;
                dialog.Dispose();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvProducts.CurrentCell.RowIndex;

            txtMaTU.Text = dtgvProducts.Rows[index].Cells[0].Value.ToString();
            txtTenTU.Text = dtgvProducts.Rows[index].Cells[1].Value.ToString();
            txtDonGia.Text = dtgvProducts.Rows[index].Cells[2].Value.ToString();
            cbDanhMuc.Text = dtgvProducts.Rows[index].Cells[3].Value.ToString();

            string imagepath = Drink.GetDrinkImage(int.Parse(txtMaTU.Text));
            if (imagepath == null || imagepath == "")
            {
                ptbImage.Image = null;
            }
            else
            {
                ptbImage.Image = Image.FromFile(imagepath);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtMaTU.Text = "";
            txtTenTU.Text = "";
            txtDonGia.Text = "";
            ptbImage.Image = null;
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            imagechosen = imagelink; 
            if(imagelink != null || imagelink != "")
                MessageBox.Show("Chọn thành công", "STATUS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Chọn không thành công!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int MaTU = int.Parse(txtMaTU.Text);
                string TenTU = txtTenTU.Text;
                int DonGia = int.Parse(txtDonGia.Text);
                string LinkAnh = imagelink;
                int MaMuc = int.Parse(cbDanhMuc.SelectedValue.ToString());
                string status = "";
                status = Drink.Insert(MaTU, TenTU, DonGia, LinkAnh, MaMuc);
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
                int MaTU = int.Parse(txtMaTU.Text);
                string TenTU = txtTenTU.Text;
                int DonGia = int.Parse(txtDonGia.Text);
                string LinkAnh = imagelink;
                int MaMuc = int.Parse(cbDanhMuc.SelectedValue.ToString());
                string status = "";
                status = Drink.Update(MaTU, TenTU, DonGia, LinkAnh, MaMuc);
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
                int MaTU = int.Parse(txtMaTU.Text);
                string status = "";
                DialogResult result = MessageBox.Show("Có chắc chắn muốn xóa?", "STATUS", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    status = Drink.Delete(MaTU);
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
