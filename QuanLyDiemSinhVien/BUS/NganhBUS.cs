using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NganhBUS
    {
        public static List<Nganh> selectAll()
        {
            return NganhDAO.selectAll();
        }
        public static Nganh selectByID(string maNganh)
        {

            return NganhDAO.selectByID(maNganh);
        }
        public static List<Nganh> selectByIDKhoa(string maKhoa)
        {
            return NganhDAO.selectByIDKhoa(maKhoa);
        }
        public static List<Nganh> selectByTenNganh(string tenNganh)
        {

            return NganhDAO.selectByTenNganh(tenNganh); ;
        }
        public static bool insert(Nganh n)
        {

            return NganhDAO.insert(n);
        }
        public static bool delete(string maNganh)
        {
            return NganhDAO.delete(maNganh);
        }
        public static bool update(string maNganh, Nganh nganh)
        {
            return NganhDAO.update(maNganh, nganh);
        }
    }
}
