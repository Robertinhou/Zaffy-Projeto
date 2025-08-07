using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZaffyStore.UserControls;

namespace ZaffyStore
{
    public partial class ConteudoLogged : Form
    {
        bool mouseDown;
        Point lastLocation;
        public Usuarios userLogado = new Usuarios();
        
        public ConteudoLogged(Usuarios user)
        {

            InitializeComponent();

            Sessao session = new Sessao();
            userLogado.Email = user.Email;
         
            userLogado.Senha = Usuarios.CriptografarSenha(user.Senha);

            session.BuscarLogado(userLogado);



            this.FormBorderStyle = FormBorderStyle.None;
            pnlTopL.MouseMove += pnlTopL_MouseMove;
            

        }




        private void Conteudo_Load(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            pnlContentLogged.Controls.Add(home);
            
        }

        

       

        // (Início) Eventos para movimentar o formulário
        private void pnlTopL_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
                Cursor = Cursors.SizeAll;
            }
        }

        private void pnlTopL_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X,
                    (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void pnlTopL_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
                Cursor = Cursors.Default;
            }
        }


        //    (fim) Eventos para movimentar o formulário 


        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {

            Cursor = Cursors.Hand;

        }

        private void pbMinimize_MouseLeave_1(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void pbMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        

       
    }
}
