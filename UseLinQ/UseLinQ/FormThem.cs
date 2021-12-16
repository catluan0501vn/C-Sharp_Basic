using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseLinQ
{
    public partial class FormThem : Form
    {
        public FormThem()
        {
            InitializeComponent();
        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            using (MyEStoreDataContext _Database = new MyEStoreDataContext())
            {
                cbbLoaiHH.DataSource = _Database.Loais.ToList();
                cbbLoaiHH.DisplayMember = "TenLoai";
                cbbLoaiHH.ValueMember = "MaLoai";

                cbbNCC.DataSource = _Database.NhaCungCaps.ToList();
                cbbNCC.DisplayMember = "TenCongTy";
                cbbNCC.ValueMember = "MaNCC";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.HangHoas.InsertOnSubmit(hh);
                    _Database.SubmitChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private HangHoa GetInputForm()
        {

            if (txtMaHH.Text == "")
            {
                txtMaHH.Text = "0";
            }
            if (txtTenHH.Text == "")
            {
                throw new Exception("Chưa Có Tên Hàng Hóa");
            }
            if (cbbLoaiHH.SelectedValue.ToString() == "")
            {
                throw new Exception("Chưa Có Loại Hàng Hóa");
            }
            
            if (txtGiamGia.Text == "")
            {
                txtGiamGia.Text = "0";
            }
            if (cbbNCC.SelectedValue.ToString() == "")
            {
                throw new Exception("Chưa Có Nhà Cung Cấp");
            }
            float giamGia;
            if(float.TryParse(txtGiamGia.Text, out giamGia) == false)
            {
                throw new Exception("Đơn Giá Không Hợp Lệ");
            }
            float donGia;
            if (float.TryParse(txtGiamGia.Text, out donGia) == false)
            {
                throw new Exception("Đơn Giá Không Hợp Lệ");
            }
            HangHoa hh = new HangHoa();
            hh.MaHH = int.Parse(txtMaHH.Text);
            hh.TenHH = txtTenHH.Text;
            hh.MaLoai = int.Parse(cbbLoaiHH.SelectedValue.ToString());
            hh.MoTaDonVi = txtMoTaDonVi.Text;
            hh.DonGia = donGia;
            hh.Hinh = txtHinh.Text;
            hh.NgaySX = dtpNgaySX.Value;
            hh.GiamGia = giamGia;
            hh.SoLanXem = 0;
            hh.MoTa = txtTenHH.Text;
            hh.MaNCC = cbbNCC.SelectedValue.ToString();

            return hh;
        }
    }
}
