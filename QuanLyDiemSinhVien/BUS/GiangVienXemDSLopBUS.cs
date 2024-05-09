using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVienXemDSLopBUS
    {
        public static List<HocKy> selectAll()
        {
            return GiangVienXemDSLopDAO.SelectAll();
        }

        public static List<LopTinChi> selectDanhSach(GiangVien giangVien)
        {
            return GiangVienXemDSLopDAO.selectDanhSach(giangVien);
        }

        public static List<LopTinChi> selectDanhSachTheoKy(string maKy, GiangVien giangVien)
        {
            return GiangVienXemDSLopDAO.selectDanhSachTheoKy(maKy, giangVien);
        }

        public static List<SinhVien> selectDSSVTrongLop(string maLop)
        {
            return GiangVienXemDSLopDAO.selectDSSVTrongLop(maLop);
        }
    }
}
