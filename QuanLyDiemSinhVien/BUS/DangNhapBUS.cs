using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhapBUS
    {
        public static List<TaiKhoang> selectByDangNhap(string tenDangNhap)
        {
            return DangNhapDAO.selectByDangNhap(tenDangNhap);
        }
    }
}
