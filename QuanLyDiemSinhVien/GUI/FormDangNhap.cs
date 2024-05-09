using BUS;
using DTO;
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
    public partial class FormDangNhap : Form
    {
        public FormMain formMain;
        public TaiKhoang taiKhoang;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        public void khoiTaoFormMain()
        {
            this.Hide();
            formMain = FormMain.getInstance();
            formMain.ShowDialog();
            formMain = null;
            this.Dispose();
        }
        public void khoiTaoFormMainGV()
        {
            this.Hide();
            GiangVien giangVien = taiKhoang.GiangViens.ToList().First();

            FormMainGV formMainGV = new FormMainGV(giangVien);
            formMainGV.ShowDialog();
            formMainGV = null;
            this.Dispose();
        }
        public void khoiTaoFormMainSV()
        {
            this.Hide();
            SinhVien sv = taiKhoang.SinhViens.ToList().First();
            FormMainSV formMainSV = new FormMainSV(sv.MSSV);
            formMainSV.ShowDialog();
            formMainSV = null;
            this.Dispose();
        }
        public void hienThiMenu()
        {
            string quyen = taiKhoang.MaQuyen.Trim();
            switch (quyen)
            {
                case "QT":
                        khoiTaoFormMain();
                        break;
                case "GV":
                    khoiTaoFormMainGV();
                    break;
                case "SV":
                    khoiTaoFormMainSV();
                    break;
                default:
                    break;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            taiKhoang = new TaiKhoang()
            {
                TenDangNhap = txtTenDangNhap.Text,
                MatKhau = txtMatKhau.Text,
            };
            taiKhoang = DangNhapBUS.selectByDangNhap(taiKhoang);
            if (taiKhoang != null)
                hienThiMenu();
            else
                MessageBox.Show("Tài khoản không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ckbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMK.Checked)
                txtMatKhau.PasswordChar = '\0';
            else
                txtMatKhau.PasswordChar = '*';
        }
    }
}
