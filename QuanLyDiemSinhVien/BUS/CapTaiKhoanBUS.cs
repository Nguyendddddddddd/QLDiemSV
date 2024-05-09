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
    public class CapTaiKhoanBUS
    {
        public static bool insert(TaiKhoang tk)
        {
            MD5 md5 = MD5.Create();
            tk.MatKhau = CapTaiKhoanBUS.GetMd5Hash(md5, tk.MatKhau);
            return CapTaiKhoanDAO.insert(tk);
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

        public static bool updateTaiKhoanSV(string mssv, string tenDangNhap)
        {

            return CapTaiKhoanDAO.updateTaiKhoanSV(mssv, tenDangNhap);
        }

        public static bool updateTaiKhoanGV(string mssv, string tenDangNhap)
        {

            return CapTaiKhoanDAO.updateTaiKhoanGV(mssv, tenDangNhap);
        }

        public static List<SinhVien> selectByTenDangNhapSVRong()
        {
            return CapTaiKhoanDAO.selectByTenDangNhapSVRong();
        }

        public static List<GiangVien> selectByTenDangNhapGVRong()
        {
            return CapTaiKhoanDAO.selectByTenDangNhapGVRong();
        }
    }
}
