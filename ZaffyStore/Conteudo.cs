using ZaffyStore.UserControls;

namespace ZaffyStore
{
    public partial class Conteudo : Form
    {

        bool mouseDown;
        Point lastLocation;

<<<<<<< HEAD
=======

>>>>>>> homeNavBar
        public Conteudo()
        {
            InitializeComponent();
        }

        private void Conteudo_Load(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            adicionarUserControl(login);
        }

<<<<<<< HEAD
=======

        

>>>>>>> homeNavBar
        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
<<<<<<< HEAD

        private void Conteudo_Scroll(object sender, ScrollEventArgs e)
        {

        }
=======
>>>>>>> homeNavBar
    }
}
