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
    public partial class FormDiemHocKy : Form
    {
        public FormDiemHocKy()
        {
            InitializeComponent();
            LoadData.loadCombobox<HocKy>(cboHocKy, "TenKy", "MaHocKy", HocKyBUS.selectAll());
            LoadData.loadCombobox<Lop>(cboLop, "TenLop", "MaLop", LopBUS.selectAll());
            loadGgv();
        }

        private void FormDiemHocKy_Load(object sender, EventArgs e)
        {

        }
        public void loadGgv()
        {
            dgvDiemHK.Rows.Clear();
            DiemHocKyBUS.selectAll().ForEach(d =>
            {
                dgvDiemHK.Rows.Add(d.SinhVien.MSSV, d.SinhVien.FullName, d.HocKy.TenKy, d.HocKy.NamHoc, d.Diem);
            });
        }

        private void btnCapNhatDiemHK_Click(object sender, EventArgs e)
        {
            FormCapNhatDiemHocKy fCapNhatDiemHocKy = new FormCapNhatDiemHocKy();
            fCapNhatDiemHocKy.Tag = this;
            fCapNhatDiemHocKy.ShowDialog();

        }

        private void FormDiemHocKy_VisibleChanged(object sender, EventArgs e)
        {
            loadGgv();
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            timSinhVien();
        }
        private void loadGgv(List<DiemHocKy> dhk)
        {
            dgvDiemHK.Rows.Clear();
            dhk.ForEach(d =>
            {
                dgvDiemHK.Rows.Add(d.SinhVien.MSSV, d.SinhVien.FullName, d.HocKy.TenKy, d.HocKy.NamHoc, d.Diem);
            });
        }
        public void timSinhVien()
        {
            List<DiemHocKy> dhk = DiemHocKyBUS.selectByMSSV(txtTimSV.Text);

            if (dhk != null)
            {
                loadGgv(dhk);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DiemHocKy> lstDhk = DiemHocKyBUS.selectAll().Where(dhk => dhk.HocKy.MaHocKy == cboHocKy.SelectedValue.ToString()).ToList();
            loadGgv(lstDhk);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DiemHocKy> lstDhk = DiemHocKyBUS.selectAll().Where(dhk => dhk.SinhVien.MaLop == cboLop.SelectedValue.ToString()).ToList();
            loadGgv(lstDhk);
        }
    }
}
