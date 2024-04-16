using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class SinhVienBUS
    {
        public static List<SinhVien> selectAll()
        {
            return SinhVienDAO.selectAll();
        }
        public static SinhVien selectByID(string mssv)
        {
            
            return SinhVienDAO.selectByID(mssv);
        }
        public static bool insert(SinhVien sv)
        {
            
            return SinhVienDAO.insert(sv);
        }

        public static bool delete(string mssv)
        {
           return SinhVienDAO.delete(mssv);
        }
        public static bool update(string mssv, SinhVien sv)
        {
           
            return SinhVienDAO.update(mssv,sv);
        }

    }
}
