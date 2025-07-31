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
                                mail.To.Add(new MailAddress("0001082383@senaimgaluno.com.br", "Matheus"));

                                Random r = new Random();

                                string codigo = "";

                                for (int i = 0; i < 9; i++)
                                {
                                    codigo += r.Next(6).ToString();
                                }

                                MessageBox.Show(codigo);

                                mail.Subject = "Redefinição de Senha";
                                mail.Body = $"Foi solicitada a mudança de senha para sua conta Zaffy! O seu código é {codigo}";

                                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                                {
                                    smtp.UseDefaultCredentials = false;
                                    smtp.EnableSsl = true;
                                    smtp.Credentials = new NetworkCredential("robertmenezesp9@gmail.com", "bsjykctzdcwxumhn");

                                    try
                                    {
                                        smtp.Send(mail);
                                        MessageBox.Show("Enviado!");
                                        txtNovaSenha.Enabled = true;
                                        btnEnviar.Visible = false;
                                        btnMudarSenha.Visible = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Não mandou");
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
                else // se for verdadeiro vai mandar email senao o txt senha ativa e redefine a senha
                {
                    if (!txtNovaSenha.Text.Equals(""))
                    {
                        usuarios.Email = txtEmail.Text;
                        usuarios.Senha = txtNovaSenha.Text;

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

        private void UC_EsqueciSenha_Load(object sender, EventArgs e)
        {

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
                                mail.To.Add(new MailAddress("0001082383@senaimgaluno.com.br", "Matheus"));

                                Random r = new Random();

                                string codigo = "";

                                for (int i = 0; i < 9; i++)
                                {
                                    codigo += r.Next(6).ToString();
                                }

                               // MessageBox.Show(codigo);

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
                                        MessageBox.Show("Enviado!");
                                        txtCodigo.Text = codigo;
                                        txtNovaSenha.Enabled = true;
                                        btnEnviar.Visible = false;
                                        btnMudarSenha.Visible = true;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message, "Não mandou");
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
                else // se for verdadeiro vai mandar email senao o txt senha ativa e redefine a senha
                {
                    if (!txtNovaSenha.Text.Equals(""))
                    {
                        usuarios.Email = txtEmail.Text;
                        usuarios.Senha = txtNovaSenha.Text;

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}
