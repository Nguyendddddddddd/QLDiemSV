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
    public partial class FormMainGV : Form
    {
        GiangVien gv;
        Form formHienTai;
        public FormMainGV(GiangVien gv)
        {
            InitializeComponent();
            this.gv = gv;
        }

        private void btnXemLop_Click(object sender, EventArgs e)
        {
            FormGiangVienXemDSLop formGiangVienXemDSLop = new FormGiangVienXemDSLop();
            formGiangVienXemDSLop.giangVien = gv;
            openChillForm(formGiangVienXemDSLop);

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

    }
}
