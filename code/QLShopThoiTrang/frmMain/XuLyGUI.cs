using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using BLL_DAL;

namespace frmMain
{
    public class XuLyGUI
    {
        XuLy xl = new XuLy();

        public int CheckConfig()
        {
            if (Properties.Settings.Default.QLShopThoiTrangConnectionString == string.Empty)
                return 1;
            SqlConnection sqlCon = new SqlConnection(Properties.Settings.Default.QLShopThoiTrangConnectionString);
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
        public DataTable getServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable getDatabaseName(string pServerName, string pUserName, string pPassword)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
                "Data Source=" + pServerName + ";Initial catalog=master;User ID=" + pUserName + ";pwd=" + pPassword + "");
            da.Fill(dt);
            return dt;
        }
        public void SaveConfig(string pServerName, string pUserName, string pPassword, string pDatabaseName)
        {
            Properties.Settings.Default.QLShopThoiTrangConnectionString = "Data Source=" + pServerName + ";Initial Catalog=" + pDatabaseName + ";User ID=" + pUserName + ";Password=" + pPassword + ""; ;
            Properties.Settings.Default.Save();
        }

        public string Encrypt(string Text)
        {
            return xl.Encrypt(Text, "30/12/2000");
        }

    }
}
