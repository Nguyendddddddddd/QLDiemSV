using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Report
{
    public class BangDiem
    {
        string mssv;
        List<string> tencot;
        List<float> diem;

        public BangDiem(string mssv, List<string> tencot, List<float> diem)
        {
            this.mssv = mssv;
            this.tencot = tencot;
            this.diem = diem;
        }

    }
}
