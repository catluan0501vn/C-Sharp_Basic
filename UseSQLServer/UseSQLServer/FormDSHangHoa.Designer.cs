namespace UseSQLServer
{
    partial class FormDSHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSHangHoa));
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.cbbChonLoaiHangHoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimHangHoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 77);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(1224, 318);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // cbbChonLoaiHangHoa
            // 
            this.cbbChonLoaiHangHoa.FormattingEnabled = true;
            this.cbbChonLoaiHangHoa.Location = new System.Drawing.Point(125, 50);
            this.cbbChonLoaiHangHoa.Name = "cbbChonLoaiHangHoa";
            this.cbbChonLoaiHangHoa.Size = new System.Drawing.Size(220, 21);
            this.cbbChonLoaiHangHoa.TabIndex = 1;
            this.cbbChonLoaiHangHoa.SelectionChangeCommitted += new System.EventHandler(this.cbbChonLoaiHangHoa_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(506, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh Sách Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn Loại Hàng Hóa:";
            // 
            // txtTimHangHoa
            // 
            this.txtTimHangHoa.Location = new System.Drawing.Point(1014, 43);
            this.txtTimHangHoa.Name = "txtTimHangHoa";
            this.txtTimHangHoa.Size = new System.Drawing.Size(222, 20);
            this.txtTimHangHoa.TabIndex = 4;
            this.txtTimHangHoa.TextChanged += new System.EventHandler(this.txtTimHangHoa_TextChanged);
            // 
            // FormDSHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 407);
            this.Controls.Add(this.txtTimHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChonLoaiHangHoa);
            this.Controls.Add(this.dgvHangHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDSHangHoa";
            this.Text = "Tìm Danh Sách Hàng Hóa";
            this.Load += new System.EventHandler(this.FormDSHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.ComboBox cbbChonLoaiHangHoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimHangHoa;
    }
}