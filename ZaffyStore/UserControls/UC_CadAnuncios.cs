using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaffyStore.UserControls
{
    public partial class UC_CadAnuncios : UserControl
    {
        public UC_CadAnuncios()
        {
            InitializeComponent();

        }

        private Anuncios anuncios = new Anuncios();

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sessao.RemoverUsuarioLogado(Sessao.UsuarioAtual);

            UC_Login login = new UC_Login();

            this.Controls.Clear();
            this.Controls.Add(login);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Caminho da pasta onde as imagens serão armazenadas
            string pastaImagens = Path.Combine(Application.StartupPath, "imagens_anuncios");

            // Verifica se a pasta existe, caso contrário, cria a pasta
            if (!Directory.Exists(pastaImagens))
            {
                Directory.CreateDirectory(pastaImagens);
            }

            // Abre o dialog para o usuário selecionar a imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImagem.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                }
                // Caminho original da imagem selecionada
                string caminhoOriginal = openFileDialog.FileName;

                // Define o novo caminho para salvar a imagem
                string nomeImagem = Path.GetFileName(caminhoOriginal);
                string caminhoDestino = Path.Combine(pastaImagens, nomeImagem);



                // Copia a imagem para a pasta
                File.Copy(caminhoOriginal, caminhoDestino, true);

                // Salva o caminho da imagem no banco de dados

                anuncios.Foto = caminhoDestino;

            }
        }

        private void UC_CadAnuncios_Load(object sender, EventArgs e)
        {
            txtContato.Text = Sessao.UsuarioAtual.Celular;

            cbCategoria.Items.Add("Selecone a categoria");
            cbCategoria.Items.Add("Instrumentos");
            cbCategoria.Items.Add("Eletrônicos");
            cbCategoria.Items.Add("Roupas");
            cbCategoria.Items.Add("Móveis");
            cbCategoria.Items.Add("Brinquedos");
            cbCategoria.Items.Add("Ferramentas");
            cbCategoria.Items.Add("Livros");
            cbCategoria.Items.Add("Outros");
            cbCategoria.SelectedIndex = 0;


        }

        private void btnAnunciar_Click(object sender, EventArgs e)
        {

            try
            {

                if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtDesc.Text) &&
                    !string.IsNullOrWhiteSpace(cbCategoria.Text) &&
                    !string.IsNullOrWhiteSpace(mtxtPreco.Text) &&
                    !string.IsNullOrWhiteSpace(txtLocal.Text) &&
                    !string.IsNullOrWhiteSpace(txtContato.Text) &&
                    anuncios.Foto != null)

                {
                    anuncios.Nome = txtNome.Text;
                    anuncios.Descricao = txtDesc.Text;
                    anuncios.Categoria = cbCategoria.SelectedItem.ToString();
                    anuncios.Preco = double.Parse(mtxtPreco.Text);
                    anuncios.DataPost = DateTime.Now;
                    anuncios.Localidade = txtLocal.Text;
                    anuncios.Contato = txtContato.Text;
                    anuncios.Id_User = Convert.ToInt32(Sessao.UsuarioAtual.Id);

                    anuncios.Horario = DateTime.Now.TimeOfDay;

                    if (anuncios.CadastrarAnuncio())
                    {

                        MessageBox.Show("Anúncio cadastrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UC_Home home = new UC_Home();
                        this.Controls.Clear();
                        this.Controls.Add(home);

                    }
                    else
                    {
                        MessageBox.Show("Não cadastrou o anúncio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o anúncio: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void mtxtPreco_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mtxtPreco.Text, @"^\d+$"))
            {
                MessageBox.Show("Apenas números são permitidos no campo preço.");
                mtxtPreco.Clear();
            }
        }
    }
}
