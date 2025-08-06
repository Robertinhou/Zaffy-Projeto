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



            CarregarBanners();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {

           
           

            if (Sessao.UsuarioAtual != null)
            {
                MessageBox.Show($"Bem-vindoou, {Sessao.UsuarioAtual.Nome}!");
            }

            if (imagens == null || imagens.Length == 0)
            {
                MessageBox.Show("Nenhuma imagem foi carregada.");
                return;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = imagens[imagemAtual];

            _ = TrocarBannersAsync();
        }

        private void CarregarBanners()
        {
            string caminhoDasImagens = @"C:\Users\Robert\source\repos\home\ZaffyStore\Resources\banners\";

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

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Sessao.RemoverUsuarioLogado(Sessao.UsuarioAtual);

            UC_Login login = new UC_Login();

            this.Controls.Clear();
            this.Controls.Add(login);

        }
    }
}
