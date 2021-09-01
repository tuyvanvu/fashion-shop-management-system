using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class CartDAO
    {
        QL_SHOPTHOITRANGEntities db;
        public CartDAO()
        {
            db = new QL_SHOPTHOITRANGEntities();
        }
        public List<GIOHANG> ListAllCart(string tendn)
        {
            return db.GIOHANGs.Where(x => x.TENDN == tendn).OrderBy(x => x.MAGH).ToList();
        }
        public bool AddCart(GIOHANG giohang)
        {
            int SoGioHang = LaySoGioHang();
            if (SoGioHang < 10)
                giohang.MAGH = "GH00" + SoGioHang;
            else if (SoGioHang < 100)
                giohang.MAGH = "GH0" + SoGioHang;
            else
                giohang.MAGH = "GH" + SoGioHang;
            giohang.THANHTOAN = false;
            db.GIOHANGs.Add(giohang);
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
        public bool SaveChange()
        {
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
        public bool RemoveGioHang(string magiohang)
        {
            GIOHANG gh = db.GIOHANGs.SingleOrDefault(x => x.MAGH == magiohang);
            if(gh != null)
            {
                db.GIOHANGs.Remove(gh);
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
        public int LaySoGioHang()
        {
            if (db.GIOHANGs.Count() == 0)
                return 0;
            GIOHANG datve = db.GIOHANGs.OrderByDescending(d => d.MAGH).First();
            if (db.GIOHANGs.Count() - int.Parse(datve.MAGH.Remove(0, 2)) == 1)
            {
                return db.GIOHANGs.Count();
            }
            int LaySo = 0;
            int x;
            foreach (GIOHANG dv in db.GIOHANGs.ToList())
            {
                x = int.Parse(dv.MAGH.Remove(0, 2));
                if (LaySo < x)
                    return LaySo;
                else
                    LaySo++;
            }
            return LaySo;
        }

    }
}
