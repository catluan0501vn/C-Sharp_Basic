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
    public partial class FormDsHangHoa : Form
    {
        public FormDsHangHoa()
        {
            InitializeComponent();
        }

        private void FormDsHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHHDataSet.LoaiHangHoa' table. You can move, or remove it, as needed.
            this.loaiHangHoaTableAdapter.Fill(this.qLHHDataSet.LoaiHangHoa);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
