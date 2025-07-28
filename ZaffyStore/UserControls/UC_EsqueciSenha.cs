using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaffyStore.UserControls;

namespace ZaffyStore.UserControls
{
    public partial class UC_EsqueciSenha : UserControl
    {
        public UC_EsqueciSenha()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Login login = new UC_Login();
            this.Controls.Clear();
            this.Controls.Add(login);
        }

        private void pbEyeClosed_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            pbEyeClosed.Visible = false;
        }

        private void pbEyeOpen_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            pbEyeClosed.Visible = true;
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            this.Controls.Clear();
            this.Controls.Add(login);
        }
    }
}
