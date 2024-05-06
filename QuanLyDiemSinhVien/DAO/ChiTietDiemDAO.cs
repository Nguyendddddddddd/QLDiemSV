using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietDiemDAO
    {
        public static List<ChiTietDiem> selectByMaSvAndMaLop(string mssv,string maLop)
        {
            var lstDiem = QLDiemSinhVien.getInstance().ChiTietDiems;

            var diem = (from d in lstDiem
                      where d.MSSV.Trim() == mssv.Trim() && d.DiemThanhPhan.MaLop.Trim() == maLop.Trim()
                        select d
                      ).ToList();
            return diem;
        }
        public static ChiTietDiem selectByMaSvAndMaDiem(string mssv, Guid maDiem)
        {
            var lstDiem = QLDiemSinhVien.getInstance().ChiTietDiems;

            var diem = (from d in lstDiem
                        where d.MSSV.Trim() == mssv.Trim() && d.MaDiemTP == maDiem
                        select d
                      ).FirstOrDefault();
            return diem;
        }
    }
}
