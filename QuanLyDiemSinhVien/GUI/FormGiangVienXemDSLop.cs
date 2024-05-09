using BUS;
using DTO;
using GUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormGiangVienXemDSLop : Form
    {
        public GiangVien giangVien;
        public FormGiangVienXemDSLop()
        {
            InitializeComponent();
        }

        private void FormGiangVienXemDSLop_Load(object sender, EventArgs e)
        {
            LoadData.loadCombobox<HocKy>(cboHocKy, "TenKy", "MaHocKy", GiangVienXemDSLopBUS.selectAll());
            loadDataGirdView();
        }

        private void loadDataGirdView()
        {
            dgvDSLop.Rows.Clear();
            if (giangVien != null)
            {
                var lsvLopTC = GiangVienXemDSLopBUS.selectDanhSach(giangVien);
                lsvLopTC.ForEach(l =>
                {
                    dgvDSLop.Rows.Add(l.MaLop, l.NgayBatDau, l.NgayKetThuc, l.SinhViens.Count, l.SLToiDa, l.HocKy.TenKy, l.MonHoc.TenMon, l.Khoa.TenKhoa);
                });
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGirdViewTheoKy();
        }

        private void loadDataGirdViewTheoKy()
        {
            if (giangVien != null)
            {
                dgvDSLop.Rows.Clear();
                string maKy = cboHocKy.SelectedValue.ToString();
                var lsvLopTC = GiangVienXemDSLopBUS.selectDanhSachTheoKy(maKy, giangVien);
                lsvLopTC.ForEach(l =>
                {
                    dgvDSLop.Rows.Add(l.MaLop, l.NgayBatDau, l.NgayKetThuc, l.SinhViens.Count, l.SLToiDa, l.HocKy.TenKy, l.MonHoc.TenMon, l.Khoa.TenKhoa);
                });
            }
        }

        private void dgvDSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow view = dgvDSLop.SelectedRows[0];
            string maLop = view.Cells[0].Value.ToString().Trim();
            FormDanhSachSVTrongLop fDanhSachSVTrong = new FormDanhSachSVTrongLop();
            fDanhSachSVTrong.maLop = maLop;
            fDanhSachSVTrong.ShowDialog();
        }
    }
}
