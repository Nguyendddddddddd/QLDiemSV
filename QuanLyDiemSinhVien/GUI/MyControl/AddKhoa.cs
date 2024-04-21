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

namespace GUI.MyControl
{
    public partial class AddKhoa : UserControl
    {
        private Action reload;
        public AddKhoa()
        {
            InitializeComponent();
        }
        public AddKhoa(Action reload)
        {
            InitializeComponent();
            this.reload = reload;
        }
        private void clearTextBox()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaKhoa.Text.Trim().Length == 0 || txtTenKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (KhoaBUS.selectByID(txtMaKhoa.Text)!=null) {
                MessageBox.Show("Mã khoa đã tồn tại hãy nhập mã khoa khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Khoa k = new Khoa()
            {
                MaKhoa = txtMaKhoa.Text,
                TenKhoa = txtTenKhoa.Text,
            };
            KhoaBUS.insert(k);
            reload();
            clearTextBox();
        }
    }
}
