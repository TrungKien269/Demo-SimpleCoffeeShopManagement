namespace WF_CoffeeManage
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.timerFlash = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnViewTables = new System.Windows.Forms.Button();
            this.btnRegisterUsers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditProfiles = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSupply = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelInfo = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(197, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmin.Location = new System.Drawing.Point(54, 28);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(78, 26);
            this.lbAdmin.TabIndex = 0;
            this.lbAdmin.Text = "Admin";
            this.lbAdmin.Click += new System.EventHandler(this.lbAdmin_Click);
            // 
            // timerFlash
            // 
            this.timerFlash.Tick += new System.EventHandler(this.timerFlash_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnCalculator);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(217, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 61);
            this.panel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = global::WF_CoffeeManage.Properties.Resources.shutdown40px;
            this.btnExit.Location = new System.Drawing.Point(793, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 48);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.Black;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculator.Image")));
            this.btnCalculator.Location = new System.Drawing.Point(723, 7);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(50, 48);
            this.btnCalculator.TabIndex = 9;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Image = global::WF_CoffeeManage.Properties.Resources.order_icon40px;
            this.btnOrder.Location = new System.Drawing.Point(650, 7);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(50, 48);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTime.Location = new System.Drawing.Point(96, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(91, 21);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "3:52:41 PM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Adminstrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WF_CoffeeManage.Properties.Resources.CoffeeCup;
            this.pictureBox1.Location = new System.Drawing.Point(256, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Controls.Add(this.btnCustomer);
            this.groupBox3.Controls.Add(this.btnReceipt);
            this.groupBox3.Controls.Add(this.btnViewTables);
            this.groupBox3.Controls.Add(this.btnRegisterUsers);
            this.groupBox3.Controls.Add(this.btnDashboard);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(12, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 244);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manage Human";
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(7, 157);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(183, 38);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "    Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnReceipt.Image")));
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.Location = new System.Drawing.Point(7, 200);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(183, 38);
            this.btnReceipt.TabIndex = 3;
            this.btnReceipt.Text = "       List Receipts";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnViewTables
            // 
            this.btnViewTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTables.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTables.ForeColor = System.Drawing.Color.White;
            this.btnViewTables.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTables.Image")));
            this.btnViewTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTables.Location = new System.Drawing.Point(7, 113);
            this.btnViewTables.Name = "btnViewTables";
            this.btnViewTables.Size = new System.Drawing.Size(183, 38);
            this.btnViewTables.TabIndex = 2;
            this.btnViewTables.Text = "     View Tables";
            this.btnViewTables.UseVisualStyleBackColor = true;
            this.btnViewTables.Click += new System.EventHandler(this.btnViewTables_Click);
            // 
            // btnRegisterUsers
            // 
            this.btnRegisterUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUsers.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnRegisterUsers.Image")));
            this.btnRegisterUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterUsers.Location = new System.Drawing.Point(7, 69);
            this.btnRegisterUsers.Name = "btnRegisterUsers";
            this.btnRegisterUsers.Size = new System.Drawing.Size(183, 38);
            this.btnRegisterUsers.TabIndex = 1;
            this.btnRegisterUsers.Text = "   Employees";
            this.btnRegisterUsers.UseVisualStyleBackColor = true;
            this.btnRegisterUsers.Click += new System.EventHandler(this.btnRegisterUsers_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(7, 25);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(183, 38);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Controls.Add(this.btnEditProfiles);
            this.groupBox4.Controls.Add(this.btnChangePassword);
            this.groupBox4.Controls.Add(this.btnSupply);
            this.groupBox4.Controls.Add(this.btnProduct);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 206);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Object:";
            // 
            // btnEditProfiles
            // 
            this.btnEditProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfiles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfiles.ForeColor = System.Drawing.Color.White;
            this.btnEditProfiles.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProfiles.Image")));
            this.btnEditProfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProfiles.Location = new System.Drawing.Point(7, 161);
            this.btnEditProfiles.Name = "btnEditProfiles";
            this.btnEditProfiles.Size = new System.Drawing.Size(183, 38);
            this.btnEditProfiles.TabIndex = 4;
            this.btnEditProfiles.Text = "  Edit Profiles";
            this.btnEditProfiles.UseVisualStyleBackColor = true;
            this.btnEditProfiles.Click += new System.EventHandler(this.btnEditProfiles_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(7, 117);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(183, 38);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "           Edit Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSupply
            // 
            this.btnSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupply.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupply.ForeColor = System.Drawing.Color.White;
            this.btnSupply.Image = ((System.Drawing.Image)(resources.GetObject("btnSupply.Image")));
            this.btnSupply.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSupply.Location = new System.Drawing.Point(7, 73);
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.Size = new System.Drawing.Size(183, 38);
            this.btnSupply.TabIndex = 1;
            this.btnSupply.Text = "Resources";
            this.btnSupply.UseVisualStyleBackColor = true;
            this.btnSupply.Click += new System.EventHandler(this.btnSupply_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(7, 28);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(183, 38);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "          Manage Drinks";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // panelInfo
            // 
            this.panelInfo.Location = new System.Drawing.Point(217, 78);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(863, 453);
            this.panelInfo.TabIndex = 8;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1090, 542);
            this.ControlBox = false;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Control Panel";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerFlash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnViewTables;
        private System.Windows.Forms.Button btnRegisterUsers;
        private System.Windows.Forms.Button btnEditProfiles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupply;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Label lbAdmin;
    }
}