using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
       
            public static DataTable queryGetData(string strquery, SqlConnection connection)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strquery, connection);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                return tb;
            }
            public static bool queryNonGetData(string strquery, SqlConnection connection)
            {
                try
                {
                    SqlCommand cm = new SqlCommand(strquery, connection);
                    cm.ExecuteNonQuery();
                    return true;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        
    }
}
