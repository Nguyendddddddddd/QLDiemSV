using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiangVienXemDSLopDAO
    {
        public static List<HocKy> SelectAll()
        {
            return QLDiemSinhVien.getInstance().HocKies.ToList();
        }

        public static List<LopTinChi> selectDanhSach(GiangVien GV)
        {
            var lstGiangVien = QLDiemSinhVien.getInstance().GiangViens.ToList();
            var giangvien = (from g in lstGiangVien
                             where g.TenDangNhap == GV.TenDangNhap
                             select g).FirstOrDefault();
            return giangvien.LopTinChis.ToList();

        }

        public static List<LopTinChi> selectDanhSachTheoKy(string maKy, GiangVien gv)
        {
            var lstLopTinChi = selectDanhSach(gv);
            var lsvDS = (from l in lstLopTinChi
                         where l.MaHocKy.Trim() == maKy.Trim()
                         select l);
            return lsvDS.ToList();
        }

        public static List<SinhVien> selectDSSVTrongLop(string maLop)
        {
            var lstsv = QLDiemSinhVien.getInstance().SinhViens.ToList();
            var sinhvien = (from s in lstsv
                            where s.MaLop.Trim() == maLop.Trim()
                            select s);
            return sinhvien.ToList();
        }
    }
}
