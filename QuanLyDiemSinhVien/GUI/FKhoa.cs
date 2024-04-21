using BUS;
using DTO;
using GUI.MyControl;
using Guna.UI2.WinForms;
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
    public partial class FKhoa : Form
    {
        private UpdateAndDeleteKhoa updateAndDeleteKhoa;
        private AddKhoa addKhoa;

        private int indexDgvKhoa = -1;
        public FKhoa()
        {
            InitializeComponent();
            addKhoa = new AddKhoa(() => { loadDataGridView(); });
            updateAndDeleteKhoa = new UpdateAndDeleteKhoa();
            updateAndDeleteKhoa.btnXoa.Click += btnXoa_Click;
            updateAndDeleteKhoa.btnSua.Click += btnSua_Click;
            addKhoa.btnClose.Click += closepnlKhoa;
            updateAndDeleteKhoa.btnClose.Click += closepnlKhoa;
        }
        // các hàm load
        private void FKhoa_Load(object sender, EventArgs e)
        {
            loadDataGridView();
          
        }
        private void loadDataGridView()
        {
            dgvKhoa.Rows.Clear();
            KhoaBUS.selectAll().ForEach(k =>
            {
                dgvKhoa.Rows.Add(k.MaKhoa, k.TenKhoa);
            });
        }
        private void loadDataGridView(List<Khoa> Khoas)
        {
            dgvKhoa.Rows.Clear();
            Khoas.ForEach(k =>
            {
                dgvKhoa.Rows.Add(k.MaKhoa, k.TenKhoa);
            });
        }
        // các hàm sự kiện click
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (indexDgvKhoa == -1)
            {
                MessageBox.Show("Bạn chưa chọn khoa để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var maKhoa = dgvKhoa.Rows[indexDgvKhoa].Cells["clMaKhoa"].Value.ToString();
            KhoaBUS.delete(maKhoa);
            loadDataGridView();
            indexDgvKhoa = -1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = dgvKhoa.Rows[indexDgvKhoa].Cells["clMaKhoa"].Value.ToString();
            if (maKhoa.Trim() != updateAndDeleteKhoa.txtMaKhoa.Text.Trim())
            {
                MessageBox.Show("Không được sửa mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                updateAndDeleteKhoa.txtMaKhoa.Text = maKhoa;
                return;
            }
            Khoa k = new Khoa()
            {
                MaKhoa = updateAndDeleteKhoa.txtMaKhoa.Text,
                TenKhoa = updateAndDeleteKhoa.txtTenKhoa.Text,
            };
            KhoaBUS.update(k.MaKhoa, k);
            loadDataGridView();
        }
        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            changeSize();
            addKhoa.Anchor =  (AnchorStyles)(AnchorStyles.Right|AnchorStyles.Left);
            pnlAddKhoa.Controls.Add(addKhoa);
        }
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            indexDgvKhoa = e.RowIndex;
            changeSize();
            if (e.RowIndex == -1)
                return;
            pnlAddKhoa.Controls.Clear();
            pnlAddKhoa.Controls.Add(updateAndDeleteKhoa);

            var rowSelect = dgvKhoa.Rows[e.RowIndex];
            updateAndDeleteKhoa.txtMaKhoa.Text = rowSelect.Cells["clMaKhoa"].Value.ToString().Trim();
            updateAndDeleteKhoa.txtTenKhoa.Text = rowSelect.Cells["clTenKhoa"].Value.ToString().Trim();
        }
        // các hàm xử lý giao diện
       
        private void changeSize()
        {
            if (!pnlAddKhoa.Visible)
            {
                pnlNganh.Size = new Size(pnlNganh.Width - pnlAddKhoa.Width - 10, pnlNganh.Height);
                pnlDsKhoa.Size = new Size(pnlDsKhoa.Width - pnlAddKhoa.Width - 10, pnlDsKhoa.Height);
                pnlAddKhoa.Visible = true;
            }
        }
        private void closepnlKhoa(object sender, EventArgs e)
        {
            if (pnlAddKhoa.Visible)
            {
                pnlNganh.Size = new Size(pnlNganh.Width + pnlAddKhoa.Width + 10, pnlNganh.Height);
                pnlDsKhoa.Size = new Size(pnlDsKhoa.Width + pnlAddKhoa.Width + 10, pnlDsKhoa.Height);
                pnlAddKhoa.Visible = false;
                pnlAddKhoa.Controls.Clear();
            }
        }

        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            var kq = KhoaBUS.selectByTenKhoa(txtTimKiemTenKhoa.Text);
            if(kq.Count <= 0)
            {
                MessageBox.Show($"Không tim thấy khoa {txtTimKiemTenKhoa.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            loadDataGridView(kq);
        }

        
    }
}
