using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVienBUS
    {
        public static List<GiangVien> selectAll()
        {
            return GiangVienDAO.selectAll();
        }
        public static GiangVien selectByID(string maGV)
        {
            return GiangVienDAO.selectByID(maGV);
        }
        public static List<GiangVien> selectByMaKhoa(string maKhoa)
        {
           
            return GiangVienDAO.selectByMaKhoa(maKhoa);
        }
        public static List<GiangVien> selectByTenGV(string tenGV)
        {
            return GiangVienDAO.selectByTenGV(tenGV);
        }
        public static bool insert(GiangVien gv)
        {
            return GiangVienDAO.insert(gv);
        }
        public static bool delete(string maGV)
        {
            return GiangVienDAO.delete(maGV);
        }

        public static bool update(string maGV, GiangVien giangVien)
        {
            return GiangVienDAO.update(maGV,giangVien);
        }
    }
}
