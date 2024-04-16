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
using System.Windows.Forms.Design;

namespace GUI
{
    public partial class FormKhoa : Form
    {
        private int indexDgvKhoa = -1;
        public FormKhoa()
        {
            InitializeComponent();
        }
        private void loadDataGridView()
        {
            dgvKhoa.Rows.Clear();
            KhoaBUS.selectAll().ForEach(k =>
            {
                dgvKhoa.Rows.Add(k.MaKhoa, k.TenKhoa);
            });
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Khoa k = new Khoa() 
            {
                MaKhoa  = txtMaKhoa.Text,
                TenKhoa = txtTenKhoa.Text,
            };
            KhoaBUS.insert(k);
            loadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(indexDgvKhoa == -1)
            {
                MessageBox.Show("Bạn chưa chọn khoa để xóa","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var maKhoa = dgvKhoa.Rows[indexDgvKhoa].Cells["clMaKhoa"].Value.ToString();
            KhoaBUS.delete(maKhoa);
            loadDataGridView();
            indexDgvKhoa = -1;
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexDgvKhoa = e.RowIndex;
            var rowSelected = dgvKhoa.Rows[indexDgvKhoa];
            txtMaKhoa.Text = rowSelected.Cells["clMaKhoa"].Value.ToString();
            txtTenKhoa.Text = rowSelected.Cells["clTenKhoa"].Value.ToString();
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = dgvKhoa.Rows[indexDgvKhoa].Cells["clMaKhoa"].Value.ToString();
            if(maKhoa != txtMaKhoa.Text) {
                MessageBox.Show("Không được sửa mã khoa", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMaKhoa.Text = maKhoa;
                return;
            }
            Khoa k = new Khoa()
            {
                MaKhoa = txtMaKhoa.Text,
                TenKhoa = txtTenKhoa.Text,
            };
            KhoaBUS.update(k.MaKhoa,k);
            loadDataGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
