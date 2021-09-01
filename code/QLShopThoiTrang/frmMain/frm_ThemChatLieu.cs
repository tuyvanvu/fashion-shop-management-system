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
    public partial class frm_ThemChatLieu : Form
    {
        MessageForm message = new MessageForm();
        QuanLyCacLoai xl = new QuanLyCacLoai();

        public frm_ThemChatLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                message.showAlert("Vui lòng nhập mã chất liệu", MessageForm.enmType.Warning);
                return;
            }
            if (txtTen.Text == "")
            {
                message.showAlert("Vui lòng nhập tên chất liệu", MessageForm.enmType.Warning);
                return;
            }
            if (!xl.KiemTraMaChatLieu(txtMa.Text))
            {
                message.showAlert("Mã chất liệu này đã tồn tại", MessageForm.enmType.Warning);
                return;
            }
            else
            {
                bool kq_ThemLoai = xl.ThemChatLieu(txtMa.Text, txtTen.Text);
                if (kq_ThemLoai)
                {
                    message.showAlert("Thêm thành công", MessageForm.enmType.Success);
                    LoadDGV();
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Xóa chất liệu này sẽ xóa hết sản phẩm, xóa nhé?", "Xóa chất liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            if (dgv.CurrentRow != null)
            {

                bool kq_XoaLoaiSP = xl.XoaChatLieu(dgv.CurrentRow.Cells["clMaChatLieu"].Value.ToString());
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
            Program.frm_ThemChatLieu.Hide();
            Program.frm_Them1HangHoa.Show();
            Program.frm_Them1HangHoa.LoadCboChatLieu();
        }
        private void frm_ThemChatLieu_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnTroLai.PerformClick();
        }


        private void LoadDGV()
        {
            dgv.DataSource = xl.LayDSChatLieu();
        }

    }
}
