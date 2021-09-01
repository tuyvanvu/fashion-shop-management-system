using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class UserDAO
    {

        QL_SHOPTHOITRANGEntities db;
        public UserDAO()
        {
            db = new QL_SHOPTHOITRANGEntities();
        }
        public NGUOIDUNG GetUser(string TENDN)
        {
            return db.NGUOIDUNGs.SingleOrDefault(x => x.TENDN == TENDN);
            
        }
        public int Login(string userName, string password)
        {
            var result = db.NGUOIDUNGs.SingleOrDefault(x => x.TENDN == userName.Trim());

            if (result == null)
                return 0;
            else
            {
                if (!result.TRANGTHAI.Value)
                    return -1;
                else
                {
                    if (result.MATKHAU == password)
                        return 1;
                    return -2;
                }
            }
        }
        public int Register(string userName, string password)
        {
            var result = db.NGUOIDUNGs.SingleOrDefault(x => x.TENDN == userName.Trim());

            if (result == null)
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd.TENDN = userName;
                nd.MATKHAU = password;
                nd.TRANGTHAI = true;
                try
                {
                    db.NGUOIDUNGs.Add(nd);
                    db.SaveChanges();
                    return 0;
                }
                catch
                {
                    return -1;
                }
                
            }
            else
            {
                return -2;
            }
        }
        public bool ChangePassword(string TenDN, string newpassword)
        {
            var nd = db.NGUOIDUNGs.SingleOrDefault(x => x.TENDN == TenDN);
            if(nd != null)
            {
                nd.MATKHAU = newpassword;
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
            return false;
        }
    }
}
