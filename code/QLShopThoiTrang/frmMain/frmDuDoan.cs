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
using Accord.MachineLearning;

namespace frmMain
{
    public partial class frmDuDoan : Form
    {
        KNearestNeighbors knn;
        int min;
        QuanLyHangHoa xl_QuanLyHangHoa = new QuanLyHangHoa();
        AI xl_knn = new AI();


        public frmDuDoan()
        {
            InitializeComponent();
            min = 0;
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


        private void frmDuDoan_Load(object sender, EventArgs e)
        {
            LoadCboLoaiSP();
            LoadCboChatLieu();
            LoadCboNSX();
            LoadCboNCC();
            
        }
        private void btnDuDoan_Click(object sender, EventArgs e)
        {
            NhomHang nh = NhomHang.BinhThuong;
            double[] data =
            {
                xl_knn.GetDiemChatLieu(cboChatLieu.SelectedValue.ToString()),
                xl_knn.GetDiemLoaiSP(cboLoaiSP.SelectedValue.ToString()),
                xl_knn.GetDiemNhaCungCap(cboNCC.SelectedValue.ToString()),
                xl_knn.GetDiemNhaSanXuat(cboNSX.SelectedValue.ToString())
            };
            try
            {
                nh = xl_knn.QuyetDinh(knn, data, min);
            }
            catch(AggregateException err)
            {
                foreach (var errInner in err.InnerExceptions)
                {
                    MessageBox.Show(errInner + ""); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
                }
            }
            if (nh == NhomHang.ThanhCong)
                MessageBox.Show("Mặt hàng có khả năng cao bán chạy");
            else if (nh == NhomHang.BinhThuong)
                MessageBox.Show("Mặt hàng này có thể sẽ bán tạm ổn");
            else
                MessageBox.Show("Mặt hàng này có thể sẽ khó bán");
        }
        private void frmDuDoan_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void btnHoc_Click(object sender, EventArgs e)
        {
            if(cboChatLieu.SelectedIndex != -1 &&
               cboLoaiSP.SelectedIndex != -1   &&
               cboNCC.SelectedIndex != -1      &&
               cboNSX.SelectedIndex != -1
                )
            {
                double[][] data = xl_knn.LayDataSanPham();
                int[] input = xl_knn.TaoInput();
                for(int i = 0; i < input.Length; i++)
                {
                    if (min > input[i])
                        min = input[i];
                }
                knn = xl_knn.Hoc(data, input);
                btnDuDoan.Enabled = true;
                btnHoc.Enabled = false;
            }
            
        }
    }
}
