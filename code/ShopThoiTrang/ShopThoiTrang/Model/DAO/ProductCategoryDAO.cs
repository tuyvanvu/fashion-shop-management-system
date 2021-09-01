using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ProductCategoryDAO
    {
        QL_SHOPTHOITRANGEntities db;
        public ProductCategoryDAO()
        {
            db = new QL_SHOPTHOITRANGEntities();
        }
        public List<LOAISANPHAM> ListAll()
        {
            List<LOAISANPHAM> lstLSP = new List<LOAISANPHAM>();
            foreach(LOAISANPHAM lsp in db.LOAISANPHAMs.ToList())
            {
                if (new ProductDAO().ProductCountCategory(lsp.MALOAISP.ToString()) > 5)
                    lstLSP.Add(lsp);
            }
            return lstLSP;
        }
        public LOAISANPHAM ViewDetail(string pProductCategoryID)
        {
            return db.LOAISANPHAMs.Find(pProductCategoryID);
        }
    }
}
