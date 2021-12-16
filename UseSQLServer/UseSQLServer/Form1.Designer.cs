namespace UseSQLServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLoạiSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhàCungCấpToolStripMenuItem,
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem,
            this.hàngHóaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(827, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýNhàCungCấpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmNCCToolStripMenuItem,
            this.danhSáchNCCToolStripMenuItem});
            this.quảnLýNhàCungCấpToolStripMenuItem.Name = "quảnLýNhàCungCấpToolStripMenuItem";
            this.quảnLýNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.quảnLýNhàCungCấpToolStripMenuItem.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // thêmNCCToolStripMenuItem
            // 
            this.thêmNCCToolStripMenuItem.Name = "thêmNCCToolStripMenuItem";
            this.thêmNCCToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thêmNCCToolStripMenuItem.Text = "Thêm NCC";
            // 
            // danhSáchNCCToolStripMenuItem
            // 
            this.danhSáchNCCToolStripMenuItem.Name = "danhSáchNCCToolStripMenuItem";
            this.danhSáchNCCToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.danhSáchNCCToolStripMenuItem.Text = "Danh Sách NCC";
            this.danhSáchNCCToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNCCToolStripMenuItem_Click);
            // 
            // quảnLýLoạiSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLoạiSPToolStripMenuItem,
            this.danhSáchLoạiSPToolStripMenuItem});
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Quản Lý Loại Sản Phẩm";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // thêmLoạiSPToolStripMenuItem
            // 
            this.thêmLoạiSPToolStripMenuItem.Name = "thêmLoạiSPToolStripMenuItem";
            this.thêmLoạiSPToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thêmLoạiSPToolStripMenuItem.Text = "Thêm Loại SP";
            // 
            // danhSáchLoạiSPToolStripMenuItem
            // 
            this.danhSáchLoạiSPToolStripMenuItem.Name = "danhSáchLoạiSPToolStripMenuItem";
            this.danhSáchLoạiSPToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.danhSáchLoạiSPToolStripMenuItem.Text = "Danh Sách Loại SP";
            this.danhSáchLoạiSPToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLoạiSPToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngHóaToolStripMenuItem,
            this.quảnLýHàngHóaToolStripMenuItem});
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            // 
            // thêmHàngHóaToolStripMenuItem
            // 
            this.thêmHàngHóaToolStripMenuItem.Name = "thêmHàngHóaToolStripMenuItem";
            this.thêmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.thêmHàngHóaToolStripMenuItem.Text = "Thêm Hàng Hóa";
            this.thêmHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngHóaToolStripMenuItem_Click);
            // 
            // quảnLýHàngHóaToolStripMenuItem
            // 
            this.quảnLýHàngHóaToolStripMenuItem.Name = "quảnLýHàngHóaToolStripMenuItem";
            this.quảnLýHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.quảnLýHàngHóaToolStripMenuItem.Text = "Quản Lý Hàng Hóa";
            this.quảnLýHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHàngHóaToolStripMenuItem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnThoat.Location = new System.Drawing.Point(740, 27);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(558, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Develop By .NET Developer - Anthony Luận";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Hàng Hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLoạiSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLoạiSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHàngHóaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

