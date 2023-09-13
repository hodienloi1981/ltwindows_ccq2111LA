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
    public partial class frmMainTinh2So : Form
    {
        public frmMainTinh2So()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy giá trị từ TextBox
                double a;
                double b;
                if (!double.TryParse(txtSoA.Text.Trim(),out a))
                {
                    throw new Exception("A không phải số");
                }
                if (!double.TryParse(txtSoB.Text.Trim(), out b))
                {
                    throw new Exception("B không phải số");
                }
                //Thiết lập giá trị
                txtKetQua.Text = (a + b).ToString();
            }
            catch(Exception error) {
                //Bị lỗi
                txtKetQua.Text = error.Message;
            }
            
        }
    }
}
