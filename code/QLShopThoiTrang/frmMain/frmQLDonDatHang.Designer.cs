namespace frmMain
{
    partial class frmQLDonDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.clMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.clMaDatHang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChiGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDTNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnXoaDon = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.chkKhachLa = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMucGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.AllowUserToAddRows = false;
            this.dgvChiTietDonHang.AllowUserToDeleteRows = false;
            this.dgvChiTietDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietDonHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDonHang,
            this.clMaSP,
            this.clMaSanPham,
            this.clSoLuong,
            this.clDonGia,
            this.hinhanh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietDonHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(3, 3);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.ReadOnly = true;
            this.dgvChiTietDonHang.RowTemplate.Height = 100;
            this.dgvChiTietDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(500, 324);
            this.dgvChiTietDonHang.TabIndex = 1;
            // 
            // clMaDonHang
            // 
            this.clMaDonHang.DataPropertyName = "MaDonHang";
            this.clMaDonHang.HeaderText = "Mã đơn hàng";
            this.clMaDonHang.Name = "clMaDonHang";
            this.clMaDonHang.ReadOnly = true;
            this.clMaDonHang.Visible = false;
            // 
            // clMaSP
            // 
            this.clMaSP.DataPropertyName = "MaSP";
            this.clMaSP.HeaderText = "Mã sản phẩm";
            this.clMaSP.Name = "clMaSP";
            this.clMaSP.ReadOnly = true;
            this.clMaSP.Visible = false;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.DataPropertyName = "TenSP";
            this.clMaSanPham.HeaderText = "Tên sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = " Giá bán";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "HinhAnh";
            this.hinhanh.HeaderText = "Hình Ảnh";
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.ReadOnly = true;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgvChiTietDonHang);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(458, 88);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(506, 330);
            this.pnlFill.TabIndex = 8;
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            this.dgvDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDatHang1,
            this.clTenDN,
            this.clNgayTao,
            this.ThanhToan,
            this.clNguoidung,
            this.clDiaChiGiaoHang,
            this.clTenNguoiNhan,
            this.clSDTNhan,
            this.clEmail,
            this.clThanhTien});
            this.dgvDonHang.Location = new System.Drawing.Point(3, 3);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowTemplate.Height = 55;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(452, 324);
            this.dgvDonHang.TabIndex = 0;
            // 
            // clMaDatHang1
            // 
            this.clMaDatHang1.DataPropertyName = "MaDatHang";
            this.clMaDatHang1.HeaderText = "Mã đơn hàng";
            this.clMaDatHang1.Name = "clMaDatHang1";
            this.clMaDatHang1.Visible = false;
            // 
            // clTenDN
            // 
            this.clTenDN.DataPropertyName = "TenDN";
            this.clTenDN.HeaderText = "Tên ĐN";
            this.clTenDN.Name = "clTenDN";
            // 
            // clNgayTao
            // 
            this.clNgayTao.DataPropertyName = "NGAYTAO";
            this.clNgayTao.HeaderText = "Ngày lập";
            this.clNgayTao.Name = "clNgayTao";
            // 
            // ThanhToan
            // 
            this.ThanhToan.DataPropertyName = "ThanhToan";
            this.ThanhToan.HeaderText = "Thanh toán";
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Visible = false;
            // 
            // clNguoidung
            // 
            this.clNguoidung.DataPropertyName = "Nguoidung";
            this.clNguoidung.HeaderText = "người dùng";
            this.clNguoidung.Name = "clNguoidung";
            this.clNguoidung.Visible = false;
            // 
            // clDiaChiGiaoHang
            // 
            this.clDiaChiGiaoHang.DataPropertyName = "DIACHIGIAOHANG";
            this.clDiaChiGiaoHang.HeaderText = "Địa chỉ giao";
            this.clDiaChiGiaoHang.Name = "clDiaChiGiaoHang";
            // 
            // clTenNguoiNhan
            // 
            this.clTenNguoiNhan.DataPropertyName = "TENNGUOINHAN";
            this.clTenNguoiNhan.HeaderText = "Tên người nhận";
            this.clTenNguoiNhan.Name = "clTenNguoiNhan";
            // 
            // clSDTNhan
            // 
            this.clSDTNhan.DataPropertyName = "SDTNHAN";
            this.clSDTNhan.HeaderText = "SĐT người nhận";
            this.clSDTNhan.Name = "clSDTNhan";
            // 
            // clEmail
            // 
            this.clEmail.DataPropertyName = "EMAIL";
            this.clEmail.HeaderText = "Email nhận";
            this.clEmail.Name = "clEmail";
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "ThanhTien";
            this.clThanhTien.HeaderText = "Tổng giá trị";
            this.clThanhTien.Name = "clThanhTien";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvDonHang);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 88);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(458, 330);
            this.pnlLeft.TabIndex = 7;
            // 
            // btnXoaDon
            // 
            this.btnXoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDon.BackColor = System.Drawing.Color.Blue;
            this.btnXoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXoaDon.Location = new System.Drawing.Point(238, 6);
            this.btnXoaDon.MinimumSize = new System.Drawing.Size(83, 62);
            this.btnXoaDon.Name = "btnXoaDon";
            this.btnXoaDon.Size = new System.Drawing.Size(83, 62);
            this.btnXoaDon.TabIndex = 0;
            this.btnXoaDon.Text = "Xóa đơn";
            this.btnXoaDon.UseVisualStyleBackColor = false;
            this.btnXoaDon.Click += new System.EventHandler(this.btnXoaDon_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBottom.Controls.Add(this.btnXoaDon);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 418);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(964, 80);
            this.pnlBottom.TabIndex = 6;
            // 
            // chkKhachLa
            // 
            this.chkKhachLa.AutoSize = true;
            this.chkKhachLa.Location = new System.Drawing.Point(80, 55);
            this.chkKhachLa.Name = "chkKhachLa";
            this.chkKhachLa.Size = new System.Drawing.Size(68, 17);
            this.chkKhachLa.TabIndex = 3;
            this.chkKhachLa.Text = "Khách lạ";
            this.chkKhachLa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá trị đơn";
            // 
            // cboMucGia
            // 
            this.cboMucGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMucGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMucGia.FormattingEnabled = true;
            this.cboMucGia.Location = new System.Drawing.Point(80, 19);
            this.cboMucGia.Name = "cboMucGia";
            this.cboMucGia.Size = new System.Drawing.Size(189, 24);
            this.cboMucGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá trị đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkKhachLa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMucGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 88);
            this.pnlTop.TabIndex = 5;
            // 
            // frmQLDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmQLDonDatHang";
            this.Text = "frmQLDonDatHang";
            this.Load += new System.EventHandler(this.frmQLDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnXoaDon;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.CheckBox chkKhachLa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMucGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDatHang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChiGiaoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDTNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}