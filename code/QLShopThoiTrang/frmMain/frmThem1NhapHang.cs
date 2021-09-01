using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using FastMember;

namespace frmMain
{
    public partial class frmThem1NhapHang : Form
    {
        QuanLyNhapHang xl_QuanLyNhapHang = new QuanLyNhapHang();

        public frmThem1NhapHang()
        {
            InitializeComponent();
            MaNhapHang = "";
        }
        public frmThem1NhapHang(string pMaNhapHang)
        {
            InitializeComponent();
            this.MaNhapHang = pMaNhapHang;
        }
        string MaNhapHang;
        ThuVien.MessageForm message = new ThuVien.MessageForm();

        private void frmThem1NhapHang_Load(object sender, EventArgs e)
        {
            cboMaSP.DataSource = xl_QuanLyNhapHang.LayDSSanPham();
            cboMaSP.DisplayMember = "MaSanPham";
            cboMaSP.ValueMember = "MaSanPham";
            cboMaSP.SelectedIndex = -1;
            cboSanPham.DataSource = xl_QuanLyNhapHang.LayDSSanPham();
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "MaSanPham";
            cboSanPham.SelectedIndex = -1;
            cboMaSP.SelectedIndexChanged += CboMaSP_SelectedIndexChanged;
            cboSanPham.SelectedIndexChanged += CboSanPham_SelectedIndexChanged;
            LoadDGVChiTietNhapHang();
        }


        private static string LayDuongDan()
        {
            string folderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return System.IO.Directory.GetParent(System.IO.Directory.GetParent((System.IO.Directory.GetParent(folderPath).ToString())).ToString()).ToString(); ;
        }
        private void LoadDGVChiTietNhapHang()
        {
            var lstNguoiDung = xl_QuanLyNhapHang.LayChiTietNhapHang(MaNhapHang);
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(lstNguoiDung))
            {
                dt.Load(reader);
            }
            Type type = typeof(System.Byte[]);
            dt.Columns.Add("clAvatar", type);
            foreach (DataRow row in dt.Rows)
            {
                string fileName = "";
                fileName = folderPath2 + "\\HinhAnh\\File_anh\\" + row["HinhAnh"].ToString();
                row["clAvatar"] = File.ReadAllBytes(fileName);

            }
            
            dgvChiTietNhapHang.DataSource = dt;
            dgvChiTietNhapHang.Columns["HinhAnh"].Visible = false;
            dgvChiTietNhapHang.Columns["clAvatar"].HeaderText = "Hình ảnh";
            setupDV();
        }
        void setupDV()
        {
            for (int i = 0; i < dgvChiTietNhapHang.Columns.Count; i++)
                if (dgvChiTietNhapHang.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvChiTietNhapHang.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }
        private double TinhTongTien()
        {
            if (dgvChiTietNhapHang.Rows.Count == 0)
                return 0;
            double TongTien = 0;
            foreach (DataGridViewRow row in dgvChiTietNhapHang.Rows)
            {
                TongTien += double.Parse(row.Cells["clGiaNhap"].Value.ToString()) * int.Parse(row.Cells["clSoLuong"].Value.ToString());
            }
            return TongTien;
        }


        private void CboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaSP.SelectedValue = cboSanPham.SelectedValue;
            txtGiaTri.Text = xl_QuanLyNhapHang.getGiaTriSanPham(cboSanPham.SelectedValue.ToString()).ToString();
        }
        private void CboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboSanPham.SelectedValue = cboMaSP.SelectedValue;
            txtGiaTri.Text = xl_QuanLyNhapHang.getGiaTriSanPham(cboMaSP.SelectedValue.ToString()).ToString();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if(cboMaSP.SelectedIndex == -1)
            {
                message.showAlert("Vui lòng thêm sản phẩm trước", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            string kq_KiemTraTonTai = xl_QuanLyNhapHang.KiemTraTonTaiChiTietNhapHang(MaNhapHang, cboMaSP.SelectedValue.ToString());
            if(kq_KiemTraTonTai == null)
            {
                bool kq_Them1SP = xl_QuanLyNhapHang.ThemChiTietNhapHang(MaNhapHang, cboMaSP.SelectedValue.ToString(), (int)nudSoLuong.Value, double.Parse(txtGiaTri.Text));
                if (kq_Them1SP)
                {
                    message.showAlert("Thêm sản phẩm thành công", ThuVien.MessageForm.enmType.Success);
                    LoadDGVChiTietNhapHang();
                }
            }
            else
            {
                bool kq_ThemSoLuongSP = xl_QuanLyNhapHang.ThemSLSPChiTietNhapHang(kq_KiemTraTonTai, (int)nudSoLuong.Value);
                message.showAlert("Cập nhật sản phẩm thành công", ThuVien.MessageForm.enmType.Success);
                LoadDGVChiTietNhapHang();

            }
            

            txtTongTien.Text = TinhTongTien().ToString();
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            bool kq_Xoa1ChiTietNhapHang = xl_QuanLyNhapHang.Xoa1ChiTietNhapHang(dgvChiTietNhapHang.CurrentRow.Cells["clMaChiTietNhaphang"].Value.ToString());
            if (kq_Xoa1ChiTietNhapHang)
            {
                message.showAlert("Xoa thanh cong", ThuVien.MessageForm.enmType.Success);
                txtTongTien.Text = TinhTongTien().ToString();
                LoadDGVChiTietNhapHang();
            }
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if(xl_QuanLyNhapHang.KiemTraNhapHangTonTai(MaNhapHang))
            {
                DialogResult dr = MessageBox.Show("Trở về sẽ hủy những đơn hàng đã nhập, ok?", "Tro ve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bool kq_KiemTraXoaChiTietDonHang = xl_QuanLyNhapHang.XoaNhapHang(MaNhapHang);
                    if(!kq_KiemTraXoaChiTietDonHang)
                    {
                        MessageBox.Show("Da co van de");
                        return;
                    }
                }
                else
                    return;

            }

            Program.frm_Them1NhapHang.Hide();
            Program.frm_QuanLyNhapHang.Show();
        }
        private void btnXacNhanDon_Click(object sender, EventArgs e)
        {
            if(dgvChiTietNhapHang.Rows.Count == 0)
            {
                message.showAlert("Không thể nhập 1 đơn trống", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            if(txtTongTien.Text == "")
            {
                message.showAlert("Hệ thống tạm thời không chấp nhận đơn vô giá trị", ThuVien.MessageForm.enmType.Warning);
                return;
            }
            Program.frm_Them1NhapHang.Hide();
            Program.frm_QuanLyNhapHang.Show();
            Program.frm_QuanLyNhapHang.LoadDGVSau(txtTongTien.Text);
        }
        private void frmThem1NhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnTroVe.PerformClick();
        }
    }
}
