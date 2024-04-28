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
        public FormCapTaiKhoan()
        {
            InitializeComponent();
            LoadData.loadCombobox<Quyen>(cboLoaiTK, "TenQuyen", "MaQuyen", QLDiemSinhVien.getInstance().Quyens.ToList());
        }

       public void xoaDuLieu()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtNhapLaiMK.Clear();
            txtTenDangNhap.Focus();
            ckbHienMK.Checked = false;
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text==""||txtMatKhau.Text==""||txtNhapLaiMK.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhau.Text != txtNhapLaiMK.Text)
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
    }
}
