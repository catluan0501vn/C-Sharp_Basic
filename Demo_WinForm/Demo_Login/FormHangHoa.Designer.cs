namespace Demo_Login
{
    partial class FormHangHoa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangSáchHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.loạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLoạiHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHóaToolStripMenuItem,
            this.loạiHàngHóaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngHóaToolStripMenuItem,
            this.dangSáchHàngHóaToolStripMenuItem});
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            // 
            // thêmHàngHóaToolStripMenuItem
            // 
            this.thêmHàngHóaToolStripMenuItem.Name = "thêmHàngHóaToolStripMenuItem";
            this.thêmHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thêmHàngHóaToolStripMenuItem.Text = "Thêm Hàng Hóa";
            // 
            // dangSáchHàngHóaToolStripMenuItem
            // 
            this.dangSáchHàngHóaToolStripMenuItem.Name = "dangSáchHàngHóaToolStripMenuItem";
            this.dangSáchHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.dangSáchHàngHóaToolStripMenuItem.Text = "Danh Sách Hàng Hóa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loạiHàngHóaToolStripMenuItem
            // 
            this.loạiHàngHóaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLoạiHàngHóaToolStripMenuItem,
            this.danhSáchLoạiHàngHóaToolStripMenuItem});
            this.loạiHàngHóaToolStripMenuItem.Name = "loạiHàngHóaToolStripMenuItem";
            this.loạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.loạiHàngHóaToolStripMenuItem.Text = "Loại Hàng Hóa";
            // 
            // thêmLoạiHàngHóaToolStripMenuItem
            // 
            this.thêmLoạiHàngHóaToolStripMenuItem.Name = "thêmLoạiHàngHóaToolStripMenuItem";
            this.thêmLoạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.thêmLoạiHàngHóaToolStripMenuItem.Text = "Thêm Loại Hàng Hóa";
            this.thêmLoạiHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.thêmLoạiHàngHóaToolStripMenuItem_Click);
            // 
            // danhSáchLoạiHàngHóaToolStripMenuItem
            // 
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Name = "danhSáchLoạiHàngHóaToolStripMenuItem";
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Text = "Danh Sách Loại Hàng Hóa";
            this.danhSáchLoạiHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLoạiHàngHóaToolStripMenuItem_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangSáchHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLoạiHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLoạiHàngHóaToolStripMenuItem;
    }
}