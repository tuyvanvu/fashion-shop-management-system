using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyHangHoa
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();
        public List<tempSanPham> LayDSSanPham()
        {
            var sanphams = (from sp in QLShopThoiTrang.SANPHAMs
                            join lsp in QLShopThoiTrang.LOAISANPHAMs on sp.MALOAISP equals lsp.MALOAISP
                            join cl in QLShopThoiTrang.CHATLIEUs on sp.MACHATLIEU equals cl.MACHATLIEU
                            join nsx in QLShopThoiTrang.NHASANXUATs on sp.MANSX equals nsx.MANSX
                            join ncc in QLShopThoiTrang.NHACUNGCAPs on sp.MANCC equals ncc.MANCC
                            select new tempSanPham
                            {
                                Masanpham = sp.MASANPHAM,
                                Tensanpham = sp.TENSANPHAM,
                                Maloaisp = lsp.MALOAISP,
                                Tenloaisp = lsp.TENLOAISP,
                                Machatlieu = cl.MACHATLIEU,
                                Tenchatlieu = cl.TENCHATLIEU,
                                Mansx = nsx.MANSX,
                                Tennsx = nsx.TENNSX,
                                Mancc = ncc.MANCC,
                                Tenncc = ncc.TENNCC,
                                Hinhanh = sp.HINHANH,
                                Soluong = sp.SOLUONGTON.Value,
                                Giatri = (double)sp.GIATRI.Value,
                                Khuyenmai = (double)sp.KHUYENMAI.Value
                            });
            return sanphams.ToList();
        }
        public List<tempSanPham> TimKiem(string pMaLoaiSP, string pMaChatLieu, string pMaNSX, string pMaNCC, bool pCoKhyenMai)
        {
            List<tempSanPham> sanphams = LayDSSanPham();



            if (pMaLoaiSP != "")
                sanphams = sanphams.Where(sp => sp.Maloaisp == pMaLoaiSP).ToList();
            if(pMaChatLieu != "")
                sanphams = sanphams.Where(sp => sp.Machatlieu == pMaChatLieu).ToList();
            if (pMaNSX != "")
                sanphams = sanphams.Where(sp => sp.Mansx== pMaNSX).ToList();
            if (pMaNCC != "")
                sanphams = sanphams.Where(sp => sp.Mancc == pMaNCC).ToList();
            if (pCoKhyenMai)
                sanphams = sanphams.Where(sp => sp.Khuyenmai != 0).ToList();
            
            return sanphams;
        }
        public List<LOAISANPHAM> LayDSLoaiSP()
        {
            List<LOAISANPHAM> lstLoaiSP = QLShopThoiTrang.LOAISANPHAMs.ToList();
            LOAISANPHAM lsp = new LOAISANPHAM();
            lsp.MALOAISP = "";
            lsp.TENLOAISP = "";
            lstLoaiSP.Insert(0, lsp);
            return lstLoaiSP;
        }
        public List<CHATLIEU> LayDSChatLieu()
        {
            List<CHATLIEU> lstChatLieu = QLShopThoiTrang.CHATLIEUs.ToList();
            CHATLIEU cl = new CHATLIEU();
            cl.MACHATLIEU = "";
            cl.TENCHATLIEU = "";
            lstChatLieu.Insert(0, cl);
            return lstChatLieu;
        }
        public List<NHASANXUAT> LayDSNhaSX()
        {
            List<NHASANXUAT> lstNSX = QLShopThoiTrang.NHASANXUATs.ToList();
            NHASANXUAT nsx = new NHASANXUAT();
            nsx.MANSX = "";
            nsx.TENNSX = "";
            lstNSX.Insert(0, nsx);
            return lstNSX;
        }
        public List<NHACUNGCAP> LayDSNhaCC()
        {
            List<NHACUNGCAP> lstNCC = QLShopThoiTrang.NHACUNGCAPs.ToList();
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.MANCC = "";
            ncc.TENNCC = "";
            lstNCC.Insert(0, ncc);
            return lstNCC;
        }

        public bool Them1HangHoa(string pTenSP, string pMaLoaiSP, string pMaChatLieu, string pMaNSX, string pMaNCC, string pHinhAnh, int pSoLuong, double pGiaTri, double pKhuyenMai)
        {
            SANPHAM sp = new SANPHAM();
            int sosp = LaySoSanPham();
            if (sosp < 10)
                sp.MASANPHAM = "SP00" + sosp;
            else if (sosp < 100)
                sp.MASANPHAM = "SP0" + sosp;
            else
                sp.MASANPHAM = "SP" + sosp;

            sp.TENSANPHAM = pTenSP;
            sp.MALOAISP = pMaLoaiSP;
            sp.MACHATLIEU = pMaChatLieu;
            sp.MANSX = pMaNSX;
            sp.MANCC = pMaNCC;
            sp.HINHANH = pHinhAnh;
            sp.KHUYENMAI = (decimal)pKhuyenMai;
            sp.SOLUONGTON = pSoLuong;
            sp.GIATRI = (decimal)pGiaTri;

            QLShopThoiTrang.SANPHAMs.InsertOnSubmit(sp);
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
        int LaySoSanPham()
        {
            
            if (QLShopThoiTrang.SANPHAMs.Count() == 0)
                return 0;
            SANPHAM lastmovie = QLShopThoiTrang.SANPHAMs.OrderByDescending(d => d.MASANPHAM).First();

            //Kiểm tra xem mã phim có hụt không

            if (QLShopThoiTrang.SANPHAMs.Count() - int.Parse(lastmovie.MASANPHAM.Remove(0, 2)) == 1)
            {
                return QLShopThoiTrang.SANPHAMs.Count();
            }


            int LaySo = 0;
            int x;
            foreach (SANPHAM p in QLShopThoiTrang.SANPHAMs.ToList())
            {
                x = int.Parse(p.MASANPHAM.Remove(0, 2));
                if (LaySo < x)
                    return LaySo;
                else
                    LaySo++;
            }
            return LaySo;
            
        }
    }
    public class tempSanPham
    {
        string _masanpham;
        string _tensanpham;
        double _giatri;
        int _soluong;
        string _hinhanh;
        string _maloaisp;
        string _tenloaisp;
        string _machatlieu;
        string _tenchatlieu;
        string _mansx;
        string _tennsx;
        string _mancc;
        string _tenncc;
        double _khuyenmai;

        public string Masanpham { get => _masanpham; set => _masanpham = value; }
        public string Tensanpham { get => _tensanpham; set => _tensanpham = value; }
        public double Giatri { get => _giatri; set => _giatri = value; }
        public int Soluong { get => _soluong; set => _soluong = value; }
        public string Hinhanh { get => _hinhanh; set => _hinhanh = value; }
        public string Tenloaisp { get => _tenloaisp; set => _tenloaisp = value; }
        public string Tenchatlieu { get => _tenchatlieu; set => _tenchatlieu = value; }
        public string Tennsx { get => _tennsx; set => _tennsx = value; }
        public string Tenncc { get => _tenncc; set => _tenncc = value; }
        public double Khuyenmai { get => _khuyenmai; set => _khuyenmai = value; }
        public string Maloaisp { get => _maloaisp; set => _maloaisp = value; }
        public string Machatlieu { get => _machatlieu; set => _machatlieu = value; }
        public string Mansx { get => _mansx; set => _mansx = value; }
        public string Mancc { get => _mancc; set => _mancc = value; }
    }
}
