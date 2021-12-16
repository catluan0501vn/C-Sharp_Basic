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
    public partial class FormTimer : Form
    {
        private static int LaDiLen;
        public FormTimer()
        {
            InitializeComponent();
        }

        private void ptsMe_Click(object sender, EventArgs e)
        {
            //ptsMe.Location = new Point(100, 100);
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {
            //t1.Interval = 30;
            //t1.Start();
            //ptsMe.Location = new Point(100, 100);
        }

        private void t1_Tick(object sender, EventArgs e)
        {

            //Point viTriHienTaiCuaHinh = ptsMe.Location;
            //if (LaDiLen == 1)
            //    viTriHienTaiCuaHinh.Y += 3;
            //else
            //    viTriHienTaiCuaHinh.Y -= 3;
            //if(viTriHienTaiCuaHinh.Y <= 0)
            //{
            //    LaDiLen = 1;
            //}    
            //if(viTriHienTaiCuaHinh.Y >= 200)
            //{
            //    LaDiLen = -1;
            //}    
            //ptsMe.Location = viTriHienTaiCuaHinh;
        }
    }
}
