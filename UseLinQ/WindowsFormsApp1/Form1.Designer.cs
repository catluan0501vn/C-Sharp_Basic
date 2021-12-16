namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myeStoreDataSet = new WindowsFormsApp1.MyeStoreDataSet();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new WindowsFormsApp1.MyeStoreDataSetTableAdapters.HoaDonTableAdapter();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachThanhToanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cachVanChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiVanChuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTrangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myeStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.ngayDatDataGridViewTextBoxColumn,
            this.ngayCanDataGridViewTextBoxColumn,
            this.ngayGiaoDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.cachThanhToanDataGridViewTextBoxColumn,
            this.cachVanChuyenDataGridViewTextBoxColumn,
            this.phiVanChuyenDataGridViewTextBoxColumn,
            this.maTrangThaiDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoaDonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // myeStoreDataSet
            // 
            this.myeStoreDataSet.DataSetName = "MyeStoreDataSet";
            this.myeStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.myeStoreDataSet;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // ngayDatDataGridViewTextBoxColumn
            // 
            this.ngayDatDataGridViewTextBoxColumn.DataPropertyName = "NgayDat";
            this.ngayDatDataGridViewTextBoxColumn.HeaderText = "NgayDat";
            this.ngayDatDataGridViewTextBoxColumn.Name = "ngayDatDataGridViewTextBoxColumn";
            // 
            // ngayCanDataGridViewTextBoxColumn
            // 
            this.ngayCanDataGridViewTextBoxColumn.DataPropertyName = "NgayCan";
            this.ngayCanDataGridViewTextBoxColumn.HeaderText = "NgayCan";
            this.ngayCanDataGridViewTextBoxColumn.Name = "ngayCanDataGridViewTextBoxColumn";
            // 
            // ngayGiaoDataGridViewTextBoxColumn
            // 
            this.ngayGiaoDataGridViewTextBoxColumn.DataPropertyName = "NgayGiao";
            this.ngayGiaoDataGridViewTextBoxColumn.HeaderText = "NgayGiao";
            this.ngayGiaoDataGridViewTextBoxColumn.Name = "ngayGiaoDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // cachThanhToanDataGridViewTextBoxColumn
            // 
            this.cachThanhToanDataGridViewTextBoxColumn.DataPropertyName = "CachThanhToan";
            this.cachThanhToanDataGridViewTextBoxColumn.HeaderText = "CachThanhToan";
            this.cachThanhToanDataGridViewTextBoxColumn.Name = "cachThanhToanDataGridViewTextBoxColumn";
            // 
            // cachVanChuyenDataGridViewTextBoxColumn
            // 
            this.cachVanChuyenDataGridViewTextBoxColumn.DataPropertyName = "CachVanChuyen";
            this.cachVanChuyenDataGridViewTextBoxColumn.HeaderText = "CachVanChuyen";
            this.cachVanChuyenDataGridViewTextBoxColumn.Name = "cachVanChuyenDataGridViewTextBoxColumn";
            // 
            // phiVanChuyenDataGridViewTextBoxColumn
            // 
            this.phiVanChuyenDataGridViewTextBoxColumn.DataPropertyName = "PhiVanChuyen";
            this.phiVanChuyenDataGridViewTextBoxColumn.HeaderText = "PhiVanChuyen";
            this.phiVanChuyenDataGridViewTextBoxColumn.Name = "phiVanChuyenDataGridViewTextBoxColumn";
            // 
            // maTrangThaiDataGridViewTextBoxColumn
            // 
            this.maTrangThaiDataGridViewTextBoxColumn.DataPropertyName = "MaTrangThai";
            this.maTrangThaiDataGridViewTextBoxColumn.HeaderText = "MaTrangThai";
            this.maTrangThaiDataGridViewTextBoxColumn.Name = "maTrangThaiDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myeStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyeStoreDataSet myeStoreDataSet;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private MyeStoreDataSetTableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachThanhToanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cachVanChuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phiVanChuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTrangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}

