using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            txtTaiKhoan.GotFocus += TxtTaiKhoan_GotFocus;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void TxtTaiKhoan_GotFocus(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Tag.Equals("Yes"))
            {
                ((TextBox)(sender)).Text = "";
                ((TextBox)(sender)).ForeColor = Color.Black;
                lblTaiKhoan.Visible = true;
                ((TextBox)(sender)).Tag = "";
            }
        }
        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
            {
                ((TextBox)(sender)).Text = " Tài khoản";
                ((TextBox)(sender)).ForeColor = Color.Gray;
                lblTaiKhoan.Visible = false;
                ((TextBox)(sender)).Tag = "Yes";
            }
        }
        private void TxtMatKhau_Enter(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Tag.Equals("Yes"))
            {
                ((TextBox)(sender)).Text = "";
                ((TextBox)(sender)).UseSystemPasswordChar = true;
                ((TextBox)(sender)).ForeColor = Color.Black;
                lblMatKhau.Visible = true;
                ((TextBox)(sender)).Tag = "";
            }
        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
            {
                ((TextBox)(sender)).Text = " Mật khẩu";
                if(((TextBox)(sender)).UseSystemPasswordChar == true)
                    ((TextBox)(sender)).UseSystemPasswordChar = false;
                ((TextBox)(sender)).ForeColor = Color.Gray;
                lblMatKhau.Visible = false;
                ((TextBox)(sender)).Tag = "Yes";
            }
        }
        private void txtNhapLaiMatKhau_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
            {
                ((TextBox)(sender)).Text = " Nhập lại mật khẩu";
                if (((TextBox)(sender)).UseSystemPasswordChar == true)
                    ((TextBox)(sender)).UseSystemPasswordChar = false;
                ((TextBox)(sender)).ForeColor = Color.Gray;
                lblNhapLaiMatKhau.Visible = false;
                ((TextBox)(sender)).Tag = "Yes";
            }
        }
        private void TxtNhapLaiMatKhau_Enter(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Tag.Equals("Yes"))
            {
                ((TextBox)(sender)).Text = "";
                ((TextBox)(sender)).UseSystemPasswordChar = true;
                ((TextBox)(sender)).ForeColor = Color.Black;
                lblNhapLaiMatKhau.Visible = true;
                ((TextBox)(sender)).Tag = "";
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text == txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Tạm thời đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.frm_Register.Hide();
            Program.frm_Login.Show();
        }
    }
}
