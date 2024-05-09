using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QLDSVConnection
    {
        private const string strConnection = "Data Source=laptop-oumk55pl\\sqlexpress;Initial Catalog=QLDiemSinhVien;Integrated Security=True;";
        private static SqlConnection instance;
        private QLDSVConnection() { }

        public static SqlConnection getInstance()
        {
            if (instance == null)
            {
                instance = new SqlConnection(strConnection);
            }
            return instance;
        }
        public static void open()
        {
            if (instance.State == ConnectionState.Closed)
                instance.Open();
        }
        public static void close()
        {
            if (instance.State == ConnectionState.Open)
                instance.Close();
        }
    }
}
