using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Register
    {
        XuLy xl = new XuLy();
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public bool KiemTraThemNguoiDung(string pTaiKhoan)
        {
            if (QLShopThoiTrang.NGUOIDUNGs.SingleOrDefault(nd => nd.TENDN == pTaiKhoan) == null)
                return true;
            return false;
        }
        public bool ThemNguoiDung(string pTaiKhoan, string pMatKhau)
        {
            NGUOIDUNG nguoidung = new NGUOIDUNG();
            nguoidung.TENDN = pTaiKhoan;
            nguoidung.MATKHAU = pMatKhau;
            try
            {
                QLShopThoiTrang.NGUOIDUNGs.InsertOnSubmit(nguoidung);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemNguoiDungFull(string pTaiKhoan, string pMatKhau, string pTenNguoiDung, string pSDT, string pDiaChi, string pCMND, string pMaNhomNguoiDung)
        {
            NGUOIDUNG nguoidung = new NGUOIDUNG();
            nguoidung.TENDN = pTaiKhoan;
            nguoidung.MATKHAU = pMatKhau;
            nguoidung.TENNGUOIDUNG = pTenNguoiDung;
            nguoidung.SDT = pSDT;
            nguoidung.DIACHI = pDiaChi;
            nguoidung.CMND = pCMND;
            try
            {
                QLShopThoiTrang.NGUOIDUNGs.InsertOnSubmit(nguoidung);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
