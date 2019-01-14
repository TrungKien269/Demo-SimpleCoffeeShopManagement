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
    public partial class Dashboard : UserControl
    {
        private static Dashboard _instance;
        public static Dashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Dashboard();
                return _instance;
            }
        }

        public Dashboard()
        {
            InitializeComponent();
        }
    }
}
