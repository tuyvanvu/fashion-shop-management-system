namespace frmMain
{
    partial class frmLogin
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
            this.chkNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.lblQuenMatKhau = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new ThuVien.HintTextBox();
            this.txtMatKhau = new ThuVien.htxtPassword();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkNhoMatKhau
            // 
            this.chkNhoMatKhau.AutoSize = true;
            this.chkNhoMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkNhoMatKhau.Location = new System.Drawing.Point(249, 182);
            this.chkNhoMatKhau.Name = "chkNhoMatKhau";
            this.chkNhoMatKhau.Size = new System.Drawing.Size(93, 17);
            this.chkNhoMatKhau.TabIndex = 2;
            this.chkNhoMatKhau.Text = "Nhớ mật khẩu";
            this.chkNhoMatKhau.UseVisualStyleBackColor = true;
            this.chkNhoMatKhau.CheckedChanged += new System.EventHandler(this.chkNhoMatKhau_CheckedChanged);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Blue;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDangNhap.Location = new System.Drawing.Point(70, 218);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(272, 44);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Chưa có tài khoản, ";
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKy.ForeColor = System.Drawing.Color.Blue;
            this.lblDangKy.Location = new System.Drawing.Point(191, 300);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(54, 13);
            this.lblDangKy.TabIndex = 4;
            this.lblDangKy.Text = "Đăng ký";
            this.lblDangKy.Click += new System.EventHandler(this.lblDangKy_Click);
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuenMatKhau.Location = new System.Drawing.Point(262, 300);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(93, 13);
            this.lblQuenMatKhau.TabIndex = 5;
            this.lblQuenMatKhau.Text = "Quên mật khẩu";
            this.lblQuenMatKhau.Click += new System.EventHandler(this.lblQuenMatKhau_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AllText = "Tài khoản";
            this.txtTaiKhoan.LabelText = "Tài khoản";
            this.txtTaiKhoan.LabelVisible = false;
            this.txtTaiKhoan.Location = new System.Drawing.Point(70, 76);
            this.txtTaiKhoan.MinimumSize = new System.Drawing.Size(0, 44);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(272, 44);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AllText = "Mật khẩu";
            this.txtMatKhau.LabelText = "Mật khẩu";
            this.txtMatKhau.LabelVisible = false;
            this.txtMatKhau.Location = new System.Drawing.Point(70, 126);
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(0, 44);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(272, 44);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(62, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lần đầu đăng nhập nếu bị lỗi, vui lòng đăng nhập lại";
            this.label3.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(424, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblQuenMatKhau);
            this.Controls.Add(this.lblDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chkNhoMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkNhoMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Label lblQuenMatKhau;
        private ThuVien.HintTextBox txtTaiKhoan;
        private ThuVien.htxtPassword txtMatKhau;
        private System.Windows.Forms.Label label3;
    }
}