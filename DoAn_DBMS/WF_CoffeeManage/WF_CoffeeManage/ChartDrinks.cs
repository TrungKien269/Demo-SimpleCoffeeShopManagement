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
    public partial class ChartDrinks : UserControl
    {

        private static ChartDrinks _instance;
        public static ChartDrinks Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChartDrinks();
                return _instance;
            }
        }
        public ChartDrinks()
        {
            InitializeComponent();
        }
    }
}
