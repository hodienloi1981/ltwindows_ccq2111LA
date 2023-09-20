using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoDienLoiLA.frm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiBai01_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmBai01();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
