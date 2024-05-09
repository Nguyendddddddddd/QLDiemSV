using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopDAO
    {
        public static List<Lop> selectAll()
        {
            return QLDiemSinhVien.getInstance().Lops.ToList();
        }
        public static Lop selectByID(string maLop)
        {
            var lstLop = QLDiemSinhVien.getInstance().Lops.ToList();
            var lop = (from l in lstLop
                        where l.MaLop.Trim() == maLop.Trim()
                        select l
                      ).FirstOrDefault();
            return lop;
        }
        public static List<Lop> selectByTenLop(string tenLop)
        {
            var lstLop = QLDiemSinhVien.getInstance().Lops.ToList();
            var lop = (from l in lstLop
                        where l.TenLop.ToLower().Trim().Contains(tenLop.ToLower().Trim()) == true
                        select l
                      ).ToList();
            return lop;
        }
        public static bool insert(Lop l)
        {
            try
            {
                QLDiemSinhVien.getInstance().Lops.Add(l);
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delete(string maLop)
        {
            try
            {
                QLDiemSinhVien.getInstance().Lops.Remove(selectByID(maLop));
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                HuyThayDoiDAO.huythaydoi();
                return false;
            }
            return true;
        }
        public static bool update(string maLop, Lop lop)
        {
            try
            {
                var l = selectByID(maLop);
                if (l != null)
                {
                    l.MaNganh = lop.MaNganh;
                    l.MaGV = lop.MaGV;
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
