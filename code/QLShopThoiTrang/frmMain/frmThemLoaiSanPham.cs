using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
using BLL_DAL;

namespace frmMain
{
    public partial class frmThemLoaiSanPham : Form
    {

        QuanLyCacLoai xl = new QuanLyCacLoai();
        MessageForm message = new MessageForm();
        public frmThemLoaiSanPham()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaLoai.Text == "")
            {
                message.showAlert("Vui lòng nhập mã loại", MessageForm.enmType.Warning);
                return;
            }
            if (txtTenLoai.Text == "")
            {
                message.showAlert("Vui lòng nhập tên loại", MessageForm.enmType.Warning);
                return;
            }
            if(!xl.KiemTraMaLoaiSanPhamTonTai(txtMaLoai.Text))
            {
                message.showAlert("Mã sản phẩm này đã tồn tại", MessageForm.enmType.Warning);
                return;
            }
            else
            {
                bool kq_ThemLoai = xl.ThemLoaiSanPham(txtMaLoai.Text, txtTenLoai.Text);
                if(kq_ThemLoai)
                {
                    message.showAlert("Thêm thành công", MessageForm.enmType.Success);
                    LoadDGV();
                }
            }

        } 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa loại sản phẩm sẽ xóa hết sản phẩm, xóa nhé?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            if(dgvLoaiSanPham.CurrentRow != null)
            {

                bool kq_XoaLoaiSP = xl.XoaLoaiSanPham(dgvLoaiSanPham.CurrentRow.Cells["clMaLoaiSP"].Value.ToString());
                if(kq_XoaLoaiSP)
                {
                    message.showAlert("Xóa thành công rồi đấy", MessageForm.enmType.Success);
                    return;
                }
                else
                {
                    message.showAlert("Xóa thất bại", MessageForm.enmType.Error);
                    return;
                }
            }
            else
            {
                message.showAlert("Chọn loại đã", MessageForm.enmType.Warning);
            }
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            Program.frm_ThemLoaiSanPham.Hide();
            Program.frm_Them1HangHoa.Show();
            Program.frm_Them1HangHoa.LoadCboLoaiSP();
        }
        private void frmThemLoaiSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnTroLai.PerformClick();
        }


        private void LoadDGV()
        {
            dgvLoaiSanPham.DataSource = xl.LayDSLoaiSanPham();
        }
    }
}
