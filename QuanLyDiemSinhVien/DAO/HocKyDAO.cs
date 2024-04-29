using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HocKyDAO
    {
        public static List<HocKy> selectAll()
        {
            return QLDiemSinhVien.getInstance().HocKies.ToList();
        }
        public static HocKy selectByID(string maHK)
        {
            var lstHocKy = QLDiemSinhVien.getInstance().HocKies.ToList();
            var HK = (from hk in lstHocKy
                        where hk.MaHocKy.Trim() == maHK.Trim()
                        select hk
                      ).FirstOrDefault();
            return HK;
        }
        public static List<HocKy> selectByTenHocKy(string tenHK)
        {
            var lstHK = QLDiemSinhVien.getInstance().HocKies.ToList();
            var HocKy = (from hk in lstHK
                        where hk.TenKy.ToLower().Trim().Contains(tenHK.ToLower().Trim()) == true
                        select hk
                      ).ToList();
            return HocKy;
        }
        public static bool insert(HocKy hk)
        {
            try
            {
                QLDiemSinhVien.getInstance().HocKies.Add(hk);
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delete(string maHK)
        {
                QLDiemSinhVien.getInstance().HocKies.Remove(selectByID(maHK));
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            try
            {
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool update(string maHK, HocKy hocKy)
        {
            try
            {
                var hk = selectByID(maHK);
                if (hk != null)
                {
                    hk.MaHocKy = hocKy.MaHocKy;
                    hk.TenKy = hocKy.TenKy;
                    hk.NamHoc = hocKy.NamHoc;
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
