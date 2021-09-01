using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyDatHang
    {
        
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public List<DATHANG> LayDSDatHang()
        {
            return QLShopThoiTrang.DATHANGs.ToList();
        }
        public List<DATHANG> LayDSDatHangTheoMucGia(string pMucGia)
        {
            if (pMucGia == "Khác")
            {
                return QLShopThoiTrang.DATHANGs.Where(dh => dh.THANHTIEN > 2000000).ToList();
            }
            if (pMucGia == "Tất cả")
                return QLShopThoiTrang.DATHANGs.ToList();


            string ch = "";
            string Gia2 = "";
            bool Truoc = true;
            foreach (char c in pMucGia.Remove(0, 5))
            {
                if (c == ' ')
                {
                    if (Truoc)
                        Truoc = false;
                    continue;
                }

                if (Truoc)
                    ch += c;
                else
                    if (char.IsDigit(c))
                    Gia2 += c;
            }
            double mucgia = double.Parse(ch);
            double mucgia2 = double.Parse(Gia2.Trim());
            return QLShopThoiTrang.DATHANGs.Where(dh => dh.THANHTIEN< (decimal)mucgia && dh.THANHTIEN> (decimal)mucgia2).ToList();
        }
        public List<MucGia> LayDSMucGia()
        {
            List<MucGia> lstMucGia = new List<MucGia>();
            MucGia mg;
            mg = new MucGia();
            mg.MaMucGia = 6 + "";
            mg.MucGiaCa = "Tất cả";
            lstMucGia.Add(mg);
            int i;
            for (i = 1; i < 5; i++)
            {
                mg = new MucGia();
                mg.MaMucGia = i + "";
                mg.MucGiaCa = "Dưới " + (500000 * i) + " Trên " + (500000 * i - 500000);
                lstMucGia.Add(mg);
            }
            mg = new MucGia();
            mg.MaMucGia = 5 + "";
            mg.MucGiaCa = "Khác";
            lstMucGia.Add(mg);
            return lstMucGia;
        }

        public bool XoaDatHang(string pMaDatHang)
        {
            foreach (DATHANG dh in QLShopThoiTrang.DATHANGs.ToList())
            {
                if (dh.MADATHANG == pMaDatHang)
                {
                    try
                    {
                        XoaChiTietDatHang(pMaDatHang);
                        QLShopThoiTrang.DATHANGs.DeleteOnSubmit(dh);
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
        public bool XoaChiTietDatHang(string pMaDatHang)
        {
            foreach (CHITIETDATHANG dh in QLShopThoiTrang.CHITIETDATHANGs.ToList())
            {
                if (dh.MADATHANG == pMaDatHang)
                {
                    try
                    {
                        QLShopThoiTrang.CHITIETDATHANGs.DeleteOnSubmit(dh);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public List<CHITIETDATHANG> LayDSChiTietDatHang()
        {
            return QLShopThoiTrang.CHITIETDATHANGs.ToList();
        }
        public List<TempChiTietDatHang> LayDSChiTietDatHang(List<string> pDSMaDatHang)
        {
            var result = (from ctdh in QLShopThoiTrang.CHITIETDATHANGs
                          join sp in QLShopThoiTrang.SANPHAMs on ctdh.MASANPHAM equals sp.MASANPHAM
                          where pDSMaDatHang.Contains(ctdh.MADATHANG)
                          select new TempChiTietDatHang
                          {
                              Madathang = ctdh.MADATHANG,
                              Masp = ctdh.MASANPHAM,
                              Tensp = sp.TENSANPHAM,
                              Soluong = ctdh.SOLUONG.Value,
                              Dongia = ctdh.DONGIA.Value,
                              Hinhanh = sp.HINHANH
                          });
            return result.ToList();
        }
        public class TempChiTietDatHang
        {
            string _madathang;
            string _masp;
            string _tensp;
            int _soluong;
            decimal _dongia;
            string _hinhanh;

            public string Madathang { get => _madathang; set => _madathang = value; }
            public string Masp { get => _masp; set => _masp = value; }
            public string Tensp { get => _tensp; set => _tensp = value; }
            public int Soluong { get => _soluong; set => _soluong = value; }
            public decimal Dongia { get => _dongia; set => _dongia = value; }
            public string Hinhanh { get => _hinhanh; set => _hinhanh = value; }
        }
    }
}
