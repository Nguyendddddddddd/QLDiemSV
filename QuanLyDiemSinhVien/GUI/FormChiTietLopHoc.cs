using BUS;
using DTO;
using GUI.MyControl;
using GUI.UI;
using Guna.UI2.WinForms;
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
    public partial class FormChiTietLopHoc : Form
    {
        public LopTinChi ltc { get; set; }
        string maLop;
        private dsSinhVien addSinhVien;
        public FormChiTietLopHoc(String malop)
        {
            this.maLop = malop;
            ltc = LopTinChiBUS.selectByID(malop);
            addSinhVien = new dsSinhVien();
            InitializeComponent();
            loadDgvDSSinhVien(); 
            loaddgvDsSinhVienTrongLop();
            LoadData.loadCombobox<Lop>(addSinhVien.cboLop, "TenLop", "MaLop", LopBUS.selectAll());
            addSinhVien.btnLuu.Click += (sender, e) =>
            {
                themSinhVienVaoLop();
            };
            addSinhVien.cboLop.SelectedIndexChanged += (sender, e) =>
            {
                Guna2ComboBox cbo = (Guna2ComboBox)sender;
                loadDgvDSSinhVien(SinhVienBUS.selectByMaLop(cbo.SelectedValue.ToString()));
            };
            addSinhVien.dgvSinhVien.CellClick += addSinhVien_dgvSinhVien_CellClick;


        }

        private void addSinhVien_dgvSinhVien_CellClick(object sender, EventArgs e)
        {
            Guna2DataGridView dgv = sender as Guna2DataGridView;
        }

        private void loadDgvDSSinhVien(List<SinhVien> lst)
        {
            addSinhVien.dgvSinhVien.Rows.Clear();
            lst.ForEach(sv =>
            {
                addSinhVien.dgvSinhVien.Rows.Add(sv.MSSV,sv.FullName);
            });
        }
        private void loadDgvDSSinhVien()
        {
            addSinhVien.dgvSinhVien.Rows.Clear();
            SinhVienBUS.selectAll().ForEach(sv =>
            {
                addSinhVien.dgvSinhVien.Rows.Add(sv.MSSV, sv.FullName);
            });
        }
        private void loaddgvDsSinhVienTrongLop()
        {
            if (ltc== null)
                return;
                dgvSinhVienLopHoc.Rows.Clear();
            ltc.SinhViens.ToList().ForEach(sv =>
            {
                dgvSinhVienLopHoc.Rows.Add(sv.MSSV,sv.FullName,sv.NgaySinh,sv.Lop.TenLop,sv.Lop.Nganh.Khoa.TenKhoa);

            });
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            HandleUI.showSidePanel(pnlMain, pnlSide);
            pnlSide.Controls.Add(addSinhVien);
        }
        public void themSinhVienVaoLop()
        {
            if (addSinhVien.dgvSinhVien.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên");
                return;
            }
            for (int i=0;i< addSinhVien.dgvSinhVien.SelectedRows.Count; i++) { 
                var mssv = addSinhVien.dgvSinhVien.SelectedRows[i].Cells[0].Value.ToString();
                LopTinChiBUS.themSinhVienVaoLop(ltc.MaLop,SinhVienBUS.selectByID(mssv));
               
            }
            loaddgvDsSinhVienTrongLop();
        }
    }
}
