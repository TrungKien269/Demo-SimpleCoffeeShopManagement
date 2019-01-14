namespace WF_CoffeeManage
{
    partial class ManageReceipts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.dtgvReceipts = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbCountRow = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.thoiDiemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.maKHDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.thoiDiemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDetail);
            this.groupBox2.Controls.Add(this.dtgvReceipts);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.lbCountRow);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.dtToDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtFromDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 281);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Receipts";
            // 
            // btnDetail
            // 
            this.btnDetail.ForeColor = System.Drawing.Color.Black;
            this.btnDetail.Location = new System.Drawing.Point(351, 252);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 13;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // dtgvReceipts
            // 
            this.dtgvReceipts.AllowUserToResizeColumns = false;
            this.dtgvReceipts.AllowUserToResizeRows = false;
            this.dtgvReceipts.AutoGenerateColumns = false;
            this.dtgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvReceipts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvReceipts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dtgvReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvReceipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thoiDiemDataGridViewTextBoxColumn,
            this.maHDDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.thanhPhoDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dtgvReceipts.DataSource = this.ordersBindingSource4;
            this.dtgvReceipts.EnableHeadersVisualStyles = false;
            this.dtgvReceipts.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvReceipts.Location = new System.Drawing.Point(11, 41);
            this.dtgvReceipts.Name = "dtgvReceipts";
            this.dtgvReceipts.ReadOnly = true;
            this.dtgvReceipts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReceipts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvReceipts.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvReceipts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReceipts.Size = new System.Drawing.Size(496, 206);
            this.dtgvReceipts.TabIndex = 15;
            this.dtgvReceipts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvReceipts_CellClick);
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(432, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbCountRow
            // 
            this.lbCountRow.AutoSize = true;
            this.lbCountRow.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountRow.Location = new System.Drawing.Point(10, 259);
            this.lbCountRow.Name = "lbCountRow";
            this.lbCountRow.Size = new System.Drawing.Size(446, 22);
            this.lbCountRow.TabIndex = 13;
            this.lbCountRow.Text = "STATUS: There are 0 record(s) found in database";
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(432, 253);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtToDate.Location = new System.Drawing.Point(257, 16);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(165, 27);
            this.dtToDate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "To:";
            // 
            // dtFromDate
            // 
            this.dtFromDate.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromDate.Location = new System.Drawing.Point(66, 16);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(165, 27);
            this.dtFromDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date:";
            // 
            // thoiDiemDataGridViewTextBoxColumn1
            // 
            this.thoiDiemDataGridViewTextBoxColumn1.DataPropertyName = "ThoiDiem";
            this.thoiDiemDataGridViewTextBoxColumn1.HeaderText = "ThoiDiem";
            this.thoiDiemDataGridViewTextBoxColumn1.Name = "thoiDiemDataGridViewTextBoxColumn1";
            this.thoiDiemDataGridViewTextBoxColumn1.Width = 71;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.Width = 70;
            // 
            // diaChiDataGridViewTextBoxColumn1
            // 
            this.diaChiDataGridViewTextBoxColumn1.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn1.Name = "diaChiDataGridViewTextBoxColumn1";
            this.diaChiDataGridViewTextBoxColumn1.Width = 71;
            // 
            // maKHDataGridViewTextBoxColumn1
            // 
            this.maKHDataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn1.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn1.Name = "maKHDataGridViewTextBoxColumn1";
            this.maKHDataGridViewTextBoxColumn1.Width = 71;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.Width = 61;
            // 
            // ordersBindingSource4
            // 
            this.ordersBindingSource4.DataSource = typeof(WF_CoffeeManage.Orders);
            // 
            // maKHDataGridViewTextBoxColumn2
            // 
            this.maKHDataGridViewTextBoxColumn2.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn2.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn2.Name = "maKHDataGridViewTextBoxColumn2";
            this.maKHDataGridViewTextBoxColumn2.Width = 70;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataSource = typeof(WF_CoffeeManage.Orders);
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataSource = typeof(WF_CoffeeManage.Orders);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(WF_CoffeeManage.Orders);
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataSource = typeof(WF_CoffeeManage.Orders);
            // 
            // thoiDiemDataGridViewTextBoxColumn
            // 
            this.thoiDiemDataGridViewTextBoxColumn.DataPropertyName = "Thời Điểm";
            this.thoiDiemDataGridViewTextBoxColumn.HeaderText = "Thời Gian";
            this.thoiDiemDataGridViewTextBoxColumn.Name = "thoiDiemDataGridViewTextBoxColumn";
            this.thoiDiemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "Mã Hóa Đơn";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "Hóa Đơn";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "Khách Hàng";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Khách Hàng";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhPhoDataGridViewTextBoxColumn
            // 
            this.thanhPhoDataGridViewTextBoxColumn.DataPropertyName = "Nhân Viên";
            this.thanhPhoDataGridViewTextBoxColumn.HeaderText = "Nhân Viên";
            this.thanhPhoDataGridViewTextBoxColumn.Name = "thanhPhoDataGridViewTextBoxColumn";
            this.thanhPhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Điện Thoại";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ManageReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ManageReceipts";
            this.Size = new System.Drawing.Size(749, 465);
            this.Load += new System.EventHandler(this.ManageReceipts_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbCountRow;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private System.Windows.Forms.DataGridView dtgvReceipts;
        private System.Windows.Forms.BindingSource ordersBindingSource4;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiDiemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiDiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhPhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn2;
    }
}
