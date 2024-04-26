using System;
using System.CodeDom;
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
using GUI.MyControl;
using GUI.UI;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class FormSinhVien : Form
    {
        private addSinhVien addSinhVien;
        private UpdateAndDeleteSinhVien updateAndDeleteSinhVien;
        private int indexDgvSinhVien = -1;
        public FormSinhVien()
        {
            InitializeComponent();
           
            addSinhVien = new addSinhVien();
            addSinhVien.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsSinhVien, pnlAddSinhVien); };
            addSinhVien.btnLuu.Click += btnLuu_Click;
           
            updateAndDeleteSinhVien = new UpdateAndDeleteSinhVien();
            updateAndDeleteSinhVien.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsSinhVien, pnlAddSinhVien); };
            updateAndDeleteSinhVien.btnXoa.Click += btnXoa_Click;
            updateAndDeleteSinhVien.btnSua.Click += btnSua_Click;

            LoadData.loadCombobox<Lop>(addSinhVien.cboLop, "MaLop", "MaLop", QLDiemSinhVien.getInstance().Lops.ToList());
            LoadData.loadCombobox<Lop>(updateAndDeleteSinhVien.cboLop, "MaLop", "MaLop", QLDiemSinhVien.getInstance().Lops.ToList());
            loadDataGirdView();
        }
        private bool ktNhapDuLieu()
        {
            return (addSinhVien.txtMSSV.Text.Trim().Length == 0 ||
                   addSinhVien.txtHoLot.Text.Trim().Length == 0 ||
                   addSinhVien.txtTen.Text.Trim().Length == 0 ||
                   addSinhVien.txtDiaChi.Text.Trim().Length == 0);
        }
        //các hàm load dữ liệu
        private void FormMain_Load(object sender, EventArgs e)
        {
           
        }
        private void loadDataGirdView()
        {
            dgvSinhVien.Rows.Clear();
            var lstSinhVien = SinhVienBUS.selectAll();
            lstSinhVien.ForEach(sv =>
            {
                string gioiTinh = bool.Parse(sv.GioiTinh.ToString()) ? "Nam" : "Nữ";
                dgvSinhVien.Rows.Add(sv.MSSV, sv.HoLot, sv.Ten, gioiTinh, sv.NgaySinh.Value.ToShortTimeString(), sv.DiaChi, sv.MaLop);
            });
        }
        private void loadDataGirdView(List<SinhVien> lstSV)
        {
            dgvSinhVien.Rows.Clear();
            lstSV.ForEach(sv =>
            {
                string gioiTinh = bool.Parse(sv.GioiTinh.ToString()) ? "Nam" : "Nữ";
                dgvSinhVien.Rows.Add(sv.MSSV, sv.HoLot, sv.Ten, gioiTinh, sv.NgaySinh.Value.ToShortTimeString(), sv.DiaChi, sv.MaLop);
            });
        }

        //Các hàm sự kiện
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            HandleUI.showSidePanel(pnlDsSinhVien, pnlAddSinhVien);
            pnlAddSinhVien.Controls.Add(addSinhVien);
        }

        private void gdvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            indexDgvSinhVien = e.RowIndex;
            var Cells = dgvSinhVien.Rows[e.RowIndex].Cells;

            var mssv = updateAndDeleteSinhVien.txtMSSV.Text = Cells[clMSSV.Index].Value.ToString();
            updateAndDeleteSinhVien.txtHoLot.Text = Cells[clHoLot.Index].Value.ToString();
            updateAndDeleteSinhVien.txtTen.Text = Cells[clTenSV.Index].Value.ToString();
            updateAndDeleteSinhVien.txtDiaChi.Text = Cells[clDiaChi.Index].Value.ToString();
            updateAndDeleteSinhVien.rdoNam.Checked = Cells[clGioiTinh.Index].Value.ToString() == "Nam";
            updateAndDeleteSinhVien.rdoNu.Checked = Cells[clGioiTinh.Index].Value.ToString() == "Nữ";

            updateAndDeleteSinhVien.dtpNgaySinh.Text = Cells[clNgaySinh.Index].Value.ToString();
            updateAndDeleteSinhVien.cboLop.SelectedValue = SinhVienBUS.selectByID(mssv).Lop.MaLop;
            HandleUI.showSidePanel(pnlDsSinhVien, pnlAddSinhVien);
            pnlAddSinhVien.Controls.Add(updateAndDeleteSinhVien);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ktNhapDuLieu())
            {
                HandleUI.ThieuThongTin();
                return;
            }
            if (SinhVienBUS.selectByID(addSinhVien.txtMSSV.Text) != null)
            {
                HandleUI.MaDaTonTai("số sinh viên");
                return;
            }
            SinhVien sv = new SinhVien()
            {
                MSSV = addSinhVien.txtMSSV.Text,
                HoLot = addSinhVien.txtHoLot.Text,
                Ten = addSinhVien.txtTen.Text,
                DiaChi = addSinhVien.txtDiaChi.Text,
                GioiTinh = addSinhVien.rdoNam.Checked,
                NgaySinh = addSinhVien.dtpNgaySinh.Value,
                MaLop = addSinhVien.cboLop.SelectedValue.ToString(),
            };
            bool kq = SinhVienBUS.insert(sv);
            loadDataGirdView();
            MessageBox.Show(kq ? "Thêm sinh viên thành công" : "Thêm sinh viên không thành công", "Thông báo");

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (indexDgvSinhVien == -1)
            {
                HandleUI.chuaChon("Sinh viên", "sửa");
            }
            if (ktNhapDuLieu())
            {
                HandleUI.ThieuThongTin();
                return;
            }
            string mssv = updateAndDeleteSinhVien.txtMSSV.Text;

            SinhVien sv = new SinhVien()
            {
                MSSV = updateAndDeleteSinhVien.txtMSSV.Text,
                HoLot = updateAndDeleteSinhVien.txtHoLot.Text,
                Ten = updateAndDeleteSinhVien.txtTen.Text,
                DiaChi = updateAndDeleteSinhVien.txtDiaChi.Text,
                GioiTinh = updateAndDeleteSinhVien.rdoNam.Checked,
                NgaySinh = updateAndDeleteSinhVien.dtpNgaySinh.Value,
                MaLop = updateAndDeleteSinhVien.cboLop.SelectedValue.ToString(),
            };
            bool kq = SinhVienBUS.update(mssv, sv);
            loadDataGirdView();
            indexDgvSinhVien = -1;
            MessageBox.Show(kq ? "Sửa sinh viên thành công" : "Sửa sinh viên không thành công", "Thông báo");

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (indexDgvSinhVien == -1)
            {
                HandleUI.chuaChon("Sinh viên", "xóa");
            }
            string mssv = dgvSinhVien.Rows[indexDgvSinhVien].Cells[clMSSV.Index].Value.ToString();
            bool kq = SinhVienBUS.delete(mssv);
            loadDataGirdView();
            indexDgvSinhVien = -1;
            MessageBox.Show(kq ? "Xóa sinh viên thành công" : "Xóa sinh viên không thành công", "Thông báo");
        }

        private void btnTimKiemSinhVien_Click(object sender, EventArgs e)
        {
            timSinhVien();
        }
        private void txtTimKiemTenSinhVien_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemTenSinhVien.Text.Length == 0)
                loadDataGirdView();
        }

        private void txtTimKiemTenSinhVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timSinhVien();
        }

        // các hàm tìm kiếm
        public void timSinhVien()
        {
            var lstSinhVien = SinhVienBUS.selectByTenSinhVien(txtTimKiemTenSinhVien.Text);
            if (lstSinhVien.Count == 0)
            {
                SinhVien sv = SinhVienBUS.selectByID(txtTimKiemTenSinhVien.Text);
                lstSinhVien.Add(sv);
                if (sv != null)
                {
                    loadDataGirdView(lstSinhVien);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            loadDataGirdView(lstSinhVien);
        }
    }
}
