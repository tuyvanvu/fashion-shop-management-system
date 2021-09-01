using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyDonHang
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public List<DONHANG> LayDSDonHang()
        {
            return QLShopThoiTrang.DONHANGs.ToList();
        }
        public List<DONHANG> LayDSDonHangTheoMucGia(string pMucGia)
        {
            if (pMucGia == "Khác")
            {
                return QLShopThoiTrang.DONHANGs.Where(dh => dh.TONGGIATRI > 2000000).ToList();
            }
            if (pMucGia == "Tất cả")
                return QLShopThoiTrang.DONHANGs.ToList();


            string ch = "";
            string Gia2 = "";
            bool Truoc = true;
            foreach(char c in pMucGia.Remove(0, 5))
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
                    if(char.IsDigit(c))
                        Gia2 += c;
            }
            double mucgia = double.Parse(ch);
            double mucgia2 = double.Parse(Gia2.Trim());
            return QLShopThoiTrang.DONHANGs.Where(dh => dh.TONGGIATRI < (decimal)mucgia && dh.TONGGIATRI > (decimal)mucgia2).ToList();
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
                mg.MucGiaCa = "Dưới " + (500000*i) + " Trên " + (500000 * i - 500000);
                lstMucGia.Add(mg);
            }
            mg = new MucGia();
            mg.MaMucGia = 5 + "";
            mg.MucGiaCa = "Khác";
            lstMucGia.Add(mg);
            return lstMucGia;
        }

        public List<DONHANG> LayDonHangTheoKhach(bool isKhachLa)
        {
            List<DONHANG> lstDonHang = new List<DONHANG>();
            if (isKhachLa)
                lstDonHang = QLShopThoiTrang.DONHANGs.Where(dh => dh.TENDN == "khach").ToList();
            else
                lstDonHang = QLShopThoiTrang.DONHANGs.Where(dh => dh.TENDN == "khach").ToList();
            return lstDonHang;
        }
        public bool XoaDonHang(string pMaDonHang)
        {
            foreach(DONHANG dh in QLShopThoiTrang.DONHANGs.ToList())
            {
                if(dh.MADONHANG == pMaDonHang)
                {
                    try
                    {
                        XoaChiTietDonHang(pMaDonHang);
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
        public bool XoaChiTietDonHang(string pMaDonHang)
        {
            foreach (CHITIETDONHANG dh in QLShopThoiTrang.CHITIETDONHANGs.ToList())
            {
                if (dh.MADONHANG == pMaDonHang)
                {
                    try
                    {
                        QLShopThoiTrang.CHITIETDONHANGs.DeleteOnSubmit(dh);
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public List<CHITIETDONHANG> LayDSChiTietDonHang()
        {
            return QLShopThoiTrang.CHITIETDONHANGs.ToList();
        }
        public List<TempChiTietDonHang> LayDSChiTietDonHang(List<string> pDSMaDonHang)
        {
            var result = (from ctdh in QLShopThoiTrang.CHITIETDONHANGs
                            join sp in QLShopThoiTrang.SANPHAMs on ctdh.MASANPHAM equals sp.MASANPHAM
                            where pDSMaDonHang.Contains(ctdh.MADONHANG)
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
    }
    public class MucGia
    {
        string _MaMucGia, _MucGia;

        public string MaMucGia { get => _MaMucGia; set => _MaMucGia = value; }
        public string MucGiaCa { get => _MucGia; set => _MucGia = value; }
    }
}
