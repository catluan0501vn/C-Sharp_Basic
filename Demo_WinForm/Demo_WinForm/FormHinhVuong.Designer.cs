namespace Demo_WinForm
{
    partial class FormHinhVuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Số Cạnh:";
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(98, 31);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(146, 20);
            this.txtCanh.TabIndex = 4;
            // 
            // btnChuVi
            // 
            this.btnChuVi.Location = new System.Drawing.Point(98, 57);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(146, 23);
            this.btnChuVi.TabIndex = 5;
            this.btnChuVi.Text = "Chu Vi";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.Location = new System.Drawing.Point(98, 86);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(146, 23);
            this.btnDienTich.TabIndex = 6;
            this.btnDienTich.Text = "Diện Tích";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(95, 112);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(49, 13);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "Kết Quả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tính Hình Vuông";
            // 
            // FormHinhVuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.txtCanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormHinhVuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHinhVuong";
            this.Load += new System.EventHandler(this.FormHinhVuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label2;
    }
}