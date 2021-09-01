using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class XuLy
    {
        public string Encrypt(string pValue, string pKey)
        {
            if(string.IsNullOrEmpty(pValue))
                return "";
            //Chuyển text vào thành byte
            byte[] byteIn = Encoding.UTF8.GetBytes(pValue);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            //Chuyển key thành byte
            byte[] bytesKey = Encoding.UTF8.GetBytes(pKey);
            //Không hiểu lắm nhưng tự dưng đổi độ dài của byteskey 2 lần
            Array.Resize(ref bytesKey, des.Key.Length);
            Array.Resize(ref bytesKey, des.IV.Length);

            des.Key = bytesKey;
            des.IV = bytesKey;
            

            MemoryStream msOut = new MemoryStream();
            ICryptoTransform desdecrypt = des.CreateEncryptor();

            CryptoStream cryptoStream = new CryptoStream(msOut, desdecrypt, CryptoStreamMode.Write);

            cryptoStream.Write(byteIn, 0, byteIn.Length);
            cryptoStream.FlushFinalBlock();
            byte[] byteOut = msOut.ToArray();
            cryptoStream.Close();

            msOut.Close();
            return Convert.ToBase64String(byteOut);
        }
        public int CheckConfig()
        {
            if (Properties.Settings.Default.QL_SHOPTHOITRANGConnectionString == string.Empty)
                return 1;
            SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.QL_SHOPTHOITRANGConnectionString);
            try
            {
                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                return 0;
            }
            catch (SqlException ex)
            {
                var sth = ex.Message;
                return 2;
            }
        }
        public void SaveConfig(string pServerName, string pUserName, string pPassword, string pDatabaseName)
        {
            Properties.Settings.Default.QL_SHOPTHOITRANGConnectionString = "Data Source=" + pServerName + ";Initial Catalog=" + pDatabaseName + ";User ID=" + pUserName + ";Password=" + pPassword + ""; ;
            Properties.Settings.Default.Save();
            CheckConfig();
        }
    }
    
    public enum KetQuaThemNhanVien
    {
        ///<summary>
        /// Thêm người dùng thất bại và thêm nhân viên vào nhóm thất bại
        /// </summary>
        ThatBai,
        ///<summary>
        /// Thêm người dùng thành công và thêm người dùng vào nhóm thành công
        /// </summary>
        ThanhCongAll,
        ///<summary>
        /// Thêm người dùng thành công nhưng thêm người dùng vào nhóm thất bại
        /// </summary>
        ThanhCong1
    }

}
