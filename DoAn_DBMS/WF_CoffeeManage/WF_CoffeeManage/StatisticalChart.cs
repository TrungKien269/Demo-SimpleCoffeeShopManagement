using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_CoffeeManage
{
    public partial class StatisticalChart : UserControl
    {

        private static StatisticalChart _instance;
        public static StatisticalChart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StatisticalChart();
                return _instance;
            }
        }
        public StatisticalChart()
        {
            InitializeComponent();
        }

        private void chartNV_Click(object sender, EventArgs e)
        {

        }

        private void chartNV_Click_1(object sender, EventArgs e)
        {

        }

        private void ChartEmployeeSalary_Load(object sender, EventArgs e)
        {

        }
    }
}
