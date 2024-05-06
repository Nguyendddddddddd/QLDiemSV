using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemThanhPhanBUS
    {
        public static List<DiemThanhPhan> selectByMaLop(string maLop)
        {
            return DiemThanhPhanDAO.selectByMaLop(maLop);
        }
        public static bool delete(Guid madiem)
        {
            return DiemThanhPhanDAO.delete(madiem);
        }
        public static DiemThanhPhan selectByID(Guid maDiem)
        {
          
            return DiemThanhPhanDAO.selectByID(maDiem);
        }
    }
}
