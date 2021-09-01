using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class ThongKeDoanhThu
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public List<DONHANG> LayDSDonHang()
        {
            return QLShopThoiTrang.DONHANGs.Where(x =>x.THANHTOAN.Value).ToList();
        }
        public List<DONHANG> LayDSDonHangTheoThoiGian(DateTime dtFirst, DateTime dtAfter)
        {
            dtFirst = dtFirst.AddDays(-1);
            dtAfter = dtAfter.AddDays(1);

            return QLShopThoiTrang.DONHANGs.Where(
                x => x.THANHTOAN.Value &&
                DateTime.Compare(x.NGAYLAP.Value, dtFirst) > 0 &&
                DateTime.Compare(x.NGAYLAP.Value, dtAfter) < 0
                ).ToList();
        }

        public List<TEMPNHAPHANG> LayDSNhapHang()
        {
            var lstNhapHang = (from nh in QLShopThoiTrang.NHAPHANGs
                               join ncc in QLShopThoiTrang.NHACUNGCAPs on nh.MANCC equals ncc.MANCC
                               where nh.THANHTOAN.Value
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
        public List<TEMPNHAPHANG> LayDSNhapHangTheoNgayNhap(DateTime dtFirst, DateTime dtAfter)
        {
            dtFirst = dtFirst.AddDays(-1);
            dtAfter = dtAfter.AddDays(1);
            var lstNhapHang = (from nh in QLShopThoiTrang.NHAPHANGs
                               join ncc in QLShopThoiTrang.NHACUNGCAPs on nh.MANCC equals ncc.MANCC
                               where nh.THANHTOAN.Value &&
                               DateTime.Compare(nh.NGAYNHAP.Value, dtFirst) > 0 &&
                               DateTime.Compare(nh.NGAYNHAP.Value, dtAfter) < 0
                               

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
    } 
}