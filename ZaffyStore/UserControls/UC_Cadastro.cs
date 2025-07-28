using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ZaffyStore.UserControls;
using ZaffyStore;

namespace ZaffyStore.UserControls
{
    public partial class UC_Cadastro : UserControl
    {
        public UC_Cadastro()
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtNomeUsuario.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    Usuarios usuarios = new Usuarios();
                    usuarios.Nome = txtNomeUsuario.Text;
                    usuarios.Email = txtEmail.Text;
                    usuarios.Senha = txtSenha.Text;

                    if (Usuarios.ValidarEmail(txtEmail.Text))
                    {
                        if (usuarios.verificarEmailExistente())
                        {
                            if (usuarios.CadastrarUsuario())
                            {
                                MessageBox.Show("Cadastro realizado" + MessageBoxButtons.OK);

                                UC_Login login = new UC_Login();
                                this.Controls.Clear();
                                this.Controls.Add(login);
                            }
                            else
                            {
                                MessageBox.Show("Falha ao cadastrar usuário");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email já cadastrado!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido ou incorreto");

                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }
    }
}
