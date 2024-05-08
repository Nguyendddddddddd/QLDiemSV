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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormGiangVien : Form
    {
        private AddGiangVien addGiangVien;
        private UpdateAndDeleteGiangVien updateAndDeleteGiangVien;
        private int indexGiangVien;

        public FormGiangVien()
        {
            InitializeComponent();
            addGiangVien = new AddGiangVien();
            updateAndDeleteGiangVien = new UpdateAndDeleteGiangVien();
            addGiangVien.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsGiangVien, pnlAddGiangVien); };
            updateAndDeleteGiangVien.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsGiangVien, pnlAddGiangVien); };
            addGiangVien.btnLuuGV.Click += btnLuuGV_Click;
            updateAndDeleteGiangVien.btnSuaGV.Click += btnSua_Click;
            updateAndDeleteGiangVien.btnXoaGV.Click += btnXoa_Click;

            LoadData.loadCombobox<Khoa>(addGiangVien.cboKhoa,"MaKhoa","MaKhoa",QLDiemSinhVien.getInstance().Khoas.ToList());
            LoadData.loadCombobox<Khoa>(updateAndDeleteGiangVien.cboKhoa, "MaKhoa", "MaKhoa", QLDiemSinhVien.getInstance().Khoas.ToList());
            loadDataGirdView();
        }

        private bool ktNhapDuLieu()
        {
            return (addGiangVien.txtMSGV.Text.Trim().Length == 0 ||
                addGiangVien.txtHoLotGV.Text.Trim().Length == 0 ||
                addGiangVien.txtTenGV.Text.Trim().Length == 0 ||
                addGiangVien.txtHocHam.Text.Trim().Length == 0 ||
                addGiangVien.txtHocVi.Text.Trim().Length==0||
                addGiangVien.txtChuyenMon.Text.Trim().Length==0); 
        }

        private void xoaDuLieuThem()
        {
            addGiangVien.txtMSGV.Clear();
            addGiangVien.txtHoLotGV.Clear();
            addGiangVien.txtTenGV.Clear();
            addGiangVien.rdoNam.Checked=true;
            addGiangVien.dtpNgaySinhGV.Value = DateTime.Now;
            addGiangVien.txtHocHam.Clear();
            addGiangVien.txtHocVi.Clear();
            addGiangVien.txtChuyenMon.Clear();
            addGiangVien.txtMSGV.Focus();
        }

        private void xoaDuLieuSuaXoa()
        {
            updateAndDeleteGiangVien.txtMSGV.Clear();
            updateAndDeleteGiangVien.txtHoLotGV.Clear();
            updateAndDeleteGiangVien.txtTenGV.Clear();
            updateAndDeleteGiangVien.rdoNam.Checked = true;
            updateAndDeleteGiangVien.dtpNgaySinhGV.Value = DateTime.Now;
            updateAndDeleteGiangVien.txtHocHam.Clear();
            updateAndDeleteGiangVien.txtHocVi.Clear();
            updateAndDeleteGiangVien.txtChuyenMon.Clear();
        }

        private bool ktNhapDuLieuSua()
        {
            return (updateAndDeleteGiangVien.txtMSGV.Text.Trim().Length == 0 ||
                updateAndDeleteGiangVien.txtHoLotGV.Text.Trim().Length == 0 ||
                updateAndDeleteGiangVien.txtTenGV.Text.Trim().Length == 0 ||
                updateAndDeleteGiangVien.txtHocHam.Text.Trim().Length == 0 ||
                updateAndDeleteGiangVien.txtHocVi.Text.Trim().Length == 0 ||
                updateAndDeleteGiangVien.txtChuyenMon.Text.Trim().Length == 0);
        }

        private void btnThemGiangVien_Click(object sender, EventArgs e)
        {
            HandleUI.showSidePanel(pnlDsGiangVien,pnlAddGiangVien);
            pnlAddGiangVien.Controls.Add(addGiangVien);
        }

        private void loadDataGirdView()
        {
            dgvGiangVien.Rows.Clear();
            var lstGiangVien= GiangVienBUS.selectAll();
            lstGiangVien.ForEach(gv =>
            {
                string gioiTinh = bool.Parse(gv.GioiTinh.ToString()) ? "Nam" : "Nữ";
                dgvGiangVien.Rows.Add(gv.MaGV, gv.HoLot, gv.Ten, gioiTinh, gv.NgaySinh.Value.ToShortTimeString(), gv.HocHam, gv.HocVi,gv.ChuyenMon,gv.MaKhoa);
            });
        }

        private void loadDataGirdView(List<GiangVien> listGV)
        {
            dgvGiangVien.Rows.Clear();
            listGV.ForEach(gv =>
            {
                string gioiTinh = bool.Parse(gv.GioiTinh.ToString()) ? "Nam" : "Nữ";
                dgvGiangVien.Rows.Add(gv.MaGV,gv.HoLot,gv.Ten,gioiTinh,gv.NgaySinh.Value.ToShortTimeString(),gv.HocHam,gv.HocVi,gv.ChuyenMon,gv.MaKhoa);
            });
        }

        private void btnLuuGV_Click(object sender, EventArgs e)
        {
            if (ktNhapDuLieu())
            {
                HandleUI.ThieuThongTin();
                return;
            }

            if (GiangVienBUS.selectByID(addGiangVien.txtMSGV.Text.Trim()) != null){
                HandleUI.MaDaTonTai("giảng viên");
                return;
            }

            GiangVien gv = new GiangVien
            {
                MaGV = addGiangVien.txtMSGV.Text.Trim(),
                HoLot = addGiangVien.txtHoLotGV.Text.Trim(),
                Ten = addGiangVien.txtTenGV.Text.Trim(),
                NgaySinh = addGiangVien.dtpNgaySinhGV.Value,
                GioiTinh = addGiangVien.rdoNam.Checked,
                HocHam = addGiangVien.txtHocHam.Text.Trim(),
                HocVi = addGiangVien.txtHocVi.Text.Trim(),
                ChuyenMon = addGiangVien.txtChuyenMon.Text.Trim(),
                MaKhoa = addGiangVien.cboKhoa.SelectedValue.ToString(),
            };
            bool kq = GiangVienBUS.insert(gv);
            loadDataGirdView();
            if (kq)
            {
                MessageBox.Show("Thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaDuLieuThem();
            }
            else
            {
                MessageBox.Show("Thêm giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) 
                return;
            indexGiangVien = e.RowIndex;
            var cell = dgvGiangVien.Rows[e.RowIndex].Cells;
            var magv = cell[clMSGV.Index].Value.ToString();

            updateAndDeleteGiangVien.txtMSGV.Text = cell[clMSGV.Index].Value.ToString();
            updateAndDeleteGiangVien.txtHoLotGV.Text = cell[clHoLot.Index].Value.ToString();
            updateAndDeleteGiangVien.txtTenGV.Text = cell[clTenGV.Index].Value.ToString();
            updateAndDeleteGiangVien.rdoNam.Checked = cell[clGioiTinh.Index].Value.ToString() == "Nam";
            updateAndDeleteGiangVien.rdoNu.Checked = cell[clGioiTinh.Index].Value.ToString() == "Nữ";
            updateAndDeleteGiangVien.dtpNgaySinhGV.Text = cell[clNgaySinh.Index].Value.ToString();
            updateAndDeleteGiangVien.txtHocHam.Text = cell[clHocHam.Index].Value.ToString();
            updateAndDeleteGiangVien.txtHocVi.Text = cell[clHocVi.Index].Value.ToString();
            updateAndDeleteGiangVien.txtChuyenMon.Text = cell[CLChuyenMon.Index].Value.ToString();
            //updateAndDeleteGiangVien.cboKhoa.SelectedValue = GiangVienBUS.selectByID(magv).MaKhoa;
            HandleUI.showSidePanel(pnlDsGiangVien, pnlAddGiangVien);
            pnlAddGiangVien.Controls.Add(updateAndDeleteGiangVien);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (indexGiangVien == -1)
            {
                HandleUI.chuaChon("Giảng viên","sửa");
                return;
            }
            if (ktNhapDuLieuSua())
            {
                HandleUI.ThieuThongTin();
                return;
            }
            string msgv = updateAndDeleteGiangVien.txtMSGV.Text;
            GiangVien gv = new GiangVien
            {
                MaGV = updateAndDeleteGiangVien.txtMSGV.Text.Trim(),
                HoLot = updateAndDeleteGiangVien.txtHoLotGV.Text.Trim(),
                Ten = updateAndDeleteGiangVien.txtTenGV.Text.Trim(),
                GioiTinh = updateAndDeleteGiangVien.rdoNam.Checked,
                NgaySinh = updateAndDeleteGiangVien.dtpNgaySinhGV.Value,
                HocHam = updateAndDeleteGiangVien.txtHocHam.Text.Trim(),
                HocVi = updateAndDeleteGiangVien.txtHocVi.Text.Trim(),
                ChuyenMon = updateAndDeleteGiangVien.txtChuyenMon.Text.Trim(),
                MaKhoa = updateAndDeleteGiangVien.cboKhoa.SelectedValue.ToString(),
            };

            bool kq = GiangVienBUS.update(msgv,gv);
            loadDataGirdView();
            indexGiangVien = -1;
            if (kq)
            {
                MessageBox.Show("Sửa giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaDuLieuSuaXoa();
                HandleUI.hideSidePanel(pnlDsGiangVien, pnlAddGiangVien);
            }
            else
            {
                MessageBox.Show("Sửa giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (indexGiangVien == -1)
            {
                HandleUI.chuaChon("Giảng viên", "xóa");
            }
            string msgv = dgvGiangVien.Rows[indexGiangVien].Cells[clMSGV.Index].Value.ToString();
            bool kq = GiangVienBUS.delete(msgv);
            loadDataGirdView();
            indexGiangVien = -1;
            if (kq)
            {
                MessageBox.Show("Xóa giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaDuLieuSuaXoa();
            }
            else
            {
                MessageBox.Show("Xóa giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiemGiangVien_Click(object sender, EventArgs e)
        {
            timKiemGiangVien();
        }

        private void txtTimKiemTenGiangVien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemTenGiangVien.Text.Length == 0)
                loadDataGirdView();
        }

        private void txtTimKiemTenGiangVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timKiemGiangVien();
        }

        private void timKiemGiangVien()
        {
            var listGiangVien = GiangVienBUS.selectByTenGV(txtTimKiemTenGiangVien.Text);
            if (listGiangVien.Count == 0)
            {
                GiangVien gv = GiangVienBUS.selectByID(txtTimKiemTenGiangVien.Text);
                listGiangVien.Add(gv);
                if (gv != null)
                    loadDataGirdView(listGiangVien);
                else
                    MessageBox.Show("Không tìm thấy giảng viên","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            loadDataGirdView(listGiangVien);
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {

        }
    }
}
