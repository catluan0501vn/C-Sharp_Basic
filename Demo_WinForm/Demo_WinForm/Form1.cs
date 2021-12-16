using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var a = MessageBox.Show("Do you want to close?", "Warning !",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning);
            if (a != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
