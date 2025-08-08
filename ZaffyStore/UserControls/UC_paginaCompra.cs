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

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Sessao.RemoverUsuarioLogado(Sessao.UsuarioAtual);
            UC_Login login = new UC_Login();
            this.Parent.Controls.Clear();
            this.Parent.Controls.Add(login);
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            UC_Perfil perfil = new UC_Perfil();
            this.Parent.Controls.Clear();
            this.Parent.Controls.Add(perfil);
        }

        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Home home = new UC_Home();
            this.Parent.Controls.Clear();
            this.Parent.Controls.Add(home);
        }

        private void lnkCadAnuncios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_CadAnuncios cadAnuncios = new UC_CadAnuncios();
            this.Parent.Controls.Clear();
            this.Parent.Controls.Add(cadAnuncios);
        }
    }
}
