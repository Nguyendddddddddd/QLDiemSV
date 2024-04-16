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
        public FormMain()
        {
            InitializeComponent();
        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinhVien fSinhVien = new FormSinhVien();
            fSinhVien.MdiParent = this;
            fSinhVien.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhoa fKhoa= new FormKhoa();
            fKhoa.MdiParent = this;
            fKhoa.Show();
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
            FormKhoa fKhoa = new FormKhoa();
            openChillForm(fKhoa);
        }
    }
}
