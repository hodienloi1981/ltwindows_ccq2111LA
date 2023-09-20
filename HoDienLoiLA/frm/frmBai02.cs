using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoDienLoiLA.frm
{
    public partial class frmBai02 : Form
    {
        private int stt = 1;
        private int vtchon = -1;
        List<String> arrListMonAn = new List<String>();
        private ArrayList price = new ArrayList();
        public frmBai02()
        {
            InitializeComponent();
        }

        private void frmBai02_Load(object sender, EventArgs e)
        {
            arrListMonAn.Add("Bún bò");
            price.Add(230000);
            arrListMonAn.Add("Hủ Tiếu");
            price.Add(300000);
            arrListMonAn.Add("Bún Huế");
            price.Add(35000);
            arrListMonAn.Add("Phở");
            price.Add(430000);
            cbMonAn.DataSource = arrListMonAn;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = true;
            for(int i=0; i<dgvDSMon.Rows.Count-1;i++)
            {
                string tenGrid = dgvDSMon.Rows[i].Cells["TenMon"].Value.ToString();
                if(tenGrid.Equals(cbMonAn.Text.Trim()))
                {
                    check = false;
                    break;
                }
            }    

            if(check==true)
            {
                int index = dgvDSMon.Rows.Add();
                dgvDSMon.Rows[index].Cells["TenMon"].Value = cbMonAn.Text.Trim();
                dgvDSMon.Rows[index].Cells["Gia"].Value = txtGia.Text;
                dgvDSMon.Rows[index].Cells["SoLuong"].Value = txtSoLuong.Text;
                dgvDSMon.Rows[index].Cells["STT"].Value = stt.ToString();
                int soluong = Convert.ToInt16(txtSoLuong.Text);
                double gia = Convert.ToDouble(txtGia.Text);
                double thanhtien = soluong * gia;
                dgvDSMon.Rows[index].Cells["ThanhTien"].Value = thanhtien.ToString();
                stt++;
            }    
          
        }

        private void dgvDSMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSMon.Rows.Count - 1)
            {
                vtchon = e.RowIndex;
                txtSoLuong.Text = dgvDSMon.Rows[vtchon].Cells["SoLuong"].Value.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvDSMon.Rows[vtchon].Cells["SoLuong"].Value = txtSoLuong.Text;
        }

        private void cbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vt = cbMonAn.SelectedIndex;
            txtGia.Text = price[vt].ToString();
            txtGia.ReadOnly = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvDSMon.Rows.RemoveAt(vtchon);
        }
    }
}
