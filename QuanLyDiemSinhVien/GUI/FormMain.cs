using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
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
        private FormGiangVien fGiangVien;
        private FormDiemHocKy fDiemHocKy;
        private FormBCDanhSachSinhVien fBCSinhVien;
        private static FormMain instance;
        private FormCapTaiKhoan fCapTaiKhoang;
        private FormMain()
        {
            InitializeComponent();
        }
        public static FormMain getInstance()
        {
            if (instance == null)
                instance = new FormMain();
            return instance;
        }
        public void openChillForm(Form chillForm)
        {
            if (formHienTai != null)
            {
                formHienTai.Close();
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
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            fSinhVien = new FormSinhVien();
            openChillForm(fSinhVien);
        }
        private void btnKhoaNganh_Click(object sender, EventArgs e)
        {
            fKhoa = new FKhoa();
            openChillForm(fKhoa);
        }
        private void btnLop_Click(object sender, EventArgs e)
        {
            fLop = new FormLop();
            openChillForm(fLop);
        }
        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            fMonHoc = new FormMonHoc();
            openChillForm(fMonHoc);
        }

        private void btnLopMonHoc_Click(object sender, EventArgs e)
        {
            fLopMonHoc = new FormLopTinChi();
            openChillForm(fLopMonHoc);
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            fHocKy = new FormHocKy();
            openChillForm(fHocKy);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            fGiangVien = new FormGiangVien();
            openChillForm(fGiangVien);
        }

        private void btnDiemHocKy_Click(object sender, EventArgs e)
        {
            fDiemHocKy = new FormDiemHocKy();
            openChillForm(fDiemHocKy);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            fBCSinhVien = new FormBCDanhSachSinhVien();
            openChillForm(fBCSinhVien);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCapTaiKhoang_Click(object sender, EventArgs e)
        {
            fCapTaiKhoang = new FormCapTaiKhoan();
            openChillForm(fCapTaiKhoang);
        }

       
    }
}
