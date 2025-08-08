namespace ZaffyStore.UserControls
{
    partial class UC_paginaCompra
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lnkPerfil = new LinkLabel();
            pnlNavBar = new Panel();
            lnkHome = new LinkLabel();
            btnEntrarEmContato = new Button();
            lblLocal = new Label();
            pbImagem = new PictureBox();
            lblDescricao = new Label();
            lblContato = new Label();
            lblPreco = new Label();
            lblProdName = new Label();
            lblDescricaoProd = new Label();
            pictureBox2 = new PictureBox();
            linkHome = new LinkLabel();
            pbLogout = new PictureBox();
            pbPerfil = new PictureBox();
            lnkCadAnuncios = new LinkLabel();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            SuspendLayout();
            // 
            // lnkPerfil
            // 
            lnkPerfil.AutoSize = true;
            lnkPerfil.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkPerfil.LinkColor = Color.White;
            lnkPerfil.Location = new Point(360, 9);
            lnkPerfil.Name = "lnkPerfil";
            lnkPerfil.Size = new Size(42, 15);
            lnkPerfil.TabIndex = 5;
            lnkPerfil.TabStop = true;
            lnkPerfil.Text = "PERFIL";
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(linkHome);
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkPerfil);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(786, 62);
            pnlNavBar.TabIndex = 3;
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(84, 9);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(42, 15);
            lnkHome.TabIndex = 4;
            lnkHome.TabStop = true;
            lnkHome.Text = "HOME";
            lnkHome.LinkClicked += lnkHome_LinkClicked;
            // 
            // btnEntrarEmContato
            // 
            btnEntrarEmContato.BackColor = Color.FromArgb(115, 76, 191);
            btnEntrarEmContato.ForeColor = Color.White;
            btnEntrarEmContato.Location = new Point(589, 419);
            btnEntrarEmContato.Name = "btnEntrarEmContato";
            btnEntrarEmContato.Size = new Size(126, 40);
            btnEntrarEmContato.TabIndex = 39;
            btnEntrarEmContato.Text = "Contatar";
            btnEntrarEmContato.UseVisualStyleBackColor = false;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(32, 447);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(325, 22);
            lblLocal.TabIndex = 37;
            lblLocal.Text = "Local: Casa do Cristiano Ronaldo - Lisboa\r\n";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.download__1_;
            pbImagem.Location = new Point(277, 58);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(257, 179);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 36;
            pbImagem.TabStop = false;
            pbImagem.Click += pbImagem_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(32, 305);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 22);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "Descrição";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(580, 379);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(148, 22);
            lblContato.TabIndex = 31;
            lblContato.Text = "Contato: Anônimo";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(580, 337);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(135, 22);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Preço: R$8000.7";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdName.Location = new Point(32, 256);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(393, 29);
            lblProdName.TabIndex = 23;
            lblProdName.Text = "PS4 slim do Cristiano Ronaldo (Jr)";
            // 
            // lblDescricaoProd
            // 
            lblDescricaoProd.AutoSize = true;
            lblDescricaoProd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoProd.Location = new Point(32, 337);
            lblDescricaoProd.Name = "lblDescricaoProd";
            lblDescricaoProd.Size = new Size(404, 22);
            lblDescricaoProd.TabIndex = 40;
            lblDescricaoProd.Text = "PS4 do filho do cristiano ronaldo. Busca a combinar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(3, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            linkHome.LinkColor = Color.White;
            linkHome.Location = new Point(84, 27);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(55, 19);
            linkHome.TabIndex = 47;
            linkHome.TabStop = true;
            linkHome.Text = "HOME";
            // 
            // pbLogout
            // 
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(745, 0);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(38, 35);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 46;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pbPerfil
            // 
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(699, 0);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(38, 35);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 45;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(166, 27);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(92, 19);
            lnkCadAnuncios.TabIndex = 44;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            // 
            // UC_paginaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescricaoProd);
            Controls.Add(btnEntrarEmContato);
            Controls.Add(lblLocal);
            Controls.Add(pbImagem);
            Controls.Add(lblDescricao);
            Controls.Add(lblContato);
            Controls.Add(lblPreco);
            Controls.Add(lblProdName);
            Controls.Add(pnlNavBar);
            Name = "UC_paginaCompra";
            Size = new Size(786, 567);
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel lnkPerfil;
        private Panel pnlNavBar;
        private LinkLabel lnkHome;
        private Button btnEntrarEmContato;
        private Label lblLocal;
        private PictureBox pbImagem;
        private Label lblDescricao;
        private Label lblContato;
        private Label lblPreco;
        private Label lblProdName;
        private Label lblDescricaoProd;
        private PictureBox pictureBox2;
        private LinkLabel linkHome;
        private PictureBox pbLogout;
        private PictureBox pbPerfil;
        private LinkLabel lnkCadAnuncios;
    }
}
