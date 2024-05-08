using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class procBUS
    {
        public static int getTongSoTC(string mssv, string mahk)
        {
            return procDAO.getTongSoTC(mssv,mahk);
        }
        public static double getDiemKTMon(string mssv, string malop)
        {
            return procDAO.getDiemKTMon(mssv,malop);
        }
        public static double getDiemKTMonNhanSoTC(string mssv, string malop)
        {

            return procDAO.getDiemKTMonNhanSoTC(mssv, malop);
        }
    }
   
}
