namespace frmMain
{
    partial class frmThem1NhapHang
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnXacNhanDon = new System.Windows.Forms.Button();
            this.txtTongTien = new ThuVien.NumericTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlDGVChiTiet = new System.Windows.Forms.Panel();
            this.dgvChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.clMaNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaChiTietNhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtGiaTri = new ThuVien.NumericTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaSP = new System.Windows.Forms.ComboBox();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlDGVChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 55);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sản phẩm sẽ nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnXacNhanDon);
            this.pnlBottom.Controls.Add(this.txtTongTien);
            this.pnlBottom.Controls.Add(this.label6);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 388);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 62);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnXacNhanDon
            // 
            this.btnXacNhanDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXacNhanDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDon.ForeColor = System.Drawing.Color.Red;
            this.btnXacNhanDon.Location = new System.Drawing.Point(350, 5);
            this.btnXacNhanDon.Name = "btnXacNhanDon";
            this.btnXacNhanDon.Size = new System.Drawing.Size(101, 53);
            this.btnXacNhanDon.TabIndex = 13;
            this.btnXacNhanDon.Text = "Xác nhận đơn";
            this.btnXacNhanDon.UseVisualStyleBackColor = false;
            this.btnXacNhanDon.Click += new System.EventHandler(this.btnXacNhanDon_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.AllowMinusSign = false;
            this.txtTongTien.Location = new System.Drawing.Point(100, 6);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(221, 20);
            this.txtTongTien.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng tiền";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlDGVChiTiet);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 55);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(401, 333);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlDGVChiTiet
            // 
            this.pnlDGVChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGVChiTiet.Controls.Add(this.dgvChiTietNhapHang);
            this.pnlDGVChiTiet.Location = new System.Drawing.Point(3, 3);
            this.pnlDGVChiTiet.Name = "pnlDGVChiTiet";
            this.pnlDGVChiTiet.Size = new System.Drawing.Size(395, 327);
            this.pnlDGVChiTiet.TabIndex = 3;
            // 
            // dgvChiTietNhapHang
            // 
            this.dgvChiTietNhapHang.AllowUserToAddRows = false;
            this.dgvChiTietNhapHang.AllowUserToDeleteRows = false;
            this.dgvChiTietNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietNhapHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.dgvChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNhapHang,
            this.clMaChiTietNhaphang,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clSoLuong,
            this.clGiaNhap});
            this.dgvChiTietNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietNhapHang.Name = "dgvChiTietNhapHang";
            this.dgvChiTietNhapHang.ReadOnly = true;
            this.dgvChiTietNhapHang.RowTemplate.Height = 100;
            this.dgvChiTietNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietNhapHang.Size = new System.Drawing.Size(395, 327);
            this.dgvChiTietNhapHang.TabIndex = 0;
            // 
            // clMaNhapHang
            // 
            this.clMaNhapHang.DataPropertyName = "MaNhapHang";
            this.clMaNhapHang.HeaderText = "Mã nhập hàng";
            this.clMaNhapHang.Name = "clMaNhapHang";
            this.clMaNhapHang.ReadOnly = true;
            this.clMaNhapHang.Visible = false;
            // 
            // clMaChiTietNhaphang
            // 
            this.clMaChiTietNhaphang.DataPropertyName = "MaChiTietNhapHang";
            this.clMaChiTietNhaphang.HeaderText = "Mã chi tiết nhập hàng";
            this.clMaChiTietNhaphang.Name = "clMaChiTietNhaphang";
            this.clMaChiTietNhaphang.ReadOnly = true;
            this.clMaChiTietNhaphang.Visible = false;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.DataPropertyName = "MaSanPham";
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            this.clMaSanPham.Visible = false;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.DataPropertyName = "TenSanPham";
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clGiaNhap
            // 
            this.clGiaNhap.DataPropertyName = "GiaNhap";
            this.clGiaNhap.HeaderText = "Giá nhập";
            this.clGiaNhap.Name = "clGiaNhap";
            this.clGiaNhap.ReadOnly = true;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.btnTroVe);
            this.pnlFill.Controls.Add(this.btnXoaSP);
            this.pnlFill.Controls.Add(this.btnThemSP);
            this.pnlFill.Controls.Add(this.txtGiaTri);
            this.pnlFill.Controls.Add(this.label5);
            this.pnlFill.Controls.Add(this.nudSoLuong);
            this.pnlFill.Controls.Add(this.label4);
            this.pnlFill.Controls.Add(this.label3);
            this.pnlFill.Controls.Add(this.cboSanPham);
            this.pnlFill.Controls.Add(this.label2);
            this.pnlFill.Controls.Add(this.cboMaSP);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(401, 55);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(399, 333);
            this.pnlFill.TabIndex = 3;
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.Blue;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(265, 216);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(106, 53);
            this.btnTroVe.TabIndex = 13;
            this.btnTroVe.Text = "Trở về nhập hàng";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.Blue;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(145, 216);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(101, 53);
            this.btnXoaSP.TabIndex = 12;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.BackColor = System.Drawing.Color.Blue;
            this.btnThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(26, 216);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(101, 53);
            this.btnThemSP.TabIndex = 11;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = false;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.AllowMinusSign = false;
            this.txtGiaTri.Location = new System.Drawing.Point(124, 121);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(221, 20);
            this.txtGiaTri.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá trị";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(124, 150);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(221, 20);
            this.nudSoLuong.TabIndex = 8;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sản phẩm";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(124, 88);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(221, 21);
            this.cboSanPham.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã sản phẩm";
            // 
            // cboMaSP
            // 
            this.cboMaSP.FormattingEnabled = true;
            this.cboMaSP.Location = new System.Drawing.Point(124, 48);
            this.cboMaSP.Name = "cboMaSP";
            this.cboMaSP.Size = new System.Drawing.Size(221, 21);
            this.cboMaSP.TabIndex = 3;
            // 
            // frmThem1NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmThem1NhapHang";
            this.Text = "frmThem1NhapHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThem1NhapHang_FormClosing);
            this.Load += new System.EventHandler(this.frmThem1NhapHang_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlDGVChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlDGVChiTiet;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.DataGridView dgvChiTietNhapHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label4;
        private ThuVien.NumericTextBox txtGiaTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnXoaSP;
        private ThuVien.NumericTextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXacNhanDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaChiTietNhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaNhap;
    }
}