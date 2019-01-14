using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CoffeeManage
{
    public partial class frmPrint : Form
    {
        List<OrderDetail> _list;
        Orders _orders;

        public frmPrint(Orders orders, List<OrderDetail> list)
        {
            InitializeComponent();
            _orders = orders;
            _list = list;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            rptOrders1.SetDataSource(_list);
            rptOrders1.SetParameterValue("pOrderID", _orders.MaHD);
            rptOrders1.SetParameterValue("pDate", _orders.ThoiDiem.ToString("MM/dd/yyyy"));
            rptOrders1.SetParameterValue("pContactName", _orders.HoTen);
            rptOrders1.SetParameterValue("pAddress", _orders.DiaChi);
            rptOrders1.SetParameterValue("pCity", _orders.ThanhPho);
            rptOrders1.SetParameterValue("pPhone", _orders.Phone);
            crystalReportViewer.ReportSource = rptOrders1;
            crystalReportViewer.Refresh();
        }
    }
}
