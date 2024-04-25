using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHocDAO
    {
            public static List<MonHoc> selectAll()
            {
                return QLDiemSinhVien.getInstance().MonHocs.ToList();
            }
            public static MonHoc selectByID(string maMonHoc)
            {
                var lstMonHoc = QLDiemSinhVien.getInstance().MonHocs.ToList();
                var mon = (from m in lstMonHoc
                           where m.MaMon.Trim() == maMonHoc.Trim()
                           select m
                          ).FirstOrDefault();
                return mon;
            }
            public static List<MonHoc> selectByTenMonHoc(string tenMon)
            {
                var lstMonHoc = QLDiemSinhVien.getInstance().MonHocs.ToList();
                var mon = (from m in lstMonHoc
                           where m.TenMon.ToLower().Trim().Contains(tenMon.ToLower().Trim()) == true
                           select m
                          ).ToList();
                return mon;
            }
            public static bool insert(MonHoc m)
            {
                try
                {
                    QLDiemSinhVien.getInstance().MonHocs.Add(m);
                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            public static bool delete(string maMonHoc)
            {
                try
                {
                    QLDiemSinhVien.getInstance().MonHocs.Remove(selectByID(maMonHoc));
                    int sl = QLDiemSinhVien.getInstance().SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
            }
            public static bool update(string maMonHoc, MonHoc monHoc)
            {
                try
                {
                    var m = selectByID(maMonHoc);
                    if (m != null)
                    {
                        m.TenMon = monHoc.TenMon;
                        m.SoTinChi = monHoc.SoTinChi;
                        m.MoTa = monHoc.MoTa;
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

