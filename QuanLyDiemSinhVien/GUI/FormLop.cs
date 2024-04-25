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
    public partial class FormLop : Form
    {
        private AddLop addLop;
        private UpdateAndDeleteLop updateAndDeleteLop;
        private int indexDgvLop = -1;
        public FormLop()
        {
            InitializeComponent();
            addLop = new AddLop();
            addLop.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsLop, pnlAddLop); };
            addLop.btnLuu.Click += btnLuuLop_Click;
            addLop.cboKhoa.SelectedValueChanged += addLopCboKhoa_SelectedIndexChanged;
            updateAndDeleteLop = new UpdateAndDeleteLop();
            updateAndDeleteLop.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsLop, pnlAddLop); };
            updateAndDeleteLop.btnXoa.Click += addLopBtnXoa_Click;
            updateAndDeleteLop.btnSua.Click += addLopBtnSua_Click;
            updateAndDeleteLop.cboKhoa.SelectedValueChanged += updateAndDeleteLopCboKhoa_SelectedIndexChanged;



        }
        public void loadDataGridViewLop()
        {
            dgvLop.Rows.Clear();
            LopBUS.selectAll().ForEach(l =>
            {
                dgvLop.Rows.Add(l.MaLop,l.Nganh.TenNganh,l.GiangVien.FullName,l.SinhViens.Count);
            });
        }
        public void addLopCboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox cbo = sender as Guna2ComboBox;
            changeSelectedNganhFromKhoa(cbo.SelectedValue.ToString(), addLop.cboNganh);
        }
        public void updateAndDeleteLopCboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox cbo = sender as Guna2ComboBox;
            changeSelectedNganhFromKhoa(cbo.SelectedValue.ToString(), updateAndDeleteLop.cboNganh);
        }
        public void addLopBtnXoa_Click(object sender, EventArgs e)
        {
            if (indexDgvLop == -1)
            {
                HandleUI.chuaChon("Lớp", "xóa");
            }
            string maLop = dgvLop.Rows[indexDgvLop].Cells[clMaLop.Index].Value.ToString();
            bool kq = SinhVienBUS.delete(maLop);
            loadDataGridViewLop();
            indexDgvLop = -1;
            MessageBox.Show(kq ? "Xóa lớp thành công" : "Xóa lớp không thành công", "Thông báo");
        }
        public void addLopBtnSua_Click(object sender, EventArgs e)
        {
            if (indexDgvLop == -1)
            {
                HandleUI.chuaChon("Lớp", "sửa");
            }
            string maLop = updateAndDeleteLop.txtMaLop.Text;

            Lop l = new Lop()
            {
                MaGV = updateAndDeleteLop.cboGiangVien.SelectedValue.ToString(),
                MaNganh = updateAndDeleteLop.cboNganh.SelectedValue.ToString(),
            };
            bool kq = LopBUS.update(maLop, l) ;
            loadDataGridViewLop();
            indexDgvLop = -1;
            MessageBox.Show(kq ? "Sửa lớp thành công" : "Sửa lớp không thành công", "Thông báo");
        }
        public void changeSelectedNganhFromKhoa(string maKhoa,Guna2ComboBox cbo)
        {
            cbo.DataSource = NganhBUS.selectByIDKhoa(maKhoa);
            cbo.DisplayMember = "TenNganh";
            cbo.ValueMember = "MaNganh";
        }
        private void btnLuuLop_Click(object sender, EventArgs e)
        {
            if (addLop.txtMaLop.Text.Trim().Length == 0)
            {
                HandleUI.ThieuThongTin();
                return;
            }
            if (LopBUS.selectByID(addLop.txtMaLop.Text) != null)
            {
                HandleUI.MaDaTonTai("Lớp");
                return;
            }
            Lop l = new Lop()
            {
                MaLop = addLop.txtMaLop.Text,
                TenLop = addLop.txtMaLop.Text,
                MaGV = addLop.cboGiangVien.SelectedValue.ToString(),
                MaNganh = addLop.cboNganh.SelectedValue.ToString(),
            };
            bool kq = LopBUS.insert(l);
            MessageBox.Show(kq ? "Thêm lớp thành công" : "Thêm lớp thất bại", "Thông báo");
            loadDataGridViewLop();
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {
            HandleUI.showSidePanel(pnlDsLop, pnlAddLop);
            pnlAddLop.Controls.Add(addLop);
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            indexDgvLop = e.RowIndex;
            HandleUI.showSidePanel(pnlDsLop, pnlAddLop);
            pnlAddLop.Controls.Add(updateAndDeleteLop);
            var rowSelect = dgvLop.Rows[indexDgvLop].Cells;
            var maLop = updateAndDeleteLop.txtMaLop.Text = rowSelect[clMaLop.Index].Value.ToString();
            updateAndDeleteLop.cboGiangVien.SelectedValue = LopBUS.selectByID(maLop).GiangVien.MaGV;
            updateAndDeleteLop.cboNganh.SelectedValue = LopBUS.selectByID(maLop).Nganh.MaNganh;
            updateAndDeleteLop.cboKhoa.SelectedValue = LopBUS.selectByID(maLop).Nganh.Khoa.MaKhoa;

        }
        private void FormLop_Load(object sender, EventArgs e)
        {
            loadDataGridViewLop();
            LoadData.loadCombobox<Khoa>(updateAndDeleteLop.cboKhoa, "TenKhoa", "MaKhoa", KhoaBUS.selectAll());
            LoadData.loadCombobox<Khoa>(addLop.cboKhoa, "TenKhoa", "MaKhoa", KhoaBUS.selectAll());
            LoadData.loadCombobox<GiangVien>(addLop.cboGiangVien, "FullName", "MaGV", GiangVienBUS.selectAll());
            LoadData.loadCombobox<GiangVien>(updateAndDeleteLop.cboGiangVien, "FullName", "MaGV", GiangVienBUS.selectAll());

        }
    }
}
