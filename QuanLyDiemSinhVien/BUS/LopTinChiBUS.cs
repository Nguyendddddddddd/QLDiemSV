using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopTinChiBUS
    {
        public static List<LopTinChi> selectAll()
        {
            return LopTinChiDAO.selectAll();
        }
        public static LopTinChi selectByID(string maLop)
        {
            return LopTinChiDAO.selectByID(maLop);
        }
        public static bool insert(LopTinChi ltc)
        {
            return LopTinChiDAO.insert(ltc);
        }
        public static bool delete(string maLopTC)
        {
            return LopTinChiDAO.delete(maLopTC);
        }
        public static bool update(string maLop, LopTinChi lopTC)
        {
            return LopTinChiDAO.update(maLop, lopTC);
        }
        public static bool themSinhVienVaoLop(string maLop, SinhVien sv)
        {
           
            return LopTinChiDAO.themSinhVienVaoLop(maLop,sv);
        }
        public static bool xoaSinhVienVaoLop(string maLop, SinhVien sv)
        { 
            return LopTinChiDAO.xoaSinhVienVaoLop(maLop,sv);
        }
        public static bool themDiemThanhPhan(string maLop, DiemThanhPhan dtp)
        {
            return LopTinChiDAO.themDiemThanhPhan(maLop,dtp);
        }

    }
}
