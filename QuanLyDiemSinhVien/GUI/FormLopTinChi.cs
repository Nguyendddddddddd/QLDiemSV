using GUI.MyControl;
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
    public partial class FormLopTinChi : Form
    {
        public FormLopTinChi()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLopTinChi_Load(object sender, EventArgs e)
        {
           
            for(int i= 0; i < 8; i++)
            { 
                flowLayoutPanel1.Controls.Add(new ContainerLopTC());
            }
        }
    }
}
