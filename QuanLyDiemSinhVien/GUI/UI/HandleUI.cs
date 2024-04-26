using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public class HandleUI
    {
        public static void showSidePanel(Guna2Panel mainPanel, Guna2Panel sidePanel)
        {
            sidePanel.Controls.Clear();
            if (!sidePanel.Visible)
            {
                mainPanel.Size = new Size(mainPanel.Width - sidePanel.Width - 10, mainPanel.Height);
                sidePanel.Visible = true;
            }
        }
        public static void hideSidePanel(Guna2Panel mainPanel, Guna2Panel sidePanel)
        {
            if (sidePanel.Visible)
            {
                mainPanel.Size = new Size(mainPanel.Width + sidePanel.Width + 10, mainPanel.Height);
                sidePanel.Visible = false;
                sidePanel.Controls.Clear();
            }
        }
        public static void ThieuThongTin()
        {
            MessageBox.Show($"Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public static void MaDaTonTai(string ma)
        {
            MessageBox.Show($"Mã {ma} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void chuaChon(string ten,string type)
        {
            MessageBox.Show($"Bạn chưa chọn {ten} để {type}! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
