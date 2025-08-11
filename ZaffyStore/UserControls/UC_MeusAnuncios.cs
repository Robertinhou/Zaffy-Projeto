using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaffyStore.UserControls
{
    public partial class UC_MeusAnuncios : UserControl
    {
        public UC_MeusAnuncios()
        {
            InitializeComponent();
        }

        private void UC_MeusAnuncios_Load(object sender, EventArgs e)
        {

            Anuncios anuncios = new Anuncios();
            anuncios.ListarMeusAnuncios(dgvMeusAnuncios);

        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Home home = new UC_Home();

            this.Controls.Clear();

            this.Controls.Add(home);
        }

        private void lnkCadAnuncios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_CadAnuncios cadAnuncios = new UC_CadAnuncios();
            this.Controls.Clear();
            this.Controls.Add(cadAnuncios);
        }

        private void lnkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Perfil perfil = new UC_Perfil();
            this.Controls.Clear();
            this.Controls.Add(perfil);
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Sessao.RemoverUsuarioLogado(Sessao.UsuarioAtual);

            UC_Login login = new UC_Login();

            this.Controls.Clear();
            this.Controls.Add(login);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            Anuncios anuncios = new Anuncios();
            anuncios.ListarMeusAnuncios(dgvMeusAnuncios);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            // Verifica se alguma linha está selecionada
            if (dgvMeusAnuncios.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    Anuncios anuncios = new Anuncios();
                    anuncios.Id_Anuncio = Convert.ToInt32(dgvMeusAnuncios.CurrentRow.Cells[0].Value);
                    anuncios.DeletarAnuncio();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dgvMeusAnuncios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Anuncios anuncio = new Anuncios();
            anuncio.Id_Anuncio = Convert.ToInt32(dgvMeusAnuncios.CurrentRow.Cells[0].Value);
            anuncio.Nome = Convert.ToString(dgvMeusAnuncios.CurrentRow.Cells[1].Value);
            anuncio.Descricao = Convert.ToString(dgvMeusAnuncios.CurrentRow.Cells[2].Value);
            anuncio.Categoria = Convert.ToString(dgvMeusAnuncios.CurrentRow.Cells[3].Value);
            anuncio.Preco = Convert.ToDouble(dgvMeusAnuncios.CurrentRow.Cells[4].Value);
            
            anuncio.DataPost = DateTime.Parse(dgvMeusAnuncios.CurrentRow.Cells[5].Value.ToString());
            string horario = dgvMeusAnuncios.CurrentRow.Cells[6].Value.ToString();
            anuncio.Horario = TimeSpan.Parse(horario);
            anuncio.Localidade = Convert.ToString(dgvMeusAnuncios.CurrentRow.Cells[7].Value);
            anuncio.Contato = Convert.ToString(dgvMeusAnuncios.CurrentRow.Cells[8].Value);
            anuncio.Id_User = int.Parse(dgvMeusAnuncios.CurrentRow.Cells[9].Value.ToString());
            anuncio.Foto = Convert.ToString(dgvMeusAnuncios.CurrentRow.Cells[10].Value);


            UC_EditarAnuncio editar = new UC_EditarAnuncio(anuncio);
            this.Controls.Clear();
            this.Controls.Add(editar);

        }

        private void pnlNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMeusAnuncios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
