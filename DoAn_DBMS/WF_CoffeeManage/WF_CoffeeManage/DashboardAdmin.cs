using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLogicLayer;

namespace WF_CoffeeManage
{
    public partial class DashboardAdmin : UserControl
    {
        private static DashboardAdmin _instance;
        public static DashboardAdmin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashboardAdmin();
                return _instance;
            }
        }

        private ChartBAL ThongKe = new ChartBAL();

        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private DataSet dsLuong = new DataSet();
        private DataSet dsDrink = new DataSet();
        private DataSet dsBill = new DataSet();
        private DataSet dsElement = new DataSet();

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            dsLuong = ThongKe.GetChartList("spThongKeLuong");
            dsDrink = ThongKe.GetChartList("spThongKeThucUong");
            dsBill = ThongKe.GetChartList("spThongKeLoaiHoaDon");
            dsElement = ThongKe.GetChartList("spThongKeNguyenLieuHDCC");
        }

        private void SetSalaryChart(StatisticalChart Chart)
        {
            Chart.chart.DataSource = null;
            Chart.chart.DataSource = dsLuong.Tables[0].DefaultView;
            int count = dsLuong.Tables[0].Rows.Count;

            try
            {
                int blockSize = 6;

                Chart.chart.Series.Clear();
                var series = Chart.chart.Series.Add("Salary");
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.ChartType = SeriesChartType.Column;
                series.XValueType = ChartValueType.Int32;
                series.Color = Color.CadetBlue;
                Chart.chart.Series["Salary"].XValueMember = "Họ Tên";
                Chart.chart.Series["Salary"].YValueMembers = "Lương";
                Chart.chart.ChartAreas[0].AxisY.Minimum = 1000000;


                var chartArea = Chart.chart.ChartAreas[0];
                chartArea.Area3DStyle.Enable3D = false;
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = count * 1.1;
                chartArea.CursorX.AutoScroll = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                int position = 0;
                int size = blockSize;
                chartArea.AxisX.ScaleView.Zoom(position, size);
                chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
                chartArea.BackColor = Color.Gainsboro;
                chartArea.AxisX.TitleFont = new Font("Segui UI", 10, FontStyle.Bold);
                chartArea.AxisX.LineColor = Color.AliceBlue;
                chartArea.AxisX.MajorGrid.LineColor = Color.White;
                chartArea.AxisX.LabelStyle.ForeColor = Color.White;
                chartArea.AxisY.LineColor = Color.White;
                chartArea.AxisY.MajorGrid.LineColor = Color.White;
                chartArea.AxisY.LabelStyle.ForeColor = Color.White;
                chartArea.AlignmentStyle = AreaAlignmentStyles.All;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalaryEmployee_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(StatisticalChart.Instance);
            StatisticalChart.Instance.Dock = DockStyle.Fill;
            StatisticalChart.Instance.BringToFront();
            SetSalaryChart(StatisticalChart.Instance);
        }

        private void SetDrinkSaleChart(StatisticalChart Chart)
        {
            Chart.chart.DataSource = null;
            Chart.chart.DataSource = dsDrink.Tables[0];
            Chart.chart.Series.Clear();
            int count = dsDrink.Tables[0].Rows.Count;
            try
            {
                int blockSize = 6;
                Chart.chart.Series.Clear();
                var series = Chart.chart.Series.Add("Drinks");
                series.IsValueShownAsLabel = true;
                series.LabelForeColor = Color.Black;
                series.ChartType = SeriesChartType.Column;
                series.XValueType = ChartValueType.Int32;
                series.Color = Color.Chocolate;
                Chart.chart.Series["Drinks"].XValueMember = "Tên TU";
                Chart.chart.Series["Drinks"].YValueMembers = "Số Lượng";
                Chart.chart.ChartAreas[0].AxisY.Minimum = 0;


                var chartArea = Chart.chart.ChartAreas[0];
                chartArea.Area3DStyle.Enable3D = false;
                chartArea.AxisX.Minimum = 0;
                chartArea.AxisX.Maximum = count * 1.1;
                chartArea.CursorX.AutoScroll = true;
                chartArea.AxisX.ScaleView.Zoomable = true;
                chartArea.AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
                int position = 0;
                int size = blockSize;
                chartArea.AxisX.ScaleView.Zoom(position, size);
                chartArea.AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
                chartArea.AxisX.ScaleView.SmallScrollSize = blockSize;
                chartArea.BackColor = Color.Gainsboro;
                chartArea.AxisX.TitleFont = new Font("Segui UI", 10, FontStyle.Bold);
                chartArea.AxisX.LineColor = Color.AliceBlue;
                chartArea.AxisX.MajorGrid.LineColor = Color.White;
                chartArea.AxisX.LabelStyle.ForeColor = Color.White;
                chartArea.AxisY.LineColor = Color.White;
                chartArea.AxisY.MajorGrid.LineColor = Color.White;
                chartArea.AxisY.LabelStyle.ForeColor = Color.White;
                chartArea.AlignmentStyle = AreaAlignmentStyles.All;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDrinkSale_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(StatisticalChart.Instance);
            StatisticalChart.Instance.Dock = DockStyle.Fill;
            StatisticalChart.Instance.BringToFront();
            SetDrinkSaleChart(StatisticalChart.Instance);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(StatisticalChart.Instance);
            StatisticalChart.Instance.Dock = DockStyle.Fill;
            StatisticalChart.Instance.BringToFront();
            SetBillSaleChart(StatisticalChart.Instance);
        }

        private void SetBillSaleChart(StatisticalChart Chart)
        {
            Chart.chart.DataSource = null;
            Chart.chart.Series.Clear();

            try
            {
                var ListMuc = dsBill.Tables[0].AsEnumerable().OrderBy(x => x.Field<int>("Mã Loại")).Select(x => x).ToList();
                Chart.chart.DataSource = ListMuc;
                Chart.chart.ChartAreas[0].Area3DStyle.Enable3D = true;
                var series = Chart.chart.Series.Add("Bill");
                series.LabelForeColor = Color.AliceBlue;
                series.Font = new Font("Segui UI", 20);
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                Chart.chart.Series["Bill"].XValueMember = "Loại";
                Chart.chart.Series["Bill"].YValueMembers = "Số Lượng";
                Chart.chart.Legends[0].Enabled = true;

                var chartArea = Chart.chart.ChartAreas[0];
                chartArea.AxisX.TitleFont = new Font("Segui UI", 10, FontStyle.Bold);
                chartArea.BackColor = Color.Gainsboro;
                chartArea.AxisX.LineColor = Color.AliceBlue;
                chartArea.AxisX.MajorGrid.LineColor = Color.White;
                chartArea.AxisX.LabelStyle.ForeColor = Color.White;
                chartArea.AxisY.LineColor = Color.White;
                chartArea.AxisY.MajorGrid.LineColor = Color.White;
                chartArea.AxisY.LabelStyle.ForeColor = Color.White;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElement_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(StatisticalChart.Instance);
            StatisticalChart.Instance.Dock = DockStyle.Fill;
            StatisticalChart.Instance.BringToFront();
            SetElementImportChart(StatisticalChart.Instance);
        }

        private void SetElementImportChart(StatisticalChart Chart)
        {
            Chart.chart.DataSource = null;
            Chart.chart.Series.Clear();
            try
            {
                var ListMuc = dsElement.Tables[0].AsEnumerable().OrderBy(x => x.Field<int>("Mã NCC")).Select(x => x).ToList();
                Chart.chart.DataSource = ListMuc;
                var series = Chart.chart.Series.Add("Element");
                series.LabelForeColor = Color.AliceBlue;
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Segui UI", 16);
                Chart.chart.Series["Element"].XValueMember = "Tên NCC";
                Chart.chart.Series["Element"].YValueMembers = "Số Lượng Nguyên Liệu";
                Chart.chart.Legends[0].Enabled = true;
                Chart.chart.ChartAreas[0].Area3DStyle.Enable3D = true;

                var chartArea = Chart.chart.ChartAreas[0];
                chartArea.AxisX.TitleFont = new Font("Segui UI", 10, FontStyle.Bold);
                chartArea.BackColor = Color.Gainsboro;
                chartArea.AxisX.LineColor = Color.AliceBlue;
                chartArea.AxisX.MajorGrid.LineColor = Color.White;
                chartArea.AxisX.LabelStyle.ForeColor = Color.White;
                chartArea.AxisY.LineColor = Color.White;
                chartArea.AxisY.MajorGrid.LineColor = Color.White;
                chartArea.AxisY.LabelStyle.ForeColor = Color.White;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
