using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtUsername.Text;
            string pass = txtPassword.Text;

            if(id == "sa" && pass == "sapassword")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }    
            else
            {
                MessageBox.Show("Username hoặc Password không đúng !",
                                "Thông Báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }    
        }
    }
}
