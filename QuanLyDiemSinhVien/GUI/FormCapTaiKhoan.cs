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
    public partial class FormCapTaiKhoan : Form
    {
        public TaiKhoang taiKhoang;
        public SinhVien sinhVien;
        public GiangVien giangVien;
        public FormCapTaiKhoan()
        {
            InitializeComponent();
            LoadData.loadCombobox<Quyen>(cboLoaiTK, "TenQuyen", "MaQuyen", QLDiemSinhVien.getInstance().Quyens.ToList());;
        }

       public void xoaDuLieu()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMK.Clear();
            txtTenDangNhap.Focus();
            ckbHienMK.Checked = false;
            if (cboLoaiTK.SelectedValue.ToString().Trim() == "SV")
                LoadData.loadCombobox<SinhVien>(cboDanhSach, "MSSV", "MSSV", CapTaiKhoanBUS.selectByTenDangNhapSVRong());
            if (cboLoaiTK.SelectedValue.ToString().Trim() == "GV")
                LoadData.loadCombobox<GiangVien>(cboDanhSach, "MaGV", "MaGV", CapTaiKhoanBUS.selectByTenDangNhapGVRong());
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim()==""||txtMatKhau.Text.Trim()==""||txtNhapLaiMK.Text.Trim() =="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhau.Text.Trim() != txtNhapLaiMK.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không khớp","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            taiKhoang = new TaiKhoang()
            {
                TenDangNhap = txtTenDangNhap.Text.Trim(),
                MatKhau = txtNhapLaiMK.Text.Trim(),
                MaQuyen = cboLoaiTK.SelectedValue.ToString(),
            };
            bool kq = CapTaiKhoanBUS.insert(taiKhoang);

            if (cboLoaiTK.SelectedValue.ToString().Trim() == "SV")
                CapTaiKhoanBUS.updateTaiKhoanSV(cboDanhSach.SelectedValue.ToString().Trim(), txtTenDangNhap.Text.Trim());

            if (cboLoaiTK.SelectedValue.ToString().Trim() == "GV")
                CapTaiKhoanBUS.updateTaiKhoanGV(cboDanhSach.SelectedValue.ToString().Trim(), txtTenDangNhap.Text.Trim());

            if (kq)
            {
                MessageBox.Show("Cấp tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                xoaDuLieu();
            }
            else
                MessageBox.Show("Cấp tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);    
        }

        private void ckbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtNhapLaiMK.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNhapLaiMK.PasswordChar = '*';
            }   
        }

        private void cboLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiTK.SelectedValue.ToString().Trim() == "SV")
                LoadData.loadCombobox<SinhVien>(cboDanhSach, "MSSV", "MSSV", CapTaiKhoanBUS.selectByTenDangNhapSVRong());
        
            if (cboLoaiTK.SelectedValue.ToString().Trim() == "GV")
                LoadData.loadCombobox<GiangVien>(cboDanhSach, "MaGV", "MaGV", CapTaiKhoanBUS.selectByTenDangNhapGVRong());

            if(cboLoaiTK.SelectedValue.ToString().Trim() == "QT")
            {
                List<string> lstRong = new List<string>();
                LoadData.loadCombobox<string>(cboDanhSach, "", "", lstRong);
            }
        }
    }
}
