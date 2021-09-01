using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BanHang
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();

        public string TaoHoaDon()
        {
            DONHANG donhang = new DONHANG();
            int sodonhang = LaySoDonHang();
            if(sodonhang < 10)
                donhang.MADONHANG = "DH00" + sodonhang;
            else if(sodonhang < 100)
                donhang.MADONHANG = "DH0" + sodonhang;
            else
                donhang.MADONHANG = "DH" + sodonhang;
            donhang.TONGGIATRI = 0;
            try
            {
                QLShopThoiTrang.DONHANGs.InsertOnSubmit(donhang);
                QLShopThoiTrang.SubmitChanges();
                return donhang.MADONHANG;
            }
            catch
            {
                return "";
            }
        }
        public decimal LayDonGiaTheoSP(string pMaSP)
        {
            SANPHAM sp = QLShopThoiTrang.SANPHAMs.SingleOrDefault(s => s.MASANPHAM == pMaSP);
            if (sp == null)
                return -1;
            return decimal.Round(sp.GIATRI.Value);
        }
        public decimal LayKhuyenMaiTheoSP(string pMaSP)
        {
            SANPHAM sp = QLShopThoiTrang.SANPHAMs.SingleOrDefault(s => s.MASANPHAM == pMaSP);
            if (sp == null)
                return -1;
            return decimal.Round(sp.KHUYENMAI.Value);
        }
        public bool KiemTraChiTietDonHangTonTai(string pMaDonHang, string pMaSanPham)
        {
            if (QLShopThoiTrang.CHITIETDONHANGs.SingleOrDefault(ct => ct.MADONHANG == pMaDonHang && ct.MASANPHAM == pMaSanPham) != null)
                return true;
            return false;
        }
        public bool CapNhatTangSoLuongSanPhamTrongGio(string pMaDonHang, string pMaSanPham, int pSoLuong)
        {
            foreach(CHITIETDONHANG ct in QLShopThoiTrang.CHITIETDONHANGs.ToList())
            {
                if(ct.MADONHANG == pMaDonHang && ct.MASANPHAM == pMaSanPham)
                {
                    ct.SOLUONG += pSoLuong;
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
            return false;
        }
        public bool ThemChiTietDonHang(string pMaDonHang, string pMaSanPham, int pSoLuong, decimal pDonGia)
        {
            CHITIETDONHANG chitietdonhang = new CHITIETDONHANG();
            chitietdonhang.MADONHANG = pMaDonHang;
            chitietdonhang.MASANPHAM = pMaSanPham;
            chitietdonhang.SOLUONG = pSoLuong;
            chitietdonhang.DONGIA = pDonGia;
            try
            {
                QLShopThoiTrang.CHITIETDONHANGs.InsertOnSubmit(chitietdonhang);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }      
        public bool SuaChiTietDonHang(string pMaDonHang, string pMaSanPham, int pSoLuong, decimal pDonGia)
        {
            foreach (CHITIETDONHANG ct in QLShopThoiTrang.CHITIETDONHANGs.ToList())
            {
                if (ct.MADONHANG == pMaDonHang && ct.MASANPHAM == pMaSanPham)
                {
                    ct.DONGIA = pDonGia;
                    ct.SOLUONG = pSoLuong;
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
            return false;
        }
        public List<TempChiTietDonHang> LayDSChiTietDonHangTheoMaDonHang(string pMaDonHang)
        {
            var result = (from ctdh in QLShopThoiTrang.CHITIETDONHANGs
                          join sp in QLShopThoiTrang.SANPHAMs on ctdh.MASANPHAM equals sp.MASANPHAM
                          where ctdh.MADONHANG == pMaDonHang
                          select new TempChiTietDonHang
                          {
                             Madonhang = ctdh.MADONHANG,
                             Masp = ctdh.MASANPHAM,
                             Tensp = sp.TENSANPHAM,
                             Soluong = ctdh.SOLUONG.Value,
                             Dongia = ctdh.DONGIA.Value,
                             Hinhanh = sp.HINHANH
                         });
            return result.ToList();
        }
        private int LaySoDonHang()
        {
            if (QLShopThoiTrang.DONHANGs.Count() == 0)
                return 0;
            DONHANG lastmovie = QLShopThoiTrang.DONHANGs.OrderByDescending(d => d.MADONHANG).First();

            //Kiểm tra xem mã phim có hụt không

            if (QLShopThoiTrang.DONHANGs.Count() - int.Parse(lastmovie.MADONHANG.Remove(0, 2)) == 1)
            {
                return QLShopThoiTrang.DONHANGs.Count();
            }


            int LaySo = 0;
            int x;
            foreach (DONHANG p in QLShopThoiTrang.DONHANGs.ToList())
            {
                x = int.Parse(p.MADONHANG.Remove(0, 2));
                if (LaySo < x)
                    return LaySo;
                else
                    LaySo++;
            }
            return LaySo;
        }
        public int LaySoLuongHangCoThe(string pMaSanPham)
        {
            SANPHAM sp = QLShopThoiTrang.SANPHAMs.SingleOrDefault(x => x.MASANPHAM == pMaSanPham);
            if (sp != null)
                return (int)sp.SOLUONGTON.Value;
            return -1;
        }
        public int LaySoLuongHangTrongChiTiet(string pMaHoaDon, string pMaSanPham)
        {
            int slHang = 0;
            foreach(CHITIETDONHANG ct in QLShopThoiTrang.CHITIETDONHANGs.Where(x => x.MADONHANG == pMaHoaDon).ToList())
            {
                slHang += ct.SOLUONG.Value;
            }
            return slHang;
        }

        public class TempChiTietDonHang
        {
            string _madonhang;
            string _masp;
            string _tensp;
            int _soluong;
            decimal _dongia;
            string _hinhanh;

            public string Madonhang { get => _madonhang; set => _madonhang = value; }
            public string Masp { get => _masp; set => _masp = value; }
            public string Tensp { get => _tensp; set => _tensp = value; }
            public int Soluong { get => _soluong; set => _soluong = value; }
            public decimal Dongia { get => _dongia; set => _dongia = value; }
            public string Hinhanh { get => _hinhanh; set => _hinhanh = value; }
            
        }
        public bool XoaChiTiet(string pMaDonHang, string pMaSanPham)
        {
            CHITIETDONHANG ctdh = QLShopThoiTrang.CHITIETDONHANGs.SingleOrDefault(ct => ct.MADONHANG == pMaDonHang && ct.MASANPHAM == pMaSanPham);
            if (ctdh != null)
            {
                QLShopThoiTrang.CHITIETDONHANGs.DeleteOnSubmit(ctdh);
                return true;
            }
            return false;
        }
        public bool ThanhToan(string pMaHoaDon, string pTenDN, double pTongGiaTri)
        {
            foreach(DONHANG dh in QLShopThoiTrang.DONHANGs.ToList())
            {
                if(dh.MADONHANG == pMaHoaDon)
                {
                    foreach(CHITIETDONHANG ct in QLShopThoiTrang.CHITIETDONHANGs.Where(x=>x.MADONHANG == dh.MADONHANG).ToList())
                    {
                        foreach(SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
                        {
                            if(sp.MASANPHAM == ct.MASANPHAM)
                            {
                                sp.SOLUONGTON -= ct.SOLUONG;
                            }
                        }
                    }
                    dh.TONGGIATRI = (decimal)pTongGiaTri;
                    dh.THANHTOAN = true;
                    dh.NGAYLAP = DateTime.Today;
                    dh.TENDN = pTenDN;
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
            return false;
        }

        public bool HuyDon(string pMaHoaDon)
        {
            XoaChiTietDon(pMaHoaDon);
            foreach(DONHANG dh in QLShopThoiTrang.DONHANGs.ToList())
            {
                if(dh.MADONHANG == pMaHoaDon)
                {
                    try
                    {
                        QLShopThoiTrang.DONHANGs.DeleteOnSubmit(dh);
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
        public void XoaChiTietDon(string pMaHoaDon)
        {
            foreach(CHITIETDONHANG ct in QLShopThoiTrang.CHITIETDONHANGs.ToList())
            {
                if(ct.MADONHANG == pMaHoaDon)
                {
                    QLShopThoiTrang.CHITIETDONHANGs.DeleteOnSubmit(ct);
                }
            }
        }


        //Common
        public List<NGUOIDUNG> LayDSNguoiDung()
        {
            var lstKhachHang = from kh in QLShopThoiTrang.NGUOIDUNGs
                               join ndnnd in QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs on kh.TENDN equals ndnnd.TENDN
                               where ndnnd.MANHOMNGUOIDUNG == "KH"
                               select kh;
            return lstKhachHang.ToList();
        }
        public List<SANPHAM> LayDSSanPham()
        {
            return QLShopThoiTrang.SANPHAMs.ToList();
        }
        public bool LuuVaoDB()
        {
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
