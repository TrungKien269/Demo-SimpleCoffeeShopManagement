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
    public partial class frmEmployee : Form
    {
        public frmEmployee(string id)
        {
            this.EmpID = id;
            InitializeComponent();
            LoadForm();
        }

        private string EmpID;

        private void LoadForm()
        {
            sidepanel.Height = btnDashboard.Height;
            sidepanel.Top = btnDashboard.Top;

            panelInfo.Controls.Add(Dashboard.Instance);
            Dashboard.Instance.Dock = DockStyle.Fill;
            Dashboard.Instance.BringToFront();
            lbEmployee.Text = this.EmpID;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnDashboard.Height;
            sidepanel.Top = btnDashboard.Top;


            panelInfo.Controls.Add(Dashboard.Instance);
            Dashboard.Instance.Dock = DockStyle.Fill;
            Dashboard.Instance.BringToFront();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            timerFlash.Start();
            timerFlash.Enabled = true;
            timerTime.Enabled = true;
            timerTime.Start();
        }

        private void btnViewTables_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnViewTables.Height;
            sidepanel.Top = btnViewTables.Top;

            ViewTables vt = new ViewTables(0);
            panelInfo.Controls.Add(vt);
            vt.Dock = DockStyle.Fill;
            vt.BringToFront();
            //panelInfo.Controls.Add(ViewTables.Instance);
            //ViewTables.type = 1;
            //ViewTables.Instance.Dock = DockStyle.Fill;
            //ViewTables.Instance.BringToFront();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    sidepanel.Height = btnReceipt.Height;
        //    sidepanel.Top = btnReceipt.Top;

        //    panelInfo.Controls.Add(ManageReceipts.Instance);
        //    ManageReceipts.Instance.Dock = DockStyle.Fill;
        //    ManageReceipts.Instance.BringToFront();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    sidepanel.Height = btnCustomer.Height;
        //    sidepanel.Top = btnCustomer.Top;

        //    panelInfo.Controls.Add(RegisterCustomer.Instance);
        //    RegisterCustomer.Instance.Dock = DockStyle.Fill;
        //    RegisterCustomer.Instance.BringToFront();
        //}

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnChangePassword.Height;
            sidepanel.Top = btnChangePassword.Top;

            Change_Password ch = new Change_Password(lbEmployee.Text);
            panelInfo.Controls.Add(ch);
            ch.Dock = DockStyle.Fill;
            ch.BringToFront();
            ch.grbAddAccount.Visible = false;
            //ch.grbEditPass.Size = new Size(400, 500);
            //panelInfo.Controls.Add(Change_Password.Instance);
            //Change_Password.Instance.Dock = DockStyle.Fill;
            //Change_Password.Instance.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnProduct.Height;
            sidepanel.Top = btnProduct.Top;

            panelInfo.Controls.Add(ManageProducts.Instance);
            ManageProducts.Instance.Dock = DockStyle.Fill;
            ManageProducts.Instance.BringToFront();
            ManageProducts.Instance.btnAddImage.Enabled = false;
            ManageProducts.Instance.btnDelete.Enabled = false;
            ManageProducts.Instance.btnEdit.Enabled = false;
            ManageProducts.Instance.btnInsert.Enabled = false;
            ManageProducts.Instance.btnSave.Enabled = false;
            ManageProducts.Instance.cbDanhMuc.Enabled = false;
            ManageProducts.Instance.txtDonGia.Enabled = false;
            ManageProducts.Instance.txtMaTU.Enabled = false;
            ManageProducts.Instance.txtTenTU.Enabled = false;
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnSupply.Height;
            sidepanel.Top = btnSupply.Top;

            panelInfo.Controls.Add(Supply.Instance);
            Supply.Instance.Dock = DockStyle.Fill;
            Supply.Instance.BringToFront();

            Supply.Instance.btnDelete.Enabled = false;
            Supply.Instance.btnEdit.Enabled = false;
            Supply.Instance.btnInsert.Enabled = false;
            Supply.Instance.txtDiaChi.Enabled = false;
            Supply.Instance.txtMaNCC.Enabled = false;
            Supply.Instance.txtTenNCC.Enabled = false;
            Supply.Instance.txtDienThoai.Enabled = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder frmOr = new frmOrder();
            frmOr.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            frmCalculator frm = new frmCalculator();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            lbEmployee.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnReceipt.Height;
            sidepanel.Top = btnReceipt.Top;

            panelInfo.Controls.Add(ManageReceipts.Instance);
            ManageReceipts.Instance.Dock = DockStyle.Fill;
            ManageReceipts.Instance.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btnCustomer.Height;
            sidepanel.Top = btnCustomer.Top;

            panelInfo.Controls.Add(RegisterCustomer.Instance);
            RegisterCustomer.Instance.Dock = DockStyle.Fill;
            RegisterCustomer.Instance.BringToFront();

            RegisterCustomer.Instance.btnDelete.Enabled = false;
            RegisterCustomer.Instance.btnEdit.Enabled = false;
            RegisterCustomer.Instance.btnInsert.Enabled = false;
            RegisterCustomer.Instance.cbGioiTinh.Enabled = false;
            RegisterCustomer.Instance.txtDiaChi.Enabled = false;
            RegisterCustomer.Instance.txtDienThoai.Enabled = false;
            RegisterCustomer.Instance.txtHoTen.Enabled = false;
            RegisterCustomer.Instance.txtMaKH.Enabled = false;
            RegisterCustomer.Instance.txtThanhPho.Enabled = false;
        }
    }
}
