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
            updateAndDeleteKhoa.btnXoa.Click += btnXoa_Click;
            updateAndDeleteKhoa.btnSua.Click += btnSua_Click;
            addKhoa.btnClose.Click += closepnlKhoa;
            updateAndDeleteKhoa.btnClose.Click += closepnlKhoa;
            updateAndDeleteNganh.btnClose.Click += closepnlKhoa;
            addNganh.btnClose.Click += closepnlKhoa;


            addNganh.btnLuu.Click += btnLuuNganh_Click;

            updateAndDeleteNganh.btnSua.Click += btnSuaNganh_click;
            updateAndDeleteNganh.btnXoa.Click += btnXoaNganh_click;



        }
        // các hàm load
        private void FKhoa_Load(object sender, EventArgs e)
        {
            loadDataGridViewKhoa();
            loadDataGridViewNganh();
            loadComboboxKhoa(addNganh.cboTenKhoa, KhoaBUS.selectAll());
            loadComboboxKhoa(updateAndDeleteNganh.cboTenKhoa, KhoaBUS.selectAll());
          
        }
        private void loadDataGridViewKhoa()
        {
            dgvKhoa.Rows.Clear();
            KhoaBUS.selectAll().ForEach(k =>
            {
                dgvKhoa.Rows.Add(k.MaKhoa, k.TenKhoa);
            });
        }
        private void loadComboboxKhoa(Guna2ComboBox cbo,List<Khoa> Khoas)
        {
            cbo.DataSource = Khoas;
            cbo.ValueMember = "MaKhoa";
            cbo.DisplayMember= "TenKhoa";
        }
        private void loadDataGridViewNganh()
        {
            dgvNganh.Rows.Clear();
            NganhBUS.selectAll().ForEach(n =>
            {
               dgvNganh.Rows.Add(n.MaNganh,n.TenNganh,n.Khoa.TenKhoa);
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
            addKhoa.Anchor =  (AnchorStyles)(AnchorStyles.Right|AnchorStyles.Left);
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
            var kq = KhoaBUS.selectByTenKhoa(txtTimKiemTenKhoa.Text);
            if (kq.Count <= 0)
            {
                MessageBox.Show($"Không tim thấy khoa {txtTimKiemTenKhoa.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            loadDataGridView(kq);
        }
        
        private void btnLuuNganh_Click(object sender, EventArgs e)
        {
            if(addNganh.txtMaNganh.Text.Trim().Length == 0 || addNganh.txtTenNganh.Text.Trim().Length == 0)
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

            addNganh.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Left);
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
    }
}
