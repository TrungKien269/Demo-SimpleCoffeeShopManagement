namespace WF_CoffeeManage
{
    partial class frmDetailBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbTongSL = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.dtgvDSTU = new System.Windows.Forms.DataGridView();
            this.MaTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSTU)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.lbTongSL);
            this.panel1.Controls.Add(this.lbMaHD);
            this.panel1.Controls.Add(this.dtgvDSTU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 330);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(569, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 40);
            this.btnExit.TabIndex = 97;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Black;
            this.lbTongTien.Location = new System.Drawing.Point(324, 260);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(153, 25);
            this.lbTongTien.TabIndex = 96;
            this.lbTongTien.Text = "Tổng số tiền trả: ";
            // 
            // lbTongSL
            // 
            this.lbTongSL.AutoSize = true;
            this.lbTongSL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSL.ForeColor = System.Drawing.Color.Black;
            this.lbTongSL.Location = new System.Drawing.Point(36, 260);
            this.lbTongSL.Name = "lbTongSL";
            this.lbTongSL.Size = new System.Drawing.Size(142, 25);
            this.lbTongSL.TabIndex = 95;
            this.lbTongSL.Text = "Tổng số lượng: ";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.ForeColor = System.Drawing.Color.Black;
            this.lbMaHD.Location = new System.Drawing.Point(259, 0);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(136, 33);
            this.lbMaHD.TabIndex = 94;
            this.lbMaHD.Text = "Hóa Đơn ";
            // 
            // dtgvDSTU
            // 
            this.dtgvDSTU.AllowUserToResizeColumns = false;
            this.dtgvDSTU.AllowUserToResizeRows = false;
            this.dtgvDSTU.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDSTU.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvDSTU.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSTU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDSTU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDSTU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTU,
            this.TenTU,
            this.MaLoai,
            this.DonGia,
            this.ThanhTien});
            this.dtgvDSTU.EnableHeadersVisualStyles = false;
            this.dtgvDSTU.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtgvDSTU.Location = new System.Drawing.Point(40, 37);
            this.dtgvDSTU.Name = "dtgvDSTU";
            this.dtgvDSTU.ReadOnly = true;
            this.dtgvDSTU.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSTU.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDSTU.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvDSTU.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDSTU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSTU.Size = new System.Drawing.Size(636, 210);
            this.dtgvDSTU.TabIndex = 93;
            // 
            // MaTU
            // 
            this.MaTU.DataPropertyName = "MaHD";
            this.MaTU.HeaderText = "Mã Hóa Đơn";
            this.MaTU.Name = "MaTU";
            this.MaTU.ReadOnly = true;
            this.MaTU.Width = 127;
            // 
            // TenTU
            // 
            this.TenTU.DataPropertyName = "TenTU";
            this.TenTU.HeaderText = "Tên Thức Uống";
            this.TenTU.Name = "TenTU";
            this.TenTU.ReadOnly = true;
            this.TenTU.Width = 126;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "SoLuong";
            this.MaLoai.HeaderText = "Số Lượng";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 127;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 126;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 127;
            // 
            // frmDetailBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(713, 330);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailBill";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Detail";
            this.Load += new System.EventHandler(this.frmDetailBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSTU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbTongSL;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.DataGridView dtgvDSTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}