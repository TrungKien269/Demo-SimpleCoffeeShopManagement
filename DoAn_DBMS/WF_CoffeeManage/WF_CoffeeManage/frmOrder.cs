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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            LoadForm();
        }

        private DrinkBAL Drink = new DrinkBAL();
        private DrinkCategoryBAL DrinkCate = new DrinkCategoryBAL();
        private CustomerBAL Customer = new CustomerBAL();
        private EmployeeBAL Employee = new EmployeeBAL();
        private ExportBillBAL ExportBill = new ExportBillBAL();

        private void LoadForm()
        {
            dtpNgayLapHD.Value = DateTime.Today;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dtgvDSTU.DataSource = Drink.GetDrinkList().Tables[0].DefaultView;

            cbLoaiTU.DataSource = DrinkCate.GetDrinkCategoryList().Tables[0].DefaultView;
            cbLoaiTU.DisplayMember = "Tên Mục";
            cbLoaiTU.ValueMember = "Mã Mục";
            cbLoaiTU.SelectedIndex = 0;

            cbCustomer.DataSource = Customer.GetCustomerList().Tables[0].DefaultView;
            cbCustomer.DisplayMember = "Họ Tên";
            cbCustomer.ValueMember = "Mã KH";

            cbEmployee.DataSource = Employee.GetEmployeeList().Tables[0].DefaultView;
            cbEmployee.DisplayMember = "Họ Tên";
            cbEmployee.ValueMember = "Mã NV";

            cbLoaiHD.DataSource = ExportBill.GetBillType().Tables[0].DefaultView;
            cbLoaiHD.DisplayMember = "Tên Loại";
            cbLoaiHD.ValueMember = "Mã Loại";

            txt_MaHD.Text = ExportBill.GetNextHoaDon();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiTU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Type = 0;
            if (cbLoaiTU.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Type = Convert.ToInt16(cbLoaiTU.SelectedValue.ToString());
            }
            else
            {
                Type = 1;
            }
            dtgvDSTU.DataSource = Drink.GetDrinkListFromCategory(Type).Tables[0].DefaultView;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                int pos = 0;
                int count = 0;
                int sumMoney = 0;
                int index = dtgvDSTU.CurrentCell.RowIndex;
                int maTU = int.Parse(dtgvDSTU.Rows[index].Cells[0].Value.ToString());
                string tenTU = dtgvDSTU.Rows[index].Cells[1].Value.ToString();
                int donGia = int.Parse(dtgvDSTU.Rows[index].Cells[2].Value.ToString());

                for (int i = 0; i < dtgvDSMua.RowCount - 1; i++) //Kiểm tra có trong DSBán chưa
                    if (int.Parse(dtgvDSMua.Rows[i].Cells[0].Value.ToString()) == maTU)
                    {
                        flag = true;
                        pos = i;
                        count = Convert.ToInt32(dtgvDSMua.Rows[i].Cells[3].Value);
                    }
                if (flag == true) //Nếu có sẵn trong DSBán
                {
                    dtgvDSMua.Rows[pos].Cells[3].Value = (count + 1).ToString();
                    dtgvDSMua.Rows[pos].Cells[4].Value =
                        donGia * int.Parse(dtgvDSMua.Rows[pos].Cells[3].Value.ToString());
                }
                else //Chưa có trong DSBán
                {
                    dtgvDSMua.Rows.Add(1);
                    int id = dtgvDSMua.RowCount - 2;
                    dtgvDSMua.Rows[id].Cells[0].Value = maTU;
                    dtgvDSMua.Rows[id].Cells[1].Value = tenTU;
                    dtgvDSMua.Rows[id].Cells[2].Value = donGia;
                    dtgvDSMua.Rows[id].Cells[3].Value = 1;
                    dtgvDSMua.Rows[id].Cells[4].Value =
                        donGia * int.Parse(dtgvDSMua.Rows[id].Cells[3].Value.ToString());
                }

                for (int j = 0; j < dtgvDSMua.RowCount - 1; j++) //Cập nhật cột thành tiền
                {
                    sumMoney += int.Parse(dtgvDSMua.Rows[j].Cells[4].Value.ToString());
                }
                txt_TongTien.Text = sumMoney.ToString(); //Cập nhật tổng tiền
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgvDSMua.CurrentCell.RowIndex;
                string SL = dtgvDSMua.Rows[index].Cells[3].Value.ToString();
                int sumMoney = 0;
                if (SL == "1")
                {
                    dtgvDSMua.Rows.RemoveAt(index);

                    for (int j = 0; j < dtgvDSMua.RowCount - 1; j++) //Cập nhật cột thành tiền
                    {
                        sumMoney += int.Parse(dtgvDSMua.Rows[j].Cells[4].Value.ToString());
                    }
                    txt_TongTien.Text = sumMoney.ToString(); //Cập nhật tổng tiền
                }
                else if (SL == "")
                {
                    throw new Exception("Cần chọn thức uống");
                }
                else
                {
                    dtgvDSMua.Rows[index].Cells[3].Value = (int.Parse(SL) - 1).ToString();
                    dtgvDSMua.Rows[index].Cells[4].Value = int.Parse(dtgvDSMua.Rows[index].Cells[2].Value.ToString()) *
                                                             int.Parse(dtgvDSMua.Rows[index].Cells[3].Value.ToString());

                    for (int j = 0; j < dtgvDSMua.RowCount - 1; j++) //Cập nhật cột thành tiền
                    {
                        sumMoney += int.Parse(dtgvDSMua.Rows[j].Cells[4].Value.ToString());
                    }
                    txt_TongTien.Text = sumMoney.ToString(); //Cập nhật tổng tiền
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtgvDSMua.Rows.Clear();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string status = "";
            try
            {
                if (txt_TongTien.Text == "0")
                    throw new Exception("Cần phải chọn thức uống cho hóa đơn");

                int maHD = int.Parse(txt_MaHD.Text);
                DateTime date = dtpNgayLapHD.Value;
                int maNV = int.Parse(cbEmployee.SelectedValue.ToString());
                int maKH = int.Parse(cbCustomer.SelectedValue.ToString());
                int maLoai = int.Parse(cbLoaiHD.SelectedValue.ToString());
                ExportBill.InsertHoaDon(maHD, date, maKH, maNV, maLoai);

                for (int i = 0; i < dtgvDSMua.RowCount - 1; i++)
                {
                    int maTU = int.Parse(dtgvDSMua.Rows[i].Cells[0].Value.ToString());
                    int soLuong = int.Parse(dtgvDSMua.Rows[i].Cells[3].Value.ToString());
                    status = ExportBill.InsertChiTietHD(maHD, maTU, soLuong);
                    if (status != "Successful")
                        throw new Exception(status);
                }
                MessageBox.Show("Ghi thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_MaHD.Text = maHD.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TongTien.Text == "")
                    throw new Exception("Chưa chọn thức uống nào");
                if (txt_TienNhan.Text == "")
                    throw new Exception("Cần nhập tiến nhận");
                int TongTien = int.Parse(txt_TongTien.Text);
                int TienNhan = int.Parse(txt_TienNhan.Text);
                int TienTra = TienNhan - TongTien;
                if (TienTra == 0)
                    MessageBox.Show("Thanh toán đủ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Đã thanh toán" + '\n' + "Tiền trả lại: " + TienTra.ToString(), "THÔNG BÁO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetBanHang();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBanHang()
        {
            dtgvDSMua.Rows.Clear();
            cbLoaiTU.Text = "";
            dtgvDSTU.DataSource = Drink.GetDrinkList().Tables[0].DefaultView;
            txt_TienNhan.Text = "";
            txt_TongTien.Text = "0";
            txt_TienTra.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int maKH = int.Parse(txtMaKH.Text);
            string HoTen = txtFullName.Text;
            string DiaChi = txtAddress.Text;
            string Phone = txtPhoneNumber.Text;
            string Gender = cbGender.SelectedItem.ToString();
            string City = txtThanhPho.Text;

            try
            {
                string status = Customer.Insert(maKH, HoTen, Gender, DiaChi, Phone, City);
                if (status != "Successful")
                    throw new Exception(status);
                MessageBox.Show("Ghi thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int MaHD = int.Parse(txt_MaHD.Text);
        }
    }
}
