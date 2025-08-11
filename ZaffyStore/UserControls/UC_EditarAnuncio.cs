using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Globalization;

namespace ZaffyStore.UserControls
{
    public partial class UC_EditarAnuncio : UserControl
    {
        private Anuncios anuncioAtual;

        public UC_EditarAnuncio(Anuncios anuncio)
        {
            InitializeComponent();
            anuncioAtual = anuncio;
        }

        private void UC_EditarAnuncio_Load(object sender, EventArgs e)
        {
            txtNome.Text = anuncioAtual.Nome;
            txtDesc.Text = anuncioAtual.Descricao;

            cbCategoria.Items.AddRange(new object[]
            {
        "Instrumentos", "Eletrônicos", "Roupas", "Móveis", "Brinquedos", "Ferramentas", "Livros", "Outros"
            });
            cbCategoria.SelectedItem = anuncioAtual.Categoria;

            mtxtPreco.Text = anuncioAtual.Preco.ToString("N2");
            txtLocal.Text = anuncioAtual.Localidade;
            txtContato.Text = anuncioAtual.Contato;

            //pbImagem.Image = anuncioAtual.Foto;
            // Puxa imagem ao carregar

            if (!string.IsNullOrEmpty(anuncioAtual.Foto) && File.Exists(anuncioAtual.Foto))
            {

                pbImagem.Image = Image.FromFile(anuncioAtual.Foto);

            }
            else
            {
                pbImagem.Image = null; // ou imagem padrão
            }
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {
            string pastaImagens = Path.Combine(Application.StartupPath, "imagens_anuncios");

            if (!Directory.Exists(pastaImagens))
                Directory.CreateDirectory(pastaImagens);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pbImagem.Image = new Bitmap(openFileDialog.FileName);

                        string nomeImagem = Path.GetFileName(openFileDialog.FileName);
                        string caminhoDestino = Path.Combine(pastaImagens, nomeImagem);

                        File.Copy(openFileDialog.FileName, caminhoDestino, true);
                        anuncioAtual.Foto = caminhoDestino;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtDesc.Text) &&
                    cbCategoria.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(mtxtPreco.Text) &&
                    !string.IsNullOrWhiteSpace(txtLocal.Text) &&
                    !string.IsNullOrWhiteSpace(txtContato.Text))
                {
                    anuncioAtual.Nome = txtNome.Text;
                    anuncioAtual.Descricao = txtDesc.Text;
                    anuncioAtual.Categoria = cbCategoria.SelectedItem.ToString();
                    anuncioAtual.Preco = double.Parse(mtxtPreco.Text, new CultureInfo("pt-BR"));
                    anuncioAtual.Localidade = txtLocal.Text;
                    anuncioAtual.Contato = txtContato.Text;
                    anuncioAtual.Horario = DateTime.Now.TimeOfDay;
                    

                    if (anuncioAtual.AtualizarAnuncio())
                    {
                        MessageBox.Show("Anúncio atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Redireciona para Home
                        UC_Home home = new UC_Home();
                        this.Controls.Clear();
                        this.Controls.Add(home);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o anúncio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Preço em formato inválido. Use vírgula para separar os centavos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        private void mtxtPreco_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(mtxtPreco.Text, @"^\d+(,\d{0,2})?$"))
            {
                MessageBox.Show("Apenas números são permitidos no campo preço. Use vírgula para centavos.");
                mtxtPreco.Clear();
            }
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkCadAnuncios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_CadAnuncios cadAnuncios = new UC_CadAnuncios();
            this.Controls.Clear();
            this.Controls.Add(cadAnuncios);
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Sessao.RemoverUsuarioLogado(Sessao.UsuarioAtual);
            UC_Login login = new UC_Login();
            this.Controls.Clear();
            this.Controls.Add(login);
        }


        private void linkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Home home = new UC_Home();
            this.Controls.Clear();
            this.Controls.Add(home);
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            UC_Perfil perfil = new UC_Perfil();
            this.Controls.Clear();
            this.Controls.Add(perfil);
            
        }
    }
}
