namespace Demo_WinForm
{
    partial class FormTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimer));
            this.ptsMe = new System.Windows.Forms.PictureBox();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptsMe)).BeginInit();
            this.SuspendLayout();
            // 
            // ptsMe
            // 
            this.ptsMe.Image = ((System.Drawing.Image)(resources.GetObject("ptsMe.Image")));
            this.ptsMe.Location = new System.Drawing.Point(12, 12);
            this.ptsMe.Name = "ptsMe";
            this.ptsMe.Size = new System.Drawing.Size(776, 350);
            this.ptsMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptsMe.TabIndex = 0;
            this.ptsMe.TabStop = false;
            this.ptsMe.Click += new System.EventHandler(this.ptsMe_Click);
            // 
            // t1
            // 
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.ptsMe);
            this.Name = "FormTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTimer";
            this.Load += new System.EventHandler(this.FormTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptsMe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptsMe;
        private System.Windows.Forms.Timer t1;
    }
}