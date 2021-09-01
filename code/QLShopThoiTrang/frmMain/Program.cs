using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    static class Program
    {
        public static frmMain frm_Main;
        public static frmLogin frm_Login;
        public static frmRegister frm_Register;
        public static frmBanHang frm_BanHang;
        public static frmKetNoiDatabase frm_KetNoiDatabase;
        public static frmQuanLyNhanVien frm_QuanLyNhanVien;
        public static frmQuanLyDonHang frm_QuanLyDonHang;
        public static frmQuanLyHangHoa frm_QuanLyHangHoa;
        public static frmQuanLyNhapHang frm_QuanLyNhapHang;
        public static frmThem1NhapHang frm_Them1NhapHang;
        public static frmThanhToanNhapHang frm_ThanhToan1NhapHang;
        public static frmThemLoaiSanPham frm_ThemLoaiSanPham;
        public static frm_ThemChatLieu frm_ThemChatLieu;
        public static frmThemNSX frm_ThemNhaSanXuat;
        public static frmThemNCC frm_ThemNCC;
        public static frmThem1HangHoa frm_Them1HangHoa;
        public static frmDuDoan frm_DuDoan;
        public static frmThongKeDoanhThu frm_ThongKeDoanhThu;
        public static frmQLDonDatHang frm_QlDDH;

        public static bool Quyen;
        public static Form frm_Previous;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_Main = new frmMain();
            frm_Login = new frmLogin();
            Application.Run(frm_Login);
        }
    }
}
