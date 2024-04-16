using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhoaDAO
    {
        public static List<Khoa> selectAll()
        {
            return QLDiemSinhVien.getInstance().Khoas.ToList();
        }
        public static Khoa selectByID(string maKhoa)
        {
            var lstKhoa = QLDiemSinhVien.getInstance().Khoas.ToList();
            var khoa = (from k in lstKhoa
                        where k.MaKhoa.Trim() == maKhoa.Trim()
                        select k
                      ).FirstOrDefault();
            return khoa;
        }
        public static bool insert(Khoa k)
        {
            try
            {
                QLDiemSinhVien.getInstance().Khoas.Add(k);
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delete(string maKhoa)
        {
            try
            {
                QLDiemSinhVien.getInstance().Khoas.Remove(selectByID(maKhoa));
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool update(string maKhoa, Khoa Khoa)
        {
            try
            {
                var k = selectByID(maKhoa);
                if (k != null)
                {
                    k.TenKhoa = Khoa.TenKhoa;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return true;
            
        }
        public static bool save()
        {
            int sl = QLDiemSinhVien.getInstance().SaveChanges();
            return sl > 0;
        }
    }
}
