using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SinhVienDAO
    {
        public static List<SinhVien> selectAll() 
        {
            return QLDiemSinhVien.getInstance().SinhViens.ToList();
        }
        public static SinhVien selectByID(string mssv)
        {
            var lstSinhVien = QLDiemSinhVien.getInstance().SinhViens.ToList();
            var sv = (from s in lstSinhVien
                      where s.MSSV.Trim() == mssv.Trim()
                      select s
                      ).FirstOrDefault();
            return sv;
        }
        public static bool insert(SinhVien sv)
        {
            QLDiemSinhVien.getInstance().SinhViens.Add(sv);
            int sl = QLDiemSinhVien.getInstance().SaveChanges();
            return sl>0;
        }
        public static bool delete(string mssv)
        {
            QLDiemSinhVien.getInstance().SinhViens.Remove(selectByID(mssv));
            int sl = QLDiemSinhVien.getInstance().SaveChanges();
            return sl > 0;
        }
        public static bool update(string mssv,SinhVien sv)
        {
           var sinhVien = selectByID(mssv);
            if(sinhVien != null)
            {   sinhVien.HoLot =sv.HoLot;
                sinhVien.Ten = sv.Ten;
                sinhVien.NgaySinh = sv.NgaySinh;
                sinhVien.DiaChi = sv.DiaChi;
                sinhVien.GioiTinh = sv.GioiTinh;
            }
            int sl = QLDiemSinhVien.getInstance().SaveChanges();
            return sl > 0;
        }
    }
}
