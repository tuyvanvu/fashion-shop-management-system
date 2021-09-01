using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace BLL_DAL
{
   
    public class XuatExcel
    {
        const string FILE_EXT_DOC = ".doc";
        const string FILE_EXT_DOCS = ".docx";
        const string FILE_EXT_XLS = ".xls";
        const string FILE_EXT_XLSs = ".xlsx";
        const string T_DONHANG = "DonHang";
        const string T_NHAPHANG = "NhapHang";
        const string TMP_ROW = "[TMP]";
        const string FOLDER_TEMPLATES = "Templates";
        string appPath = string.Empty;



        public class TempDonHang
        {
            string sTT;
            string maDonHang;
            double tongGiaTri;
            string tKKhachHang;
            string ngayLap;

            public string MaDonHang { get => maDonHang; set => maDonHang = value; }
            public double TongGiaTri { get => tongGiaTri; set => tongGiaTri = value; }
            public string TKKhachHang { get => tKKhachHang; set => tKKhachHang = value; }
            public string NgayLap { get => ngayLap; set => ngayLap = value; }
            public string STT { get => sTT; set => sTT = value; }
        }
        public List<TempDonHang> GetListTempDonHang(List<DONHANG> lstDonHang)
        {
            List<TempDonHang> lstTempDonHang = new List<TempDonHang>();
            int i = 1;
            foreach(DONHANG dh in lstDonHang)
            {
                TempDonHang tdh = new TempDonHang();
                tdh.MaDonHang = dh.MADONHANG;
                tdh.TongGiaTri = (double)dh.TONGGIATRI.Value;
                tdh.TKKhachHang = dh.TENDN;
                tdh.NgayLap = dh.NGAYLAP.ToString();
                lstTempDonHang.Add(tdh);
            }
            return lstTempDonHang;
        }
        public bool ExportDonHang(List<TempDonHang> dataSource, ref string fileName, bool isPrintPreview)
        {
            // Check if data is null
            if (dataSource == null || (dataSource != null && dataSource.Count == 0))
            {
                return false;
            }
            Dictionary<string, string> replacer = new Dictionary<string, string>();
            // Set the So thu tu

            for (int i = 1; i <= dataSource.Count; i++)
            {
                dataSource[i - 1].STT = i.ToString();
            }
            string TongTien = dataSource.Sum(t => t.TongGiaTri).ToString();
            
            replacer.Add("%TongGiaTri", TongTien);


            return OutSimpleReport(dataSource, replacer, T_DONHANG, isPrintPreview, ref fileName);
        }
        public bool ExportNhapHang(List<TEMPNHAPHANG> dataSource, ref string fileName, bool isPrintPreview)
        {
            // Check if data is null
            if (dataSource == null || (dataSource != null && dataSource.Count == 0))
            {
                return false;
            }
            Dictionary<string, string> replacer = new Dictionary<string, string>();
            // Set the So thu tu

            for (int i = 1; i <= dataSource.Count; i++)
            {
                dataSource[i - 1].STT = i.ToString();
            }
            string TongTien = dataSource.Sum(t => t.TongChiPhi).ToString();

            replacer.Add("%TongGiaTri", TongTien);
            return OutSimpleReport(dataSource, replacer, T_NHAPHANG, isPrintPreview, ref fileName);
        }

        //public List<TEMPNHAPHANG> GetListTempNhapHang(List<TEMPNHAPHANG> lstDonHang)
        //{
        //    List<TEMPNHAPHANG> lstTempDonHang = new List<TEMPNHAPHANG>();
        //    int i = 1;
        //    foreach (NHAPHANG dh in lstDonHang)
        //    {
        //        TempDonHang tdh = new TempDonHang();
        //        tdh.MaDonHang = dh.MADONHANG;
        //        tdh.TongGiaTri = (double)dh.TONGGIATRI.Value;
        //        tdh.TKKhachHang = dh.TENDN;
        //        tdh.NgayLap = dh.NGAYLAP.ToString();
        //        lstTempDonHang.Add(tdh);
        //    }
        //    return lstTempDonHang;
        //}

        private bool OutSimpleReport<T>(List<T> dataSource, Dictionary<string, string> replaceValues, string viewName, bool isPrintPreview, ref string fileName)
        {
            string file = string.Empty;
            bool result = false;

            // Get template stream
            MemoryStream stream = GetTemplateStream(viewName);

            // Check if data is null
            if (stream == null)
            {
                return false;
            }

            // Create excel engine
            ExcelEngine engine = new ExcelEngine();
            IWorkbook workBook = engine.Excel.Workbooks.Open(stream);

            IWorksheet workSheet = workBook.Worksheets[0];
            ITemplateMarkersProcessor markProcessor = workSheet.CreateTemplateMarkersProcessor();

            // Replace value
            if (replaceValues != null && replaceValues.Count > 0)
            {
                // Find and replace values
                foreach (KeyValuePair<string, string> replacer in replaceValues)
                {
                    Replace(workSheet, replacer.Key, replacer.Value);
                }
            }

            // Fill variables
            markProcessor.AddVariable(viewName, dataSource);



            // End template
            markProcessor.ApplyMarkers(UnknownVariableAction.ReplaceBlank);

            // Delete temporary row
            IRange range = workSheet.FindFirst(TMP_ROW, ExcelFindType.Text);

            // Delete
            if (range != null)
            {
                workSheet.DeleteRow(range.Row);
            }

            file = Path.GetTempFileName() + FILE_EXT_XLS;

            fileName = file;

            // Output file
            if (!IsFileOpenOrReadOnly(file))
            {
                workBook.SaveAs(file);
                result = true;
            }

            // Close
            workBook.Close();
            engine.Dispose();

            // Print preview
            if (result && isPrintPreview)
            {
                PrintExcel(file);
                File.Delete(file);
            }

            return result;
        }
        private static void Replace(IWorksheet workSheet, string findValue, string replaceValue)
        {
            // Find and replace
            if (workSheet != null && !string.IsNullOrEmpty(findValue))
            {
                // Get current cells
                IRange[] cells = workSheet.Range.Cells;
                IRange range = null;

                // Loop cells to replace
                for (int i = 0; i < cells.Count(); i++)
                {
                    // Current cell
                    range = cells[i];

                    // Find and replace values
                    if (range != null && range.DisplayText.Contains(findValue))
                    {
                        range.Text = range.Text.Replace(findValue, replaceValue);
                        break;
                    }
                }
            }
        }
        public string AppPath
        {
            get
            {
                if (string.IsNullOrEmpty(appPath))
                {
                    appPath = AppDomain.CurrentDomain.BaseDirectory;
                }
                return appPath;
            }
        }
        private MemoryStream GetTemplateStream(string viewName)
        {
            MemoryStream stream = null;
            byte[] arrByte = new byte[0];

            //Create Temp Folder if it does not exist
            if (!Directory.Exists(AppPath + FOLDER_TEMPLATES))
            {
                Directory.CreateDirectory(AppPath + FOLDER_TEMPLATES);
            }

            // Get template by view name
            switch (viewName)
            {
                #region ---- Lấy file report----
                case T_DONHANG:
                    arrByte = File.ReadAllBytes("ThongKeDoanhThu.xlsx");
                    break;
                case T_NHAPHANG:
                    arrByte = File.ReadAllBytes("ThongKeChiPhi.xlsx");
                    break;
                #endregion
            }
            // Get stream
            if (arrByte.Count() > 0)
            {
                stream = new MemoryStream(arrByte);
            }

            return stream;
        }
        public static bool IsFileOpenOrReadOnly(string fileName)
        {
            try
            {
                // Check if file is not existed
                if (!File.Exists(fileName))
                {
                    return false;
                }

                // First make sure it's not a read only file
                if ((File.GetAttributes(fileName) & FileAttributes.ReadOnly) != FileAttributes.ReadOnly)
                {
                    // First we open the file with a FileStream
                    using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                    {
                        try
                        {
                            stream.ReadByte();
                            return false;
                        }
                        catch (IOException)
                        {
                            return true;
                        }
                        finally
                        {
                            stream.Close();
                            stream.Dispose();
                        }
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (IOException)
            {
                return true;
            }
        }
        public static void PrintExcel(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = null;

            try
            {
                wb = excelApp.Workbooks.Open(fileName);

                if (wb != null)
                {
                    // Show print preview
                    excelApp.Visible = true;
                    wb.PrintPreview(true);
                }
            }
            catch (Exception ex)
            {
                //ShowMessage
            }
            finally
            {
                // Cleanup:
                GC.Collect();
                GC.WaitForPendingFinalizers();

                wb.Close(false, Type.Missing, Type.Missing);
                Marshal.FinalReleaseComObject(wb);

                excelApp.Quit();
                Marshal.FinalReleaseComObject(excelApp);
            }
        }
    }
}
