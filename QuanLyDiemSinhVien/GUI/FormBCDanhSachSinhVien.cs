using BUS;
using DTO;
using GUI.UI;
using Microsoft.Reporting.WinForms;
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
    public partial class FormBCDanhSachSinhVien : Form
    {
        public FormBCDanhSachSinhVien()
        {
            InitializeComponent();
            LoadData.loadCombobox<Lop>(cboLop, "TenLop", "MaLop", LopBUS.selectAll());
            LoadData.loadCombobox<LopTinChi>(cboLopMonHoc, "MaLop", "MaLop", LopTinChiBUS.selectAll());
            LoadData.loadCombobox<LopTinChi>(cboLopHocBangDiem, "MaLop", "MaLop", LopTinChiBUS.selectAll());


        }

        private void FormBCDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDiemSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLDiemSinhVienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'qLDiemSinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLDiemSinhVienDataSet.SinhVien);

            this.rpvSinhVienLop.RefreshReport();
            this.rpvLopMonHoc.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sinhVienTableAdapter.FillByMaLop(this.qLDiemSinhVienDataSet.SinhVien, cboLop.SelectedValue.ToString());
            this.rpvSinhVienLop.RefreshReport();
        }

        private void cboLopMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboLopMonHoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.sinhVienLopMonHocTableAdapter1.FillByMaLopMonHoc(this.qLDiemSinhVienDataSet.SinhVienLopMonHoc, cboLopMonHoc.SelectedValue.ToString());
            this.rpvLopMonHoc.RefreshReport();
        }

        private void cboLopHocBangDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bangDiemTableAdapter.Fill(this.qLDiemSinhVienDataSet.BangDiem,cboLopHocBangDiem.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
