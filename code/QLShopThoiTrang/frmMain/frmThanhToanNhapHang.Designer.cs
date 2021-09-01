namespace frmMain
{
    partial class frmThanhToanNhapHang
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.clMaNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaChiTietNhaphang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnXacNhan);
            this.pnlBottom.Controls.Add(this.btnTroVe);
            this.pnlBottom.Controls.Add(this.btnThanhToan);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 369);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 81);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 37);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.txtTongChiPhi);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.txtNhaCungCap);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 37);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(147, 332);
            this.pnlLeft.TabIndex = 3;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.pnlDGV);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(147, 37);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(653, 332);
            this.pnlFill.TabIndex = 5;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGV.Controls.Add(this.dgvChiTietNhapHang);
            this.pnlDGV.Location = new System.Drawing.Point(3, 3);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(647, 326);
            this.pnlDGV.TabIndex = 4;
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
            this.dgvChiTietNhapHang.Size = new System.Drawing.Size(647, 326);
            this.dgvChiTietNhapHang.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhà cung cấp";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNhaCungCap.Location = new System.Drawing.Point(12, 49);
            this.txtNhaCungCap.Multiline = true;
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.ReadOnly = true;
            this.txtNhaCungCap.Size = new System.Drawing.Size(132, 65);
            this.txtNhaCungCap.TabIndex = 1;
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTongChiPhi.Location = new System.Drawing.Point(9, 142);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.ReadOnly = true;
            this.txtTongChiPhi.Size = new System.Drawing.Size(132, 20);
            this.txtTongChiPhi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng chi phí";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(537, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(89, 63);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTroVe.Location = new System.Drawing.Point(420, 6);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(89, 63);
            this.btnTroVe.TabIndex = 1;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXacNhan.Location = new System.Drawing.Point(302, 6);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(95, 63);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận đơn";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmThanhToanNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmThanhToanNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThanhToanNhapHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThanhToanNhapHang_FormClosing);
            this.Load += new System.EventHandler(this.frmThanhToanNhapHang_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlFill.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.DataGridView dgvChiTietNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaChiTietNhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaNhap;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongChiPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnXacNhan;
    }
}