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
    public partial class FormThemHangHoa : Form
    {
        public FormThemHangHoa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInPutForm();
                HangHoaServices hhServices = new HangHoaServices();
                hhServices.Add(hh);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                
            }
        }

        private HangHoa GetInPutForm()
        {
            if(txtMaHH.Text == "")
            {
                txtMaHH.Text = "0";
            }    
            if(txtTenHH.Text == "")
            {
                throw new Exception("Chưa Có Tên Hàng Hóa");
            }    
            if(cbbLoaiHH.SelectedValue.ToString() == "")
            {
                throw new Exception("Chưa Có Loại Hàng Hóa");
            }    
            if(txtGiamGia.Text == "")
            {
                txtGiamGia.Text = "0";
            }    
            if(cbbNCC.SelectedValue.ToString() == "")
            {
                throw new Exception("Chưa Có Nhà Cung Cấp");
            }

            HangHoa hh = new HangHoa();
            hh.MaHH = int.Parse(txtMaHH.Text);
            hh.TenHH = txtTenHH.Text;
            hh.MaLoai = int.Parse(cbbLoaiHH.SelectedValue.ToString());
            hh.MoTaDonVi = txtMoTaDonVi.Text;
            hh.DonGia = float.Parse(txtDonGia.Text);
            hh.Hinh = txtHinh.Text;
            hh.NgaySx = dtPNgaySX.Value;
            hh.GiamGia = float.Parse(txtTenHH.Text);
            hh.SoLanXem = 0;
            hh.MoTa = txtTenHH.Text;
            hh.MaNCC = cbbNCC.SelectedValue.ToString();

            return hh;
        }

        private void FormThemHangHoa_Load(object sender, EventArgs e)
        {
            LoadCBBLoaiHangHoa();
            LoadCBB_NCC();  
        }

        private void LoadCBB_NCC()
        {
            NCCServices nCCServices = new NCCServices();
            cbbNCC.DataSource = nCCServices.GetAll();
            cbbNCC.DisplayMember = "TenCongTy";
            cbbNCC.ValueMember = "MaNCC";
        }

        private void LoadCBBLoaiHangHoa()
        {
            LoaiSPServices loaiSPServices = new LoaiSPServices();
            cbbLoaiHH.DataSource = loaiSPServices.GetAll();
            cbbLoaiHH.DisplayMember = "TenLoai";
            cbbLoaiHH.ValueMember = "MaLoai";
        }
    }
}
