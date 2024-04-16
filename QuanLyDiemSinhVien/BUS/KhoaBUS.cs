using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoaBUS
    {
        public static List<Khoa> selectAll()
        {
            return KhoaDAO.selectAll();
        }
        public static Khoa selectByID(string maKhoa)
        {
           
            return KhoaDAO.selectByID(maKhoa);
        }
        public static bool insert(Khoa k)
        {
            return KhoaDAO.insert(k);
        }
        public static bool delete(string maKhoa)
        {
            
            return KhoaDAO.delete(maKhoa);
        }
        public static bool update(string maKhoa, Khoa Khoa)
        {
           
            return KhoaDAO.update(maKhoa, Khoa);
        }
        public static bool save()
        {
            return KhoaDAO.save();
        }
    }
}
