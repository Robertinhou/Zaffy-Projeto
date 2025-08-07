using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaffyStore.UserControls
{
    public partial class UC_paginaCompra : UserControl
    {
        public UC_paginaCompra()
        {
            InitializeComponent();
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {

        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Home home = new UC_Home();
            this.Controls.Clear();
            this.Controls.Add(home);

        }
    }
}
