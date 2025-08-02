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
using System.Net.Mail;
using System.Net;

namespace ZaffyStore.UserControls
{
    public partial class UC_EsqueciSenha : UserControl
    {
        public UC_EsqueciSenha()
        {
            InitializeComponent();
            txtNovaSenha.UseSystemPasswordChar = true;
            txtNovaSenha.TextChanged += txtNovaSenha_TextChanged;
            txtNovaSenha.Enabled = false;
            btnMudarSenha.Visible = false;
            txtCodigo.Visible = false;
            lblCodigo.Visible = false;
            linkLogin.Visible = false;
            panelSenha.Visible = false;
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

        private string codigoGerado;

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNovaSenha.Enabled == true)
                {
                    if (txtCodigo.Text != codigoGerado)
                    {
                        MessageBox.Show("Código inválido. Verifique o código enviado para seu email.");
                        return;
                    }
                    else
                    {

                    }

                    if (!txtEmail.Text.Equals(""))
                    {
                        Usuarios usuarios = new Usuarios();
                        usuarios.Email = txtEmail.Text;
                        usuarios.BuscarNome();

                        if (Usuarios.ValidarEmail(txtEmail.Text))
                        {
                            if (!usuarios.verificarEmailExistente())
                            {
                                if (!txtNovaSenha.Text.Equals(""))
                                {
                                    usuarios.Senha = txtNovaSenha.Text;
                                    if (Usuarios.ValidarSenha(txtNovaSenha.Text))
                                    {
                                        if (usuarios.MudarSenha())
                                        {
                                            MessageBox.Show("Senha atualizada");
                                            UC_Login login = new UC_Login();
                                            this.Controls.Clear();
                                            this.Controls.Add(login);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Não atualizou a senha mas chegou aqui");
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Senha não corresponde os requisitos");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Preencha a senha!");
                                }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }




        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuarios = new Usuarios();
                if (txtNovaSenha.Enabled == false)
                {
                    if (!txtEmail.Text.Equals(""))
                    {
                        usuarios.Email = txtEmail.Text;

                        if (Usuarios.ValidarEmail(txtEmail.Text))
                        {
                            if (!usuarios.verificarEmailExistente())
                            {
                                MailMessage mail = new MailMessage();
                                mail.From = new MailAddress("noreply@gmail.com", "Zaffy");
                                mail.To.Add(new MailAddress(txtEmail.Text));

                                Random r = new Random();

                                string codigo = "";

                                // for define o tamanho 
                                for (int i = 0; i < 6; i++)
                                {
                                    // random define de 0 a 9
                                    codigo += r.Next(9).ToString();
                                }

                                codigoGerado = codigo;
                                txtCodigo.Text = "";  // limpa para o usuário digitar o código recebido no email

                                mail.Subject = "Redefinição de Senha";
                                mail.Body = $"Foi solicitada a mudança de senha para sua conta Zaffy! O seu código é {codigo}";

                                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtp.UseDefaultCredentials = false;
                                    smtp.EnableSsl = true;
                                    smtp.Credentials = new NetworkCredential("robertmenezesp9@gmail.com", "yjjfaiiwulmsuieu");

                                    try
                                    {
                                        smtp.Send(mail);
                                        MessageBox.Show("Código enviado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //txtCodigo.Text = codigo;
                                        txtNovaSenha.Enabled = true;
                                        panelSenha.Visible = true;
                                        btnEnviar.Visible = false;
                                        btnMudarSenha.Visible = true;
                                        txtCodigo.Visible = true;
                                        lblCodigo.Visible = true;
                                        linkLogin.Visible = true;
                                        txtEmail.Enabled = false;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Email não enviado");
                                    }
                                }
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
