using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemHocKyBUS
    {
        public static List<DiemHocKy> selectAll()
        {
            return DiemHocKyDAO.selectAll();
        }
        public static DiemHocKy selectByID(string maHocKy, string maSV)
        {
            return DiemHocKyDAO.selectByID(maHocKy,maSV);
        }
        public static bool insert(DiemHocKy dhk)
        {
                return DiemHocKyDAO.insert(dhk);
        }
        public static bool update(string maHocKy, string maSV, double diem)
        {
           
                return DiemHocKyDAO.update(maHocKy,maSV,diem);
        }
        public static List<DiemHocKy> selectByMSSV(string mssv)
        {
            return DiemHocKyDAO.selectByMSSV(mssv);
        }

    }
}
