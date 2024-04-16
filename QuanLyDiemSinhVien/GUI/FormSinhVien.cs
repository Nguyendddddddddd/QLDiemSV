using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           
            loadDataGirdView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = txtMSSV.Text;
            sv.HoLot = txtHoLot.Text;
            sv.Ten = txtTen.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            sv.NgaySinh = dtpNgaySinh.Value;
            bool kq = SinhVienBUS.insert(sv);
            MessageBox.Show(kq ? "Thêm thành công" : "Thêm không thành công");
            loadDataGirdView();
        }
        private void loadDataGirdView()
        {
            dgvSinhVien.Rows.Clear();
            var lstSinhVien = SinhVienBUS.selectAll();
            lstSinhVien.ForEach(sv =>
            {
                dgvSinhVien.Rows.Add(sv.MSSV,sv.HoLot,sv.Ten,sv.NgaySinh,sv.GioiTinh,sv.DiaChi);
            });
        }
    }
}
