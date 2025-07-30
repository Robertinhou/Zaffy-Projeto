using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZaffyStore.UserControls;

namespace ZaffyStore.UserControls
{
    public partial class UC_EsqueciSenha : UserControl
    {
        public UC_EsqueciSenha()
        {
            InitializeComponent();
            txtNovaSenha.UseSystemPasswordChar = true;
            txtNovaSenha.TextChanged += txtNovaSenha_TextChanged;
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Login login = new UC_Login();
            this.Controls.Clear();
            this.Controls.Add(login);
        }

        private void pbEyeClosed_Click(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = false;
            pbEyeClosed.Visible = false;
        }

        private void pbEyeOpen_Click(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = true;
            pbEyeClosed.Visible = true;
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtNovaSenha.Text.Equals(""))
                {

                    Usuarios usuarios = new Usuarios();
                    usuarios.Email = txtEmail.Text;
                    usuarios.Senha = txtNovaSenha.Text;

                    if (Usuarios.ValidarEmail(txtEmail.Text))
                    {
                        if (!usuarios.verificarEmailExistente())
                        {
                            usuarios.MudarSenha();
                            MessageBox.Show("Senha atualizada");

                            UC_Login login = new UC_Login();
                            this.Controls.Clear();
                            this.Controls.Add(login);
                        }
                        else
                        {
                            MessageBox.Show("Email não cadastrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }

        private void txtNovaSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = txtNovaSenha.Text;

            bool temTamanhoMinimo = senha.Length >= 8;
            bool temMaiuscula = senha.Any(char.IsUpper);
            bool temMinuscula = senha.Any(char.IsLower);
            bool temNumero = senha.Any(char.IsDigit);
            bool temEspecial = senha.Any(ch => !char.IsLetterOrDigit(ch));

            lblTamanho.Text = temTamanhoMinimo ? "✔ Mínimo 8 caracteres" : "✘ Mínimo 8 caracteres";
            lblTamanho.ForeColor = temTamanhoMinimo ? Color.Green : Color.Red;

            lblMaiuscula.Text = temMaiuscula ? "✔ Letra maiúscula" : "✘ Letra maiúscula";
            lblMaiuscula.ForeColor = temMaiuscula ? Color.Green : Color.Red;

            lblMinuscula.Text = temMinuscula ? "✔ Letra minúscula" : "✘ Letra minúscula";
            lblMinuscula.ForeColor = temMinuscula ? Color.Green : Color.Red;

            lblEspecial.Text = (temNumero && temEspecial) ? "✔ Número e caractere especial" : "✘ Número e caractere especial";
            lblEspecial.ForeColor = (temNumero && temEspecial) ? Color.Green : Color.Red;
        }

    }
}
