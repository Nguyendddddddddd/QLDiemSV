using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CSDLDAO
    {
        static SqlConnection con;
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
        
            string sql = "BACKUP DATABASE QLDiemSinhVien TO DISK = N'" + sDuongDan + "'";
            con = QLDSVConnection.getInstance();
            QLDSVConnection.open();
            bool kq = DataProvider.queryNonGetData(sql, con);
            return kq;
        }

        //D:\SaoLuu.bak\QLDiemSinhVien(9_5_2024_18_57).bak
        //

        //
        public static bool phucHoi(string sDuongDan)
        {
            sDuongDan = sDuongDan.Substring(0, sDuongDan.Length - 2);
            string stRestore = "USE master ALTER DATABASE [QLDiemSinhVien] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
            stRestore += " RESTORE DATABASE [QLDiemSinhVien] FROM DISK = N'" + sDuongDan + "'";
            stRestore += " WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 10";
            stRestore += " ALTER DATABASE [QLDiemSinhVien] SET MULTI_USER ";
          //  string sql = $"USE master RESTORE DATABASE QLDiemSinhVien FROM DISK = N'{sDuongDan}' WITH REPLACE";
            con = QLDSVConnection.getInstance();
            QLDSVConnection.open();
            bool kq = DataProvider.queryNonGetData(stRestore, con);
            QLDSVConnection.close();
            return kq;
        }
    }

}
