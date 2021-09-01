using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyCacLoai
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();






        //loai san pham
        public List<LOAISANPHAM> LayDSLoaiSanPham()
        {
            return QLShopThoiTrang.LOAISANPHAMs.ToList();
        }
        public bool KiemTraMaLoaiSanPhamTonTai(string pMaLoaiSP)
        {
            LOAISANPHAM lsp = QLShopThoiTrang.LOAISANPHAMs.SingleOrDefault(x => x.MALOAISP == pMaLoaiSP);
            return lsp == null;
        }
        public bool ThemLoaiSanPham(string pMaLoaiSP, string pTenLoaiSP)
        {
            LOAISANPHAM lsp = new LOAISANPHAM();
            lsp.MALOAISP = pMaLoaiSP;
            lsp.TENLOAISP = pTenLoaiSP;
            try
            {
                QLShopThoiTrang.LOAISANPHAMs.InsertOnSubmit(lsp);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaLoaiSanPham(string pMaLoaiSanPham)
        {
            LOAISANPHAM lsp = QLShopThoiTrang.LOAISANPHAMs.SingleOrDefault(x => x.MALOAISP ==pMaLoaiSanPham);
            if(lsp != null)
            {
                foreach(SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
                {
                    if(sp.MALOAISP == lsp.MALOAISP)
                    {
                        QLShopThoiTrang.SANPHAMs.DeleteOnSubmit(sp);
                    }
                }
            }
            QLShopThoiTrang.LOAISANPHAMs.DeleteOnSubmit(lsp);
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






        //Chat lieu
        public List<CHATLIEU> LayDSChatLieu()
        {
            return QLShopThoiTrang.CHATLIEUs.ToList();
        }
        public bool KiemTraMaChatLieu(string pMaLoaiSP)
        {
            CHATLIEU lsp = QLShopThoiTrang.CHATLIEUs.SingleOrDefault(x => x.MACHATLIEU == pMaLoaiSP);
            return lsp == null;
        }
        public bool ThemChatLieu(string pMaChatLieu, string pTenChatLieu)
        {
            CHATLIEU lsp = new CHATLIEU();
            lsp.MACHATLIEU = pMaChatLieu;
            lsp.TENCHATLIEU = pTenChatLieu;
            try
            {
                QLShopThoiTrang.CHATLIEUs.InsertOnSubmit(lsp);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaChatLieu(string pMaLoaiChatLieu)
        {
            CHATLIEU lsp = QLShopThoiTrang.CHATLIEUs.SingleOrDefault(x => x.MACHATLIEU == pMaLoaiChatLieu);
            if (lsp != null)
            {
                foreach (SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
                {
                    if (sp.MACHATLIEU == lsp.MACHATLIEU)
                    {
                        QLShopThoiTrang.SANPHAMs.DeleteOnSubmit(sp);
                    }
                }
            }
            QLShopThoiTrang.CHATLIEUs.DeleteOnSubmit(lsp);
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






        //nha san xuat
        public List<NHASANXUAT> LayDSNhaSanXuat()
        {
            return QLShopThoiTrang.NHASANXUATs.ToList();
        }
        public bool KiemTraMaNhaSanXuat(string pMaNhaSanXuat)
        {
            NHASANXUAT lsp = QLShopThoiTrang.NHASANXUATs.SingleOrDefault(x => x.MANSX == pMaNhaSanXuat);
            return lsp == null;
        }
        public bool ThemNhaSanXuat(string pMaNhaSanXuat, string pTenNhaSanXuat)
        {
            NHASANXUAT lsp = new NHASANXUAT();
            lsp.MANSX = pMaNhaSanXuat;
            lsp.TENNSX = pTenNhaSanXuat;
            try
            {
                QLShopThoiTrang.NHASANXUATs.InsertOnSubmit(lsp);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaNSX(string pMaNSX)
        {
            NHASANXUAT lsp = QLShopThoiTrang.NHASANXUATs.SingleOrDefault(x => x.MANSX == pMaNSX);
            if (lsp != null)
            {
                foreach (SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
                {
                    if (sp.MANSX == lsp.MANSX)
                    {
                        QLShopThoiTrang.SANPHAMs.DeleteOnSubmit(sp);
                    }
                }
            }
            QLShopThoiTrang.NHASANXUATs.DeleteOnSubmit(lsp);
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






        //nha cung cap
        public List<NHACUNGCAP> LayDSNhaCungCap()
        {
            return QLShopThoiTrang.NHACUNGCAPs.ToList();
        }
        public bool KiemTraMaNhaCungCap(string pMaNhaCungCap)
        {
            NHACUNGCAP lsp = QLShopThoiTrang.NHACUNGCAPs.SingleOrDefault(x => x.MANCC == pMaNhaCungCap);
            return lsp == null;
        }
        public bool ThemNhaCungCap(string pMaNhaCungCap, string pTenNhaCungCap)
        {
            NHACUNGCAP lsp = new NHACUNGCAP();
            lsp.MANCC = pMaNhaCungCap;
            lsp.TENNCC = pTenNhaCungCap;
            try
            {
                QLShopThoiTrang.NHACUNGCAPs.InsertOnSubmit(lsp);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaNCC(string pMaNCC)
        {
            NHACUNGCAP lsp = QLShopThoiTrang.NHACUNGCAPs.SingleOrDefault(x => x.MANCC == pMaNCC);
            if (lsp != null)
            {
                foreach (SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
                {
                    if (sp.MANCC == lsp.MANCC)
                    {
                        QLShopThoiTrang.SANPHAMs.DeleteOnSubmit(sp);
                    }
                }
            }
            QLShopThoiTrang.NHACUNGCAPs.DeleteOnSubmit(lsp);
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
    }
}
