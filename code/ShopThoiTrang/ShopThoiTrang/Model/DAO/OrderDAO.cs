using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class OrderDAO
    {
        QL_SHOPTHOITRANGEntities db;
        public OrderDAO()
        {
            db = new QL_SHOPTHOITRANGEntities();
        }
        public string Insert(DATHANG order)
        {
            int mdh = LaySoDatHang();
            if (mdh < 10)
                order.MADATHANG = "DH00" + mdh;
            else if(mdh < 100)
                order.MADATHANG = "DH0" + mdh;
            else
                order.MADATHANG = "DH" + mdh;

            db.DATHANGs.Add(order);
            db.SaveChanges();
            return order.MADATHANG;
        }

        public int LaySoDatHang()
        {
            if (db.DATHANGs.Count() == 0)
                return 0;
            DATHANG datve = db.DATHANGs.OrderByDescending(d => d.MADATHANG).First();
            if (db.GIOHANGs.Count() - int.Parse(datve.MADATHANG.Remove(0, 2)) == 1)
            {
                return db.DATHANGs.Count();
            }
            int LaySo = 0;
            int x;
            foreach (DATHANG dv in db.DATHANGs.ToList())
            {
                x = int.Parse(dv.MADATHANG.Remove(0, 2));
                if (LaySo < x)
                    return LaySo;
                else
                    LaySo++;
            }
            return LaySo;
        }
    }
}
