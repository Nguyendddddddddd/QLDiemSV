using BUS;
using DTO;
using GUI.MyControl;
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
    public partial class FormXemDiemSinhVien : Form
    {
        string mssv;
        public FormXemDiemSinhVien(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;   
        }

        private void FormXemDiemSinhVien_Load(object sender, EventArgs e)
        {
            var sv = SinhVienBUS.selectByID(mssv);
            sv.DiemHocKies.ToList().ForEach(d => {
                flowDiem.Controls.Add(new DiemMon(d.MaHocKy, sv.MSSV));
            });
        }

        private void flowDiem_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
