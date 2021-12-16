using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_Login
{
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            Form frmLogin = new LoginForm();
            var ktDangNhap = frmLogin.ShowDialog(this);
            if (ktDangNhap == DialogResult.OK)
            {
                InitializeComponent();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            var kt = MessageBox.Show("Do you want to exit ?", "Warning",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(kt != DialogResult.Yes)
            {
                e.Cancel = true;
            }    
        }

        private void thêmLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDSHangHoa = new FormDsHangHoa();
            frmDSHangHoa.Show();
        }
    }
}
