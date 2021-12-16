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
    public partial class FormHinhTamGiac : Form
    {
        public FormHinhTamGiac()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            try
            {
                double CanhA = double.Parse(txtCanhA.Text);
                double CanhB = double.Parse(txtCanhB.Text);
                double CanhC = double.Parse(txtCanhC.Text);
                HinhTamGiac htg = new HinhTamGiac();
                htg.CanhA = CanhA;
                htg.CanhB = CanhB;
                htg.CanhC = CanhC;
                lblKetQua.Text =
                    String.Format("Chu Vi: {0}", htg.ChuVi());
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
                double CanhA = double.Parse(txtCanhA.Text);
                double CanhB = double.Parse(txtCanhB.Text);
                double CanhC = double.Parse(txtCanhC.Text);
                HinhTamGiac htg = new HinhTamGiac();
                htg.CanhA = CanhA;
                htg.CanhB = CanhB;
                htg.CanhC = CanhC;
                lblKetQua.Text =
                    String.Format("Diện Tích: {0}", htg.DienTich());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Typing Wrong !");
            }
        }

        private void FormHinhTamGiac_Load(object sender, EventArgs e)
        {

        }
    }
}
