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
    public partial class frmSinhVienInfo : Form
    {
        public string thongtin = "";
        public int stt = 1;
        public frmSinhVienInfo()
        {
            InitializeComponent();
        }

        private void bthThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(mtxtMaSV.Text.Length<10)
                {
                    mtxtMaSV.Focus();
                    throw new Exception("Mã sinh viên không hợp lệ");
                } 
                if(txtHoTen.Text.Length.Equals(0))
                {
                    txtHoTen.Focus();
                    throw new Exception("Chưa nhập họ tên");
                }
                if (mtxtNgaySinh.Text.Length < 10)
                {
                    mtxtNgaySinh.Focus();
                    throw new Exception("Ngày sinh không hợp lệ");
                }
                string masv = mtxtMaSV.Text;
                string hoten = txtHoTen.Text.Trim();
                string ngaysinh = mtxtNgaySinh.Text;
                thongtin += stt+"."+masv + hoten + ngaysinh+"\t\n";
                txtThongTin.Text = thongtin;
                stt++;
                mtxtMaSV.Text = null;
                txtHoTen.Text= null;
                mtxtNgaySinh= null;
            }
            catch (Exception message)
            {
                MessageBox.Show(message.Message);
            }
        }
    }
}
