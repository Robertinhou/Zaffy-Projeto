using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaffyStore.UserControls
{
    public partial class UC_Home : UserControl
    {
        private Image[] imagens;
        private int imagemAtual = 0;

        private int cardsCarregados = 0;
        private const int CARDS_POR_CARGA = 6;

        public UC_Home()
        {
            InitializeComponent();

            // UC_Home cresce com conteúdo
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;




        }

        private void UC_Home_Load(object sender, EventArgs e)
        {

            HorizontalScroll.Enabled = false;
            VerticalScroll.Enabled = true;
            HorizontalScroll.Visible = false;
            this.Dock = DockStyle.Fill;

            var formPrincipal = this.FindForm(); // Pega o formulário que contém este UserControl
            if (formPrincipal != null)
            {
                
                //formPrincipal.Size = new Size(1138, 945); // ou o tamanho que desejar
                formPrincipal.Size = new Size(1144, 984); // ou o tamanho que desejar
            }

            CarregarBanners();

            lblWelcome.Text = $"Bem-vindo, {Sessao.UsuarioAtual.Nome}!";

            if (imagens == null || imagens.Length == 0)
            {
                MessageBox.Show("Nenhuma imagem foi carregada.");
                return;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = imagens[imagemAtual];

            _ = TrocarBannersAsync();


            Anuncios anuncios = new Anuncios();
            anuncios.ListarAnuncios(dgvAnuncios);


        }

        private void CarregarBanners()
        {

            //string caminhoDasImagens = @"C:\Users\Robert\source\repos\home\ZaffyStore\Resources\banners\"; Robert
            // string caminhoDasImagens = @"C:\Users\Aluno_Manha\Source\Repos\Zaffy-ProjetoAtual\ZaffyStore\Resources\banners\";//  Matheus pc senai
            string caminhoDasImagens = @"C:\Users\Aluno_Tarde\source\repos\Zaffy-Projeto\ZaffyStore\Resources\banners\"; // matheus notebook tarde
            //  string caminhoDasImagens = @"C:\Users\Aluno_Manha\Desktop\zaffy\Zaffy-Projeto\ZaffyStore\Resources\banners\";


            if (Directory.Exists(caminhoDasImagens))
            {
                var arquivos = Directory.GetFiles(caminhoDasImagens, "*.*")
                    .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                f.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                imagens = arquivos.Select(imgPath => Image.FromFile(imgPath)).ToArray();
            }
            else
            {
                MessageBox.Show("Pasta de imagens não encontrada.");
            }
        }

        private async Task TrocarBannersAsync()
        {
            while (true)
            {
                await Task.Delay(4000);
                int proximoIndice = (imagemAtual + 1) % imagens.Length;
                Image proximaImagem = imagens[proximoIndice];
                await SlideTransition(pictureBox1.Image, proximaImagem);
                pictureBox1.Image = proximaImagem;
                imagemAtual = proximoIndice;
            }
        }

        private async Task SlideTransition(Image atual, Image proxima)
        {
            Bitmap frame = new Bitmap(pictureBox1.Width * 2, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(frame))
            {
                g.DrawImage(atual, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                g.DrawImage(proxima, new Rectangle(pictureBox1.Width, 0, pictureBox1.Width, pictureBox1.Height));
            }

            int x = 0;
            int step = 20;
            int total = pictureBox1.Width;

            while (x < total)
            {
                Bitmap sub = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(sub))
                {
                    g.DrawImage(frame, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height),
                        new Rectangle(x, 0, pictureBox1.Width, pictureBox1.Height), GraphicsUnit.Pixel);
                }

                pictureBox1.Image = sub;
                x += step;
                await Task.Delay(10);
            }
        }


        private void lnkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Perfil perfil = new UC_Perfil();
            this.Controls.Clear();
            this.Controls.Add(perfil);
        }


        private void dgvAnuncios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkCadAnuncios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UC_CadAnuncios anunciar = new UC_CadAnuncios();
            this.Controls.Clear();
            this.Controls.Add(anunciar);

        }

        private void lnkMeuAnuncio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            UC_MeusAnuncios meusAnuncios = new UC_MeusAnuncios();

            this.Controls.Clear();
            this.Controls.Add(meusAnuncios);

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void cardFoto_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void cardFoto_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void cardFoto_Click(object sender, EventArgs e)
        {

            UC_paginaCompra comprar = new UC_paginaCompra();
            this.Controls.Clear();
            this.Controls.Add(comprar);

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            UC_paginaCompra comprar = new UC_paginaCompra();
            this.Controls.Clear();
            this.Controls.Add(comprar);
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            Sessao.RemoverUsuarioLogado(Sessao.UsuarioAtual);

            UC_Login login = new UC_Login();

            this.Controls.Clear();
            this.Controls.Add(login);
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {
            UC_Perfil perfil = new UC_Perfil();
            this.Controls.Clear();
            this.Controls.Add(perfil);
        }
    }
}
