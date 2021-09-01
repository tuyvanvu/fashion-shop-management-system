namespace frmMain
{
    partial class frmQuanLyNhapHang
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlDGVNhapHang = new System.Windows.Forms.Panel();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNhaCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNhapHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlLeft.SuspendLayout();
            this.pnlDGVNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.pnlFill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 391);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1350, 37);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlDGVNhapHang);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(734, 391);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlDGVNhapHang
            // 
            this.pnlDGVNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDGVNhapHang.Controls.Add(this.dgvNhapHang);
            this.pnlDGVNhapHang.Location = new System.Drawing.Point(21, 23);
            this.pnlDGVNhapHang.Name = "pnlDGVNhapHang";
            this.pnlDGVNhapHang.Size = new System.Drawing.Size(691, 347);
            this.pnlDGVNhapHang.TabIndex = 0;
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNhaCungCap,
            this.clSTT,
            this.clMaNhapHang,
            this.clNgayNhap,
            this.clMaNCC,
            this.clTenNCC,
            this.clTongChiPhi,
            this.clThanhToan});
            this.dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.RowTemplate.Height = 50;
            this.dgvNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHang.Size = new System.Drawing.Size(691, 347);
            this.dgvNhapHang.TabIndex = 0;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.panel1);
            this.pnlFill.Controls.Add(this.label2);
            this.pnlFill.Controls.Add(this.dateTimePicker1);
            this.pnlFill.Controls.Add(this.label1);
            this.pnlFill.Controls.Add(this.textBox1);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(734, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(616, 391);
            this.pnlFill.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 391);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(200)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.txtTongChiPhi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cboNhaCC);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpNgayNhap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaNhapHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 391);
            this.panel2.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThanhToan.BackColor = System.Drawing.Color.Blue;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(101, 339);
            this.btnThanhToan.MaximumSize = new System.Drawing.Size(433, 100);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(433, 52);
            this.btnThanhToan.TabIndex = 12;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Location = new System.Drawing.Point(210, 166);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.ReadOnly = true;
            this.txtTongChiPhi.Size = new System.Drawing.Size(293, 20);
            this.txtTongChiPhi.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tổng chi phi";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Blue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(402, 234);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 99);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa thông tin nhập hàng";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Blue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(250, 234);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 99);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa nhập hàng";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Blue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(101, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 99);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm Nhập hàng";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboNhaCC
            // 
            this.cboNhaCC.FormattingEnabled = true;
            this.cboNhaCC.Location = new System.Drawing.Point(210, 123);
            this.cboNhaCC.Name = "cboNhaCC";
            this.cboNhaCC.Size = new System.Drawing.Size(293, 21);
            this.cboNhaCC.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhà cung cấp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(210, 79);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(293, 20);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã Nhập hàng";
            // 
            // txtMaNhapHang
            // 
            this.txtMaNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMaNhapHang.Location = new System.Drawing.Point(210, 42);
            this.txtMaNhapHang.Name = "txtMaNhapHang";
            this.txtMaNhapHang.ReadOnly = true;
            this.txtMaNhapHang.Size = new System.Drawing.Size(293, 20);
            this.txtMaNhapHang.TabIndex = 0;
            this.txtMaNhapHang.Click += new System.EventHandler(this.txtMaNhapHang_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhập";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Nhập hàng";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhập hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clNhaCungCap
            // 
            this.clNhaCungCap.DataPropertyName = "NHACUNGCAP";
            this.clNhaCungCap.HeaderText = "Nhà cung cấp";
            this.clNhaCungCap.Name = "clNhaCungCap";
            this.clNhaCungCap.ReadOnly = true;
            this.clNhaCungCap.Visible = false;
            // 
            // clSTT
            // 
            this.clSTT.DataPropertyName = "STT";
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Visible = false;
            // 
            // clMaNhapHang
            // 
            this.clMaNhapHang.DataPropertyName = "MaNhapHang";
            this.clMaNhapHang.HeaderText = "Mã nhập hàng";
            this.clMaNhapHang.Name = "clMaNhapHang";
            this.clMaNhapHang.ReadOnly = true;
            // 
            // clNgayNhap
            // 
            this.clNgayNhap.DataPropertyName = "NgayNhap";
            this.clNgayNhap.HeaderText = "Ngày nhập";
            this.clNgayNhap.Name = "clNgayNhap";
            this.clNgayNhap.ReadOnly = true;
            // 
            // clMaNCC
            // 
            this.clMaNCC.DataPropertyName = "MaNCC";
            this.clMaNCC.HeaderText = "Mã nhà cung cấp";
            this.clMaNCC.Name = "clMaNCC";
            this.clMaNCC.ReadOnly = true;
            this.clMaNCC.Visible = false;
            // 
            // clTenNCC
            // 
            this.clTenNCC.DataPropertyName = "TenNCC";
            this.clTenNCC.HeaderText = "Tên nhà cung cấp";
            this.clTenNCC.Name = "clTenNCC";
            this.clTenNCC.ReadOnly = true;
            // 
            // clTongChiPhi
            // 
            this.clTongChiPhi.DataPropertyName = "TongChiPhi";
            this.clTongChiPhi.HeaderText = "Tổng chi phí";
            this.clTongChiPhi.Name = "clTongChiPhi";
            this.clTongChiPhi.ReadOnly = true;
            // 
            // clThanhToan
            // 
            this.clThanhToan.DataPropertyName = "ThanhToan";
            this.clThanhToan.FalseValue = "";
            this.clThanhToan.HeaderText = "Thanh toán";
            this.clThanhToan.IndeterminateValue = "";
            this.clThanhToan.Name = "clThanhToan";
            this.clThanhToan.ReadOnly = true;
            this.clThanhToan.ThreeState = true;
            this.clThanhToan.TrueValue = "V";
            // 
            // frmQuanLyNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 428);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmQuanLyNhapHang";
            this.Text = "frmQuanLyNhapHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyNhapHang_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyNhapHang_Load);
            this.VisibleChanged += new System.EventHandler(this.frmQuanLyNhapHang_VisibleChanged);
            this.pnlLeft.ResumeLayout(false);
            this.pnlDGVNhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel pnlDGVNhapHang;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNhapHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboNhaCC;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTongChiPhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongChiPhi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clThanhToan;
    }
}