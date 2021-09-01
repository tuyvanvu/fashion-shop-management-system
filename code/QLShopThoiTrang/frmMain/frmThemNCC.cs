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
using ThuVien;

namespace frmMain
{
    public partial class frmThemNCC : Form
    {
        QuanLyCacLoai xl = new QuanLyCacLoai();
        MessageForm message = new MessageForm();
        public frmThemNCC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                message.showAlert("Vui lòng nhập mã NCC", MessageForm.enmType.Warning);
                return;
            }
            if (txtTen.Text == "")
            {
                message.showAlert("Vui lòng nhập tên NCC", MessageForm.enmType.Warning);
                return;
            }
            if (!xl.KiemTraMaNhaCungCap(txtMa.Text))
            {
                message.showAlert("Mã NCC này đã tồn tại", MessageForm.enmType.Warning);
                return;
            }
            else
            {
                bool kq_ThemLoai = xl.ThemNhaCungCap(txtMa.Text, txtTen.Text);
                if (kq_ThemLoai)
                {
                    message.showAlert("Thêm thành công", MessageForm.enmType.Success);
                    LoadDGV();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa NCC này sẽ xóa hết sản phẩm, xóa nhé?", "Xóa NCC", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            if (dgv.CurrentRow != null)
            {

                bool kq_XoaLoaiSP = xl.XoaNCC(dgv.CurrentRow.Cells["clMaNCC"].Value.ToString());
                if (kq_XoaLoaiSP)
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
            Program.frm_ThemNCC.Hide();
            Program.frm_Them1HangHoa.Show();
            Program.frm_Them1HangHoa.LoadCboNCC();
        }
        private void frmThemNCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnTroLai.PerformClick();
        }

        private void LoadDGV()
        {
            dgv.DataSource = xl.LayDSNhaCungCap();
        }
    }
}
