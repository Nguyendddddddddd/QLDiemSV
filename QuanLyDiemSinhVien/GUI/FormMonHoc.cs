using BUS;
using DTO;
using GUI.MyControl;
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
    public partial class FormMonHoc : Form
    {
        private AddMonHoc addMonHoc;
        private UpdateAndDeleteMonHoc updateAndDeleteMonHoc;
        private int indexDgvMonHoc = -1;
        public FormMonHoc()
        {
            InitializeComponent();
            addMonHoc = new AddMonHoc();
            updateAndDeleteMonHoc = new UpdateAndDeleteMonHoc();
            addMonHoc.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsMonHoc, pnlAddMonHoc); };
            updateAndDeleteMonHoc.btnClose.Click += (object sender, EventArgs e) => { HandleUI.hideSidePanel(pnlDsMonHoc, pnlAddMonHoc); };
            addMonHoc.btnLuu.Click += addMonHocBtnLuu_Click;
            updateAndDeleteMonHoc.btnSua.Click += updateAndDeleteMonHocBtnSua_Click;
            updateAndDeleteMonHoc.btnXoa.Click += updateAndDeleteMonHocBtnXoa_Click;


        }
        //các hàm load
        private void loadDataGridViewMonHoc()
        {
            dgvMonHoc.Rows.Clear();
            MonHocBUS.selectAll().ForEach(mh =>
            {
                dgvMonHoc.Rows.Add(mh.MaMon,mh.TenMon,mh.SoTinChi,mh.MoTa);
            });
        }
        private void loadDataGridViewMonHoc(List<MonHoc> lstMonHoc)
        {
            dgvMonHoc.Rows.Clear();
            lstMonHoc.ForEach(mh =>
            {
                dgvMonHoc.Rows.Add(mh.MaMon, mh.TenMon, mh.SoTinChi, mh.MoTa);
            });
        }
        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            loadDataGridViewMonHoc();
        }
      
        // các hàm sự kiện
        private void updateAndDeleteMonHocBtnSua_Click(object sender, EventArgs e)
        {
            if (kiemTraNhapDuLieu(updateAndDeleteMonHoc))
            {
                HandleUI.ThieuThongTin();
                return;
            }
            if(indexDgvMonHoc == -1)
            {
                HandleUI.chuaChon("Môn học", "sửa");
                return;
            }
            string maMonHoc = updateAndDeleteMonHoc.txtMaMonHoc.Text;

            MonHoc mh = new MonHoc()
            {
                MaMon = updateAndDeleteMonHoc.txtMaMonHoc.Text,
                TenMon = updateAndDeleteMonHoc.txtTenMonHoc.Text,
                MoTa = updateAndDeleteMonHoc.txtMoTa.Text,
                SoTinChi = short.Parse(updateAndDeleteMonHoc.nudSoTinChi.Value.ToString())
            };
            bool kq = MonHocBUS.update(maMonHoc, mh);
            MessageBox.Show(kq ? "Sửa môn học thành công" : "Sửa môn học không thành công","Thông báo ");
            loadDataGridViewMonHoc();
        }
        private void updateAndDeleteMonHocBtnXoa_Click(object sender, EventArgs e)
        {
            if (indexDgvMonHoc == -1)
            {
                HandleUI.chuaChon("Môn học", "Xóa");
                return;
            }
            string maMon = dgvMonHoc.Rows[indexDgvMonHoc].Cells[clMaMon.Index].Value.ToString();
            bool kq = MonHocBUS.delete(maMon);
            loadDataGridViewMonHoc();
            MessageBox.Show(kq ? "Xóa môn học thành công" : "Xóa môn học không thành công", "Thông báo");
        }
        private void addMonHocBtnLuu_Click(object sender, EventArgs e)
        {
           if(kiemTraNhapDuLieu(addMonHoc))
            {
                HandleUI.ThieuThongTin();
                return;
            }
            if (MonHocBUS.selectByID(addMonHoc.txtMaMonHoc.Text) != null)
            {
                HandleUI.MaDaTonTai("Môn học");
                return;
            }
            MonHoc mh = new MonHoc()
            {
                MaMon = addMonHoc.txtMaMonHoc.Text,
                TenMon = addMonHoc.txtTenMonHoc.Text,
                MoTa = addMonHoc.txtMoTa.Text,
                SoTinChi = short.Parse(addMonHoc.nudSoTinChi.Value.ToString()),
            };
            bool kq = MonHocBUS.insert(mh);
            MessageBox.Show(kq ? "Thêm môn học thành công" : "Thêm môn học không thành công", "Thông báo");
            loadDataGridViewMonHoc();
        }
        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            HandleUI.showSidePanel(pnlDsMonHoc, pnlAddMonHoc);
            pnlAddMonHoc.Controls.Add(addMonHoc);
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            indexDgvMonHoc = e.RowIndex;
            HandleUI.showSidePanel(pnlDsMonHoc, pnlAddMonHoc);
            pnlAddMonHoc.Controls.Add(updateAndDeleteMonHoc);
            var rowSelecte = dgvMonHoc.Rows[e.RowIndex].Cells;
            updateAndDeleteMonHoc.txtMaMonHoc.Text = rowSelecte[clMaMon.Index].Value.ToString();
            updateAndDeleteMonHoc.txtTenMonHoc.Text = rowSelecte[clTenMon.Index].Value.ToString();
            updateAndDeleteMonHoc.txtMoTa.Text = rowSelecte[clMoTa.Index].Value.ToString();
            updateAndDeleteMonHoc.nudSoTinChi.Value = decimal.Parse(rowSelecte[clSoTinChi.Index].Value.ToString());
        }

      

        private void btnTimKiemMonHoc_Click(object sender, EventArgs e)
        {
            timMonHoc();
        }
        private void txtTimKiemMonHoc_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemMonHoc.Text.Length == 0)
                loadDataGridViewMonHoc();
        }

        private void txtTimKiemMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            timMonHoc();
        }

        //các hàm tìm kiếm
        private void timMonHoc()
        {
            var lstMonHoc = MonHocBUS.selectByTenMonHoc(txtTimKiemMonHoc.Text);
            if (lstMonHoc.Count == 0)
            {
                MonHoc mh = MonHocBUS.selectByID(txtTimKiemMonHoc.Text);
                lstMonHoc.Add(mh);
                if (mh != null)
                {
                    loadDataGridViewMonHoc(lstMonHoc);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            loadDataGridViewMonHoc(lstMonHoc);
        }
        // các hàm kiểm tra
        public bool kiemTraNhapDuLieu(dynamic control)
        {
            return (control.txtMaMonHoc.Text.Trim().Length == 0 || control.txtTenMonHoc.Text.Trim().Length == 0 || control.txtMoTa.Text.Trim().Length == 0);
        }
    }
}
