using System;
using System.Windows.Forms;
using System.IO;
namespace Lab03_NguyenHuyBaoToan
{
    public partial class frmSecurityPanel : Form
    {
        string path = @"C:\Users\Nguyen Huy Bao Toan\source\repos\Thực Hành\Lab03_NguyenHuyBaoToan\Login_log.txt";
        //int Technicians = 1689;
        public frmSecurityPanel()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getNumber(object o, EventArgs e)
        {
            if (txtSecurityCode.TextLength < 4)
                txtSecurityCode.Text += ((Button)o).Text;
            
        }

        private void getPressNumber(object o, KeyPressEventArgs e)
        {
            if (txtSecurityCode.TextLength < 4 && e.KeyChar >= '0' && e.KeyChar <= '9' && e.KeyChar != Convert.ToChar(Keys.Enter))
            txtSecurityCode.Text += e.KeyChar.ToString();
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            /*
            if(txtSecurityCode.Text == pass)
            {
                MessageBox.Show("Đăng nhập thành công!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtSecurityCode.Text = "";
            */
            EnterPress();
        }

        private void EnterPress()
        {
            if (txtSecurityCode.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSecurityCode.TextLength == 1)
            {
                DateTime d = DateTime.Now;
                MessageBox.Show(d + " Restricted Access!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtSecurityCode.TextLength == 1)
            {
                txtSecurityCode.Text = "";
                return;
            }
            switch (txtSecurityCode.Text)
            {

                case "1689":
                case "1645":
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            DateTime d = DateTime.Now;
                            sw.WriteLine(d + " Technicians");
                            sw.Dispose();
                        }
                        MessageBox.Show("Đăng nhập thành công", "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowLog();
                        txtSecurityCode.Text = "";
                        break;
                    }

                case "8345":
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            DateTime d = DateTime.Now;
                            sw.WriteLine(d + " Custodians");
                            sw.Dispose();
                        }
                        MessageBox.Show("Đăng nhập thành công", "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowLog();
                        txtSecurityCode.Text = "";
                        break;
                    }

                case "9998":
                case "1006":
                case "1007":
                case "1008":
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            DateTime d = DateTime.Now;
                            sw.WriteLine(d + " Scientist");
                            sw.Dispose();
                        }
                        MessageBox.Show("Đăng nhập thành công", "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowLog();
                        txtSecurityCode.Text = "";
                        break;
                    }

                default:
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            DateTime d = DateTime.Now;
                            sw.WriteLine(d + " Access Denied!");
                            sw.Dispose();
                        }
                        MessageBox.Show("Đăng nhập thất bại", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ShowLog();
                        txtSecurityCode.Text = "";
                        break;

                    }

            }

            /*
            if (txtSecurityCode.Text == Technicians.ToString())
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    DateTime d = DateTime.Now;
                    sw.WriteLine(d + " Access Granted!");
                    sw.Dispose();
                }
                MessageBox.Show("Đăng nhập thành công", "Access Granted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            

            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    DateTime d = DateTime.Now;
                    sw.WriteLine(d + " Access Denied!");
                    sw.Dispose();
                }
                MessageBox.Show("Đăng nhập thất bại", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowLog();
            txtSecurityCode.Text = "";
            */
        }

        private void txtSecurityCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowLog()
        {
            listBox1.Items.Clear();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
    }
}
