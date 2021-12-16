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
    public partial class FormSua : Form
    {
        private string maHH;
        public FormSua()
        {
            InitializeComponent();
        }
        public FormSua(string maHH)
        {
            InitializeComponent();
            this.maHH = maHH;
            using (MyEStoreDataContext _Database = new MyEStoreDataContext())
            {
                _Database.DeferredLoadingEnabled = false;
                HangHoa hh = _Database.HangHoas.FirstOrDefault(
                            item => item.MaHH.Equals(int.Parse(maHH)));
                SetInPutForm(hh);
            }
            txtMaHH.Text = maHH;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.DeferredLoadingEnabled = false;
                    HangHoa hhSua = _Database.HangHoas.FirstOrDefault(
                                item => item.MaHH.Equals(hh.MaHH));
                    hhSua.TenHH = hh.TenHH;
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
        private void SetInPutForm(HangHoa hh)
        {
            txtMaHH.Text = hh.MaHH.ToString();
            txtTenHH.Text = hh.TenHH;
            cbbLoaiHH.SelectedValue = hh.MaLoai;
            txtMoTaDonVi.Text = hh.MoTaDonVi;
            txtDonGia.Text = hh.DonGia.ToString();
            txtHinh.Text = hh.Hinh;
            dtpNgaySX.Value = hh.NgaySX;
            txtGiamGia.Text = hh.GiamGia.ToString();
            txtMoTa.Text = hh.MoTa;
            cbbNCC.SelectedValue = hh.MaNCC;


        }
        private HangHoa GetInputForm()
        {

            //if (txtMaHH.Text == "")
            //{
            //    txtMaHH.Text = "0";
            //}
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
            if (float.TryParse(txtGiamGia.Text, out giamGia) == false)
            {
                throw new Exception("Đơn Giá Không Hợp Lệ");
            }
            float donGia;
            if (float.TryParse(txtGiamGia.Text, out donGia) == false)
            {
                throw new Exception("Đơn Giá Không Hợp Lệ");
            }
            int maHH;
            if (int.TryParse(txtMaHH.Text, out maHH) == false)
            {
                throw new Exception("Mã Hàng Hóa Không Hợp Lệ");
            }
            HangHoa hh = new HangHoa();          
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
            hh.MaHH = maHH;

            return hh;
        }

        private void FormSua_Load(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.DeferredLoadingEnabled = false;
                    HangHoa hhXoa = _Database.HangHoas.Single(
                                item => item.MaHH.Equals(hh.MaHH));
                    _Database.HangHoas.DeleteOnSubmit(hhXoa);
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
    }
}
