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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Tong = n + m;
            txtKq.Text = Tong.ToString();

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Hieu = n - m;
            txtKq.Text = Hieu.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Nhan = n * m;
            txtKq.Text = Nhan.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int Chia = n / m;
            txtKq.Text = Chia.ToString();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = " ";
            txtSom.Text = " ";
            txtKq.Text = " ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
