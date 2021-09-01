using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.EF;

namespace ShopThoiTrang.Models
{
    public class Giohang
    {
        public SANPHAM SanPham { get; set; }
        public NGUOIDUNG NguoiDung { get; set; }
        public int SoLuong { get; set; }
        public bool ThanhToan { get; set; }
    }
}