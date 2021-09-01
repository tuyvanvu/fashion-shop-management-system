using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class DoiMatKhau
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public bool ThucHienDoiMatKhau(string pTenDN, string pMatKhau)
        {
            foreach(NGUOIDUNG nd in QLShopThoiTrang.NGUOIDUNGs.ToList())
            {
                if(nd.TENDN == pTenDN)
                {
                    nd.MATKHAU = pMatKhau;
                }
            }
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
