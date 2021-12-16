namespace Demo_Login
{
    partial class FormDsHangHoa
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
            this.dgvLoaiHangHoa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHHDataSet = new Demo_Login.QLHHDataSet();
            this.lbldsSP = new System.Windows.Forms.Label();
            this.loaiHangHoaTableAdapter = new Demo_Login.QLHHDataSetTableAdapters.LoaiHangHoaTableAdapter();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiHangHoa
            // 
            this.dgvLoaiHangHoa.AutoGenerateColumns = false;
            this.dgvLoaiHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn});
            this.dgvLoaiHangHoa.DataSource = this.loaiHangHoaBindingSource;
            this.dgvLoaiHangHoa.Location = new System.Drawing.Point(13, 37);
            this.dgvLoaiHangHoa.Name = "dgvLoaiHangHoa";
            this.dgvLoaiHangHoa.Size = new System.Drawing.Size(500, 254);
            this.dgvLoaiHangHoa.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "MaLoai";
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            // 
            // loaiHangHoaBindingSource
            // 
            this.loaiHangHoaBindingSource.DataMember = "LoaiHangHoa";
            this.loaiHangHoaBindingSource.DataSource = this.qLHHDataSet;
            // 
            // qLHHDataSet
            // 
            this.qLHHDataSet.DataSetName = "QLHHDataSet";
            this.qLHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbldsSP
            // 
            this.lbldsSP.AutoSize = true;
            this.lbldsSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsSP.ForeColor = System.Drawing.Color.Cyan;
            this.lbldsSP.Location = new System.Drawing.Point(272, 9);
            this.lbldsSP.Name = "lbldsSP";
            this.lbldsSP.Size = new System.Drawing.Size(241, 25);
            this.lbldsSP.TabIndex = 1;
            this.lbldsSP.Text = "Danh Sách Sản Phẩm";
            // 
            // loaiHangHoaTableAdapter
            // 
            this.loaiHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(519, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormDsHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lbldsSP);
            this.Controls.Add(this.dgvLoaiHangHoa);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDsHangHoa";
            this.Text = "FromDsHangHoa";
            this.Load += new System.EventHandler(this.FormDsHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiHangHoa;
        private System.Windows.Forms.Label lbldsSP;
        private QLHHDataSet qLHHDataSet;
        private System.Windows.Forms.BindingSource loaiHangHoaBindingSource;
        private QLHHDataSetTableAdapters.LoaiHangHoaTableAdapter loaiHangHoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThem;
    }
}