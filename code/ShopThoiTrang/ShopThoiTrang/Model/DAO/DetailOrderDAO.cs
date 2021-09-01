using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class DetailOrderDAO
    {
        QL_SHOPTHOITRANGEntities db;

        public DetailOrderDAO()
        {
            db = new QL_SHOPTHOITRANGEntities();
        }
        public bool Insert(CHITIETDATHANG detail)
        {
            try
            {
                db.CHITIETDATHANGs.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
