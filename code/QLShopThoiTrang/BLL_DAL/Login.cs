using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Login
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public NGUOIDUNG LoginCheck(string pTaiKhoan, string pMatKhau)
        {
            return QLShopThoiTrang.NGUOIDUNGs.SingleOrDefault(nd => nd.TENDN == pTaiKhoan && nd.MATKHAU == pMatKhau);
        }
        public bool isAdmin(NGUOIDUNG nd)
        {
            return !(QLShopThoiTrang.NGUOIDUNG_NHOMNGUOIDUNGs.SingleOrDefault(x => x.TENDN == nd.TENDN && x.MANHOMNGUOIDUNG == "QL") == null);

        }
    }
}
