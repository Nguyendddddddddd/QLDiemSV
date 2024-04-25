using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MonHocBUS
    {
        public static List<MonHoc> selectAll()
        {
            return MonHocDAO.selectAll();
        }
        public static MonHoc selectByID(string maMonHoc)
        {
            
            return MonHocDAO.selectByID(maMonHoc);
        }
        public static List<MonHoc> selectByTenMonHoc(string tenMon)
        {
            
            return MonHocDAO.selectByTenMonHoc(tenMon);
        }
        public static bool insert(MonHoc m)
        {
          
            return MonHocDAO.insert(m);
        }
        public static bool delete(string maMonHoc)
        {
            return MonHocDAO.delete(maMonHoc);
        }
        public static bool update(string maMonHoc, MonHoc monHoc)
        {
            return MonHocDAO.update(maMonHoc,monHoc);
        }
    }
}

