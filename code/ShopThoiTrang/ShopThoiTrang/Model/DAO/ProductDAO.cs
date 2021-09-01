using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.DAO
{
    public class ProductDAO
    {
        QL_SHOPTHOITRANGEntities db = null;
        public ProductDAO()
        {
            db = new QL_SHOPTHOITRANGEntities();
        }
        public SANPHAM GetProduct(string ProductID)
        {
            return db.SANPHAMs.SingleOrDefault(x => x.MASANPHAM == ProductID);
        }

        public IEnumerable<SANPHAM> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<SANPHAM> model = db.SANPHAMs;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.TENSANPHAM.Contains(searchString));
            }

            return model.OrderByDescending(x => x.MASANPHAM).ToPagedList(page, pageSize);
        }

        public List<SANPHAM> ListAll()
        {
            return db.SANPHAMs.OrderBy(x => x.TENSANPHAM).ToList();
        }
        public IEnumerable<SANPHAM> ListAllPageList(int page, int pagesize)
        {
            return db.SANPHAMs.OrderByDescending(x => x.MASANPHAM).ToPagedList(page, pagesize);
        }
        public SANPHAM SanPhamDetail(string pMaSP)
        {
            return db.SANPHAMs.Find(pMaSP);
        }
        public int ProductCountCategory(string pProductCategoryID)
        {
            int sl = 0;
            sl = db.SANPHAMs.Where(x => x.MALOAISP == pProductCategoryID).Count();
            return sl;
        }

        public List<SANPHAM> ListByCategoryId(string categoryID, ref int totalRecord, int pageIndex = 1, int pageSize = 3)
        {
            totalRecord = db.SANPHAMs.Where(x => x.MALOAISP == categoryID).Count();
            var model = db.SANPHAMs.Where(x => x.MALOAISP == categoryID).OrderByDescending(x => x.MASANPHAM).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return model;
        }

        public List<SANPHAM> ListRelateProducts(string productId)
        {
            var product = db.SANPHAMs.Find(productId);
            return db.SANPHAMs.Where(x => x.MASANPHAM != productId && x.MALOAISP == product.MALOAISP).Take(3).ToList();
        }

        public SANPHAM ViewDetail(string id)
        {
            return db.SANPHAMs.Find(id);
        }
    }
}
