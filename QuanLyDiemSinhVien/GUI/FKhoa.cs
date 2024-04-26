using BUS;
using DTO;
using GUI.MyControl;
using GUI.UI;
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
        private AddNganh addNganh;
        private UodateAndDeleteNganh updateAndDeleteNganh;

        private int indexDgvKhoa = -1;
        private int indexDgvNganh = -1;
        public FKhoa()
        {
            InitializeComponent();
            addKhoa = new AddKhoa(() => { loadDataGridViewKhoa(); });
            updateAndDeleteKhoa = new UpdateAndDeleteKhoa();

            updateAndDeleteNganh = new UodateAndDeleteNganh();
            addNganh = new AddNganh();

            addKhoa.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            addNganh.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);


            updateAndDeleteKhoa.btnXoa.Click += btnXoa_Click;
            updateAndDeleteKhoa.btnSua.Click += btnSua_Click;
            updateAndDeleteKhoa.btnClose.Click += closepnlKhoa;

            addKhoa.btnClose.Click += closepnlKhoa;

            addNganh.btnClose.Click += closepnlKhoa;
            addNganh.btnLuu.Click += btnLuuNganh_Click;

            updateAndDeleteNganh.btnClose.Click += closepnlKhoa;
            updateAndDeleteNganh.btnSua.Click += btnSuaNganh_click;
            updateAndDeleteNganh.btnXoa.Click += btnXoaNganh_click;

            loadDataGridViewKhoa();
            loadDataGridViewNganh();
            LoadData.loadCombobox<Khoa>(addNganh.cboTenKhoa, "TenKhoa", "MaKhoa", KhoaBUS.selectAll());
            LoadData.loadCombobox<Khoa>(updateAndDeleteNganh.cboTenKhoa, "TenKhoa", "MaKhoa", KhoaBUS.selectAll());
        }
        // các hàm load
        private void FKhoa_Load(object sender, EventArgs e)
        {

        }
        private void loadDataGridViewKhoa()
        {
            dgvKhoa.Rows.Clear();
            KhoaBUS.selectAll().ForEach(k =>
            {
                dgvKhoa.Rows.Add(k.MaKhoa, k.TenKhoa);
            });
        }
        private void loadDataGridViewKhoa(List<Khoa> lstKhoa)
        {
            dgvKhoa.Rows.Clear();
            lstKhoa.ForEach(k =>
            {
                dgvKhoa.Rows.Add(k.MaKhoa, k.TenKhoa);
            });
        }
        private void loadDataGridViewNganh()
        {
            dgvNganh.Rows.Clear();
            NganhBUS.selectAll().ForEach(n =>
            {
                dgvNganh.Rows.Add(n.MaNganh, n.TenNganh, n.Khoa.TenKhoa);
            });
        }
        private void loadDataGridViewNganh(List<Nganh> lstNganh)
        {
            dgvNganh.Rows.Clear();
            lstNganh.ForEach(n =>
            {
                dgvNganh.Rows.Add(n.MaNganh, n.TenNganh, n.Khoa.TenKhoa);
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
            loadDataGridViewKhoa();
            indexDgvKhoa = -1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (indexDgvKhoa == -1)
            {
                MessageBox.Show("Bạn chưa chọn khoa để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            loadDataGridViewKhoa();
            indexDgvKhoa = -1;
        }
        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            changeSize();
            pnlAddKhoa.Controls.Add(addKhoa);
        }
        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indexDgvKhoa = e.RowIndex;
            changeSize();
            if (e.RowIndex == -1)
                return;
            pnlAddKhoa.Controls.Add(updateAndDeleteKhoa);

            var rowSelect = dgvKhoa.Rows[e.RowIndex];
            updateAndDeleteKhoa.txtMaKhoa.Text = rowSelect.Cells["clMaKhoa"].Value.ToString().Trim();
            updateAndDeleteKhoa.txtTenKhoa.Text = rowSelect.Cells["clTenKhoa"].Value.ToString().Trim();
        }
        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            timKiemKhoa();
        }

        private void btnLuuNganh_Click(object sender, EventArgs e)
        {
            if (addNganh.txtMaNganh.Text.Trim().Length == 0 || addNganh.txtTenNganh.Text.Trim().Length == 0)
            {
                MessageBox.Show($"Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (NganhBUS.selectByID(addNganh.txtMaNganh.Text) != null)
            {
                MessageBox.Show("Mã nganh đã tồn tại hãy nhập mã khoa khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Nganh n = new Nganh()
            {
                MaNganh = addNganh.txtMaNganh.Text,
                TenNganh = addNganh.txtTenNganh.Text,
                MaKhoa = addNganh.cboTenKhoa.SelectedValue.ToString(),
            };
            NganhBUS.insert(n);
            loadDataGridViewNganh();
        }
        private void btnSuaNganh_click(object sender, EventArgs e)
        {
            if (indexDgvNganh == -1)
            {
                MessageBox.Show("Bạn chưa chọn ngành để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maNganh = dgvNganh.Rows[indexDgvNganh].Cells["clMaNganh"].Value.ToString();
            if (maNganh.Trim() != updateAndDeleteNganh.txtMaNganh.Text.Trim())
            {
                MessageBox.Show("Không được sửa mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                updateAndDeleteKhoa.txtMaKhoa.Text = maNganh;
                return;
            }
            Nganh n = new Nganh()
            {
                MaNganh = updateAndDeleteNganh.txtMaNganh.Text,
                TenNganh = updateAndDeleteNganh.txtTenNganh.Text,
                MaKhoa = updateAndDeleteNganh.cboTenKhoa.SelectedValue.ToString(),

            };
            NganhBUS.update(maNganh, n);
            indexDgvNganh = -1;
            loadDataGridViewNganh();
        }
        private void btnXoaNganh_click(object sender, EventArgs e)
        {
            if (indexDgvNganh == -1)
            {
                MessageBox.Show("Bạn chưa chọn ngành để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var maNganh = dgvNganh.Rows[indexDgvNganh].Cells["clMaNganh"].Value.ToString();
            NganhBUS.delete(maNganh);
            loadDataGridViewNganh();
            indexDgvNganh = -1;
        }
        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            changeSize();
            pnlAddKhoa.Controls.Add(addNganh);
        }
        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexDgvNganh = e.RowIndex;
            changeSize();
            if (e.RowIndex == -1)
                return;
            pnlAddKhoa.Controls.Add(updateAndDeleteNganh);
            var rowSelect = dgvNganh.Rows[indexDgvNganh];
            var maNganh = updateAndDeleteNganh.txtMaNganh.Text = rowSelect.Cells["clMaNganh"].Value.ToString();
            updateAndDeleteNganh.txtTenNganh.Text = rowSelect.Cells["clTenNganh"].Value.ToString();
            updateAndDeleteNganh.cboTenKhoa.SelectedValue = NganhBUS.selectByID(maNganh).Khoa.MaKhoa;


        }
        private void txtTimKiemTenKhoa_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemTenKhoa.Text.Length == 0)
                loadDataGridViewKhoa();
        }

        private void txtTimKiemTenKhoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timKiemKhoa();
        }

        private void txtTimKiemNganh_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiemNganh.Text.Length == 0)
                loadDataGridViewNganh();
        }

        private void txtTimKiemNganh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timKiemNganh();
        }

        private void btnTimKiemNganh_Click(object sender, EventArgs e)
        {
            timKiemNganh();
        }
        // các hàm xử lý giao diện
        private void changeSize()
        {
            pnlAddKhoa.Controls.Clear();
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
        // các hàm tìm kiếm
        private void timKiemKhoa()
        {
            var lstKhoa = KhoaBUS.selectByTenKhoa(txtTimKiemTenKhoa.Text);
            if (lstKhoa.Count == 0)
            {
                Khoa k = KhoaBUS.selectByID(txtTimKiemTenKhoa.Text);
                lstKhoa.Add(k);
                if (k != null)
                {
                    loadDataGridViewKhoa(lstKhoa);
                }
                else
                {
                    MessageBox.Show($"Không tim thấy khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            loadDataGridViewKhoa(lstKhoa);
        }
        private void timKiemNganh()
        {
            var lstNganh = NganhBUS.selectByTenNganh(txtTimKiemNganh.Text);
            if (lstNganh.Count == 0)
            {
                Nganh n = NganhBUS.selectByID(txtTimKiemNganh.Text);
                lstNganh.Add(n);
                if (n != null)
                {
                    loadDataGridViewNganh(lstNganh);
                }
                else
                {
                    MessageBox.Show($"Không tim thấy ngành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            loadDataGridViewNganh(lstNganh);
        }

    }
}
