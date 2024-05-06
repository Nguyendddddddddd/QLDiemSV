using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopTinChiDAO
    {
        public static List<LopTinChi> selectAll()
        {
            return QLDiemSinhVien.getInstance().LopTinChis.ToList();
        }
        public static LopTinChi selectByID(string maLop)
        {
            var lstLopTC = QLDiemSinhVien.getInstance().LopTinChis.ToList();
            var LopTC = (from l in lstLopTC
                      where l.MaLop.Trim() == maLop.Trim()
                      select l
                      ).FirstOrDefault();
            return LopTC;
        }
        public static bool insert(LopTinChi ltc)
        {
                QLDiemSinhVien.getInstance().LopTinChis.Add(ltc);
                int sl = QLDiemSinhVien.getInstance().SaveChanges();
            try
            {
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool delete(string maLopTC)
        {
            LopTinChi ltc = selectByID(maLopTC);
            ltc.SinhViens.Clear();
            ltc.GiangViens.Clear();
            ltc.DiemThanhPhans.Clear();
            QLDiemSinhVien.getInstance().LopTinChis.Remove(ltc);
            int sl = QLDiemSinhVien.getInstance().SaveChanges();
            try
            {
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool update(string maLop, LopTinChi lopTC)
        {
            try
            {
                var ltc = selectByID(maLop);
                if (ltc != null)
                {
                    ltc.MaHocKy = lopTC.MaHocKy;
                    ltc.NgayBatDau = lopTC.NgayBatDau;
                    ltc.NgayKetThuc = lopTC.NgayKetThuc;
                    ltc.SLToiDa = lopTC.SLToiDa;
                    ltc.MaMon= lopTC.MaMon;
                    ltc.GiangViens = lopTC.GiangViens;
                    
                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static bool themSinhVienVaoLop(string maLop,SinhVien sv)
        {
            try
            {
                var ltc = selectByID(maLop);
                if (ltc != null)
                {
                   ltc.SinhViens.Add(sv);

                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool xoaSinhVienVaoLop(string maLop, SinhVien sv)
        {
            try
            {
                var ltc = selectByID(maLop);
                if (ltc != null)
                {
                    ltc.SinhViens.Remove(sv);

                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool themDiemThanhPhan(string maLop, DiemThanhPhan dtp)
        {
            try
            {
                var ltc = selectByID(maLop);
                if (ltc != null)
                {
                    ltc.DiemThanhPhans.Add(dtp);

                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool xoaDiemThanhPhan(string maLop, DiemThanhPhan dtp)
        {
            try
            {
                var ltc = selectByID(maLop);
                if (ltc != null)
                {
                    ltc.DiemThanhPhans.Remove(dtp);

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

