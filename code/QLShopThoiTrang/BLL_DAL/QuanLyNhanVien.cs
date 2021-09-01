using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyNhanVien
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public List<NGUOIDUNG> LayDSNhanVien()
        {
            var lstNguoiDung = from nd in QLShopThoiTrang.NGUOIDUNGs
                               join ndnnd in QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs on nd.TENDN equals ndnnd.TENDN
                               where ndnnd.MANHOMNGUOIDUNG == "NV"
                               select nd;
            return lstNguoiDung.ToList();
        }

        /// <summary>
        /// Kiểm tra xem tên đăng nhập đã tồn tại chưa
        /// </summary>
        /// <param name="pTenDN"></param>
        /// <returns>true nếu tên đăng nhập đã tồn tại và false nếu chưa tồn tại</returns>
        public bool KiemTraTenDNDaTonTaiChua(string pTenDN)
        {
            if (QLShopThoiTrang.NGUOIDUNGs.SingleOrDefault(nd => nd.TENDN == pTenDN) == null)
                return false;
            return true;
        }
        public bool KiemTraTKCoPhaiNhanVienKhong(string pTenNV)
        {
            if (QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs.SingleOrDefault(nd => nd.TENDN == pTenNV && nd.MANHOMNGUOIDUNG == "NV") != null)
                return true;
            return false;
        }
        public int Them1NhanVien(string pTenDN, string pTenNV, string pSDT,string pEmail, string pGioiTinh, string pDiaChi, string pCMND, string pAvatar)
        {
            NGUOIDUNG nguoidung = new NGUOIDUNG();
            nguoidung.TENDN = pTenDN;
            nguoidung.TENNGUOIDUNG = pTenNV;
            nguoidung.SDT = pSDT;
            nguoidung.DIACHI = pDiaChi;
            nguoidung.CMND = pCMND;
            nguoidung.EMAIL = pEmail;
            nguoidung.GIOITINH = pGioiTinh;
            nguoidung.MATKHAU = pTenDN;
            nguoidung.AVATAR = pAvatar;
            nguoidung.TRANGTHAI = true;
            try
            {
                QLShopThoiTrang.NGUOIDUNGs.InsertOnSubmit(nguoidung);
                if(ThemNguoiDungVaoNhom(nguoidung.TENDN, "NV"))
                    return 1;
                return 0;
            }
            catch
            {
                return -1;
            }
        }
        public bool ThemNguoiDungVaoNhom(string pTenDN, string pMaNhomNguoiDung)
        {
            NGUOIDUNG_NHOMNGUOIDUNG ndnnd = new NGUOIDUNG_NHOMNGUOIDUNG();
            ndnnd.TENDN = pTenDN;
            ndnnd.MANHOMNGUOIDUNG = pMaNhomNguoiDung;
            ndnnd.GHICHU = "";
            try
            {
                QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs.InsertOnSubmit(ndnnd);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool SuaThongTinNhanVien(string pTenDN, string pTenNV, string pSDT, string pEmail, string pGioiTinh, string pDiaChi, string pCMND, string pAvatar)
        {
            NGUOIDUNG nguoidung = QLShopThoiTrang.NGUOIDUNGs.SingleOrDefault(nd => nd.TENDN == pTenDN);
            if(nguoidung != null)
            {
                nguoidung.TENNGUOIDUNG = pTenNV;
                nguoidung.SDT = pSDT;
                nguoidung.DIACHI = pDiaChi;
                nguoidung.CMND = pCMND;
                nguoidung.EMAIL = pEmail;
                nguoidung.GIOITINH = pGioiTinh;
                nguoidung.AVATAR = pAvatar;
                try
                {
                    QLShopThoiTrang.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        public bool BatTatNhanVien(string pTenDN)
        {
            NGUOIDUNG nguoidung = QLShopThoiTrang.NGUOIDUNGs.SingleOrDefault(nd => nd.TENDN == pTenDN);
            if(nguoidung != null)
            {
                if (nguoidung.TRANGTHAI == true)
                    nguoidung.TRANGTHAI = false;
                else
                    nguoidung.TRANGTHAI = false;
                try
                {
                    QLShopThoiTrang.SubmitChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                

            }
            
            return false;
        }
        public bool XoaNhanVien(string pTenDN)
        {
            foreach(NGUOIDUNG nd in QLShopThoiTrang.NGUOIDUNGs.ToList())
            {
                if(nd.TENDN == pTenDN)
                {
                    try
                    {
                        XoaNhanVienTrongNhom(pTenDN);
                        QLShopThoiTrang.NGUOIDUNGs.DeleteOnSubmit(nd);
                        QLShopThoiTrang.SubmitChanges();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                    
                }
            }
            return false;
        }
        public void XoaNhanVienTrongNhom(string pTenDN)
        {
            foreach(NGUOIDUNG_NHOMNGUOIDUNG ndnnd in QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs.ToList())
            {
                if(ndnnd.TENDN == pTenDN)
                {
                    QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs.DeleteOnSubmit(ndnnd);
                }
            }
        }
    }
}
