using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocKyBUS
    {
        public static List<HocKy> selectAll()
        {
            return HocKyDAO.selectAll();
        }
        public static HocKy selectByID(string maHK)
        {
            return HocKyDAO.selectByID(maHK);
        }
        public static List<HocKy> selectByTenHocKy(string tenHK)
        {
            return HocKyDAO.selectByTenHocKy(tenHK);
        }
        public static bool insert(HocKy hk)
        {
            return HocKyDAO.insert(hk);
        }
        public static bool delete(string maHK)
        {
            return HocKyDAO.delete(maHK);
        }
        public static bool update(string maHK, HocKy hocKy)
        {
            return HocKyDAO.update(maHK,hocKy);
        }
    }
}
