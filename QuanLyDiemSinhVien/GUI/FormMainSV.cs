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
    public partial class FormMainSV : Form
    {
        string mssv;
        public FormMainSV(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
            lbHoTen.Text ="Xin chào "+SinhVienBUS.selectByID(mssv).FullName;
        }
        private Form formHienTai;
        private FormXemDiemSinhVien formXemDiem;
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

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            formXemDiem = new FormXemDiemSinhVien(mssv);
            openChillForm(formXemDiem);
        }
    }
}
