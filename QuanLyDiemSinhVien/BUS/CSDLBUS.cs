using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CSDLBUS
    {
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            return CSDLDAO.SaoLuuDuLieu(sDuongDan);
        }
        public static bool phucHoi(string sDuongDan)
        {
            return CSDLDAO.phucHoi(sDuongDan);
        }
    }
}
