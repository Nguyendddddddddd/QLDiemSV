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
    public partial class FormDanhSachSVTrongLop : Form
    {
        public string maLop;
        public FormDanhSachSVTrongLop()
        {
            InitializeComponent();
        }

        private void FormDanhSachSVTrongLop_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            LopTinChi ltc = LopTinChiBUS.selectAll().Where(l => l.MaLop.Trim() == maLop.Trim()).FirstOrDefault();
            ltc.SinhViens.ToList().ForEach(l =>
            {
                dgvDSLop.Rows.Add(l.MSSV,l.HoLot,l.Ten,l.NgaySinh,l.GioiTinh.Value?"Nam":"Nữ",l.MaLop);
            });
        }
    }
}
