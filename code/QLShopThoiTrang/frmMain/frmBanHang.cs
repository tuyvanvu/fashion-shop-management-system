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
    public partial class frmBanHang : Form
    {
        double VAT = 10;
        ThuVien.MessageForm message = new ThuVien.MessageForm();
        BanHang xl_BanHang = new BanHang();
        string HoaDon = "";


        public frmBanHang()
        {
            InitializeComponent();
            btnDown.FlatAppearance.MouseOverBackColor = btnSua.BackColor;
            btnDown.BackColorChanged += (s, e) => {
                btnSua.FlatAppearance.MouseOverBackColor = btnSua.BackColor;
            };
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            HoaDon = "";
            cboMaHang.DataSource = xl_BanHang.LayDSSanPham();
            cboMaHang.DisplayMember = "MaSanPham";
            cboMaHang.ValueMember = "MaSanPham";
            cboMaHang.SelectedIndex = -1;
            cboTenHang.DataSource = xl_BanHang.LayDSSanPham();
            cboTenHang.DisplayMember = "TenSanPham";
            cboTenHang.ValueMember = "MaSanPham";
            cboTenHang.SelectedIndex = -1;
            cboMaHang.SelectedIndexChanged += CboMaHang_SelectedIndexChanged;
            cboTenHang.SelectedIndexChanged += CboTenHang_SelectedIndexChanged;
            UnAbleTLPControls();
            cboMaKH.DataSource = xl_BanHang.LayDSNguoiDung();
            cboMaKH.DisplayMember = "TENDN";
            cboMaKH.ValueMember = "TENDN";
            cboMaKH.SelectedIndex = -1;
            cboTenKhachHang.DataSource = xl_BanHang.LayDSNguoiDung();
            cboTenKhachHang.DisplayMember = "TenNguoiDung";
            cboTenKhachHang.ValueMember = "TENDN";
            cboTenKhachHang.SelectedIndex = -1;
            cboMaKH.SelectedIndexChanged += CboMaKH_SelectedIndexChanged;
            cboTenKhachHang.SelectedIndexChanged += CboTenKhachHang_SelectedIndexChanged;
            
        }



        private void CboTenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTenKhachHang.SelectedIndex != -1)
            {
                cboMaKH.SelectedValue = cboTenKhachHang.SelectedValue;
            }
        }
        private void CboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKH.SelectedIndex != -1)
            {
                cboTenKhachHang.SelectedValue = cboMaKH.SelectedValue;
            }
        }
        private void CboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenHang.SelectedIndex == -1)
                return;
            cboMaHang.SelectedValue = cboTenHang.SelectedValue.ToString();
            txtDonGia.Text = xl_BanHang.LayDonGiaTheoSP(cboTenHang.SelectedValue.ToString()).ToString();
            txtKhuyenMai.Text = xl_BanHang.LayKhuyenMaiTheoSP(cboTenHang.SelectedValue.ToString()).ToString();
        }
        private void CboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaHang.SelectedIndex == -1)
                return;
            cboTenHang.SelectedValue = cboMaHang.SelectedValue.ToString();
            txtDonGia.Text = xl_BanHang.LayDonGiaTheoSP(cboMaHang.SelectedValue.ToString()).ToString();
            txtKhuyenMai.Text = xl_BanHang.LayKhuyenMaiTheoSP(cboMaHang.SelectedValue.ToString()).ToString();
        }


        
        // PRIVATE MAIN EVENTHANDLER
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckFill())
            {
                //ton tai => sua
                if(xl_BanHang.KiemTraChiTietDonHangTonTai(txtMaHoaDon.Text, cboMaHang.SelectedValue.ToString()))
                {
                    if(txtDonGia.Text.Trim() != txtGiaBan.Text.Trim())
                    {
                        MessageBox.Show("Không thể bán 1 mặt hàng với 2 mức giá khác nhau trong cùng hóa đơn");
                        return;
                    }
                    if((int)nudSoLuong.Value + xl_BanHang.LaySoLuongHangTrongChiTiet(txtMaHoaDon.Text, cboMaHang.SelectedValue.ToString()) > xl_BanHang.LaySoLuongHangCoThe(cboMaHang.SelectedValue.ToString()))
                    {
                        message.showAlert("Số lượng hàng mua vượt quá số lượng còn", ThuVien.MessageForm.enmType.Warning);
                        return;
                    }
                    DialogResult dr = MessageBox.Show("Giỏ hàng đã tồn tại sản phẩm này, cập nhật số lượng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        bool kq_ThemSoLuong = xl_BanHang.CapNhatTangSoLuongSanPhamTrongGio(txtMaHoaDon.Text, cboMaHang.SelectedValue.ToString(), (int)nudSoLuong.Value);
                        if (kq_ThemSoLuong)
                        {
                            LoadDGVNhanVien();
                            UpdateTLPBottomLeft();
                            ClearTLPRightTop();
                            return;
                        }
                    }
                    else
                        return;
                }
                if((int)nudSoLuong.Value > xl_BanHang.LaySoLuongHangCoThe(cboTenHang.SelectedValue.ToString()))
                {
                    message.showAlert("số lượng hàng mua vượt quá số lượng còn", ThuVien.MessageForm.enmType.Warning);
                    return;
                }
                bool kq_Them = xl_BanHang.ThemChiTietDonHang(txtMaHoaDon.Text, cboMaHang.SelectedValue.ToString(), (int)nudSoLuong.Value, decimal.Parse(txtGiaSanPham.Text));
                if (kq_Them)
                {
                    LoadDGVNhanVien();
                    UpdateTLPBottomLeft();
                    ClearTLPRightTop();
                    return;
                }
                else
                    MessageBox.Show("Thất bại");
            }
            ValidateCheckFill();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dr == DialogResult.Yes)
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvChiTietHang.SelectedRows)
                {
                    if (row != null)
                        if (xl_BanHang.XoaChiTiet(row.Cells["clMaDonHang"].Value.ToString(), row.Cells["clMaSP"].Value.ToString()))
                            count++;
                }
                bool kq_LuuXoa = xl_BanHang.LuuVaoDB();
                if(kq_LuuXoa)
                {
                    MessageBox.Show("Bạn đã xóa thành công " + count + " sản phẩm trong giỏ");
                    LoadDGVNhanVien();
                    UpdateTLPBottomLeft();
                    return;
                }
                MessageBox.Show("Xóa thất bại");
            }
                
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy đơn này không?", "Hủy đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                bool kq_HuyDon = xl_BanHang.HuyDon(txtMaHoaDon.Text);
                if(kq_HuyDon)
                {
                    message.Alert("Đã hủy đơn " + txtMaHoaDon.Text, ThuVien.MessageForm.enmType.Success);
                    txtMaHoaDon.Text = "";
                    dgvChiTietHang.DataSource = DBNull.Value;
                    ClearTLPRightTop();
                    ClearPnlBottom();
                    CLearPnlTop();
                }
                else
                {
                    message.Alert("Hủy đơn không thành công" + txtMaHoaDon.Text, ThuVien.MessageForm.enmType.Error);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckFill())
            {
                if (xl_BanHang.KiemTraChiTietDonHangTonTai(txtMaHoaDon.Text, cboMaHang.SelectedValue.ToString()))
                {
                    DialogResult dr = MessageBox.Show("Thay đổi thông tin sản phẩm " + cboTenHang.SelectedText + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                        return;
                    bool kq_SuaChiTiet = xl_BanHang.SuaChiTietDonHang(txtMaHoaDon.Text, cboMaHang.SelectedValue.ToString(), (int)nudSoLuong.Value, decimal.Parse(txtGiaSanPham.Text));
                    if (kq_SuaChiTiet)
                    {

                        LoadDGVNhanVien();
                        UpdateTLPBottomLeft();
                        ClearTLPRightTop();
                        UnValidateCheckFill();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Trong đơn hàng không tồn tại mặt hàng trên");
                    return;
                }
            }
            ValidateCheckFill();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(txtMaHoaDon.Text == "")
            {
                epCheckFill.SetError(txtMaHoaDon, "Vui lòng tạo mới hóa đơn, thêm các mặt hàng trước khi thanh toán");
                return;
            }
            if(txtThanhTienCuoiCung.Text == "")
            {
                {
                    epCheckFill.SetError(txtThanhTienCuoiCung, "Vui lòng thêm các mặt hàng trước khi thanh toán");
                    return;
                }
            }
            if (txtTienNhan.Text == "")
            {
                {
                    epCheckFill.SetError(txtTienNhan, "Vui lòng điền số tiền khách hàng thanh toán trước");
                    return;
                }
            }

                string MaKH = "khach";
            if (cboMaKH.SelectedIndex != -1)
                MaKH = cboMaKH.SelectedValue.ToString();


            bool kq = xl_BanHang.ThanhToan(txtMaHoaDon.Text, MaKH, double.Parse(txtThanhTienCuoiCung.Text));
            if(kq)
            {
                dgvChiTietHang.DataSource = null;
                
                ThuVien.MessageForm message = new ThuVien.MessageForm();
                message.Alert("Thanh toán thành công", ThuVien.MessageForm.enmType.Success);
                ClearPnlBottom();
                //frmHoaDon hd = new frmHoaDon(txtMaHoaDon.Text);
                //hd.Show();
                txtMaHoaDon.Text = "";
                LoadDGVNhanVien();
            }
        }



        // PRIVATE EVENTHANDLER
        private void txtMaHoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                HoaDon = xl_BanHang.TaoHoaDon();
                txtMaHoaDon.Text = HoaDon;
                EnableTLPControls();
            }
            
        }
        private void txtMaHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtThanhTien_Enter(object sender, EventArgs e)
        {
            if(txtGiaBan.Text != "" && nudSoLuong.Value != 0)
            {
                if(txtKhuyenMai.Text == "0")
                    ((TextBox)(sender)).Text = (decimal.Round(decimal.Parse(txtGiaBan.Text))).ToString();
                else
                    ((TextBox)(sender)).Text = (decimal.Round(decimal.Parse(txtGiaBan.Text)) - decimal.Parse(txtKhuyenMai.Text)).ToString();
            }
        }
        private void txtKhuyenMai_Leave(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "")
                ((TextBox)(sender)).Text = "0";
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            frmScan frm_Scan = new frmScan();
            frm_Scan.TurnOnPictureBoxClick();
            frm_Scan.Show();
            frm_Scan.FormClosed += Frm_Scan_FormClosed;
            cboMaKH.SelectedValue = frm_Scan.GetCode();
        }
        private void Frm_Scan_FormClosed(object sender, FormClosedEventArgs e)
        {
            cboMaKH.SelectedValue = ((frmScan)(sender)).GetCode();
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            btnDown.BackColor = Color.Transparent;
            btnDown.FlatAppearance.BorderSize = 0;
            txtGiaBan.Text = txtDonGia.Text;
        }




        // PRIVATE COMMON FUNCTION
        void UnAbleTLPControls()
        {
            cboMaHang.Enabled = false;
            cboTenHang.Enabled = false;
            txtDonGia.Enabled = false;
            txtGiaBan.Enabled = false;
            txtKhuyenMai.Enabled = false;
            btnDown.Enabled = false;
            txtGiaSanPham.Enabled = false;
        }
        void EnableTLPControls()
        {
            cboMaHang.Enabled = true;
            cboTenHang.Enabled = true;
            txtDonGia.Enabled = true;
            txtGiaBan.Enabled = true;
            txtKhuyenMai.Enabled = true;
            btnDown.Enabled = true;
            txtGiaSanPham.Enabled = true;
        }
        void LoadDGVNhanVien()
        {
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(xl_BanHang.LayDSChiTietDonHangTheoMaDonHang(txtMaHoaDon.Text)))
            {
                dt.Load(reader);
            }
            Type type = typeof(System.Byte[]);
            dt.Columns.Add("clHinhAnh", type);
            foreach (DataRow row in dt.Rows)
            {
                string fileName = "";
                fileName = folderPath2 + "\\HinhAnh\\File_anh\\" + row["HinhAnh"].ToString();
                row["clHinhAnh"] = File.ReadAllBytes(fileName);

            }
            dgvChiTietHang.DataSource = dt;
            dgvChiTietHang.Columns["clHinhAnh"].HeaderText = "Hình ảnh";
            dgvChiTietHang.Columns["clHinhAnh"].Width = 188;
            dgvChiTietHang.Columns["hinhanh"].Visible = false;
            setupDV();
        }
        void setupDV()
        {
            for (int i = 0; i < dgvChiTietHang.Columns.Count; i++)
                if (dgvChiTietHang.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvChiTietHang.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }
        private void ValidateCheckFill()
        {
            if (txtMaHoaDon.Text == "")
                epCheckFill.SetError(txtMaHoaDon, "Vui lòng nhấp đôi để tạo mới 1 hóa đơn");
            else
                epCheckFill.SetError(txtMaHoaDon, "");
            if (cboMaHang.SelectedIndex == -1 || cboTenHang.SelectedIndex == -1)
            {
                epCheckFill.SetError(cboMaHang, "Vui lòng chọn hàng trước khi thực hiện thao tác");
                epCheckFill.SetError(cboTenHang, "Vui lòng chọn hàng trước khi thực hiện thao tác");
            }
            else
            {
                epCheckFill.SetError(cboMaHang, "");
                epCheckFill.SetError(cboTenHang, "");

            }
            if (txtGiaBan.Text == "")
                epCheckFill.SetError(txtGiaBan, "Vui lòng dùng đơn giá hoặc nhập giá bán trước khi thực hiện thao tác");
            else
                epCheckFill.SetError(txtGiaBan, "");
        }
        private void UnValidateCheckFill()
        {
            epCheckFill.SetError(txtMaHoaDon, "");
            epCheckFill.SetError(cboMaHang, "");
            epCheckFill.SetError(cboTenHang, "");            
            epCheckFill.SetError(txtGiaBan, "");
        }
        private bool CheckFill()
        {
            if (txtMaHoaDon.Text == "")
                return false;
            if (cboMaHang.SelectedIndex == -1)
                return false;
            if (cboTenHang.SelectedIndex == -1)
                return false;
            if (txtGiaBan.Text == "")
                return false;
            if (txtGiaSanPham.Text == "")
                return false;
            return true;
        }
        private static string LayDuongDan()
        {
            string folderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return System.IO.Directory.GetParent(System.IO.Directory.GetParent((System.IO.Directory.GetParent(folderPath).ToString())).ToString()).ToString(); ;
        }
        void ClearTLPRightTop()
        {
            cboMaHang.SelectedIndex = -1;
            cboTenHang.SelectedIndex = -1;
            txtDonGia.Text = "";
            txtGiaBan.Text = "";
            nudSoLuong.Value = 1;
            txtKhuyenMai.Text = "";
            txtGiaSanPham.Text = "";
        }
        void ClearPnlBottom()
        {
            txtTongCong.Text = "";
            txtKhuyenMai2.Text = "";
            txtThanhTienCuoiCung.Text = "";
            txtTienNhan.Text = "";
            txtTienThua.Text = "";
        }
        void CLearPnlTop()
        {
            cboMaKH.SelectedIndex = -1;
            cboTenKhachHang.SelectedIndex = -1;
        }
        void UpdateTLPBottomLeft()
        {
            double ThanhTien = TinhTongCong();
            txtTongCong.Text = ThanhTien.ToString();
            if (chkVAT.Checked)
                ThanhTien -= ThanhTien * (VAT/100);
            txtThanhTienCuoiCung.Text = decimal.Round((decimal)ThanhTien).ToString();
        }
        private double TinhTongCong()
        {
            double TongTien = 0;
            double dongia = 0;
            int soluong = 0;
            foreach(DataGridViewRow row in dgvChiTietHang.Rows)
            {
                try
                {
                    dongia = double.Parse(row.Cells["clDonGia"].Value.ToString());
                    soluong = int.Parse(row.Cells["clSoLuong"].Value.ToString());
                    TongTien += dongia * soluong;
                }
                catch
                {
                    dongia = double.Parse(row.Cells["DonGia"].Value.ToString());
                    soluong = int.Parse(row.Cells["Soluong"].Value.ToString());
                    TongTien += dongia * soluong;
                }
                
            }
            return TongTien;
        }
        private double TinhTongCongSauThue()
        {
            double TongTien = 0;
            double dongia = 0;
            int soluong = 0;
            foreach (DataGridViewRow row in dgvChiTietHang.Rows)
            {
                dongia = double.Parse(row.Cells["clDonGia"].Value.ToString());
                soluong = int.Parse(row.Cells["clSoLuong"].Value.ToString());
                TongTien += dongia * soluong;
            }
            TongTien = TongTien - TongTien * (VAT / 100);
            return TongTien;
        }
        //



        //
        private void chkVAT_CheckedChanged(object sender, EventArgs e)
        {
            if (txtThanhTienCuoiCung.Text == "")
                return;
            if(((CheckBox)(sender)).Checked)
            {
                if (txtKhuyenMai2.Text == "")
                    txtThanhTienCuoiCung.Text = TinhTongCongSauThue().ToString();
                else
                    txtThanhTienCuoiCung.Text = (TinhTongCongSauThue() - double.Parse(txtKhuyenMai2.Text)).ToString();
            }
            else
            {
                if (txtKhuyenMai2.Text == "")
                    txtThanhTienCuoiCung.Text = TinhTongCong().ToString();
                else
                    txtThanhTienCuoiCung.Text = (TinhTongCong() - double.Parse(txtKhuyenMai2.Text)).ToString();
            }
        }
        private void txtKhuyenMai2_TextChanged(object sender, EventArgs e)
        {
            if (txtThanhTienCuoiCung.Text == "")
                return;
            if (txtKhuyenMai2.Text == "")
            {
                if (chkVAT.Checked)
                    txtThanhTienCuoiCung.Text = (TinhTongCongSauThue() - 0).ToString();
                else
                    txtThanhTienCuoiCung.Text = (TinhTongCong() - 0).ToString();
                return;
            }

            if(chkVAT.Checked)
                txtThanhTienCuoiCung.Text = (TinhTongCongSauThue() - double.Parse(txtKhuyenMai2.Text)).ToString();
            else
                txtThanhTienCuoiCung.Text = (TinhTongCong() - double.Parse(txtKhuyenMai2.Text)).ToString();
        }
        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            if (txtThanhTienCuoiCung.Text == "")
                return;
            if(txtTienNhan.Text != "")
                if (double.Parse(txtTienNhan.Text) < double.Parse(txtThanhTienCuoiCung.Text))
                {
                    txtTienThua.Text = "";
                    return;
                }
                else
                    txtTienThua.Text = (double.Parse(txtTienNhan.Text) - double.Parse(txtThanhTienCuoiCung.Text)).ToString();
        }
        //
        
    }
}