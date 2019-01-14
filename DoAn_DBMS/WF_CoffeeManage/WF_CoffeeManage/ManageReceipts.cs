using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLogicLayer;

namespace WF_CoffeeManage
{
    public partial class ManageReceipts : UserControl
    {
        private static ManageReceipts _instance;

        public static ManageReceipts Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ManageReceipts();
                return _instance;
            }
        }

        private ExportBillBAL ExBill = new ExportBillBAL();

        public ManageReceipts()
        {
            InitializeComponent();
        }

        private int MaHD;

        private void CountRow()
        {
            int count = dtgvReceipts.RowCount - 1;
            lbCountRow.Text = "STATUS: There are " + count.ToString() + " record(s) found in database";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //{
            //    if (db.State == ConnectionState.Closed)
            //    {
            //        db.Open();
            //    }

            //    string query = "SELECT hd.MaHD, kh.MaKH, kh.HoTen,kh.DiaChi,kh.ThanhPho,kh.Phone,hd.ThoiDiem" +
            //                    " FROM KhachHang kh inner join HoaDon hd on kh.MaKH = hd.MaKH" +
            //                    $" where hd.ThoiDiem between '{dtFromDate.Value}' and '{dtToDate.Value}'" +
            //                    " Order By ThoiDiem";


            //    ordersBindingSource4.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
            //    CountRow();
            //}
            DataSet ds = new DataSet();
            ds = ExBill.GetBills(dtFromDate.Value, dtToDate.Value);
            dtgvReceipts.DataSource = ds.Tables[0].DefaultView;
            CountRow();
            MaHD = Int32.Parse(dtgvReceipts.Rows[0].Cells[1].Value.ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource4.Current as Orders;
            if(obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();

                    //string query = "SELECT HoaDon.MaHD, TenTU, SoLuong, Discount, DonGia" +
                    //                " FROM HoaDon, ChiTietHD, KhachHang, ThucUong" +
                    //                " WHERE ChiTietHD.MaHD = HoaDon.MaHD AND HoaDon.MaKH = KhachHang.MaKH" +
                    //                $" and ChiTietHD.MaTU = ThucUong.MaTU and HoaDon.MaHD = {obj.MaHD}";

                    string query = "SELECT HoaDon.MaHD as OrderID, TenTU as ProductName, SoLuong as Quantity, Discount, DonGia as UnitPrice" +
                                    " FROM HoaDon, ChiTietHD, KhachHang, ThucUong" +
                                    $" WHERE ChiTietHD.MaHD = HoaDon.MaHD AND HoaDon.MaKH = KhachHang.MaKH and ChiTietHD.MaTU = ThucUong.MaTU and HoaDon.MaHD = {obj.MaHD}";




                    List<OrderDetail> list  = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();
                    using (frmPrint frm = new frmPrint(obj, list))
                    {
                        frm.ShowDialog();
                    }
                }
            }           
        }

        private void ManageReceipts_Load(object sender, EventArgs e)
        {
            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            //{
            //    if (db.State == ConnectionState.Closed)
            //    {
            //        db.Open();
            //    }

            //    string query = "SELECT hd.ThoiDiem, hd.MaHD, kh.MaKH, kh.HoTen,kh.DiaChi,kh.ThanhPho,kh.Phone" +
            //                    " FROM KhachHang kh inner join HoaDon hd on kh.MaKH = hd.MaKH" +
            //                    " Order By ThoiDiem";
            //                    //$" where hd.ThoiDiem between '{dtFromDate.Value}' and '{dtToDate.Value}'";


            //    ordersBindingSource4.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
            //    CountRow();
            //}
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtgvReceipts.RowCount == 1)
                    throw new Exception("Chưa chọn hóa đơn!");
                frmDetailBill frm = new frmDetailBill(MaHD);
                frm.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvReceipts.CurrentCell.RowIndex;
            MaHD = Int32.Parse(dtgvReceipts.Rows[index].Cells[1].Value.ToString());
        }
    }
}
