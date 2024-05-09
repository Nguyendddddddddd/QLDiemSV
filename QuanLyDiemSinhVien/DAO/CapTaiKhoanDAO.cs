using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CapTaiKhoanDAO
    {
      
            public static bool insert(TaiKhoang tk)
            {
                try
                {
                    QLDiemSinhVien.getInstance().TaiKhoangs.Add(tk);
                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
        

            public static SinhVien selectByID(string mssv)
            {
                var lstSinhVien = QLDiemSinhVien.getInstance().SinhViens.ToList();
                var sv = (from s in lstSinhVien
                          where s.MSSV.Trim() == mssv.Trim()
                          select s
                          ).FirstOrDefault();
                return sv;
            }

            public static GiangVien selectByIDGV(string magv)
            {
                var lstGiangVien = QLDiemSinhVien.getInstance().GiangViens.ToList();
                var gv = (from g in lstGiangVien
                          where g.MaGV.Trim() == magv.Trim()
                          select g
                          ).FirstOrDefault();
                return gv;
            }

            public static bool updateTaiKhoanSV(string mssv, string tenDangNhap)
            {
                var sinhVien = selectByID(mssv);
                if (sinhVien != null)
                {
                    sinhVien.TenDangNhap = tenDangNhap;
                }
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
                return sl > 0;
            }

            public static bool updateTaiKhoanGV(string magv, string tenDangNhap)
            {
                var giangvien = selectByIDGV(magv);
                if (giangvien != null)
                {
                    giangvien.TenDangNhap = tenDangNhap;
                }
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
                return sl > 0;
            }

            public static List<SinhVien> selectByTenDangNhapSVRong()
            {
                var lstSV = QLDiemSinhVien.getInstance().SinhViens.ToList();
                var sinhVien = (from s in lstSV
                                where s.TenDangNhap == null
                                select s
                          ).ToList();
                return sinhVien;
            }

            public static List<GiangVien> selectByTenDangNhapGVRong()
            {
                var lstGV = QLDiemSinhVien.getInstance().GiangViens.ToList();
                var giangvien = (from g in lstGV
                                 where g.TenDangNhap == null
                                 select g
                          ).ToList();
                return giangvien;
            }

        }
    }

