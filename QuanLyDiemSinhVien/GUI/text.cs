using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class text : Form
    {
        public text()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fp.Size = new Size(400, 400);
        }

        private void text_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                fp.Controls.Add(new Panel()
                {
                    Size = new Size(38, 38),
                    BackColor = Color.Black,
                    Margin = new Padding(1, 1, 1, 1)
                }) ;
            }
        }
    }
}
