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
        public static List<TaiKhoang> selectByDangNhap(string tenDangNhap)
        {
            var lstTaiKhoan = QLDiemSinhVien.getInstance().TaiKhoangs;
            var taikhoan = (from t in lstTaiKhoan
                            where t.TenDangNhap.Trim() == tenDangNhap.Trim()
                            select t
                ).ToList();
            return taikhoan;
        }
    }
}
