using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using UseSQLServer.Database.MyeStoreTableAdapters;

namespace UseSQLServer
{
    public partial class FormNCC : Form
    {
        public FormNCC()
        {
            InitializeComponent();
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myeStore.NhaCungCap' table. You can move, or remove it, as needed.
            //this.nhaCungCapTableAdapter1.Fill(this.myeStore.NhaCungCap);
            LoadGirdView();

        }

        private void LoadGirdView()
        {
            NCCServices NCCs = new NCCServices();
            dgvNCC.DataSource = NCCs.GetAll();
        }

        private NCC GetInputForm()
        {
            return new NCC()
            {
                MaNCC = txtMaNCC.Text,
                TenCongTy = txtTenCty.Text,
                Logo = txtLogo.Text,
                NguoiLienLac = txtNguoiLienLac.Text,
                Email = txtEmail.Text,
                DienThoai = txtDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                MoTa = txtMoTa.Text
            }; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NCC nCC = GetInputForm();
                NCCServices nCCs = new NCCServices();
                nCCs.Add(nCC);
                LoadGirdView();
                SetInPutForm(new NCC());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SetInPutForm(NCC nCC)
        {
            txtMaNCC.Text = nCC.MaNCC;
            txtTenCty.Text = nCC.TenCongTy;
            txtLogo.Text = nCC.Logo;
            txtNguoiLienLac.Text = nCC.NguoiLienLac;
            txtEmail.Text = nCC.Email;
            txtDienThoai.Text = nCC.DienThoai;
            txtDiaChi.Text = nCC.DiaChi;
            txtMoTa.Text = nCC.MoTa;
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NCC nCC = new NCC();
            nCC.MaNCC = dgvNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            nCC.TenCongTy = dgvNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            nCC.Logo = dgvNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
            nCC.NguoiLienLac = dgvNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
            nCC.Email = dgvNCC.Rows[e.RowIndex].Cells[4].Value.ToString();
            nCC.DienThoai = dgvNCC.Rows[e.RowIndex].Cells[5].Value.ToString();
            nCC.DiaChi = dgvNCC.Rows[e.RowIndex].Cells[6].Value.ToString();
            nCC.MoTa = dgvNCC.Rows[e.RowIndex].Cells[7].Value.ToString();

            SetInPutForm(nCC);

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NCC nCC = GetInputForm();
                NCCServices nCCs = new NCCServices();
                nCCs.Edit(nCC);
                LoadGirdView();
                SetInPutForm(new NCC());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = txtMaNCC.Text;
                var kt = MessageBox.Show("Bạn Có Muốn Xóa Nhà Cung Cấp Này Không ?",
                                         "Xóa Nhà Cung Cấp", MessageBoxButtons.YesNoCancel,
                                          MessageBoxIcon.Warning);
                
                if (kt == DialogResult.Yes)
                {
                    NCCServices nCCs = new NCCServices();
                    nCCs.Delete(MaNCC);
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
