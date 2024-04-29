using BUS;
using DTO;
using GUI.UI;
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
    public partial class FormHocKy : Form
    {
        private int indexDgvHocKy = -1;
        public FormHocKy()
        {
            InitializeComponent();
        }
        private void loadDataGridViewHocKy()
        {
            dgvHocKy.Rows.Clear();
            HocKyBUS.selectAll().ForEach(hk =>
            {
                dgvHocKy.Rows.Add(hk.MaHocKy, hk.TenKy, hk.NamHoc);
            });
        }
        private string xuLyMaHK(string str)
        {
            string[] chuoiTach = str.Split(' ');
            string maHK = "";

            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                    maHK += chuoiTach[i];
                else
                    maHK += chuoiTach[i][0];

            }
            return maHK;
        }

        private int phanTachTenHK(string str)
        {
            string[] strTach = str.Split(' ');
            return strTach[2].Length - 1;
        }
        private void loadNamHoc()
        {
            int nowYear = DateTime.Now.Year;

            string NamHoc = "";
            for (int i = 2010; i <= nowYear; i++)
            {
                NamHoc = $"{i - 1}-{i}";
                cboNamHoc.Items.Add(NamHoc);
            }
            cboNamHoc.SelectedItem = NamHoc;
        }
        private void FormHocKy_Load(object sender, EventArgs e)
        {
            loadNamHoc();
            loadDataGridViewHocKy();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string hocKy = xuLyMaHK(cboKy.SelectedItem.ToString().ToUpper());
            string NamHoc = cboNamHoc.SelectedItem.ToString();
            string maKy = hocKy + NamHoc;
            HocKy hk = new HocKy
            {
                MaHocKy = maKy,
                TenKy = cboKy.SelectedItem.ToString() + " năm học " + NamHoc,
                NamHoc = NamHoc
            };
            if (HocKyBUS.selectByID(hk.MaHocKy) != null)
            {
                MessageBox.Show("Học kỳ đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool kq = HocKyBUS.insert(hk);
            loadDataGridViewHocKy();
            MessageBox.Show(kq ? "Thêm học kỳ thành công" : "Thêm học kỳ không thành công", "Thông báo");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(indexDgvHocKy == -1)
            {
                HandleUI.chuaChon("học kỳ", "xóa");
                return;
            }
            string mahk = dgvHocKy.Rows[indexDgvHocKy].Cells[clMaHK.Index].Value.ToString();
            bool kq = HocKyBUS.delete(mahk);
            loadDataGridViewHocKy();
            MessageBox.Show(kq ? "Xóa học kỳ thành công" : "Xóa học kỳ không thành công", "Thông báo");
            indexDgvHocKy = -1;
        }

        private void dgvHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            indexDgvHocKy = e.RowIndex;
            var rowSelect = dgvHocKy.Rows[e.RowIndex].Cells;
            string tenHK = rowSelect[clTenHocKy.Index].Value.ToString();
            string namHoc = rowSelect[clNamHoc.Index].Value.ToString();
            cboKy.SelectedIndex = phanTachTenHK(tenHK);
            cboNamHoc.SelectedItem = namHoc;
            indexDgvHocKy = e.RowIndex;
        }
    }
}
