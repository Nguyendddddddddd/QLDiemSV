using BUS;
using DTO;
using GUI.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCapNhatDiemHocKy : Form
    {
        public FormCapNhatDiemHocKy()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            capNhatDiem();
        }

        private void FormCapNhatDiemHocKy_Load(object sender, EventArgs e)
        {
            LoadData.loadCombobox<HocKy>(cboHocKy, "TenKy", "MaHocKy", HocKyBUS.selectAll());
        }

        private void capNhatDiem()
        {
            string maHK = cboHocKy.SelectedValue.ToString();
            float diem =0;
            int tongsotc = 0;
            int kq = QLDiemSinhVien.getInstance().getTongSoTinChiSinhVien("2", "HKI2023-2024");
            MessageBox.Show(kq +"");
        }

    }
}
