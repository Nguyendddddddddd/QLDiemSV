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
    public partial class FormMain : Form
    {
        private Form formHienTai;
        private FKhoa fKhoa;
        private FormSinhVien fSinhVien;
        private FormLop fLop;
        private FormMonHoc fMonHoc;
        private FormLopTinChi fLopMonHoc;
        private FormHocKy fHocKy;

        public FormMain()
        {
            InitializeComponent();
        }
        private void openChillForm(Form chillForm)
        {
            if (formHienTai != null)
            {
                formHienTai.Hide();
            }
            formHienTai = chillForm;
            chillForm.TopLevel = false;
            chillForm.FormBorderStyle = FormBorderStyle.None;
            chillForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(chillForm);
            pnlMain.Tag = chillForm;
            pnlMain.BringToFront();
            chillForm.Show();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            fKhoa = new FKhoa();
            fSinhVien = new FormSinhVien();
            fLop = new FormLop();
            fMonHoc = new FormMonHoc();
            fLopMonHoc = new FormLopTinChi();
            fHocKy = new FormHocKy();
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            openChillForm(fSinhVien);
        }
        private void btnKhoaNganh_Click(object sender, EventArgs e)
        {
            openChillForm(fKhoa);
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            openChillForm(fLop);
        }
        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            openChillForm(fMonHoc);
        }

        private void btnLopMonHoc_Click(object sender, EventArgs e)
        {
            openChillForm(fLopMonHoc);
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            openChillForm(fHocKy);
        }
    }
}
