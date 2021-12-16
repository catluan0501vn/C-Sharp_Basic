namespace Demo_WinForm
{
    partial class FormHinhTamGiac
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoC = new System.Windows.Forms.Label();
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(318, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính Tam Giác";
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(12, 35);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(33, 13);
            this.lblSoA.TabIndex = 2;
            this.lblSoA.Text = "Số A:";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(12, 61);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(33, 13);
            this.lblSoB.TabIndex = 3;
            this.lblSoB.Text = "Số B:";
            // 
            // lblSoC
            // 
            this.lblSoC.AutoSize = true;
            this.lblSoC.Location = new System.Drawing.Point(12, 87);
            this.lblSoC.Name = "lblSoC";
            this.lblSoC.Size = new System.Drawing.Size(33, 13);
            this.lblSoC.TabIndex = 4;
            this.lblSoC.Text = "Số C:";
            // 
            // txtCanhA
            // 
            this.txtCanhA.BackColor = System.Drawing.SystemColors.Window;
            this.txtCanhA.Location = new System.Drawing.Point(53, 35);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(162, 20);
            this.txtCanhA.TabIndex = 5;
            // 
            // txtCanhB
            // 
            this.txtCanhB.Location = new System.Drawing.Point(53, 61);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(162, 20);
            this.txtCanhB.TabIndex = 6;
            // 
            // txtCanhC
            // 
            this.txtCanhC.Location = new System.Drawing.Point(53, 87);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(162, 20);
            this.txtCanhC.TabIndex = 7;
            // 
            // btnChuVi
            // 
            this.btnChuVi.BackColor = System.Drawing.Color.Cyan;
            this.btnChuVi.Location = new System.Drawing.Point(53, 123);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChuVi.Size = new System.Drawing.Size(162, 23);
            this.btnChuVi.TabIndex = 8;
            this.btnChuVi.Text = "Chu Vi";
            this.btnChuVi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChuVi.UseVisualStyleBackColor = false;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.BackColor = System.Drawing.Color.Yellow;
            this.btnDienTich.Location = new System.Drawing.Point(221, 123);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(143, 23);
            this.btnDienTich.TabIndex = 9;
            this.btnDienTich.Text = "Diện Tích";
            this.btnDienTich.UseVisualStyleBackColor = false;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(49, 149);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(71, 20);
            this.lblKetQua.TabIndex = 10;
            this.lblKetQua.Text = "Kết Quả:";
            // 
            // FormHinhTamGiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 347);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.txtCanhC);
            this.Controls.Add(this.txtCanhB);
            this.Controls.Add(this.txtCanhA);
            this.Controls.Add(this.lblSoC);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHinhTamGiac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHinhTamGiac";
            this.Load += new System.EventHandler(this.FormHinhTamGiac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoC;
        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Label lblKetQua;
    }
}