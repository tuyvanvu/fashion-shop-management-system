using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace frmMain
{
    public partial class frmLogin : Form
    {
        Login xl_DN = new Login();
        XuLy xl = new XuLy();
        string TenDangNhap, MatKhau;

        public frmLogin()
        {
            InitializeComponent();
            //txtTaiKhoan.GotFocus += TxtTaiKhoan_GotFocus;
            //txtMatKhau.GotFocus += TxtMatKhau_GotFocus;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            XuLyNutLuuTaiKhoan();
        }

        




        //Xử lý lúc nhấn vào tài khoản và mật khẩu
        //private void TxtMatKhau_GotFocus(object sender, EventArgs e)
        //{
        //    if (((TextBox)(sender)).Tag.Equals("Yes"))
        //    {
        //        ((TextBox)(sender)).Text = "";
        //        ((TextBox)(sender)).UseSystemPasswordChar = true;
        //        ((TextBox)(sender)).ForeColor = Color.Black;
        //        lblMatKhau.Visible = true;
        //        ((TextBox)(sender)).Tag = "";
        //    }
        //}
        //private void TxtTaiKhoan_GotFocus(object sender, EventArgs e)
        //{
        //    if (((TextBox)(sender)).Tag.Equals("Yes"))
        //    {
        //        ((TextBox)(sender)).Text = "";
        //        ((TextBox)(sender)).ForeColor = Color.Black;
        //        lblTaiKhoan.Visible = true;
        //        ((TextBox)(sender)).Tag = "";
        //    }
        //}
        //private void txtTaiKhoan_Leave(object sender, EventArgs e)
        //{
        //    if (((TextBox)(sender)).Text == "")
        //    {
        //        ((TextBox)(sender)).Text = " Tài khoản";
        //        ((TextBox)(sender)).ForeColor = Color.Gray;
        //        lblTaiKhoan.Visible = false;
        //        ((TextBox)(sender)).Tag = "Yes";
        //    }
        //}
        //private void txtMatKhau_Leave(object sender, EventArgs e)
        //{
        //    if (((TextBox)(sender)).Text == "")
        //    {
        //        ((TextBox)(sender)).Text = " Mật khẩu";
        //        if (((TextBox)(sender)).UseSystemPasswordChar == true)
        //            ((TextBox)(sender)).UseSystemPasswordChar = false;
        //        ((TextBox)(sender)).ForeColor = Color.Gray;
        //        lblMatKhau.Visible = false;
        //        ((TextBox)(sender)).Tag = "Yes";
        //    }
        //}


        //Xử lý sự kiện cho các nút
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int kq = xl.CheckConfig();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }
        private void lblDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frm_Register = new frmRegister();
            Program.frm_Register.Show();
        }
        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {

        }




        //Còn lại
        private void chkNhoMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhoMatKhau.Checked)
            {
                Properties.Settings.Default.Username = txtTaiKhoan.Text;
                Properties.Settings.Default.Password = txtMatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }
        private void ProcessConfig()
        {
            label3.Visible = true;
            Program.frm_KetNoiDatabase = new frmKetNoiDatabase();
            Program.frm_KetNoiDatabase.Show();
            Program.frm_Login.Hide();
        }
        private void ProcessLogin()
        {
            if (chkNhoMatKhau.Checked)
            {
                Properties.Settings.Default.Username = txtTaiKhoan.Text;
                Properties.Settings.Default.Password = txtMatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            NGUOIDUNG nguoidung = xl_DN.LoginCheck(txtTaiKhoan.Text, /*xl.Encrypt(*/txtMatKhau.Text);
            if (nguoidung != null)
            {
                if (xl_DN.isAdmin(nguoidung))
                    Program.Quyen = true;
                else
                    Program.Quyen = false;
                Program.frm_Previous = Program.frm_Login;
                Program.frm_Main = new frmMain(txtTaiKhoan.Text);
                Program.frm_Main.Show();
                Program.frm_Login.Hide();
            }
            else
                MessageBox.Show("Dang Nhap that bai");
        }

        


        private void XuLyNutLuuTaiKhoan()
        {
            TenDangNhap = Properties.Settings.Default.Username;
            MatKhau = Properties.Settings.Default.Password;
            if (TenDangNhap != "" || MatKhau != "")
            {

                txtTaiKhoan.SetText(TenDangNhap);
                txtMatKhau.SetText(MatKhau);
                chkNhoMatKhau.Checked = true;
            }
        }
		public bool KiemTraSDT(string pSDT)
		{
			if(pSDT.Length != 10)
				return false;
			foreach(char c in pSDT)
			{
				if(!char.IsNumber(c))
					return false;
			}
            return true;
			
		}



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
