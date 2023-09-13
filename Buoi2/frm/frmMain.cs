using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       

        private void Bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmMainTinh2So();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void Bai2TinSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmSinhVienInfo();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
