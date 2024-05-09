using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapDAO
    {
        public static TaiKhoang selectByDangNhap(TaiKhoang tk)
        {
            var listTK = QLDiemSinhVien.getInstance().TaiKhoangs.ToList();
            var taikhoan = (from t in listTK
                             where t.TenDangNhap.Trim()==tk.TenDangNhap.Trim() && t.MatKhau==tk.MatKhau.Trim()
                             select t
                      ).FirstOrDefault();
            return taikhoan;
        }
        public static GiangVien selectGVTuTenDangNhap(string tenDangNhap)
        {
            var lstGiangVien = QLDiemSinhVien.getInstance().GiangViens.ToList();
            var giangVien = (from g in lstGiangVien
                             where g.TenDangNhap == tenDangNhap
                             select g).FirstOrDefault();
            return giangVien;
        }
    }
}
