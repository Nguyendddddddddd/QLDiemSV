using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DiemHocKyDAO
    {
        public static List<DiemHocKy> selectAll()
        {
            return QLDiemSinhVien.getInstance().DiemHocKies.ToList();
        }
        public static DiemHocKy selectByID(string maHocKy, string maSV)
        {
            var lstDiemHocKy = selectAll();

            var diemhk = (from d in lstDiemHocKy
                          where d.MaHocKy.Trim() == maHocKy.Trim() && d.MSSV.Trim() == maSV.Trim()
                          select d
                          ).FirstOrDefault();
            return diemhk;
        }

        public static List<DiemHocKy> selectByMSSV(string mssv)
        {
            var lstDiemHocKy = selectAll();

            var diemhk = (from d in lstDiemHocKy
                          where d.SinhVien.MSSV.Trim() == mssv.Trim()
                          select d
                          ).ToList();
            return diemhk;
        }

        public static bool insert(DiemHocKy dhk)
        {
            try
            {
                QLDiemSinhVien.getInstance().DiemHocKies.Add(dhk);
                QLDiemSinhVien.getInstance().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static bool update(string maHocKy, string maSV, double diem)
        {
            try
            {
                DiemHocKy dhk = selectByID(maHocKy, maSV);
                dhk.Diem = diem;
                QLDiemSinhVien.getInstance().SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }


    }
}
