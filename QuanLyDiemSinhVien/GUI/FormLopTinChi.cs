using BUS;
using DTO;
using GUI.MyControl;
using GUI.UI;
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
    public partial class FormLopTinChi : Form
    {
        private AddLopMonHoc addLopMonHoc;
        private UpdateAndDeleteLopMonHoc updateAndDeleteLMH;
        private int indexdgv = -1;
        private LopTinChi LopTinChiSelect;
        public FormLopTinChi()
        {
            InitializeComponent();
            addLopMonHoc = new AddLopMonHoc();
            updateAndDeleteLMH = new UpdateAndDeleteLopMonHoc();
            addLopMonHoc.btnThem.Click += (sender, e) => { ThemLop(); };
            updateAndDeleteLMH.btnSua.Click += (sender, e) => { SuaLop(); };
            updateAndDeleteLMH.btnXoa.Click += (sender, e) => { xoaLop(); };
            updateAndDeleteLMH.lbDenLopHoc.Click += (sender, e) => { openFormChiTietLopHoc(); };

            loadData();
        }
        public void openFormChiTietLopHoc()
        {
            FormChiTietLopHoc formChiTietLH = new FormChiTietLopHoc(LopTinChiSelect.MaLop);
            FormMain.getInstance().openChillForm(formChiTietLH);

        }
        private void loadData()
        {
            loadDataGridview();
            loadCboHocKy();
            loadCboMonHoc();
            loadCboGiangVien();
        }
        private void loadDataGridview()
        {
            dgvLopTinChi.Rows.Clear();

            LopTinChiBUS.selectAll().ForEach(ltc =>
            {
                dgvLopTinChi.Rows.Add(ltc.MaLop, ltc.MonHoc.TenMon, ltc.SLToiDa, ltc.SinhViens.Count, ltc.NgayBatDau, ltc.NgayKetThuc, ltc.HocKy.TenKy);

            });
        }
        private void loadCboHocKy()
        {
            LoadData.loadCombobox<HocKy>(addLopMonHoc.cboHocKy, "TenKy", "MaHocKy", HocKyBUS.selectAll());
            LoadData.loadCombobox<HocKy>(updateAndDeleteLMH.cboHocKy, "TenKy", "MaHocKy", HocKyBUS.selectAll());
            LoadData.loadCombobox<HocKy>(cboHocKy, "TenKy", "MaHocKy", HocKyBUS.selectAll());
        }
        private void loadCboMonHoc()
        {
            LoadData.loadCombobox<MonHoc>(addLopMonHoc.cboMonHoc, "TenMon", "MaMon", MonHocBUS.selectAll());
            LoadData.loadCombobox<MonHoc>(updateAndDeleteLMH.cboMonHoc, "TenMon", "MaMon", MonHocBUS.selectAll());
        }
        private void loadCboGiangVien()
        {
            LoadData.loadCombobox<GiangVien>(addLopMonHoc.cboGiangVien, "FullName", "MaGV", GiangVienBUS.selectAll());
        }
       

        private void FormLopTinChi_Load(object sender, EventArgs e)
        {


        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            HandleUI.showSidePanel(pnlDsLopTC, pnlAddLopTC);
            pnlAddLopTC.Controls.Add(addLopMonHoc);
        }


        private void ThemLop()
        {
            int soLuongLop = LopTinChiBUS.selectAll().Count;
            string maMon = addLopMonHoc.cboMonHoc.SelectedValue.ToString();
            string MaLop = maMon.Trim() + "" + soLuongLop;
            GiangVien gv = GiangVienBUS.selectByID(addLopMonHoc.cboGiangVien.SelectedValue.ToString());

            if (addLopMonHoc.dtpNgayBD.Value > addLopMonHoc.dtpNgayKT.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Thông báo");
                return;
            }

            MessageBox.Show(MaLop);
            LopTinChi lopTinChi = new LopTinChi()
            {
                MaLop = MaLop,
                NgayBatDau = addLopMonHoc.dtpNgayBD.Value,
                NgayKetThuc = addLopMonHoc.dtpNgayKT.Value,
                SLToiDa = (int)addLopMonHoc.nudSLToiDa.Value,
                MaHocKy = addLopMonHoc.cboHocKy.SelectedValue.ToString(),
                MaMon = addLopMonHoc.cboMonHoc.SelectedValue.ToString(),
                SLSinhVien = 0,
            };
            lopTinChi.GiangViens.Add(gv);
            LopTinChiBUS.insert(lopTinChi);
            loadDataGridview();
        }
        private void SuaLop()
        {
            if (LopTinChiSelect == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp để sửa", "Thông báo");
                return;
            }
            if (updateAndDeleteLMH.dtpNgayBD.Value > updateAndDeleteLMH.dtpNgayKT.Value)
            {
                MessageBox.Show("Ngày bắt đầu phải trước ngày kết thúc", "Thông báo");
                return;
            }
            LopTinChi lopTinChi = new LopTinChi()
            {
                NgayBatDau = updateAndDeleteLMH.dtpNgayBD.Value,
                NgayKetThuc = updateAndDeleteLMH.dtpNgayKT.Value,
                SLToiDa = (int)updateAndDeleteLMH.nudSLToiDa.Value,
                MaHocKy = updateAndDeleteLMH.cboHocKy.SelectedValue.ToString(),
                MaMon = updateAndDeleteLMH.cboMonHoc.SelectedValue.ToString(),
                SLSinhVien = 0,
            };
            LopTinChiBUS.update(LopTinChiSelect.MaLop, lopTinChi);
            loadDataGridview();
            LopTinChiSelect = null;
        }
        public void xoaLop()
        {
            if (LopTinChiSelect == null)
            {
                MessageBox.Show("Bạn chưa chọn lớp để xóa", "Thông báo");
                return;
            }
            LopTinChiBUS.delete(LopTinChiSelect.MaLop);
            MessageBox.Show("Xóa lớp thành công", "Thông báo");
            loadDataGridview();
            LopTinChiSelect = null;
        }

        private void dgvLopTinChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            HandleUI.showSidePanel(pnlDsLopTC, pnlAddLopTC);
            pnlAddLopTC.Controls.Add(updateAndDeleteLMH);
            var rowSelect = dgvLopTinChi.Rows[e.RowIndex].Cells;

            string maLop = rowSelect[clMaLop.Index].Value.ToString();

            LopTinChiSelect = LopTinChiBUS.selectByID(maLop);
            updateAndDeleteLMH.cboMonHoc.SelectedValue = LopTinChiSelect.MaMon;
            updateAndDeleteLMH.cboHocKy.SelectedValue = LopTinChiSelect.MaHocKy;
            updateAndDeleteLMH.dtpNgayBD.Value = LopTinChiSelect.NgayBatDau.Value;
            updateAndDeleteLMH.dtpNgayKT.Value = LopTinChiSelect.NgayKetThuc.Value;
            updateAndDeleteLMH.nudSLToiDa.Value = decimal.Parse(LopTinChiSelect.SLToiDa.ToString());



        }

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            timLopMonHoc();
        }

        private void timLopMonHoc()
        {

            LopTinChi ltc = LopTinChiBUS.selectByID(txtTimKiemLop.Text);

            if (ltc != null)
            {
                dgvLopTinChi.Rows.Clear();
                dgvLopTinChi.Rows.Add(ltc.MaLop, ltc.MonHoc.TenMon, ltc.SLToiDa, ltc.SLSinhVien, ltc.NgayBatDau, ltc.NgayKetThuc, ltc.HocKy);
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        private void txtTimKiemLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timLopMonHoc();
        }

        private void txtTimKiemLop_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemLop.Text.Length == 0)
                loadDataGridview();
        }
    } 
}


