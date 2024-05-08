using BUS;
using DTO;
using GUI.MyControl;
using GUI.UI;
using Guna.UI2.WinForms;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        int index;
        public FormChiTietLopHoc(String malop)
        {
            this.maLop = malop;
            ltc = LopTinChiBUS.selectByID(malop);
            addSinhVien = new dsSinhVien();
            InitializeComponent();
            loadDgvDSSinhVien();
            loaddgvDsSinhVienTrongLop();
            loadCotDiem();
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
                int kq = 0;
                ltc.SinhViens.ToList().ForEach(svtl =>
                {
                    if (sv.MSSV == svtl.MSSV)
                    {
                        kq++;
                    }
                });

                if (kq == 0)
                {
                    addSinhVien.dgvSinhVien.Rows.Add(sv.MSSV, sv.FullName);
                }
                else
                {
                    kq = 0;
                }

            });
        }

        private void loadCotDiem()
        {
            dgvCotDiem.Rows.Clear();
            LopTinChiBUS.selectByID(maLop).DiemThanhPhans.ToList().ForEach(d =>
            {
                dgvCotDiem.Rows.Add(d.MaDiemTP,d.TenDiem,d.PhanTram);

            });
        }
        private void loadDgvDSSinhVien()
        {
            addSinhVien.dgvSinhVien.Rows.Clear();
            SinhVienBUS.selectAll().ForEach(sv =>
            {
                int kq = 0;
                ltc.SinhViens.ToList().ForEach(svtl =>
                {
                    if (sv.MSSV == svtl.MSSV)
                    {
                        kq++;
                    }
                });

                if (kq == 0)
                {
                    addSinhVien.dgvSinhVien.Rows.Add(sv.MSSV, sv.FullName);
                }
                else
                {
                    kq = 0;
                }
            });
        }
        private void loaddgvDsSinhVienTrongLop()
        {
            if (ltc == null)
                return;
            dgvSinhVienLopHoc.Rows.Clear();
            ltc.SinhViens.ToList().ForEach(sv =>
            {
                dgvSinhVienLopHoc.Rows.Add(sv.MSSV, sv.FullName, sv.NgaySinh, sv.Lop.TenLop, sv.Lop.Nganh.Khoa.TenKhoa);

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
            for (int i = 0; i < addSinhVien.dgvSinhVien.SelectedRows.Count; i++)
            {
                var mssv = addSinhVien.dgvSinhVien.SelectedRows[i].Cells[0].Value.ToString();
                LopTinChiBUS.themSinhVienVaoLop(ltc.MaLop, SinhVienBUS.selectByID(mssv));

            }
            loaddgvDsSinhVienTrongLop();
            loadDgvDSSinhVien();
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvSinhVienLopHoc.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để xóa");
                return;
            }
            for(int i = 0;i< dgvSinhVienLopHoc.SelectedRows.Count; i++)
            {
                string mssv = dgvSinhVienLopHoc.SelectedRows[i].Cells[0].Value.ToString();


                LopTinChiBUS.xoaSinhVienVaoLop(ltc.MaLop,SinhVienBUS.selectByID(mssv));
            }
            loaddgvDsSinhVienTrongLop();
            loadDgvDSSinhVien();
        }
        private void btnThemCotDiem_Click(object sender, EventArgs e)
        {
            DiemThanhPhan diemThanhPhan = new DiemThanhPhan()
            {
                MaDiemTP =  Guid.NewGuid(),
                TenDiem = txtTenCot.Text,
                PhanTram = (int)nudPhanTram.Value
            };
            int tongPhanTram = (int)nudPhanTram.Value;
            ltc.DiemThanhPhans.ToList().ForEach(d => {
                tongPhanTram += d.PhanTram.Value;
            });
            if (tongPhanTram > 100)
            {
                MessageBox.Show("Phần trăm lớn hơn 100%");
                return;
            }
            LopTinChiBUS.themDiemThanhPhan(maLop, diemThanhPhan);
            loadCotDiem();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvCotDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            index = e.RowIndex;
            var rowselect = dgvCotDiem.Rows[0].Cells;
            txtTenCot.Text = rowselect[clTenCot.Index].Value.ToString();
            nudPhanTram.Value = decimal.Parse(rowselect[clPhanTram.Index].Value.ToString());


        }
        private void btnXoaCotDiem_Click(object sender, EventArgs e)
        {
            if (index == -1)
                return;
            var maDiemTP = Guid.Parse(dgvCotDiem.Rows[index].Cells[clMaDiem.Index].Value.ToString());
            DiemThanhPhanBUS.selectByID(maDiemTP).ChiTietDiems.Clear();
            ltc.DiemThanhPhans.Remove(DiemThanhPhanBUS.selectByID(maDiemTP));
            loadCotDiem();
        }

        private void dgvSinhVienLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleUI.showSidePanel(pnlMain, pnlSide);
            var mssv = dgvSinhVienLopHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            addDiem adiem = new addDiem(mssv,maLop);
            adiem.Tag = ltc.DiemThanhPhans.ToList();
            pnlSide.Controls.Add(adiem);

        }
    }
}
