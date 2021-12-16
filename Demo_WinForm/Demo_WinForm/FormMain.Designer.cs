namespace Demo_WinForm
{
    partial class FormMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hìnhHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhTamGiácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhVuôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hìnhTrònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workingWithTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hìnhHọcToolStripMenuItem,
            this.workingWithTimeToolStripMenuItem,
            this.newFormToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hìnhHọcToolStripMenuItem
            // 
            this.hìnhHọcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hìnhTamGiácToolStripMenuItem,
            this.hìnhVuôngToolStripMenuItem,
            this.hìnhTrònToolStripMenuItem});
            this.hìnhHọcToolStripMenuItem.Name = "hìnhHọcToolStripMenuItem";
            this.hìnhHọcToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.hìnhHọcToolStripMenuItem.Text = "Hình Học";
            // 
            // hìnhTamGiácToolStripMenuItem
            // 
            this.hìnhTamGiácToolStripMenuItem.Name = "hìnhTamGiácToolStripMenuItem";
            this.hìnhTamGiácToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hìnhTamGiácToolStripMenuItem.Text = "Hình Tam Giác";
            this.hìnhTamGiácToolStripMenuItem.Click += new System.EventHandler(this.hìnhTamGiácToolStripMenuItem_Click);
            // 
            // hìnhVuôngToolStripMenuItem
            // 
            this.hìnhVuôngToolStripMenuItem.Name = "hìnhVuôngToolStripMenuItem";
            this.hìnhVuôngToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hìnhVuôngToolStripMenuItem.Text = "Hình Vuông";
            this.hìnhVuôngToolStripMenuItem.Click += new System.EventHandler(this.hìnhVuôngToolStripMenuItem_Click);
            // 
            // hìnhTrònToolStripMenuItem
            // 
            this.hìnhTrònToolStripMenuItem.Name = "hìnhTrònToolStripMenuItem";
            this.hìnhTrònToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.hìnhTrònToolStripMenuItem.Text = "Hình Tròn";
            this.hìnhTrònToolStripMenuItem.Click += new System.EventHandler(this.hìnhTrònToolStripMenuItem_Click);
            // 
            // workingWithTimeToolStripMenuItem
            // 
            this.workingWithTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formTimerToolStripMenuItem});
            this.workingWithTimeToolStripMenuItem.Name = "workingWithTimeToolStripMenuItem";
            this.workingWithTimeToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.workingWithTimeToolStripMenuItem.Text = "Working With Time";
            // 
            // formTimerToolStripMenuItem
            // 
            this.formTimerToolStripMenuItem.Name = "formTimerToolStripMenuItem";
            this.formTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formTimerToolStripMenuItem.Text = "Form Timer";
            this.formTimerToolStripMenuItem.Click += new System.EventHandler(this.formTimerToolStripMenuItem_Click);
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFormToolStripMenuItem});
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.newFormToolStripMenuItem.Text = "New Form";
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginFormToolStripMenuItem.Text = "Login Form";
            this.loginFormToolStripMenuItem.Click += new System.EventHandler(this.loginFormToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hìnhHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhTamGiácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhVuôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hìnhTrònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workingWithTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginFormToolStripMenuItem;
    }
}