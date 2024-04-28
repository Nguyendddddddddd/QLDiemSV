using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiangVienDAO
    {
        public static List<GiangVien> selectAll()
        {
            return QLDiemSinhVien.getInstance().GiangViens.ToList();
        }
        public static GiangVien selectByID(string maGV)
        {
            var lstGiangVien = QLDiemSinhVien.getInstance().GiangViens.ToList();
            var giangVien = (from g in lstGiangVien
                       where g.MaGV.Trim() == maGV.Trim()
                       select g
                      ).FirstOrDefault();
            return giangVien;
        }
        public static List<GiangVien> selectByTenGV(string tenGV)
        {
            var lstGV = QLDiemSinhVien.getInstance().GiangViens.ToList();
            var giangVien = (from g in lstGV
                       where g.FullName.ToLower().Trim().Contains(tenGV.ToLower().Trim()) == true
                       select g
                      ).ToList();
            return giangVien;
        }
        public static bool insert(GiangVien gv)
        {
            try
            {
                QLDiemSinhVien.getInstance().GiangViens.Add(gv);
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delete(string maGV)
        {
            try
            {
                QLDiemSinhVien.getInstance().GiangViens.Remove(selectByID(maGV));
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool update(string maGV, GiangVien giangVien)
        {
            try
            {
                var gv = selectByID(maGV);
                if (gv != null)
                {
                    gv.HoLot= giangVien.HoLot;
                    gv.Ten= giangVien.Ten;
                    gv.NgaySinh = giangVien.NgaySinh;
                    gv.GioiTinh = giangVien.GioiTinh;
                    gv.HocVi= giangVien.HocVi;
                    gv.HocHam = giangVien.HocHam;
                    gv.ChuyenMon= giangVien.ChuyenMon;
                    gv.MaKhoa= giangVien.MaKhoa;
                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
