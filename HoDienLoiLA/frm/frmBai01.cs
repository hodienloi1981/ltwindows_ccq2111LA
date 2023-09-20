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
    public partial class frmBai01 : Form
    {
        public frmBai01()
        {
            InitializeComponent();
        }

        private void frmBai01_Load(object sender, EventArgs e)
        {
            loadKhoa();
        }
        private void loadKhoa()
        {
            string[] listKhoa = { "CNTT", "Kế Toán", "Cơ Khí" };
            cbKhoa.DataSource = listKhoa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text.Trim();
            string hoten = txtHoTen.Text.Trim();
            string diem = txtDiem.Text.Trim();
            string tenkhoa = cbKhoa.Text;
            txtThongTin.Text = masv+hoten+diem+tenkhoa;
        }
    }
}
