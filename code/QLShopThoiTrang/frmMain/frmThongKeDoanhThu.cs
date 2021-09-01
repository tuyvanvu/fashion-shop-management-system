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
    public partial class frmThongKeDoanhThu : Form
    {
        ThongKeDoanhThu xl_ThongKe = new ThongKeDoanhThu();
        MessageForm message = new MessageForm();
        


        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(DateTime.Compare(dtpBatDau.Value, dtpKetThuc.Value) == 0 || DateTime.Compare(dtpBatDau.Value, dtpKetThuc.Value) > 0)
            {
                message.showAlert("Vui lòng kiểm tra lại ngày bắt đầu và ngày kết thúc", MessageForm.enmType.Warning);
                return;
            }


            if(rdoThu.Checked)
            {
                if (dgvThongKe2.Visible)
                {
                    dgvThongKe2.Visible = false;
                    dgvThongKe.Visible = true;
                }
                dgvThongKe.DataSource = xl_ThongKe.LayDSDonHangTheoThoiGian(dtpBatDau.Value, dtpKetThuc.Value);
                LayTongThu();
            }
            else
            {
                if (dgvThongKe.Visible)
                {
                    dgvThongKe.Visible = false;
                    dgvThongKe2.Visible = true;
                }
                dgvThongKe2.DataSource = xl_ThongKe.LayDSNhapHangTheoNgayNhap(dtpBatDau.Value, dtpKetThuc.Value);
                LayTongChi();
            }
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            if(!dgvThongKe.Visible && !dgvThongKe2.Visible)
            {
                message.showAlert("Vui lòng Chọn loại thống kê", MessageForm.enmType.Warning);
                return;
            }
            if(dgvThongKe.Visible)
            {
                XuatExcel ex = new XuatExcel();
                string FileName = "";
                List<DONHANG> lstDonHang = (List<DONHANG>)dgvThongKe.DataSource;
                try
                {
                    ex.ExportDonHang(ex.GetListTempDonHang(lstDonHang), ref FileName, true);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                XuatExcel ex = new XuatExcel();
                string FileName = "";
                try
                {
                    List<TEMPNHAPHANG> lstTempNhapHang = (List<TEMPNHAPHANG>)dgvThongKe2.DataSource;
                    ex.ExportNhapHang(lstTempNhapHang, ref FileName, true);
                }
                catch
                {
                    MessageBox.Show("Bao loi");
                }

            }

        }

        void LoadDGVThu()
        {
            dgvThongKe2.Visible = false;
            dgvThongKe.Visible = true;
            dgvThongKe.DataSource = xl_ThongKe.LayDSDonHang();
            dgvThongKe.Columns["clMaDonHang"].Visible = true;
            dgvThongKe.Columns["clTenDN"].Visible = true;
            dgvThongKe.Columns["clNgayLap"].Visible = true;
            txtTongThu.Text = LayTongThu();
            
        }

        private string LayTongThu()
        {
            double tongcong = 0;
            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if(row.Cells["clTongGiaTri"] != null)
                    tongcong += double.Parse(row.Cells["clTongGiaTri"].Value.ToString());
            }
            return decimal.Round((decimal)tongcong).ToString();
        }

        void LoadDGVChi()
        {
            dgvThongKe.Visible = false;
            dgvThongKe2.Visible = true;
            dgvThongKe2.DataSource = xl_ThongKe.LayDSNhapHang();
            dgvThongKe2.Columns["clMaNhapHang"].Visible = true;
            dgvThongKe2.Columns["clNgayNhap"].Visible = true;
            dgvThongKe2.Columns["clTenNCC"].Visible = true;
            txtTongChi.Text = LayTongChi();
        }
        private string LayTongChi()
        {
            double tongcong = 0;
            foreach(DataGridViewRow row in dgvThongKe2.Rows)
            {
                if (row.Cells["clTongGiaTri2"].Value != null)
                    tongcong += double.Parse(row.Cells["clTongGiaTri2"].Value.ToString());
            }
            return decimal.Round((decimal)tongcong).ToString();
        }


        private void rdoThu_CheckedChanged(object sender, EventArgs e)
        {
            //pnlThu.Visible = rdoThu.Checked;
            //LoadDGVThu();
        }
        private void rdoChi_CheckedChanged(object sender, EventArgs e)
        {
            //pnlChi.Visible = rdoChi.Checked;
            //LoadDGVChi();
        }
        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            rdoThu.Checked = true;
        }
    }
}
