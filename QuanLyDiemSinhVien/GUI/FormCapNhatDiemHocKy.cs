using BUS;
using DTO;
using GUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCapNhatDiemHocKy : Form
    {
        public FormCapNhatDiemHocKy()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capNhatDiem();
            ((FormDiemHocKy)this.Tag).loadGgv();
            // this.Close();
        }

        private void FormCapNhatDiemHocKy_Load(object sender, EventArgs e)
        {
            LoadData.loadCombobox<HocKy>(cboHocKy, "TenKy", "MaHocKy", HocKyBUS.selectAll());
        }

        private void capNhatDiem()
        {
            string maHK = cboHocKy.SelectedValue.ToString();
            int tongsotc = 0;
            float kq = 0;
            //int kq = QLDiemSinhVien.getInstance().getTongSoTinChiSinhVien("2", "HKI2023-2024");



            //MessageBox.Show(kq +"");
            SinhVienBUS.selectAll().ForEach(sv =>
            {
                tongsotc = procBUS.getTongSoTC(sv.MSSV, maHK);
                List<LopTinChi> ltc = sv.LopTinChis.Where(l => l.MaHocKy == maHK).ToList();

               
                if(ltc.Count != 0)
                {
                    ltc.ToList().ForEach(l =>
                    {
                        kq += (float)procBUS.getDiemKTMonNhanSoTC(sv.MSSV, l.MaLop);
                    });

                    if (DiemHocKyBUS.selectByID(maHK, sv.MSSV) != null)
                    {
                        DiemHocKyBUS.update(maHK, sv.MSSV, kq / tongsotc);
                        kq = 0;
                        tongsotc = 0;
                        return;
                    }
                    DiemHocKy diemHocKy = new DiemHocKy()
                    {
                        MaHocKy = maHK,
                        MSSV = sv.MSSV,
                        Diem = kq / tongsotc,
                    };

                    DiemHocKyBUS.insert(diemHocKy);
                    kq = 0;
                    tongsotc = 0;
                }
            });

        }

    }
}
