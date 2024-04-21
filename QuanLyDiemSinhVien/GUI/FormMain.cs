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
            FKhoa fKhoa = new FKhoa();
            openChillForm(fKhoa);
        }
    }
}
