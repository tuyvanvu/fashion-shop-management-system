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
    public partial class frmQuanLyNhapHang : Form
    {


        QuanLyNhapHang xl_QuanLyNhapHang = new QuanLyNhapHang();
        ThuVien.MessageForm message = new ThuVien.MessageForm();
        public frmQuanLyNhapHang()
        {
            InitializeComponent();
        }


        private void frmQuanLyNhapHang_Load(object sender, EventArgs e)
        {
            LoadDGVNhapHang();
            cboNhaCC.DataSource = xl_QuanLyNhapHang.LayDSNhaCungCap();
            cboNhaCC.DisplayMember = "TenNCC";
            cboNhaCC.ValueMember = "MaNCC";
            if(!Program.Quyen)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        public void LoadDGVNhapHang()
        {
            dgvNhapHang.DataSource = xl_QuanLyNhapHang.LayDSNhapHang();
        }
        public void LoadDGVSau(string TongChiPhi)
        {
            txtTongChiPhi.Text = TongChiPhi;
            
            bool kq = xl_QuanLyNhapHang.CapNhatThongTinNhapHang(txtMaNhapHang.Text, double.Parse(txtTongChiPhi.Text), dtpNgayNhap.Value, cboNhaCC.SelectedValue.ToString());
            if(kq)
            {
                message.showAlert("Tạo thành công", ThuVien.MessageForm.enmType.Success);
                LoadDGVNhapHang();
                txtMaNhapHang.Text = "";
            }
            else
            {
                message.showAlert("Co van de roi, Toang", ThuVien.MessageForm.enmType.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if(dtpNgayNhap.Value <= DateTime.Today)
            {
                message.showAlert("Vui lòng nhập ngày sau hôm nay", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            if(txtMaNhapHang.Text == "")
            {
                message.showAlert("Vui lòng nhấn ô mã nhập hàng để tạo mã trước", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            if(cboNhaCC.SelectedIndex == -1)
            {
                message.showAlert("Vui lòng Chon nha cung cap truoc", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            Program.frm_Them1NhapHang = new frmThem1NhapHang(txtMaNhapHang.Text);
            Program.frm_Them1NhapHang.StartPosition = FormStartPosition.CenterScreen;
            Program.frm_Them1NhapHang.Show();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvNhapHang.CurrentRow == null)
            {
                message.showAlert("Vui lòng chọn đơn nhập hàng muốn xóa trước", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa đơn nhập hàng này không", "Xóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;

            bool kq_Xoa1NhapHang = xl_QuanLyNhapHang.XoaNhapHang(dgvNhapHang.CurrentRow.Cells["clMaNhapHang"].Value.ToString());
            if (kq_Xoa1NhapHang)
            {
                message.showAlert("Đã xóa 1 đơn nhập hàng", ThuVien.MessageForm.enmType.Success);
                LoadDGVNhapHang();
            }
            else
            {
                message.showAlert("Lỗi gì rồi", ThuVien.MessageForm.enmType.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void txtMaNhapHang_Click(object sender, EventArgs e)
        {
            if (!Program.Quyen)
                return;
            if(txtMaNhapHang.Text == "")
                txtMaNhapHang.Text = xl_QuanLyNhapHang.TaoMaNhapHang();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(dgvNhapHang.CurrentRow != null)
            {
                Program.frm_ThanhToan1NhapHang = new frmThanhToanNhapHang(dgvNhapHang.CurrentRow.Cells["clMaNhapHang"].Value.ToString());
                Program.frm_QuanLyNhapHang.Hide();
                Program.frm_ThanhToan1NhapHang.Show();
            }
            else
            {
                message.showAlert("Chọn đơn muốn thanh toán trước", ThuVien.MessageForm.enmType.Warning);
            }
        }
        private void frmQuanLyNhapHang_VisibleChanged(object sender, EventArgs e)
        {
            if(txtMaNhapHang.Text != "")
            {
                bool kq = xl_QuanLyNhapHang.XoaNhapHang(txtMaNhapHang.Text);
            }
        }
        private void frmQuanLyNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtMaNhapHang.Text != "")
            {
                bool kq = xl_QuanLyNhapHang.XoaNhapHang(txtMaNhapHang.Text);
            }
        }

    }
}
