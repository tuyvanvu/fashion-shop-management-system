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
    public partial class frmQuanLyHangHoa : Form
    {
        QuanLyHangHoa xl_QuanLyHangHoa = new QuanLyHangHoa();
        ThuVien.MessageForm message = new ThuVien.MessageForm();

        public frmQuanLyHangHoa()
        {
            InitializeComponent();
        }
        private void frmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            cboLoaiSP.DataSource = xl_QuanLyHangHoa.LayDSLoaiSP();
            cboLoaiSP.DisplayMember = "TenLoaiSP";
            cboLoaiSP.ValueMember = "MaLoaiSP";
            cboChatLieu.DataSource = xl_QuanLyHangHoa.LayDSChatLieu();
            cboChatLieu.DisplayMember = "TenChatLieu";
            cboChatLieu.ValueMember = "MaChatLieu";
            cboNSX.DataSource = xl_QuanLyHangHoa.LayDSNhaSX();
            cboNSX.DisplayMember = "TenNSX";
            cboNSX.ValueMember = "MaNSX";
            cboNCC.DataSource = xl_QuanLyHangHoa.LayDSNhaCC();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            LoadDGVSanPham();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDGVSanPham();
        }


        public void LoadTable()
        {
            LoadDGVSanPham();
        }


        void LoadDGVSanPham()
        {
            string MaLoaiSP;
            string MaChatLieu;
            string MaNSX;
            string MaNCC;
            bool isKhuyenMai;
            try
            {
                MaLoaiSP = cboLoaiSP.SelectedValue.ToString();
            }
            catch
            {
                MaLoaiSP = "";
            }
            try
            {
                MaChatLieu = cboChatLieu.SelectedValue.ToString();
            }
            catch
            {
                MaChatLieu = "";
            }
            try
            {
                MaNSX = cboNSX.SelectedValue.ToString();
            }
            catch
            {
                MaNSX = "";
            }
            try
            {
                MaNCC = cboNCC.SelectedValue.ToString();
            }
            catch
            {
                MaNCC = "";
            }
            try
            {
                isKhuyenMai = chkKhuyenMai.Checked;
            }
            catch
            {
                isKhuyenMai = false;
            }


            var lstSanPham = xl_QuanLyHangHoa.TimKiem(
                MaLoaiSP,
                MaChatLieu,
                MaNSX,
                MaNCC,
                isKhuyenMai);
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            if (lstSanPham != null && lstSanPham.Count != 0)
            {
                string fileName = "";
                using (var reader = ObjectReader.Create(lstSanPham))
                {
                    dt.Load(reader);
                }
                Type type = typeof(System.Byte[]);
                dt.Columns.Add("clHinhAnh", type);
                foreach (DataRow row in dt.Rows)
                {
                    fileName = folderPath2 + "\\HinhAnh\\File_anh\\" + row["Hinhanh"];
                    row["clHinhAnh"] = File.ReadAllBytes(fileName);
                }
                dgvSanPham.DataSource = dt;
                dgvSanPham.Columns["clHinhAnh"].HeaderText = "Hình ảnh";
                setupDV();
            }
            else
            {
                message.Alert("Không tìm thấy sản phẩm với những tiêu chí trên", ThuVien.MessageForm.enmType.Error);
            }
        }
        private static string LayDuongDan()
        {
            string folderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return System.IO.Directory.GetParent(System.IO.Directory.GetParent((System.IO.Directory.GetParent(folderPath).ToString())).ToString()).ToString(); ;
        }
        void setupDV()
        {
            for (int i = 0; i < dgvSanPham.Columns.Count; i++)
                if (dgvSanPham.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvSanPham.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Program.frm_Them1HangHoa = new frmThem1HangHoa();
            Program.frm_Them1HangHoa.ShowDialog();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            BaoTri();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            BaoTri();
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            BaoTri();
        }
        void BaoTri()
        {
            message.showAlert("Chức năng đang được bảo trì", ThuVien.MessageForm.enmType.Info);
        }

    }
}
