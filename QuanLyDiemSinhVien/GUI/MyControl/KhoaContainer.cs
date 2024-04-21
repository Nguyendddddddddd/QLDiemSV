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
    public partial class KhoaContainer : UserControl
    {
        public KhoaContainer()
        {
            InitializeComponent();
        }
        public KhoaContainer(string tenKhoa,int slNganh, int slGiangVien) 
        {
            InitializeComponent();
            lbTenKhoa.Text = tenKhoa;
            lbSoLuongNganh.Text = $"Số lượng ngành {slNganh}";
            lbSoLuongGV.Text = $"Số lượng giảng viên {slGiangVien}";
        }

    }
}
