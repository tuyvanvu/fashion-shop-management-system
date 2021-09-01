using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    
    public class QuanLyNhapHang
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();

        public List<TempChiTietNhapHang> LayChiTietNhapHang(string pMaNhapHang)
        {
            var lstChiTietNhapHang = (from ct in QLShopThoiTrang.CHITIETNHAPHANGs
                                      join nh in QLShopThoiTrang.NHAPHANGs on ct.MANHAPHANG equals nh.MANHAPHANG
                                      join sp in QLShopThoiTrang.SANPHAMs on ct.MASP equals sp.MASANPHAM
                                      where ct.MANHAPHANG == pMaNhapHang
                                      select new TempChiTietNhapHang
                                      {
                                          MaChiTietNhapHang = ct.MACHITIETNHAPHANG,
                                          MaNhapHang = nh.MANHAPHANG,
                                          GiaNhap = (double)ct.GIANHAP.Value,
                                          TenSanPham = sp.TENSANPHAM,
                                          HinhAnh = sp.HINHANH,
                                          MaSanPham = ct.MASP,
                                          SoLuong = ct.SOLUONG.Value

                                      }).ToList();
            return lstChiTietNhapHang;
        }
        public bool CapNhatThongTinNhapHang(string pMaNhapHang, double pTongChiPhi, DateTime pNgayNhap, string pMaNhaCungCap)
        {
            foreach(NHAPHANG nh in QLShopThoiTrang.NHAPHANGs.ToList())
            {
                if (nh.MANHAPHANG == pMaNhapHang)
                {
                    nh.TONGCHIPHI = (decimal)pTongChiPhi;
                    nh.NGAYNHAP = pNgayNhap;
                    nh.MANCC = pMaNhaCungCap;
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
        public List<SANPHAM> LayDSSanPham()
        {
            return QLShopThoiTrang.SANPHAMs.ToList();
        }
        public double getGiaTriSanPham(string pMaSanPham)
        {
            SANPHAM sp = QLShopThoiTrang.SANPHAMs.SingleOrDefault(x => x.MASANPHAM == pMaSanPham);
            if (sp != null)
                return (double)sp.GIATRI.Value;
            return -1;
        }
        public NHAPHANG LayNhapHangTheoMa(string pMaNhapHang)
        {
            NHAPHANG nh = QLShopThoiTrang.NHAPHANGs.SingleOrDefault(x => x.MANHAPHANG == pMaNhapHang);
            return nh;
        }
        public int LaySoLuongHangCoThe(string pMaSanPham)
        {
            SANPHAM sp = QLShopThoiTrang.SANPHAMs.SingleOrDefault(x => x.MASANPHAM == pMaSanPham);
            if (sp != null)
                return (int)sp.SOLUONGTON.Value;
            return -1;
        }
        public string TaoMaNhapHang()
        {
            int sonhaphang = LaySoNhapHang();
            NHAPHANG nh = new NHAPHANG();
            if (sonhaphang < 10)
                nh.MANHAPHANG = "MNH00" + sonhaphang;
            else if (sonhaphang < 100)
                nh.MANHAPHANG = "MNH0" + sonhaphang;
            else
                nh.MANHAPHANG = "MNH" + sonhaphang;
            nh.THANHTOAN = false;
            try
            {
                QLShopThoiTrang.NHAPHANGs.InsertOnSubmit(nh);
                QLShopThoiTrang.SubmitChanges();
                return nh.MANHAPHANG;
            }
            catch
            {
                return string.Empty;
            }

        }
        public bool ThanhToanNhapHang(string maNhapHang)
        {
            NHAPHANG nh = LayNhapHangTheoMa(maNhapHang);
            if(nh != null)
            {
                foreach(CHITIETNHAPHANG ct in QLShopThoiTrang.CHITIETNHAPHANGs.ToList())
                {
                    if(ct.MANHAPHANG == nh.MANHAPHANG)
                    {
                        foreach(SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
                        {
                            if(sp.MASANPHAM == ct.MASP)
                            {
                                sp.SOLUONGTON += ct.SOLUONG;
                            }
                        }
                    }
                }
            }
            try
            {
                nh.THANHTOAN = true;
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<NHACUNGCAP> LayDSNhaCungCap()
        {
            return QLShopThoiTrang.NHACUNGCAPs.ToList();
        }
        public List<NHASANXUAT> LayDSNhaSanXuat()
        {
            return QLShopThoiTrang.NHASANXUATs.ToList();
        }
        public List<TEMPNHAPHANG> LayDSNhapHang()
        {
            var lstNhapHang = (from nh in QLShopThoiTrang.NHAPHANGs
                               join ncc in QLShopThoiTrang.NHACUNGCAPs on nh.MANCC equals ncc.MANCC
                               select new TEMPNHAPHANG
                               {
                                   MaNCC = nh.MANCC,
                                   MaNhapHang = nh.MANHAPHANG,
                                   NgayNhap = nh.NGAYNHAP.Value,
                                   TenNCC = ncc.TENNCC,
                                   TongChiPhi = (double)nh.TONGCHIPHI.Value,
                                   ThanhToan = nh.THANHTOAN.Value
                              }).ToList();
            return lstNhapHang;
        }



        public bool ThemChiTietNhapHang(string pMaNhapHang, string pMaSP, int pSoLuong, double pGiaNhap)
        {
            CHITIETNHAPHANG ctnh = new CHITIETNHAPHANG();
            int SoChiTiet = LaySoChiTietNhap();
            if (SoChiTiet < 10)
                ctnh.MACHITIETNHAPHANG = "CTNH00" + SoChiTiet;
            else if (SoChiTiet < 100)
                ctnh.MACHITIETNHAPHANG = "CTNH0" + SoChiTiet;
            else
                ctnh.MACHITIETNHAPHANG = "CTNH" + SoChiTiet;
            ctnh.MANHAPHANG = pMaNhapHang;
            ctnh.MASP = pMaSP;
            ctnh.SOLUONG = pSoLuong;
            ctnh.GIANHAP = (decimal)pGiaNhap;
            try
            {
                QLShopThoiTrang.CHITIETNHAPHANGs.InsertOnSubmit(ctnh);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ThemSLSPChiTietNhapHang(string pMaCTNH, int pSL)
        {
            foreach(CHITIETNHAPHANG ct in QLShopThoiTrang.CHITIETNHAPHANGs.ToList())
            {
                if(ct.MACHITIETNHAPHANG == pMaCTNH)
                {
                    ct.SOLUONG += pSL;
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
        public bool Xoa1ChiTietNhapHang(string pMaChiTietNhapHang)
        {
            CHITIETNHAPHANG ct = QLShopThoiTrang.CHITIETNHAPHANGs.SingleOrDefault(x => x.MACHITIETNHAPHANG == pMaChiTietNhapHang);
            if(ct != null)
            {
                QLShopThoiTrang.CHITIETNHAPHANGs.DeleteOnSubmit(ct);
                QLShopThoiTrang.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool KiemTraNhapHangTonTai(string pMaNhapHang)
        {
            foreach(CHITIETNHAPHANG ct in QLShopThoiTrang.CHITIETNHAPHANGs.ToList())
            {
                if (ct.MANHAPHANG == pMaNhapHang)
                    return true;
            }
            return false;
        }
        public bool XoaNhapHang(string pMaNhapHang)
        {
            NHAPHANG nh = QLShopThoiTrang.NHAPHANGs.SingleOrDefault(x => x.MANHAPHANG == pMaNhapHang);
            if (nh == null)
                return false;
            foreach (CHITIETNHAPHANG ct in QLShopThoiTrang.CHITIETNHAPHANGs.ToList())
            {
                if(ct.MANHAPHANG == nh.MANHAPHANG)
                {
                    QLShopThoiTrang.CHITIETNHAPHANGs.DeleteOnSubmit(ct);
                }
            }
            QLShopThoiTrang.NHAPHANGs.DeleteOnSubmit(nh);

            
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
        public string KiemTraTonTaiChiTietNhapHang(string pMaNhapHang, string pMaSanPham)
        {
            CHITIETNHAPHANG ct = QLShopThoiTrang.CHITIETNHAPHANGs.SingleOrDefault(x => x.MANHAPHANG == pMaNhapHang && x.MASP == pMaSanPham);
            if (ct != null)
                return ct.MACHITIETNHAPHANG;
            return null;
        }
        int LaySoChiTietNhap()
        {
            if (QLShopThoiTrang.CHITIETNHAPHANGs.Count() == 0)
                return 0;
            CHITIETNHAPHANG lastmovie = QLShopThoiTrang.CHITIETNHAPHANGs.OrderByDescending(d => d.MACHITIETNHAPHANG).First();

            //Kiểm tra xem mã phim có hụt không

            if (QLShopThoiTrang.CHITIETNHAPHANGs.Count() - int.Parse(lastmovie.MACHITIETNHAPHANG.Remove(0, 4)) == 1)
            {
                return QLShopThoiTrang.CHITIETNHAPHANGs.Count();
            }


            int LaySo = 0;
            int x;
            foreach (CHITIETNHAPHANG p in QLShopThoiTrang.CHITIETNHAPHANGs.ToList())
            {
                x = int.Parse(p.MACHITIETNHAPHANG.Remove(0, 4));
                if (LaySo < x)
                    return LaySo;
                else
                    LaySo++;
            }
            return LaySo;
            
        }
        int LaySoNhapHang()
        {
            if (QLShopThoiTrang.NHAPHANGs.Count() == 0)
                return 0;
            NHAPHANG lastmovie = QLShopThoiTrang.NHAPHANGs.OrderByDescending(d => d.MANHAPHANG).First();

            //Kiểm tra xem mã phim có hụt không

            if (QLShopThoiTrang.NHAPHANGs.Count() - int.Parse(lastmovie.MANHAPHANG.Remove(0, 3)) == 1)
            {
                return QLShopThoiTrang.NHAPHANGs.Count();
            }


            int LaySo = 0;
            int x;
            foreach (NHAPHANG p in QLShopThoiTrang.NHAPHANGs.ToList())
            {
                x = int.Parse(p.MANHAPHANG.Remove(0, 3));
                if (LaySo < x)
                    return LaySo;
                else
                    LaySo++;
            }
            return LaySo;

        }
    }

    public class TEMPNHAPHANG
    {
        string sTT;
        string maNhapHang;
        double tongChiPhi;
        DateTime ngayNhap;
        string maNCC;
        string tenNCC;
        bool thanhToan;

        public string MaNhapHang { get => maNhapHang; set => maNhapHang = value; }
        public double TongChiPhi { get => tongChiPhi; set => tongChiPhi = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public bool ThanhToan { get => thanhToan; set => thanhToan = value; }
        public string STT { get => sTT; set => sTT = value; }
    }
    public class TempChiTietNhapHang
    {
        string maNhapHang;
        double giaNhap;
        int soLuong;
        string maSanPham;
        string maChiTietNhapHang;
        string tenSanPham;
        string hinhAnh;

        public string MaNhapHang { get => maNhapHang; set => maNhapHang = value; }
        public double GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string MaChiTietNhapHang { get => maChiTietNhapHang; set => maChiTietNhapHang = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
