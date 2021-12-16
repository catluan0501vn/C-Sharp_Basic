using SuDungClass;
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
    public partial class FormHinhTron : Form
    {
        public FormHinhTron()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = double.Parse(txtSoA.Text);
                HinhTron ht = new HinhTron();
                ht.BK = soA;
                lblKetQua.Text =
                    String.Format("Chu Vi:{0}", ht.ChuVi());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Typing Wrong !");
            }
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            try
            {
                double soA = double.Parse(txtSoA.Text);
                HinhTron ht = new HinhTron();
                ht.BK = soA;
                lblKetQua.Text =
                    String.Format("Diện Tích:{0}", ht.DienTich());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Typing Wrong !");
            }
        }
    }
}
