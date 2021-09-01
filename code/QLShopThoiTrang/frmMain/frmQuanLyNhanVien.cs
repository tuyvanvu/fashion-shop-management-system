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
    public partial class frmQuanLyNhanVien : Form
    {
        QuanLyNhanVien xl_QLNV = new QuanLyNhanVien();


        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadDGVNhanVien();
            UpdateThongTinNhanVien(null);
        }

        
        
        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                UpdateThongTinNhanVien(dgvNhanVien.CurrentRow);
            }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)(sender)).Text != "")
                epCheckFill.SetError(((TextBox)(sender)), "");
        }
        private void pbAvatar_Click(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog();
            string ImagePath = LayDuongDan() + "\\HinhAnh\\File_anh_avatar\\";
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pbAvatar.Image = new Bitmap(open.FileName);
                pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                pbAvatar.Tag = Path.GetFileName(open.FileName);
                if (!File.Exists(ImagePath + Path.GetFileName(open.FileName)))
                    File.Copy(open.FileName, ImagePath + Path.GetFileName(open.FileName));
            }
        }
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (CheckFillAll())
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn thêm nhân viên không?", "Thêm nhân viên mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                if (xl_QLNV.KiemTraTenDNDaTonTaiChua(txtTenDN.Text))
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác");
                    return;
                }
                string radio = rdNam.Checked ? rdNam.Text : rdNu.Text;
                string pictureName = pbAvatar.Tag.ToString();
                int kq = xl_QLNV.Them1NhanVien(txtTenDN.Text, txtTenNV.Text, txtSDT.Text,txtEmail.Text, radio,  txtDiaChi.Text, txtCMND.Text, pictureName);
                if (kq == 1)
                {
                    ClearAll();
                    MessageBox.Show("Thêm thành công nhân viên với mật khẩu mặc định là " + txtTenDN.Text);
                    UpdateDatagridviewNhanVien();
                }
                else
                    MessageBox.Show("Thất bại òi");
            }
            else
                ValidationFillAll();
        }
        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (CheckFillAll())
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn sửa thông tin của nhân viên không?", "Sửa thông tin nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                    return;
                if (!xl_QLNV.KiemTraTKCoPhaiNhanVienKhong(txtTenDN.Text))
                {
                    MessageBox.Show("Tài khoản không phải tài khoản nhân viên, vui lòng chọn tài khoản khác");
                    return;
                }
                string radio = rdNam.Checked ? rdNam.Text : rdNu.Text;
                string pictureName = pbAvatar.Tag.ToString();
                bool kq = xl_QLNV.SuaThongTinNhanVien(txtTenDN.Text, txtTenNV.Text, txtSDT.Text, txtEmail.Text, radio, txtDiaChi.Text, txtCMND.Text, pictureName); 
                if (kq)
                {
                    MessageBox.Show("Sửa thành công");
                    UpdateDatagridviewNhanVien();
                }
                else
                    MessageBox.Show("Thất bại òi");
            }
            else
                ValidationFillAll();
        }
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
                return;
            if(txtTenDN.Text == "")
            {
                epCheckFill.SetError(txtTenDN, "Vui lòng nhập tên nhân viên");
                return;
            }
            bool kq = xl_QLNV.XoaNhanVien(txtTenDN.Text);
            if (kq)
            {
                MessageBox.Show("Xóa thành công");
                UpdateDatagridviewNhanVien();
            }
            else
                MessageBox.Show("Thất bại òi");

        }


        //Các hàm phụ trợ
        void LoadDGVNhanVien()
        {
            List<NGUOIDUNG> lstNguoiDung = xl_QLNV.LayDSNhanVien();
            string folderPath2 = LayDuongDan();

            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(lstNguoiDung))
            {
                dt.Load(reader);
            }
            Type type = typeof(System.Byte[]);
            dt.Columns.Add("clAvatar1", type);
            foreach (DataRow row in dt.Rows)
            {
                string fileName = "";
                    fileName = folderPath2 + "\\HinhAnh\\File_anh_avatar\\" + row["Avatar"].ToString();
                row["clAvatar1"] = File.ReadAllBytes(fileName);
            }
            dgvNhanVien.DataSource = dt;
            dgvNhanVien.Columns["clAvatar1"].HeaderText = "Avatar";
            setupDV();
        }
        void setupDV()
        {
            for (int i = 0; i < dgvNhanVien.Columns.Count; i++)
                if (dgvNhanVien.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvNhanVien.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }
        private static string LayDuongDan()
        {
            string folderPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return System.IO.Directory.GetParent(System.IO.Directory.GetParent((System.IO.Directory.GetParent(folderPath).ToString())).ToString()).ToString(); ;
        }
        void LoadPictureBox()
        {
            string folderPath2 = LayDuongDan();
            string AvatarName = dgvNhanVien.CurrentRow.Cells["clAvatar"].Value.ToString();
            string fileName = folderPath2 + "\\HinhAnh\\File_anh_avatar\\" + AvatarName;
            Bitmap bitmap = new Bitmap(fileName);
            pbAvatar.Image = bitmap;
            pbAvatar.Tag = AvatarName;
            pbAvatar.Width = 115;
            pbAvatar.Height = 150;
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }
        void UpdateThongTinNhanVien(DataGridViewRow dgvrNhanVien)
        {
            if (dgvrNhanVien is null)
            {
                txtTenDN.Text = "";
                txtTenNV.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                txtDiaChi.Text = "";
                return;
            }
            txtTenDN.Text = dgvrNhanVien.Cells["clTenDN"].Value.ToString();
            txtTenNV.Text = dgvrNhanVien.Cells["clTenNguoiDung"].Value.ToString();
            txtSDT.Text = dgvrNhanVien.Cells["clSDT"].Value.ToString();
            txtCMND.Text = dgvrNhanVien.Cells["clCMND"].Value.ToString();
            txtDiaChi.Text = dgvrNhanVien.Cells["clDiaChi"].Value.ToString();
            txtEmail.Text = dgvrNhanVien.Cells["clEmail"].Value.ToString();
            CheckRadioButton();
            LoadPictureBox();

        }
        void CheckRadioButton()
        {
            if (dgvNhanVien.CurrentRow.Cells["clGioiTinh"].Value.ToString() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
        }
        bool CheckFillAll()
        {
            if (txtTenDN.Text == "")
                return false;
            if (txtTenNV.Text == "")
                return false;
            if (txtSDT.Text == "")
                return false;
            if (txtCMND.Text == "")
                return false;
            if (txtDiaChi.Text == "")
                return false;
            if (!rdNu.Checked && !rdNam.Checked)
                return false;
            return true;
        }
        void ValidationFillAll()
        {
            if (txtTenDN.Text == "")
                epCheckFill.SetError(txtTenDN, "Vui lòng nhập tên nhân viên");

            if (txtTenNV.Text == "")
                epCheckFill.SetError(txtTenNV, "Vui lòng nhập tên nhân viên");

            if (txtSDT.Text == "")
                epCheckFill.SetError(txtSDT, "Vui lòng nhập tên nhân viên");

            if (txtCMND.Text == "")
                epCheckFill.SetError(txtCMND, "Vui lòng nhập tên nhân viên");

            if (txtDiaChi.Text == "")
                epCheckFill.SetError(txtDiaChi, "Vui lòng nhập tên nhân viên");
            if (!rdNu.Checked && !rdNam.Checked)
            {
                epCheckFill.SetError(rdNu, "Vui lòng chọn giới tính của nhân viên");
            }
        }
        private void UpdateDatagridviewNhanVien()
        {
            LoadDGVNhanVien();
        }
        void ClearAll()
        {
            txtTenDN.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            rdNam.Checked = true;
        }

        
    }
}
