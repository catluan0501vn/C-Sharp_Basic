using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace UseLinQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (MyEStoreDataContext _Database = new MyEStoreDataContext())
            {
                _Database.DeferredLoadingEnabled = false;
                //dgvHangHoa.DataSource = _Database.HangHoas.ToList();

                #region Join multiple tables by Linq
                dgvHangHoa.DataSource = (from a in _Database.HangHoas
                                         join b in _Database.Loais on a.MaLoai equals b.MaLoai
                                         join c in _Database.NhaCungCaps on a.MaNCC equals c.MaNCC
                                         select new
                                         {
                                             MaHH = a.MaHH,
                                             TenHH = a.TenHH,
                                             MaLoai = a.MaLoai,
                                             Description = a.MoTaDonVi,
                                             DonGia = a.DonGia,
                                             Hinh = a.Hinh,
                                             NgaySX = a.NgaySX,
                                             GiamGia = a.GiamGia,
                                             SoLanXem = a.SoLanXem,
                                             MoTa = a.MoTa,
                                             NCC = a.MaNCC,
                                             TenLoai = b.TenLoai,
                                             MaNCC = c.MaNCC
                                         });
                #endregion

                cbbLoai.DataSource = _Database.Loais.ToList();

                List<Loai> dsLoai = _Database.Loais.ToList();
                dsLoai.Insert(0, new Loai
                {
                    MaLoai = 0,
                    TenLoai = "Chon Loại Sản Phẩm"
                });
                cbbLoai.DataSource = dsLoai;
                cbbLoai.ValueMember = "MaLoai";
                cbbLoai.DisplayMember = "TenLoai";
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearching.Text;
            using (MyEStoreDataContext _Database = new MyEStoreDataContext())
            {
                _Database.DeferredLoadingEnabled = false;
                var dsTimKiem = _Database.HangHoas.
                                Where(hh => hh.TenHH.Contains(tuKhoa)
                                      || hh.MaHH.ToString().Contains(tuKhoa)).ToList();

                dgvHangHoa.DataSource = dsTimKiem;
                
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var kt = MessageBox.Show("Bạn Có Muốn Thoát Không ?"
                                            , "Xóa Sản Phẩm", MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes)
            {
                this.Close();
            }
            this.Close();
        }

        private void cbbLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string MaLoai = cbbLoai.SelectedValue.ToString();
            using (MyEStoreDataContext _Database = new MyEStoreDataContext())
            {
                _Database.DeferredLoadingEnabled = false;
                var dsHangHoaTheoLoai =
                    _Database.HangHoas.Where(hh => hh.MaLoai.
                                            Equals(int.Parse(MaLoai))).ToList();
                dgvHangHoa.DataSource = dsHangHoaTheoLoai;

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frmThem = new FormThem();
            DialogResult drThem = frmThem.ShowDialog();
            if (drThem == DialogResult.OK)
            {
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.DeferredLoadingEnabled = false;
                    //dgvHangHoa.DataSource = _Database.HangHoas.ToList();
                    #region Join multiple tables by Linq
                    dgvHangHoa.DataSource = (from a in _Database.HangHoas
                                             join b in _Database.Loais on a.MaLoai equals b.MaLoai
                                             join c in _Database.NhaCungCaps on a.MaNCC equals c.MaNCC
                                             select new
                                             {
                                                 MaHH = a.MaHH,
                                                 TenHH = a.TenHH,
                                                 MaLoai = a.MaLoai,
                                                 Description = a.MoTaDonVi,
                                                 DonGia = a.DonGia,
                                                 Hinh = a.Hinh,
                                                 NgaySX = a.NgaySX,
                                                 GiamGia = a.GiamGia,
                                                 SoLanXem = a.SoLanXem,
                                                 MoTa = a.MoTa,
                                                 NCC = a.MaNCC,
                                                 TenLoai = b.TenLoai,
                                                 MaNCC = c.MaNCC
                                             });
                    #endregion

                }
            }
            frmThem.Show();
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var MaHH = dgvHangHoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            FormSua frmSua = new FormSua(MaHH);

            DialogResult kt = frmSua.ShowDialog();
            if(kt == DialogResult.OK)
            {
                using (MyEStoreDataContext _Database = new MyEStoreDataContext())
                {
                    _Database.DeferredLoadingEnabled = false;
                    //dgvHangHoa.DataSource = _Database.HangHoas.ToList();

                    #region Join multiple tables by Linq
                    dgvHangHoa.DataSource = (from a in _Database.HangHoas
                                             join b in _Database.Loais on a.MaLoai equals b.MaLoai
                                             join c in _Database.NhaCungCaps on a.MaNCC equals c.MaNCC
                                             select new
                                             {
                                                 MaHH = a.MaHH,
                                                 TenHH = a.TenHH,
                                                 MaLoai = a.MaLoai,
                                                 Description = a.MoTaDonVi,
                                                 DonGia = a.DonGia,
                                                 Hinh = a.Hinh,
                                                 NgaySX = a.NgaySX,
                                                 GiamGia = a.GiamGia,
                                                 SoLanXem = a.SoLanXem,
                                                 MoTa = a.MoTa,
                                                 NCC = a.MaNCC,
                                                 TenLoai = b.TenLoai,
                                                 MaNCC = c.MaNCC
                                             });
                    #endregion
                }
            }    
        }

        private void listHH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
