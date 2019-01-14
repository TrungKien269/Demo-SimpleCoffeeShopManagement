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
    public partial class frmDetailBill : Form
    {
        public frmDetailBill(int MaHD)
        {
            this.MaHD = MaHD;
            InitializeComponent();
        }

        private int MaHD;
        private ExportBillBAL ExBill = new ExportBillBAL();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetailBill_Load(object sender, EventArgs e)
        {
            dtgvDSTU.DataSource = ExBill.GetBillDetail(MaHD).Tables[0].DefaultView;

            lbMaHD.Text = lbMaHD.Text + MaHD;
            lbTongSL.Text = lbTongSL.Text + CountSoLuongTU();
            lbTongTien.Text = lbTongTien.Text + CountTongTien() + "đ";
        }

        private int CountSoLuongTU()
        {
            int sum = 0;
            for (int i = 0; i < dtgvDSTU.RowCount - 1; i++)
            {
                sum += Int32.Parse(dtgvDSTU.Rows[i].Cells[2].Value.ToString());
            }
            return sum;
        }

        private int CountTongTien()
        {
            int sum = 0;
            for (int i = 0; i < dtgvDSTU.RowCount - 1; i++)
            {
                sum += Int32.Parse(dtgvDSTU.Rows[i].Cells[4].Value.ToString());
            }
            return sum;
        }
    }
}
