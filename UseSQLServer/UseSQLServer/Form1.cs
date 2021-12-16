using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void danhSáchNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDSNCC = new FormNCC();
            frmDSNCC.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhSáchLoạiSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLoaiSP = new FormLoaiSP();
            frmLoaiSP.Show();
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThemHH = new FormThemHangHoa();
            frmThemHH.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDSHangHoa = new FormDSHangHoa();
            frmDSHangHoa.Show();
        }
    }
}
