using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhapBUS
    {
        public static TaiKhoang selectByDangNhap(TaiKhoang tk)
        {
            MD5 md5 = MD5.Create();
            tk.MatKhau = DangNhapBUS.GetMd5Hash(md5,tk.MatKhau);
            return DangNhapDAO.selectByDangNhap(tk);
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static GiangVien selectGVTuTenDangNhap(string tenDangNhap)
        {
            return DangNhapDAO.selectGVTuTenDangNhap(tenDangNhap);
        }
    }
}
