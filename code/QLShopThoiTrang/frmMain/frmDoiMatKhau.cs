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
    public partial class frmDoiMatKhau : Form
    {
        string tendn = string.Empty;
        DoiMatKhau xl_DoiMatKhau = new DoiMatKhau();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public frmDoiMatKhau(string TenDN)
        {
            InitializeComponent();
            this.tendn = TenDN;

        }


        private void btnDoi_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text == "")
            {
                errorProvider1.SetError(txtTaiKhoan,"Vui long nhap ten dang nhap");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan, "");
            }
            if(txtMatKhau.Text == "")
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui long nhap mat khau");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan, "");
            }
            if (txtNhapLaiMatKhau.Text == "")
            {
                errorProvider1.SetError(txtTaiKhoan, "Vui long nhap lai mat khau");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTaiKhoan, "");
            }
            if (txtMatKhau.Text == txtNhapLaiMatKhau.Text)
            {
                bool kq_doimk = xl_DoiMatKhau.ThucHienDoiMatKhau(txtTaiKhoan.Text, txtNhapLaiMatKhau.Text);
                if(kq_doimk)
                {
                    MessageBox.Show("doi mk thanh cong");

                }
                else
                {
                    MessageBox.Show("doi mk that bai");
                }

            }
            MessageBox.Show("mat khau khong giong nhap lai mat khau");
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            if(tendn != string.Empty)
                txtTaiKhoan.Text = tendn;
        }
    }
}
