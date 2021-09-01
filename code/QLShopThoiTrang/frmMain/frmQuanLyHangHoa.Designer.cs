namespace frmMain
{
    partial class frmQuanLyHangHoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkKhuyenMai = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboChatLieu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.pnlFillFullAnchor = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLoaiSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.pnlFillFullAnchor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlTop.Controls.Add(this.btnTimKiem);
            this.pnlTop.Controls.Add(this.panel3);
            this.pnlTop.Controls.Add(this.panel2);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 82);
            this.pnlTop.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(578, 16);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(87, 55);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 55);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.chkKhuyenMai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(424, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 82);
            this.panel3.TabIndex = 2;
            // 
            // chkKhuyenMai
            // 
            this.chkKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkKhuyenMai.AutoSize = true;
            this.chkKhuyenMai.Location = new System.Drawing.Point(31, 38);
            this.chkKhuyenMai.Name = "chkKhuyenMai";
            this.chkKhuyenMai.Size = new System.Drawing.Size(96, 17);
            this.chkKhuyenMai.TabIndex = 0;
            this.chkKhuyenMai.Text = "Có khuyến mãi";
            this.chkKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.cboNCC);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cboNSX);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(212, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 82);
            this.panel2.TabIndex = 1;
            // 
            // cboNCC
            // 
            this.cboNCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(82, 55);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(121, 21);
            this.cboNCC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cboNSX
            // 
            this.cboNSX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNSX.FormattingEnabled = true;
            this.cboNSX.Location = new System.Drawing.Point(82, 18);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(121, 21);
            this.cboNSX.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NSX";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cboChatLieu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboLoaiSP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 82);
            this.panel1.TabIndex = 0;
            // 
            // cboChatLieu
            // 
            this.cboChatLieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChatLieu.FormattingEnabled = true;
            this.cboChatLieu.Location = new System.Drawing.Point(82, 55);
            this.cboChatLieu.Name = "cboChatLieu";
            this.cboChatLieu.Size = new System.Drawing.Size(121, 21);
            this.cboChatLieu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chất liệu";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(82, 18);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại sản phẩm";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.panel4);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 365);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(964, 63);
            this.pnlBottom.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.btnXemChiTiet);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Location = new System.Drawing.Point(105, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 57);
            this.panel4.TabIndex = 7;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.Blue;
            this.btnXemChiTiet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(261, 0);
            this.btnXemChiTiet.MinimumSize = new System.Drawing.Size(140, 57);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(140, 57);
            this.btnXemChiTiet.TabIndex = 7;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(174, 0);
            this.btnSua.MinimumSize = new System.Drawing.Size(87, 57);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 57);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Blue;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(87, 0);
            this.btnXoa.MinimumSize = new System.Drawing.Size(87, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 57);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.MinimumSize = new System.Drawing.Size(87, 57);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 57);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlFill.Controls.Add(this.pnlFillFullAnchor);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 82);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(964, 283);
            this.pnlFill.TabIndex = 3;
            // 
            // pnlFillFullAnchor
            // 
            this.pnlFillFullAnchor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFillFullAnchor.Controls.Add(this.dgvSanPham);
            this.pnlFillFullAnchor.Location = new System.Drawing.Point(3, 3);
            this.pnlFillFullAnchor.Name = "pnlFillFullAnchor";
            this.pnlFillFullAnchor.Size = new System.Drawing.Size(958, 277);
            this.pnlFillFullAnchor.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSanPham,
            this.clTenSanPham,
            this.clMaLoaiSp,
            this.clTenLoaiSanPham,
            this.clMaChatLieu,
            this.clTenChatLieu,
            this.clMaNSX,
            this.clTenNSX,
            this.clMaNCC,
            this.clTenNCC,
            this.hinhanh,
            this.clSoLuong,
            this.clGiaTri,
            this.clKhuyenMai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSanPham.RowTemplate.Height = 100;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(958, 277);
            this.dgvSanPham.TabIndex = 2;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.DataPropertyName = "MaSanpham";
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.DataPropertyName = "TenSanPham";
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            // 
            // clMaLoaiSp
            // 
            this.clMaLoaiSp.DataPropertyName = "MaLoaiSP";
            this.clMaLoaiSp.HeaderText = "mã loại sản phẩm";
            this.clMaLoaiSp.Name = "clMaLoaiSp";
            this.clMaLoaiSp.ReadOnly = true;
            this.clMaLoaiSp.Visible = false;
            // 
            // clTenLoaiSanPham
            // 
            this.clTenLoaiSanPham.DataPropertyName = "TenLoaiSP";
            this.clTenLoaiSanPham.HeaderText = "Tên Loại SP";
            this.clTenLoaiSanPham.Name = "clTenLoaiSanPham";
            this.clTenLoaiSanPham.ReadOnly = true;
            // 
            // clMaChatLieu
            // 
            this.clMaChatLieu.DataPropertyName = "MaChatLieu";
            this.clMaChatLieu.HeaderText = "mã chất liệu";
            this.clMaChatLieu.Name = "clMaChatLieu";
            this.clMaChatLieu.ReadOnly = true;
            this.clMaChatLieu.Visible = false;
            // 
            // clTenChatLieu
            // 
            this.clTenChatLieu.DataPropertyName = "TenChatLieu";
            this.clTenChatLieu.HeaderText = "Tên chất liệu";
            this.clTenChatLieu.Name = "clTenChatLieu";
            this.clTenChatLieu.ReadOnly = true;
            // 
            // clMaNSX
            // 
            this.clMaNSX.DataPropertyName = "MaNSX";
            this.clMaNSX.HeaderText = "mã nsx";
            this.clMaNSX.Name = "clMaNSX";
            this.clMaNSX.ReadOnly = true;
            // 
            // clTenNSX
            // 
            this.clTenNSX.DataPropertyName = "TenNSX";
            this.clTenNSX.HeaderText = "Tên NSX";
            this.clTenNSX.Name = "clTenNSX";
            this.clTenNSX.ReadOnly = true;
            // 
            // clMaNCC
            // 
            this.clMaNCC.DataPropertyName = "MaNCC";
            this.clMaNCC.HeaderText = "mã ncc";
            this.clMaNCC.Name = "clMaNCC";
            this.clMaNCC.ReadOnly = true;
            this.clMaNCC.Visible = false;
            // 
            // clTenNCC
            // 
            this.clTenNCC.DataPropertyName = "TenNCC";
            this.clTenNCC.HeaderText = "Tên NCC";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.ReadOnly = true;
            // 
            // hinhanh
            // 
            this.hinhanh.DataPropertyName = "HinhAnh";
            this.hinhanh.HeaderText = "hình ảnh";
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.ReadOnly = true;
            this.hinhanh.Visible = false;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số lượng tồn";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clGiaTri
            // 
            this.clGiaTri.DataPropertyName = "GiaTri";
            this.clGiaTri.HeaderText = "Giá trị";
            this.clGiaTri.Name = "clGiaTri";
            this.clGiaTri.ReadOnly = true;
            // 
            // clKhuyenMai
            // 
            this.clKhuyenMai.DataPropertyName = "KhuyenMai";
            this.clKhuyenMai.HeaderText = "Khuyến mãi";
            this.clKhuyenMai.Name = "clKhuyenMai";
            this.clKhuyenMai.ReadOnly = true;
            // 
            // frmQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(964, 428);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmQuanLyHangHoa";
            this.Text = "frmQuanLyHangHoa";
            this.Load += new System.EventHandler(this.frmQuanLyHangHoa_Load);
            this.pnlTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.pnlFillFullAnchor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlFillFullAnchor;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboChatLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLoaiSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhuyenMai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}