using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietDiemBUS
    {
            public static List<ChiTietDiem> selectByMaSvAndMaLop(string mssv, string  maLop)
            {
               
                return ChiTietDiemDAO.selectByMaSvAndMaLop(mssv,maLop);
            }
        public static ChiTietDiem selectByMaSvAndMaDiem(string mssv, Guid maDiem)
        {
            return ChiTietDiemDAO.selectByMaSvAndMaDiem(mssv,maDiem);
        }

    }
}
