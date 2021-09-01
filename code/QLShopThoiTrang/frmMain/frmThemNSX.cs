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
    public partial class frmThemNSX : Form
    {
        QuanLyCacLoai xl = new QuanLyCacLoai();
        MessageForm message = new MessageForm();

        public frmThemNSX()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                message.showAlert("Vui lòng nhập mã NSX", MessageForm.enmType.Warning);
                return;
            }
            if (txtTen.Text == "")
            {
                message.showAlert("Vui lòng nhập tên NSX", MessageForm.enmType.Warning);
                return;
            }
            if (!xl.KiemTraMaNhaSanXuat(txtMa.Text))
            {
                message.showAlert("Mã NSX này đã tồn tại", MessageForm.enmType.Warning);
                return;
            }
            else
            {
                bool kq_ThemLoai = xl.ThemNhaSanXuat(txtMa.Text, txtTen.Text);
                if (kq_ThemLoai)
                {
                    message.showAlert("Thêm thành công", MessageForm.enmType.Success);
                    LoadDGV();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa NSX này sẽ xóa hết sản phẩm, xóa nhé?", "Xóa NSX", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            if (dgv.CurrentRow != null)
            {

                bool kq_XoaLoaiSP = xl.XoaNSX(dgv.CurrentRow.Cells["clMaNSX"].Value.ToString());
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
            Program.frm_ThemNhaSanXuat.Hide();
            Program.frm_Them1HangHoa.Show();
            Program.frm_Them1HangHoa.LoadCboNSX();
        }
        private void frmThemNSX_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnTroLai.PerformClick();
        }

        private void LoadDGV()
        {
            dgv.DataSource = xl.LayDSNhaSanXuat();
        }

    }
}
