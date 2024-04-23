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
        public List<TaiKhoang> list;

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
            string quyen;
            quyen = list[0].MaQuyen;

            if (quyen == "QT")
            {
                khoiTaoFormMain();
            }
            else if (quyen == "GV")
            {
                khoiTaoFormMain();
            }
            else
            {
                khoiTaoFormMain();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            list = new List<TaiKhoang>();
            list = DangNhapBUS.selectByDangNhap(txtTenDangNhap.Text);
            if (list.Count > 0)
                hienThiMenu();
            else
                MessageBox.Show("Tài khoản không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
