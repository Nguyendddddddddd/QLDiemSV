using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NganhDAO
    {
        public static List<Nganh> selectAll()
        {
            return QLDiemSinhVien.getInstance().Nganhs.ToList();
        }
        public static Nganh selectByID(string maNganh)
        {
            var lstNganh = QLDiemSinhVien.getInstance().Nganhs.ToList();
            var nganh = (from n in lstNganh
                        where n.MaNganh.Trim() == maNganh.Trim()
                        select n
                      ).FirstOrDefault();
            return nganh;
        }
        public static List<Nganh> selectByIDKhoa(string maKhoa)
        {
            var lstNganh = QLDiemSinhVien.getInstance().Nganhs.ToList();
            var nganh = (from n in lstNganh
                         where n.MaKhoa.Trim() == maKhoa.Trim()
                         select n
                      ).ToList();
            return nganh;
        }
        public static List<Nganh> selectByTenNganh(string tenNganh)
        {
            var lstNganh = QLDiemSinhVien.getInstance().Nganhs.ToList();
            var nganh = (from n in lstNganh
                        where n.TenNganh.ToLower().Trim().Contains(tenNganh.ToLower().Trim()) == true
                        select n
                      ).ToList();
            return nganh;
        }
        public static bool insert(Nganh n)
        {
            try
            {
                QLDiemSinhVien.getInstance().Nganhs.Add(n);
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delete(string maNganh)
        {
            try
            {
                QLDiemSinhVien.getInstance().Nganhs.Remove(selectByID(maNganh));
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool update(string maNganh, Nganh nganh)
        {
            try
            {
                var n = selectByID(maNganh);
                if (n != null)
                {
                    n.TenNganh = nganh.TenNganh;
                    n.MaKhoa = nganh.MaKhoa;
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
