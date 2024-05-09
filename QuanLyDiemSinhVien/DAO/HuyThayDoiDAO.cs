using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HuyThayDoiDAO
    {
        public static void huythaydoi()
        {
            var context = QLDiemSinhVien.getInstance();

            // Lấy tất cả các đối tượng được theo dõi bởi DbContext
            var changedEntries = context.ChangeTracker.Entries().Where(e => e.State != EntityState.Unchanged).ToList();

            // Đặt trạng thái của từng đối tượng về Unchanged
            foreach (var entry in changedEntries)
            {
                entry.State = EntityState.Unchanged;
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            context.SaveChanges();

        }
    }
}
