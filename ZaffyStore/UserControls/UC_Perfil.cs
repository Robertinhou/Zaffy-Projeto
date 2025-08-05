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

        private void lblNomeUser_Click(object sender, EventArgs e)
        {
            


        }
    }
}
