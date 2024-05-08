using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
   public class procDAO
    {

        public static int getTongSoTC(string mssv,string mahk)
        {
            SinhVien sv = SinhVienDAO.selectByID(mssv);
            List<LopTinChi> lstLop = sv.LopTinChis.ToList();

            var kq = (from tc in lstLop
                      where tc.MaHocKy.Trim() == mahk.Trim()
                      select tc).Sum(t => t.MonHoc.SoTinChi);

            if (kq == null)
                return 0;
            return kq.Value;
        }
        public static  double getDiemKTMon(string mssv,string malop)
        {
            double diem =0;
            ChiTietDiemDAO.selectByMaSvAndMaLop(mssv, malop).ForEach(ctd =>
            {   
                diem +=(Double)ctd.DiemThanhPhan.PhanTram.Value * ctd.Diem.Value;
            });
            return (double)diem/100;
        }
        public static double getDiemKTMonNhanSoTC(string mssv, string malop)
        {
            double diem = 0;
            int sotc = 0;
            ChiTietDiemDAO.selectByMaSvAndMaLop(mssv, malop).ForEach(ctd =>
            {
                diem += (Double)ctd.DiemThanhPhan.PhanTram.Value * ctd.Diem.Value;
                sotc = ctd.DiemThanhPhan.LopTinChi.MonHoc.SoTinChi.Value;
            });
            return (diem / 100)*sotc;
        }
    }
}
