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
using ThuVien;

namespace frmMain
{
    public partial class frmThanhToanNhapHang : Form
    {
        public frmThanhToanNhapHang()
        {
            InitializeComponent();
        }
        public frmThanhToanNhapHang(string pMaNhapHang)
        {
            InitializeComponent();
            this.MaNhapHang = pMaNhapHang;
        }


        //Khai bao
        string MaNhapHang;
        QuanLyNhapHang xl_QuanLyNhapHang = new QuanLyNhapHang();
        MessageForm message = new MessageForm();



        

        private void frmThanhToanNhapHang_Load(object sender, EventArgs e)
        {
            LoadDGVChiTietNhapHang();
            NHAPHANG nhaphang = xl_QuanLyNhapHang.LayNhapHangTheoMa(MaNhapHang);
            if(nhaphang == null)
            {
                message.showAlert("Nhập hàng null rồi", MessageForm.enmType.Error);
                return;
            }
            else
            {
                txtNhaCungCap.Text = nhaphang.NHACUNGCAP.TENNCC;
                txtTongChiPhi.Text = nhaphang.TONGCHIPHI.Value.ToString();
            }

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


        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bool kq_ThanhToanNhapHang = xl_QuanLyNhapHang.ThanhToanNhapHang(MaNhapHang);
            if(kq_ThanhToanNhapHang)
            {
                message.showAlert("Thanh toán thành công",MessageForm.enmType.Success);

                Program.frm_ThanhToan1NhapHang.Hide();
                Program.frm_QuanLyNhapHang.Show();
                Program.frm_QuanLyNhapHang.LoadDGVNhapHang();

            }
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if(btnThanhToan.Enabled)
            {
                DialogResult dr = MessageBox.Show("Đơn đã được xác nhận, bạn có chắc muốn trở về không", "trở về", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
            }
            Program.frm_ThanhToan1NhapHang.Hide();
            Program.frm_QuanLyNhapHang.Show();
        }
        private void frmThanhToanNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnTroVe.PerformClick();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = true;
        }
    }
}
