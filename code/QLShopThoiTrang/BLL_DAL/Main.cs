using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Main
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();

        
        public List<string> GetMaNhomNguoiDung(string tenDN)
        {
            var lstMaNhomNguoiDung = (from ndnnd in QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs
                                      where ndnnd.TENDN == tenDN
                                      select ndnnd.MANHOMNGUOIDUNG).ToList();

            return lstMaNhomNguoiDung;
        }
        public bool CoQuyenHayKhong(string pMaNhomNguoiDung, string pMaManHinh)
        {
            PHANQUYEN pq = QLShopThoiTrang.PHANQUYENs.SingleOrDefault(x => x.MANHOMNGUOIDUNG == pMaNhomNguoiDung && x.MAMANHINH == pMaManHinh && x.COQUYEN.Value);
            return pq == null;

        }

        public DataTable GetMaManHinh(string pMaNhomNguoiDung)
        {
            DataTable dt = new DataTable();
            var lsPhanQuyen = from pq in QLShopThoiTrang.PHANQUYENs
                              where pq.MANHOMNGUOIDUNG == pMaNhomNguoiDung
                              select new
                              {
                                  pq.MANHOMNGUOIDUNG,
                                  pq.MAMANHINH,
                                  pq.COQUYEN
                              };

            using (var reader = ObjectReader.Create(lsPhanQuyen))
            {
                dt.Load(reader);
            }
            return dt;
        }
    }
}
