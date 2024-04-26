using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopBUS
    {
        public static List<Lop> selectAll()
        {
            return LopDAO.selectAll();
        }
        public static Lop selectByID(string maLop)
        {
            return LopDAO.selectByID(maLop);
        }
        public static List<Lop> selectByTenLop(string tenLop)
        {
            return LopDAO.selectByTenLop(tenLop);
        }
        public static bool insert(Lop l)
        {
           
            return LopDAO.insert(l);
        }
        public static bool delete(string maLop)
        {
            return LopDAO.delete(maLop);
        }
        public static bool update(string maLop, Lop lop)
        {
            return LopDAO.update(maLop,lop);
        }
    }
}
