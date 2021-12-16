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
    public partial class FormHinhVuong : Form
    {
        public FormHinhVuong()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            try
            {
                double Canh = double.Parse(txtCanh.Text);
                HinhVuong hv = new HinhVuong();
                hv.CanhHV = Canh;
                lblKetQua.Text =
                    String.Format("Chu Vi: {0}", hv.ChuVi());
            }
            catch (Exception)
            {

                MessageBox.Show("Typing Wrong !");
            }
        }

        private void FormHinhVuong_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            try
            {
                double Canh = double.Parse(txtCanh.Text);
                HinhVuong hv = new HinhVuong();
                hv.CanhHV = Canh;
                lblKetQua.Text =
                    String.Format("Diện Tích: {0}", hv.DienTich());
            }
            catch (Exception)
            {

                MessageBox.Show("Typing Wrong !");
            }
        }
    }
}
