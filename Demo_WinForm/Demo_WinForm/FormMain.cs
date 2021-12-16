using Demo_Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_WinForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void hìnhTamGiácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHinhTamGiac = new FormHinhTamGiac();
            frmHinhTamGiac.MdiParent = this;
            frmHinhTamGiac.Show();
        }

        private void hìnhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHinhVuong = new FormHinhVuong();
            frmHinhVuong.MdiParent = this;
            frmHinhVuong.Show();
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHinhTron = new FormHinhTron();
            frmHinhTron.MdiParent = this;
            frmHinhTron.Show();
        }

        private void formTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTimer = new FormTimer();
            frmTimer.MdiParent = this;
            frmTimer.Show();
        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLogin = new LoginForm();
            var ktDangNhap = frmLogin.ShowDialog(this);
            if(ktDangNhap == DialogResult.OK)
            {
                InitializeComponent();
            }   
            else
            {
                this.Close();
            }    
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }
    }
}
