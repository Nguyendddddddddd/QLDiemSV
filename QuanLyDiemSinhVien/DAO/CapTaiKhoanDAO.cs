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
    }
}
