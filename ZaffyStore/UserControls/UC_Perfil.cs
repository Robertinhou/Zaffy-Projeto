using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ZaffyStore.UserControls
{
    public partial class UC_Perfil : UserControl
    {
        public UC_Perfil()
        {
            InitializeComponent();

            Usuarios usuarios = new Usuarios();


            usuarios.Nome = Sessao.listaLogados[0].Nome;
            usuarios.Email = Sessao.listaLogados[0].Email;
            lblNomeUser.Text = usuarios.Nome;
            txtEmail.Text = usuarios.Email;
            MessageBox.Show(usuarios.Email);
        }

        private void UC_Perfil_Load(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();


        }

        private void btnEnvFoto_Click(object sender, EventArgs e)
        {

            // Caminho da pasta onde as imagens serão armazenadas
            string pastaImagens = Path.Combine(Application.StartupPath, "imagens_Perfil");

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
                // Caminho original da imagem selecionada
                string caminhoOriginal = openFileDialog.FileName;

                // Define o novo caminho para salvar a imagem
                string nomeImagem = Path.GetFileName(caminhoOriginal);
                string caminhoDestino = Path.Combine(pastaImagens, nomeImagem);

                // Copia a imagem para a pasta
                File.Copy(caminhoOriginal, caminhoDestino, true);

                // Salva o caminho da imagem no banco de dados
                Usuarios usuarios = new Usuarios();
                usuarios.CadastroInformacoes(caminhoDestino);
            }
        }
        
        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            mskdCep.Enabled = true;

            mskdCelular.Enabled = true;
            mskdCpf.Enabled = true;
            mskdDataNascimento.Enabled = true;
            btnEnvFoto.Enabled = true;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtBairro.Text.Equals("") && !txtCidade.Text.Equals("") && !txtEstado.Text.Equals("") &&
                    !txtRua.Text.Equals("") && mskdCelular.Text.Equals("") && mskdCep.Text.Equals("") && mskdCpf.Text.Equals("") && mskdDataNascimento.Text.Equals(""))
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.Bairro = txtBairro.Text;
                    usuarios.Rua = txtRua.Text;
                    usuarios.Cidade = txtCidade.Text;
                    usuarios.Estado = txtEstado.Text;
                    usuarios.Cpf = mskdCpf.Text;
                    usuarios.Cep = mskdCep.Text;
                    usuarios.Celular = mskdCelular.Text;
                    usuarios.Data_Nascimento = DateOnly.Parse(mskdDataNascimento.Text);


                    if (Usuarios.IsCpf(mskdCpf.Text))
                    {
                        btnSalvar.Enabled = true;

                        if (usuarios.CadastroInformacoes(lblCaminhoFoto.Text))
                        {
                            MessageBox.Show("INFOS SALVAS");
                        }
                        else 
                        {
                            MessageBox.Show("Erro ao cadastrar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido");
                    }

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            try
            {

                Endereco endereco = ApiCep.BuscarCep(mskdCep.Text); // Certifique-se de que isso retorna corretamente

                if (endereco != null)
                {
                    txtRua.Text = endereco.Logradouro;
                    txtCidade.Text = endereco.Localidade;
                    txtEstado.Text = endereco.Uf;
                    txtBairro.Text = endereco.Bairro;
                    txtRua.Enabled = true; txtCidade.Enabled = true; txtEstado.Enabled = true;
                }
                else
                {
                    MessageBox.Show("CEP não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar CEP: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

