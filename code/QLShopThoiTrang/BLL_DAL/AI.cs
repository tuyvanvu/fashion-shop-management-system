using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning;
using Accord.Math.Distances;

namespace BLL_DAL
{
    public class AI
    {
        DCQuanLyShopThoiTrangDataContext QLShopThoiTrang = new DCQuanLyShopThoiTrangDataContext();

        public double GetDiemLoaiSP(string pMaLoaiSP)
        {
            LOAISANPHAM lsp = QLShopThoiTrang.LOAISANPHAMs.SingleOrDefault(x => x.MALOAISP == pMaLoaiSP);
            if (lsp == null)
                return 0;
            else
                return (double)lsp.Diem.Value;
        }
        public double GetDiemChatLieu(string pMaChatLieu)
        {
            CHATLIEU lsp = QLShopThoiTrang.CHATLIEUs.SingleOrDefault(x => x.MACHATLIEU == pMaChatLieu);
            if (lsp == null)
                return 0;
            else return (double)lsp.Diem.Value;
        }
        public double GetDiemNhaCungCap(string pMaNCC)
        {
            NHACUNGCAP lsp = QLShopThoiTrang.NHACUNGCAPs.SingleOrDefault(x => x.MANCC == pMaNCC);
            if (lsp == null)
                return 0;
            else return (double)lsp.Diem.Value;
        }
        public double GetDiemNhaSanXuat(string pMaNSX)
        {
            NHASANXUAT lsp = QLShopThoiTrang.NHASANXUATs.SingleOrDefault(x => x.MANSX == pMaNSX);
            if (lsp == null)
                return 0;
            else return (double)lsp.Diem.Value;
        }



        public int LayTongSLSP()
        {
            //int sl = 0;
            //List<string> lstSanPham = (from sp in QLShopThoiTrang.SANPHAMs
            //                          select sp.MASANPHAM).ToList();

            //foreach(CHITIETDONHANG ct in QLShopThoiTrang.CHITIETDONHANGs.ToList())
            //{
            //    if(lstSanPham.Contains(ct.MASANPHAM))
            //    {
            //        string msp = ct.MASANPHAM;
            //        lstSanPham.Remove(msp);
            //        sl++;
            //    }
            //}
            //return sl;
            return QLShopThoiTrang.SANPHAMs.Count();
        }
        public double[][] LayDataSanPham()
        {
            double[][] data = new double[LayTongSLSP()][];
            int i = 0;
            foreach(SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
            {
                data[i++] = new double[] {

                    GetDiemChatLieu(sp.MACHATLIEU),
                    GetDiemLoaiSP(sp.MALOAISP),
                    GetDiemNhaCungCap(sp.MANCC),
                    GetDiemNhaSanXuat(sp.MANSX)

                };
            }
            return data;
        }
        public List<CHITIETDONHANG> GetChiTietDonHang(string pMaDonHang)
        {
            List<CHITIETDONHANG> lst = QLShopThoiTrang.CHITIETDONHANGs.Where(x => x.MADONHANG == pMaDonHang).ToList();
            return lst;
        }
        public NhomHang GetMaNhom(string pMaSP)
        {
            int sl = 0;
            

            foreach(DONHANG dh in QLShopThoiTrang.DONHANGs.ToList())
            {
                foreach(CHITIETDONHANG ct in GetChiTietDonHang(dh.MADONHANG))
                {
                    if (ct.MASANPHAM == pMaSP)
                        sl += ct.SOLUONG.Value;
                }
            }

            if (sl > 70)
                return NhomHang.ThanhCong;
            else if (sl > 50)
                return NhomHang.BinhThuong;
            else
                return NhomHang.Kem;
        }

        //out put, viet nham
        public int[] TaoInput()
        {
            int[] input = new int[LayTongSLSP()];
            int i = 0;
            int x = 0;
            foreach(SANPHAM sp in QLShopThoiTrang.SANPHAMs.ToList())
            {

                if (i == 0)
                {
                    x = (int)GetMaNhom(sp.MASANPHAM);
                    if (x == 0)
                        input[i++] = x;
                    else
                        input[i++] = x - x;
                    continue;
                }
                input[i++] = (int)GetMaNhom(sp.MASANPHAM) - x;
            }
            return input;
        }
        public KNearestNeighbors Hoc(double[][] data, int[] output)
        {
            KNearestNeighbors knn = new KNearestNeighbors(k: 3);
            knn.Learn(data, output);
            return knn;
        }
        public NhomHang QuyetDinh(KNearestNeighbors knn, double[] data, int x)
        {

            //Cong them x de can bang lai cai output dau tien
            int answer = knn.Decide(data) - x;
            if (answer == (int)NhomHang.ThanhCong)
                return NhomHang.ThanhCong;
            else if (answer == (int)NhomHang.BinhThuong)
                return NhomHang.BinhThuong;
            else
                return NhomHang.Kem;
        }
    }
    public enum NhomHang
    {
        Kem,
        BinhThuong,
        ThanhCong
    }
}
