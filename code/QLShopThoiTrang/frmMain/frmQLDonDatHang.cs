using FastMember;
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

namespace frmMain
{
    public partial class frmQLDonDatHang : Form
    {
        BanHang xl_BanHang = new BanHang();
        QuanLyDatHang xl_QLDH = new QuanLyDatHang();
        ThuVien.MessageForm message = new ThuVien.MessageForm();


        public frmQLDonDatHang()
        {
            InitializeComponent();
        }



        private static string LayDuongDan()
        {
            string folderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return System.IO.Directory.GetParent(System.IO.Directory.GetParent((System.IO.Directory.GetParent(folderPath).ToString())).ToString()).ToString(); ;
        }
        void LoadDGVDonHang(bool KhachLa)
        {
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(xl_QLDH.LayDSDatHang()))
            {
                dt.Load(reader);
            }
            Type type = typeof(System.Byte[]);
            dt.Columns.Add("clThanhToan", type);
            foreach (DataRow row in dt.Rows)
            {
                row["ThanhTien"] = decimal.Round((decimal)row["ThanhTien"]);
                string fileName = "";

                if (row["THANHTOAN"] is true)
                    fileName = folderPath2 + "\\HinhAnh\\Anh\\success.png";
                else
                    fileName = folderPath2 + "\\HinhAnh\\Anh\\error.png";
                row["clThanhToan"] = File.ReadAllBytes(fileName);
            }
            if (KhachLa)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "TenDN = 'Khach'";
                dgvDonHang.DataSource = dv;
            }
            else
                dgvDonHang.DataSource = dt;
            dgvDonHang.Columns["clThanhToan"].HeaderText = "Đã thanh toán";
            dgvDonHang.Columns["clThanhToan"].Width = 188;
            dgvDonHang.Columns["thanhtoan"].Visible = false;
            setupDV();
        }
        void LoadDGVDonHangTheoGia(bool KhachLa)
        {
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(xl_QLDH.LayDSDatHangTheoMucGia(cboMucGia.GetItemText(cboMucGia.SelectedItem))))
            {
                dt.Load(reader);
            }
            Type type = typeof(System.Byte[]);
            dt.Columns.Add("clThanhToan", type);
            foreach (DataRow row in dt.Rows)
            {
                row["ThanhTien"] = decimal.Round((decimal)row["ThanhTien"]);
                string fileName = "";

                if (row["THANHTOAN"] is true)
                    fileName = folderPath2 + "\\HinhAnh\\Anh\\success.png";
                else
                    fileName = folderPath2 + "\\HinhAnh\\Anh\\error.png";
                row["clThanhToan"] = File.ReadAllBytes(fileName);
            }
            if (KhachLa)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "TenDN = 'Khach'";
                dgvDonHang.DataSource = dv;
            }
            else
                dgvDonHang.DataSource = dt;

            dgvDonHang.Columns["clThanhToan"].HeaderText = "Đã thanh toán";
            dgvDonHang.Columns["clThanhToan"].Width = 188;
            dgvDonHang.Columns["thanhtoan"].Visible = false;
            setupDV();
        }
        void LoadDGVChiTietDonHang(bool IsAll)
        {
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            List<string> lst = new List<string>();
            if (IsAll)
            {
                foreach (DataGridViewRow row in dgvDonHang.Rows)
                {
                    if (row.Cells["clMaDatHang1"].Value.ToString() != null)
                        lst.Add(row.Cells["clMaDatHang1"].Value.ToString());
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvDonHang.SelectedRows)
                {
                    if (row.Cells["clMaDatHang1"].Value.ToString() != null)
                        lst.Add(row.Cells["clMaDatHang1"].Value.ToString());
                }
            }




            using (var reader = ObjectReader.Create(xl_QLDH.LayDSChiTietDatHang(lst)))
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
            dgvChiTietDonHang.DataSource = dt;
            dgvChiTietDonHang.Columns["clHinhAnh"].HeaderText = "Hình ảnh";
            dgvChiTietDonHang.Columns["clHinhAnh"].Width = 188;
            dgvChiTietDonHang.Columns["hinhanh"].Visible = false;
            setupDV();
        }
        void setupDV()
        {
            for (int i = 0; i < dgvChiTietDonHang.Columns.Count; i++)
                if (dgvChiTietDonHang.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvChiTietDonHang.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void frmQLDonDatHang_Load(object sender, EventArgs e)
        {
            LoadDGVDonHang(chkKhachLa.Checked);
            dgvDonHang.SelectionChanged += DgvDonHang_SelectionChanged;
            cboMucGia.DataSource = xl_QLDH.LayDSMucGia();
            cboMucGia.DisplayMember = "MucGiaCa";
            cboMucGia.ValueMember = "MaMucGia";
            cboMucGia.SelectedIndex = -1;
            cboMucGia.SelectedIndexChanged += CboMucGia_SelectedIndexChanged; ;
        }

        private void CboMucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMucGia.SelectedIndex != -1)
                LoadDGVDonHangTheoGia(chkKhachLa.Checked);
        }
        private void DgvDonHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == dgvDonHang.Rows.Count)
            {
                LoadDGVChiTietDonHang(true);
                return;
            }

            if (dgvDonHang.SelectedRows.Count != 0)
            {
                LoadDGVChiTietDonHang(false);
            }
        }

        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa đơn không", "Xóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                bool kq = xl_QLDH.XoaDatHang(dgvDonHang.CurrentRow.Cells["clMaDatHang1"].Value.ToString());
                if (kq)
                {
                    if (cboMucGia.SelectedIndex == -1)
                        LoadDGVDonHang(chkKhachLa.Checked);
                    else
                        LoadDGVDonHangTheoGia(chkKhachLa.Checked);
                    message.Alert("Xóa đơn hàng thành công", ThuVien.MessageForm.enmType.Success);
                }
                else
                    message.Alert("Thất bại", ThuVien.MessageForm.enmType.Error);
            }
        }
    }
}
