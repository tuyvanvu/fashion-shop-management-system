namespace frmMain
{
    partial class frmThongKeDoanhThu
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
            this.btnToExcel = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlDGV = new System.Windows.Forms.Panel();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.rdoThu = new System.Windows.Forms.RadioButton();
            this.rdoChi = new System.Windows.Forms.RadioButton();
            this.pnlThu = new System.Windows.Forms.Panel();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlChi = new System.Windows.Forms.Panel();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvThongKe2 = new System.Windows.Forms.DataGridView();
            this.clMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhToan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongGiaTri2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.pnlThu.SuspendLayout();
            this.pnlChi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnToExcel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 398);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(964, 100);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnToExcel
            // 
            this.btnToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToExcel.ForeColor = System.Drawing.Color.White;
            this.btnToExcel.Image = global::frmMain.Properties.Resources.excel;
            this.btnToExcel.Location = new System.Drawing.Point(278, 12);
            this.btnToExcel.MaximumSize = new System.Drawing.Size(200, 170);
            this.btnToExcel.MinimumSize = new System.Drawing.Size(92, 76);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(92, 76);
            this.btnToExcel.TabIndex = 8;
            this.btnToExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToExcel.UseVisualStyleBackColor = false;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.tableLayoutPanel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 82);
            this.pnlTop.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rdoChi, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnThongKe, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoThu, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpKetThuc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpBatDau, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.BackColor = System.Drawing.Color.Blue;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(275, 3);
            this.btnThongKe.Name = "btnThongKe";
            this.tableLayoutPanel1.SetRowSpan(this.btnThongKe, 2);
            this.btnThongKe.Size = new System.Drawing.Size(121, 76);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê ngày";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpKetThuc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKetThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(111, 51);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(158, 20);
            this.dtpKetThuc.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ngày bắt đầu";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBatDau.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBatDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(111, 10);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(158, 20);
            this.dtpBatDau.TabIndex = 8;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlChi);
            this.pnlRight.Controls.Add(this.pnlThu);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(564, 82);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(400, 316);
            this.pnlRight.TabIndex = 3;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.pnlDGV);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 82);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(564, 316);
            this.pnlFill.TabIndex = 4;
            // 
            // pnlDGV
            // 
            this.pnlDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGV.Controls.Add(this.dgvThongKe2);
            this.pnlDGV.Controls.Add(this.dgvThongKe);
            this.pnlDGV.Location = new System.Drawing.Point(3, 3);
            this.pnlDGV.Name = "pnlDGV";
            this.pnlDGV.Size = new System.Drawing.Size(558, 310);
            this.pnlDGV.TabIndex = 4;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaDonHang,
            this.clTongGiaTri,
            this.clTenDN,
            this.clThanhToan,
            this.clNgayLap,
            this.clNguoiDung});
            this.dgvThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe.Location = new System.Drawing.Point(0, 0);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(558, 310);
            this.dgvThongKe.TabIndex = 0;
            // 
            // rdoThu
            // 
            this.rdoThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoThu.AutoSize = true;
            this.rdoThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoThu.Location = new System.Drawing.Point(402, 12);
            this.rdoThu.Name = "rdoThu";
            this.rdoThu.Size = new System.Drawing.Size(88, 17);
            this.rdoThu.TabIndex = 1;
            this.rdoThu.TabStop = true;
            this.rdoThu.Text = "Thu";
            this.rdoThu.UseVisualStyleBackColor = true;
            this.rdoThu.CheckedChanged += new System.EventHandler(this.rdoThu_CheckedChanged);
            // 
            // rdoChi
            // 
            this.rdoChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoChi.AutoSize = true;
            this.rdoChi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoChi.Location = new System.Drawing.Point(402, 53);
            this.rdoChi.Name = "rdoChi";
            this.rdoChi.Size = new System.Drawing.Size(88, 17);
            this.rdoChi.TabIndex = 2;
            this.rdoChi.TabStop = true;
            this.rdoChi.Text = "Chi";
            this.rdoChi.UseVisualStyleBackColor = true;
            this.rdoChi.CheckedChanged += new System.EventHandler(this.rdoChi_CheckedChanged);
            // 
            // pnlThu
            // 
            this.pnlThu.Controls.Add(this.txtTongThu);
            this.pnlThu.Controls.Add(this.label3);
            this.pnlThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThu.Location = new System.Drawing.Point(0, 0);
            this.pnlThu.Name = "pnlThu";
            this.pnlThu.Size = new System.Drawing.Size(400, 84);
            this.pnlThu.TabIndex = 4;
            this.pnlThu.Visible = false;
            // 
            // txtTongThu
            // 
            this.txtTongThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThu.ForeColor = System.Drawing.Color.Red;
            this.txtTongThu.Location = new System.Drawing.Point(34, 38);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.ReadOnly = true;
            this.txtTongThu.Size = new System.Drawing.Size(277, 26);
            this.txtTongThu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng thu";
            // 
            // pnlChi
            // 
            this.pnlChi.Controls.Add(this.txtTongChi);
            this.pnlChi.Controls.Add(this.label4);
            this.pnlChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChi.Location = new System.Drawing.Point(0, 84);
            this.pnlChi.Name = "pnlChi";
            this.pnlChi.Size = new System.Drawing.Size(400, 84);
            this.pnlChi.TabIndex = 5;
            this.pnlChi.Visible = false;
            // 
            // txtTongChi
            // 
            this.txtTongChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChi.ForeColor = System.Drawing.Color.Red;
            this.txtTongChi.Location = new System.Drawing.Point(34, 38);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.ReadOnly = true;
            this.txtTongChi.Size = new System.Drawing.Size(277, 26);
            this.txtTongChi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng chi";
            // 
            // dgvThongKe2
            // 
            this.dgvThongKe2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.dgvThongKe2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNhapHang,
            this.clSTT,
            this.clTenNCC,
            this.clNgayNhap,
            this.clThanhToan2,
            this.dataGridViewTextBoxColumn9,
            this.clTongGiaTri2});
            this.dgvThongKe2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvThongKe2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKe2.Location = new System.Drawing.Point(0, 0);
            this.dgvThongKe2.Name = "dgvThongKe2";
            this.dgvThongKe2.ReadOnly = true;
            this.dgvThongKe2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe2.Size = new System.Drawing.Size(558, 310);
            this.dgvThongKe2.TabIndex = 1;
            // 
            // clMaDonHang
            // 
            this.clMaDonHang.DataPropertyName = "MADONHANG";
            this.clMaDonHang.HeaderText = "Mã đơn hàng";
            this.clMaDonHang.Name = "clMaDonHang";
            this.clMaDonHang.ReadOnly = true;
            // 
            // clTongGiaTri
            // 
            this.clTongGiaTri.DataPropertyName = "TONGGIATRI";
            this.clTongGiaTri.HeaderText = "Tổng giá trị";
            this.clTongGiaTri.Name = "clTongGiaTri";
            this.clTongGiaTri.ReadOnly = true;
            // 
            // clTenDN
            // 
            this.clTenDN.DataPropertyName = "TENDN";
            this.clTenDN.HeaderText = "tk khách hàng";
            this.clTenDN.Name = "clTenDN";
            this.clTenDN.ReadOnly = true;
            // 
            // clThanhToan
            // 
            this.clThanhToan.DataPropertyName = "THANHTOAN";
            this.clThanhToan.HeaderText = "Thanh Toán";
            this.clThanhToan.Name = "clThanhToan";
            this.clThanhToan.ReadOnly = true;
            this.clThanhToan.Visible = false;
            // 
            // clNgayLap
            // 
            this.clNgayLap.DataPropertyName = "NGAYLAP";
            this.clNgayLap.HeaderText = "Ngày lập";
            this.clNgayLap.Name = "clNgayLap";
            this.clNgayLap.ReadOnly = true;
            // 
            // clNguoiDung
            // 
            this.clNguoiDung.DataPropertyName = "NGUOIDUNG";
            this.clNguoiDung.HeaderText = "Người dùng";
            this.clNguoiDung.Name = "clNguoiDung";
            this.clNguoiDung.ReadOnly = true;
            this.clNguoiDung.Visible = false;
            // 
            // clMaNhapHang
            // 
            this.clMaNhapHang.DataPropertyName = "MANHAPHANG";
            this.clMaNhapHang.HeaderText = "Mã nhập hàng";
            this.clMaNhapHang.Name = "clMaNhapHang";
            this.clMaNhapHang.ReadOnly = true;
            // 
            // clSTT
            // 
            this.clSTT.DataPropertyName = "STT";
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Visible = false;
            // 
            // clTenNCC
            // 
            this.clTenNCC.DataPropertyName = "TENNCC";
            this.clTenNCC.HeaderText = "Tên nhà cung cấp";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.ReadOnly = true;
            // 
            // clNgayNhap
            // 
            this.clNgayNhap.DataPropertyName = "NGAYNHAP";
            this.clNgayNhap.HeaderText = "Ngày nhập";
            this.clNgayNhap.Name = "clNgayNhap";
            this.clNgayNhap.ReadOnly = true;
            // 
            // clThanhToan2
            // 
            this.clThanhToan2.DataPropertyName = "THANHTOAN";
            this.clThanhToan2.HeaderText = "Thanh Toán";
            this.clThanhToan2.Name = "clThanhToan2";
            this.clThanhToan2.ReadOnly = true;
            this.clThanhToan2.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // clTongGiaTri2
            // 
            this.clTongGiaTri2.DataPropertyName = "TONGCHIPHI";
            this.clTongGiaTri2.HeaderText = "Tổng Chi Phí";
            this.clTongGiaTri2.Name = "clTongGiaTri2";
            this.clTongGiaTri2.ReadOnly = true;
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 498);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "frmThongKeDoanhThu";
            this.Load += new System.EventHandler(this.frmThongKeDoanhThu_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.pnlThu.ResumeLayout(false);
            this.pnlThu.PerformLayout();
            this.pnlChi.ResumeLayout(false);
            this.pnlChi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlDGV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.RadioButton rdoChi;
        private System.Windows.Forms.RadioButton rdoThu;
        private System.Windows.Forms.Panel pnlChi;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlThu;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThongKe2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhToan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongGiaTri2;
    }
}