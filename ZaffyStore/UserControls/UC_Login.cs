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
using ZaffyStore;

namespace ZaffyStore.UserControls
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtLogin.Text.Equals("") && !txtLogin.Text.Equals(""))
                {

                    if (Usuarios.ValidarEmail(txtLogin.Text))
                    {
                        Usuarios usuarios = new Usuarios();
                        usuarios.Email = txtLogin.Text;
                        usuarios.Senha = txtSenha.Text;


                        if (!usuarios.verificarEmailExistente())
                        {
                            if (usuarios.verificarLogin())
                            {
                                string nomeLogado = usuarios.BuscarNome();


                                
                                UC_Home home = new UC_Home( );

                                this.Controls.Clear();
                                this.Controls.Add(home);


                            }
                            else
                            {
                                MessageBox.Show("Email e/ou senha incorreto(s)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não cadastrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O e-mail informado é inválido. Verifique e tente novamente.", "E-mail inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }

        }




        private void linkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_EsqueciSenha fgtPwd = new UC_EsqueciSenha();
            this.Controls.Clear();
            this.Controls.Add(fgtPwd);
        }

        private void pbEyeOpen_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            pbEyeClosed.Visible = true;
        }
        private void pbEyeClosed_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            pbEyeClosed.Visible = false;
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Cadastro cadastro = new UC_Cadastro();
            this.Controls.Clear();
            this.Controls.Add(cadastro);
        }
    }
}
