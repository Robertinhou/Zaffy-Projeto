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
    public partial class UC_Perfil : UserControl
    {
        public UC_Perfil()
        {
            InitializeComponent();

            Usuarios usuarios = new Usuarios();
            txtEmail.Text = usuarios.Email;


            usuarios.Nome = Sessao.listaLogados[0].Nome;
            lblNomeUser.Text = usuarios.Nome;
        }

        private void UC_Perfil_Load(object sender, EventArgs e)
        {

        }

        private void btnEnvFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg*.jpeg;*.png)|*.jpg*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFotoUsuario.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                }
            }
        }



        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            mskdCep.Enabled = true;

            mskdCelular.Enabled = true;
            mskdCpf.Enabled = true;
            mskdDataNascimento.Enabled = true;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {

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

