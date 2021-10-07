using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_NguyenHuyBaoToan
{
    public partial class frmUocboi : Form
    {
        public frmUocboi()
        {
            InitializeComponent();
        }

        public int USCLN(int a, int b)
        {
            return b == 0 ? a : USCLN(b, a % b);
        }

        public int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txta.Text);
            int b = int.Parse(txtb.Text);
            if(btnBSCNN.Checked)
            {
                BSCNN(a, b);
                txtKq.Text = BSCNN(a, b).ToString();
            }
            else if (btnUSCLN.Checked)
            {
                USCLN(a, b);
                txtKq.Text = USCLN(a, b).ToString();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtKq.Text = "";
            
        }
    }
}
