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
    public partial class frmThem1HangHoa : Form
    {
        QuanLyHangHoa xl_QuanLyHangHoa = new QuanLyHangHoa();
        ThuVien.MessageForm message = new ThuVien.MessageForm();


        public frmThem1HangHoa()
        {
            InitializeComponent();
        }       
        private void frmThem1HangHoa_Load(object sender, EventArgs e)
        {
            LoadCboLoaiSP();
            LoadCboChatLieu();
            LoadCboNSX();
            LoadCboNCC();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaLoaiSP;
            string MaChatLieu;
            string MaNSX;
            string MaNCC;
            int SL;
            double GiaTri, KhuyenMai;
            if (txtTenSanPham.Text == "")
            {
                errorProvider1.SetError(txtTenSanPham, "Vui lòng nhập tên sản phẩm");
            }

            
            
            

            if (txtSoLuong.Text == "")
                SL = 0;
            else
                SL = int.Parse(txtSoLuong.Text);
            if (txtGiaTri.Text == "")
                GiaTri = 0;
            else
                GiaTri = double.Parse(txtGiaTri.Text);
            if (txtKhuyenMai.Text == "")
                KhuyenMai = 0;
            else
                KhuyenMai = double.Parse(txtKhuyenMai.Text);

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
            
            
            bool kq_ThemSP = xl_QuanLyHangHoa.Them1HangHoa(
                            txtTenSanPham.Text, 
                            MaLoaiSP,
                            MaChatLieu,
                            MaNSX,
                            MaNCC,
                            GetPictureBoxImage(),
                            SL,
                            GiaTri,
                            KhuyenMai);
            if(kq_ThemSP)
            {
                message.Alert("Thêm thành công 1 sản phẩm", ThuVien.MessageForm.enmType.Success);
                Program.frm_QuanLyHangHoa.LoadTable();
                this.Close();
            }
            else
            {
                message.Alert("Thêm thất bại, vui lòng kiểm tra lại", ThuVien.MessageForm.enmType.Error);
            }

        }



        private string GetPictureBoxImage()
        {
            if (pictureBox1.Tag is null)
            {
                return "SanPhamMau.jpg";
            }
            return pictureBox1.Tag.ToString();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            string ImagePath = LayDuongDan() + "\\HinhAnh\\File_anh\\";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = Path.GetFileName(open.FileName);
                if (!File.Exists(ImagePath + Path.GetFileName(open.FileName)))
                    File.Copy(open.FileName, ImagePath + Path.GetFileName(open.FileName));
            }
        }
        private static string LayDuongDan()
        {
            string folderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return System.IO.Directory.GetParent(System.IO.Directory.GetParent((System.IO.Directory.GetParent(folderPath).ToString())).ToString()).ToString(); ;
        }
        public void LoadCboLoaiSP()
        {
            cboLoaiSP.DataSource = xl_QuanLyHangHoa.LayDSLoaiSP();
            cboLoaiSP.DisplayMember = "TenLoaiSP";
            cboLoaiSP.ValueMember = "MaLoaiSP";
        }
        public void LoadCboChatLieu()
        {
            cboChatLieu.DataSource = xl_QuanLyHangHoa.LayDSChatLieu();
            cboChatLieu.DisplayMember = "TenChatLieu";
            cboChatLieu.ValueMember = "MaChatLieu";
        }
        public void LoadCboNSX()
        {
            cboNSX.DataSource = xl_QuanLyHangHoa.LayDSNhaSX();
            cboNSX.DisplayMember = "TenNSX";
            cboNSX.ValueMember = "MaNSX";
        }
        public void LoadCboNCC()
        {
            cboNCC.DataSource = xl_QuanLyHangHoa.LayDSNhaCC();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }



        private void btnThemLoaiSanPham_Click(object sender, EventArgs e)
        {
            Program.frm_ThemLoaiSanPham = new frmThemLoaiSanPham();
            Program.frm_ThemLoaiSanPham.Show();
            Program.frm_Them1HangHoa.Hide();

        }
        private void btnThemChatLieu_Click(object sender, EventArgs e)
        {
            Program.frm_ThemChatLieu = new frm_ThemChatLieu();
            Program.frm_ThemChatLieu.Show();
            Program.frm_Them1HangHoa.Hide();
        }
        private void btnNSX_Click(object sender, EventArgs e)
        {
            Program.frm_ThemNhaSanXuat = new frmThemNSX();
            Program.frm_ThemNhaSanXuat.Show();
            Program.frm_Them1HangHoa.Hide();
        }
        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            Program.frm_ThemNCC = new frmThemNCC();
            Program.frm_ThemNCC.Show();
            Program.frm_Them1HangHoa.Hide();
        }
        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            Program.frm_DuDoan = new frmDuDoan();
            Program.frm_DuDoan.Show();
        }
    }
}
