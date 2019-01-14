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
    public partial class frmCalculator : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_pressed == true))
                txtResult.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            txtResult.Text = txtResult.Text + b.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(txtResult.Text);
            operation_pressed = true;
            lbEquation.Text = value + " " + operation;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            lbEquation.Text = "";
            
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            value = 0;
        }
    }
}
