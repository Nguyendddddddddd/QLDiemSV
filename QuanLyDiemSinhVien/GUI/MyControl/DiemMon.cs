using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyControl
{
    public partial class DiemMon : UserControl
    {
        string hk;
        string mssv;

        public DiemMon(string hk,string mssv)
        {
            this.hk = hk;
            this.mssv = mssv;
            InitializeComponent();
            var sv = SinhVienBUS.selectByID(mssv);
            var loptc = sv.LopTinChis.Where(ltc => ltc.MaHocKy == hk).ToList();
            var diemHK = sv.DiemHocKies.Where(dhk => dhk.MaHocKy == hk).FirstOrDefault();

            dgvDiemMH.Rows.Clear();
            loptc.ForEach(l =>
            {
                dgvDiemMH.Rows.Add(l.MonHoc.MaMon, l.MonHoc.TenMon, procBUS.getDiemKTMon(sv.MSSV, l.MaLop), chuyenSoSangHeChu(procBUS.getDiemKTMon(sv.MSSV, l.MaLop)));
            });
            lbHK.Text = HocKyBUS.selectByID(hk).TenKy;
            lbDiemTBHK.Text ="Điểm trung bình học kỳ hệ 10: "+ Math.Round(diemHK.Diem.Value,2).ToString();
            lbDTBhe4.Text = "Điểm trung bình học kỳ hệ 4: "+Math.Round(chuyenHe10SangHe4(diemHK.Diem.Value),2).ToString();
            lbXepLoai.Text = "Phân loại trung bình học kỳ: " + chuyenSoSangXepLoai(diemHK.Diem.Value);
        }

        private void DiemMon_Load(object sender, EventArgs e)
        {
         

        }
        private double chuyenHe10SangHe4(double diemHe10)
        {
            return (diemHe10 / 10) * 4;
        }
        private string chuyenSoSangHeChu(double diemHe10)
        {
            string Diem = "";
            if (diemHe10 >= 9)
                Diem = "A+";
            else if (diemHe10 >= 8)
                Diem = "A";
            else if (diemHe10 >= 7)
                Diem = "B+";
            else if (diemHe10 >= 6)
                Diem = "B";
            else if (diemHe10 >= 5)
                Diem = "C";
            else if (diemHe10 >= 4)
                Diem = "D+";
            else if (diemHe10 >= 3)
                Diem = "D";
            else
                Diem = "F";
            return Diem;
        }
        private string chuyenSoSangXepLoai(double diemHe10)
        {
            string Diem = "";
            if (diemHe10 >= 9)
                Diem = "Xuất sắc";
            else if (diemHe10 >= 8)
                Diem = "Giỏi";
            else if (diemHe10 >= 6)
                Diem = "Khá";
            else if (diemHe10 >= 5)
                Diem = "Trung bình";
            else if (diemHe10 >= 4)
                Diem = "Yếu";
            else
                Diem = "Kém";
            return Diem;
        }
    }
}
