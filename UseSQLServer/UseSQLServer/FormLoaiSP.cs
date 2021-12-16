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
    public partial class FormLoaiSP : Form
    {
        public FormLoaiSP()
        {
            InitializeComponent();
        }

        private void FormLoaiSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myeStore.Loai' table. You can move, or remove it, as needed.
            //this.loaiTableAdapter.Fill(this.myeStore.Loai);
            LoadGirdView();
        }

        private void LoadGirdView()
        {
            LoaiSPServices loaiSPServices = new LoaiSPServices();
            dgvLoaiSP.DataSource = loaiSPServices.GetAll();
        }
        private LoaiSP GetInPutForm()
        {
            if (txtMaLoai.Text == "")
            {
                txtMaLoai.Text = "0";
            }
            return new LoaiSP()
            {
                MaLoai = int.Parse(txtMaLoai.Text),
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text,
                Hinh = txtHinh.Text
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSP loai = GetInPutForm();
                LoaiSPServices loaiSPServices = new LoaiSPServices();
                loaiSPServices.Add(loai);
                LoadGirdView();
                SetInPutForm(new LoaiSP());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetInPutForm(LoaiSP loaiSP)
        {
            txtMaLoai.Text = loaiSP.MaLoai.ToString();
            txtTenLoai.Text = loaiSP.TenLoai;
            txtMoTa.Text = loaiSP.MoTa;
            txtHinh.Text = loaiSP.Hinh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSP loai = GetInPutForm();
                LoaiSPServices loaiSPServices = new LoaiSPServices();
                loaiSPServices.Edit(loai);
                LoadGirdView();
                SetInPutForm(new LoaiSP());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoaiSP loai = new LoaiSP();
            loai.MaLoai = int.Parse(dgvLoaiSP.Rows[e.RowIndex].Cells[0].Value.ToString());
            loai.TenLoai = dgvLoaiSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            loai.MoTa = dgvLoaiSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            loai.Hinh = dgvLoaiSP.Rows[e.RowIndex].Cells[3].Value.ToString();

            SetInPutForm(loai);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLoaiSP = txtMaLoai.Text;
                var kt = MessageBox.Show("Bạn Có Muốn Xóa Không ?"
                                            , "Xóa Sản Phẩm", MessageBoxButtons.YesNoCancel
                                            , MessageBoxIcon.Warning);
                if (kt == DialogResult.Yes)
                {
                    LoaiSPServices loaiSPServices = new LoaiSPServices();
                    loaiSPServices.Delete(MaLoaiSP);
                    LoadGirdView();
                }    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
