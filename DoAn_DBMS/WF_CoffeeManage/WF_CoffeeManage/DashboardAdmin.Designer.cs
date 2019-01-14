namespace WF_CoffeeManage
{
    partial class DashboardAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnElement = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panelInfo);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 281);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary Chart";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.btnElement);
            this.panel3.Controls.Add(this.btnBill);
            this.panel3.Controls.Add(this.btnDrink);
            this.panel3.Controls.Add(this.btnSalary);
            this.panel3.Location = new System.Drawing.Point(5, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 34);
            this.panel3.TabIndex = 1;
            // 
            // btnElement
            // 
            this.btnElement.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElement.ForeColor = System.Drawing.Color.White;
            this.btnElement.Image = ((System.Drawing.Image)(resources.GetObject("btnElement.Image")));
            this.btnElement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElement.Location = new System.Drawing.Point(382, 3);
            this.btnElement.Name = "btnElement";
            this.btnElement.Size = new System.Drawing.Size(120, 29);
            this.btnElement.TabIndex = 16;
            this.btnElement.Text = "Element Import";
            this.btnElement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElement.UseVisualStyleBackColor = false;
            this.btnElement.Click += new System.EventHandler(this.btnElement_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(256, 3);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(120, 29);
            this.btnBill.TabIndex = 15;
            this.btnBill.Text = "Bill Sale";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrink.ForeColor = System.Drawing.Color.White;
            this.btnDrink.Image = ((System.Drawing.Image)(resources.GetObject("btnDrink.Image")));
            this.btnDrink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrink.Location = new System.Drawing.Point(129, 3);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(120, 29);
            this.btnDrink.TabIndex = 14;
            this.btnDrink.Text = "Drinks Sale";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrinkSale_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.Image = ((System.Drawing.Image)(resources.GetObject("btnSalary.Image")));
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(8, 3);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(114, 29);
            this.btnSalary.TabIndex = 13;
            this.btnSalary.Text = "           Employee Salary";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalaryEmployee_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackgroundImage = global::WF_CoffeeManage.Properties.Resources.Dashboard;
            this.panelInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelInfo.Location = new System.Drawing.Point(5, 16);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(509, 224);
            this.panelInfo.TabIndex = 0;
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.groupBox2);
            this.Name = "DashboardAdmin";
            this.Size = new System.Drawing.Size(859, 406);
            this.Load += new System.EventHandler(this.DashboardAdmin_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnElement;
    }
}
