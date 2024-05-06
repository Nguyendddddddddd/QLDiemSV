using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DiemThanhPhanDAO
    {
        public static List<DiemThanhPhan> selectByMaLop(string maLop)
        {
            return QLDiemSinhVien.getInstance().DiemThanhPhans.ToList();
        }
        public static bool delete(Guid madiem)
        {
            try
            {
                QLDiemSinhVien.getInstance().DiemThanhPhans.Remove(selectByID(madiem));
                QLDiemSinhVien.getInstance().SaveChanges();


            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public static DiemThanhPhan selectByID(Guid maDiem)
        {
            var lstDiem= QLDiemSinhVien.getInstance().DiemThanhPhans.ToList();
            var diem = (from d in lstDiem
                        where d.MaDiemTP == maDiem
                         select d
                      ).FirstOrDefault();
            QLDiemSinhVien.getInstance().SaveChanges();
            return diem;
        }
    }
}
