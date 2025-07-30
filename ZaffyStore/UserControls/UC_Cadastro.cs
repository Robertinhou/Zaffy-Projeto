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
            txtSenha.TextChanged += txtSenha_TextChanged;

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
                            if (Usuarios.ValidarSenha(txtSenha.Text))
                            {
                                if (usuarios.CadastrarUsuario())
                                {
                                    MessageBox.Show("Cadastro realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                                MessageBox.Show("Senha não corresponde os requisitos");
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

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;

            bool temTamanhoMinimo = senha.Length >= 8;
            bool temMaiuscula = senha.Any(char.IsUpper);
            bool temMinuscula = senha.Any(char.IsLower);
            bool temNumero = senha.Any(char.IsDigit);
            bool temEspecial = senha.Any(ch => !char.IsLetterOrDigit(ch));

            lblTamanho.Text = temTamanhoMinimo ? "✔ Mínimo 8 caracteres" : "✘ Mínimo 8 caracteres";
            lblTamanho.ForeColor = temTamanhoMinimo ? Color.White : Color.Red;

            lblMaiuscula.Text = temMaiuscula ? "✔ Letra maiúscula" : "✘ Letra maiúscula";
            lblMaiuscula.ForeColor = temMaiuscula ? Color.White : Color.Red;

            lblMinuscula.Text = temMinuscula ? "✔ Letra minúscula" : "✘ Letra minúscula";
            lblMinuscula.ForeColor = temMinuscula ? Color.White : Color.Red;

            lblEspecial.Text = (temNumero && temEspecial) ? "✔ Número e caractere especial" : "✘ Número e caractere especial";
            lblEspecial.ForeColor = (temNumero && temEspecial) ? Color.White : Color.Red;
        }

    }
}
