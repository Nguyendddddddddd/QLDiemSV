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
            formMain = new FormMain();
            formMain.ShowDialog();
            formMain = null;
            this.Dispose();
        }

        public void hienThiMenu()
        {
            string quyen = taiKhoang.MaQuyen.Trim();
            switch (quyen)
            {
                case "QT":
                    MessageBox.Show("Tài khoản quản trị");
                    break;
                case "GV":
                    MessageBox.Show("Tài khoản giáo viên");
                    break;
                case "SV":
                    MessageBox.Show("Tài khoản sinh viên");
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
