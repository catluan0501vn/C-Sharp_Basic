using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseSQLServer
{
    public partial class FormDSHangHoa : Form
    {
        public FormDSHangHoa()
        {
            InitializeComponent();
        }

        private void FormDSHangHoa_Load(object sender, EventArgs e)
        {
            LoadCbbChonLoaiHangHoa();
        }

        private void LoadCbbChonLoaiHangHoa()
        {
            LoaiSPServices loaiSPServices = new LoaiSPServices();
            List<LoaiSP> listLoaiSP = new List<LoaiSP>();
            listLoaiSP.Add(new LoaiSP
            {
                MaLoai = 0,
                TenLoai = "Chọn Loại Hàng Hóa"
            });

            cbbChonLoaiHangHoa.DataSource = loaiSPServices.GetAll();
            cbbChonLoaiHangHoa.DisplayMember = "TenLoai";
            cbbChonLoaiHangHoa.ValueMember = "MaLoai";
            cbbChonLoaiHangHoa.SelectedValue = 0;
        }

        private void cbbChonLoaiHangHoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int loaiHH = int.Parse(cbbChonLoaiHangHoa.SelectedValue.ToString());
            HangHoaServices hangHoaServices = new HangHoaServices();
            List<HangHoa> listHH = hangHoaServices.GetHangHoaByMaLoai(loaiHH.ToString());
            dgvHangHoa.DataSource = listHH;
        }

        private void txtTimHangHoa_TextChanged(object sender, EventArgs e)
        {
            if(txtTimHangHoa.TextLength >= 3)
            {
                string tenHH = txtTimHangHoa.Text;
                HangHoaServices hangHoaServices = new HangHoaServices();
                List<HangHoa> listHH = hangHoaServices.GetHangHoaByName(tenHH);
                dgvHangHoa.DataSource = listHH;
            }    
        }


        //private void cbbChonLoaiHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //int loaiHH = int.Parse(cbbChonLoaiHangHoa.SelectedValue.ToString());
        //    //HangHoaServices hangHoaServices = new HangHoaServices();
        //    //List<HangHoa> listHH = hangHoaServices.GetHangHoaByMaLoai(loaiHH.ToString());

        //}
    }
}
