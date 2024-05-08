using BUS;
using DTO;
using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyControl
{
    public partial class addDiem : UserControl
    {
        string mssv;
        string malop;
        public addDiem(string mssv, string malop)
        {
            this.mssv = mssv;
            this.malop = malop;
            InitializeComponent();
        }

        private void addDiem_Load(object sender, EventArgs e)
        {
            if (this.Tag == null)
            {
                return;
            }
            List<DiemThanhPhan> lstDiem = this.Tag as List<DiemThanhPhan>;
            lstDiem.ForEach(d =>
          {
              inputDiem nhapDiem = new inputDiem();
              nhapDiem.Tag = d;
              nhapDiem.lbTenCot.Text = d.TenDiem;
              flowLayoutPanel1.Controls.Add(nhapDiem);
          });

            if (ChiTietDiemBUS.selectByMaSvAndMaLop(mssv, malop).Count > 0)
            {
                SinhVienBUS.selectByID(mssv).ChiTietDiems.ToList().ForEach(d =>
                {
                    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    {
                        inputDiem nhapDiem = flowLayoutPanel1.Controls[i] as inputDiem;
                        DiemThanhPhan dtp = nhapDiem.Tag as DiemThanhPhan;
                        if (dtp.MaDiemTP == d.MaDiemTP)
                        {
                            nhapDiem.txtDiem.Text = d.Diem.ToString();
                        }
                    }

                });
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try 
            {
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    inputDiem nhapDiem = flowLayoutPanel1.Controls[i] as inputDiem;
                    DiemThanhPhan dtp = nhapDiem.Tag as DiemThanhPhan;
                    float diem = 0;
                    bool kq = float.TryParse(nhapDiem.txtDiem.Text, out diem);
                    if (diem > 10 || diem < 0)
                    {
                        MessageBox.Show("Điểm phải trong khoảng từ 0 đến 10");
                        return;
                    }
                    if (!kq)
                    {
                        MessageBox.Show("Bạn phải nhập số", "Thông báo");
                        return;
                    }
                    if(ChiTietDiemBUS.selectByMaSvAndMaDiem(mssv, dtp.MaDiemTP) != null)
                    {
                        continue;
                    }
                    ChiTietDiem chiTietDiem = new ChiTietDiem()
                    {
                        MSSV = mssv,
                        MaDiemTP = dtp.MaDiemTP,
                        Diem = diem
                    };
                    QLDiemSinhVien.getInstance().ChiTietDiems.Add(chiTietDiem);
                }
                QLDiemSinhVien.getInstance().SaveChanges();
                MessageBox.Show("Thêm điểm thành công", "Thông báo");
            }catch(Exception ex)
            {
                MessageBox.Show("Thêm điểm thất bại", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChiTietDiemBUS.selectByMaSvAndMaLop(mssv, malop).Count > 0)
                {
                    for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                    {
                        inputDiem nhapDiem = flowLayoutPanel1.Controls[i] as inputDiem;
                        DiemThanhPhan dtp = nhapDiem.Tag as DiemThanhPhan;
                        ChiTietDiem ctd = ChiTietDiemBUS.selectByMaSvAndMaDiem(mssv, dtp.MaDiemTP);
                        float diem = 0;
                        bool kq = float.TryParse(nhapDiem.txtDiem.Text, out diem);
                        if (diem > 10 || diem < 0)
                        {
                            MessageBox.Show("Điểm phải trong khoảng từ 0 đến 10");
                            return;
                        }
                        ctd.Diem = diem;
                        QLDiemSinhVien.getInstance().SaveChanges();
                    }
                }
                MessageBox.Show("sửa điểm thành công", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("sửa điểm thất bại", "Thông báo");
            }
        }
    }
}
