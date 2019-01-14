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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            timerFlash.Start();
            timerFlash.Enabled = true;
            timerTime.Enabled = true;
            timerTime.Start();

            panelInfo.Controls.Add(DashboardAdmin.Instance);
            DashboardAdmin.Instance.Dock = DockStyle.Fill;
            DashboardAdmin.Instance.BringToFront();
        }

        private void timerFlash_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            lbAdmin.ForeColor = Color.FromArgb(A, R, G, B);
            //lbASROMA.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void btnRegisterUsers_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(RegisterUsers.Instance);
            RegisterUsers.Instance.Dock = DockStyle.Fill;
            RegisterUsers.Instance.BringToFront();
        }

        private void btnViewTables_Click(object sender, EventArgs e)
        {
            ViewTables vt = new ViewTables(1);
            panelInfo.Controls.Add(vt);
            vt.Dock = DockStyle.Fill;
            vt.BringToFront();
            //panelInfo.Controls.Add(ViewTables.Instance);
            //ViewTables.type = 1;
            //ViewTables.Instance.Dock = DockStyle.Fill;
            //ViewTables.Instance.BringToFront();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Change_Password ch = new Change_Password(lbAdmin.Text);
            panelInfo.Controls.Add(ch);
            ch.Dock = DockStyle.Fill;
            ch.BringToFront();
            //panelInfo.Controls.Add(Change_Password.Instance);
            //Change_Password.Instance.Dock = DockStyle.Fill;
            //Change_Password.Instance.BringToFront();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            frmCalculator frm = new frmCalculator();
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(DashboardAdmin.Instance);
            DashboardAdmin.Instance.Dock = DockStyle.Fill;
            DashboardAdmin.Instance.BringToFront();
        }

        private void btnCalculator_Click_1(object sender, EventArgs e)
        {
            frmCalculator frm = new frmCalculator();
            frm.Show();
        }
 
        private void lbAdmin_Click(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(RegisterCustomer.Instance);
            RegisterCustomer.Instance.Dock = DockStyle.Fill;
            RegisterCustomer.Instance.BringToFront();
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(Supply.Instance);
            Supply.Instance.Dock = DockStyle.Fill;
            Supply.Instance.BringToFront();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(ManageReceipts.Instance);
            ManageReceipts.Instance.Dock = DockStyle.Fill;
            ManageReceipts.Instance.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Add(ManageProducts.Instance);
            ManageProducts.Instance.Dock = DockStyle.Fill;
            ManageProducts.Instance.BringToFront();
        }

        private void btnEditProfiles_Click(object sender, EventArgs e)
        {
            EditProfiles edit = new EditProfiles();
            panelInfo.Controls.Add(edit);
            edit.Dock = DockStyle.Fill;
            edit.BringToFront();
            //EditProfiles.Instance.Refresh();
            //EditProfiles.Instance.Dock = DockStyle.Fill;
            //EditProfiles.Instance.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder frm = new frmOrder();
            frm.ShowDialog();
        }
    }
}
