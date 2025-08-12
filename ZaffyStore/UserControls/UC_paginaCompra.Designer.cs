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
            pnlNavBar = new Panel();
            pictureBox2 = new PictureBox();
            linkHome = new LinkLabel();
            pbLogout = new PictureBox();
            pbPerfil = new PictureBox();
            lnkCadAnuncios = new LinkLabel();
            btnEntrarEmContato = new Button();
            lblLocal = new Label();
            pbImagem = new PictureBox();
            lblDescricao = new Label();
            lblContato = new Label();
            lblPreco = new Label();
            lblProdName = new Label();
            lblDescricaoProd = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(linkHome);
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1144, 63);
            pnlNavBar.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Cursor = Cursors.Hand;
            linkHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            linkHome.LinkColor = Color.White;
            linkHome.Location = new Point(104, 16);
            linkHome.Margin = new Padding(4, 0, 4, 0);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(82, 28);
            linkHome.TabIndex = 47;
            linkHome.TabStop = true;
            linkHome.Text = "HOME";
            linkHome.LinkClicked += linkHome_LinkClicked;
            // 
            // pbLogout
            // 
            pbLogout.Cursor = Cursors.Hand;
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(1083, 3);
            pbLogout.Margin = new Padding(4, 5, 4, 5);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(54, 58);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 46;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pbPerfil
            // 
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(1018, 3);
            pbPerfil.Margin = new Padding(4, 5, 4, 5);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(54, 58);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 45;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.Cursor = Cursors.Hand;
            lnkCadAnuncios.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(208, 16);
            lnkCadAnuncios.Margin = new Padding(4, 0, 4, 0);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(139, 28);
            lnkCadAnuncios.TabIndex = 44;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // btnEntrarEmContato
            // 
            btnEntrarEmContato.BackColor = Color.FromArgb(115, 76, 191);
            btnEntrarEmContato.ForeColor = Color.White;
            btnEntrarEmContato.Location = new Point(873, 766);
            btnEntrarEmContato.Margin = new Padding(4, 5, 4, 5);
            btnEntrarEmContato.Name = "btnEntrarEmContato";
            btnEntrarEmContato.Size = new Size(180, 67);
            btnEntrarEmContato.TabIndex = 39;
            btnEntrarEmContato.Text = "Contatar";
            btnEntrarEmContato.UseVisualStyleBackColor = false;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(459, 335);
            lblLocal.Margin = new Padding(4, 0, 4, 0);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(398, 29);
            lblLocal.TabIndex = 37;
            lblLocal.Text = "Casa do Cristiano Ronaldo - Lisboa\r\n";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.download__1_;
            pbImagem.Location = new Point(51, 127);
            pbImagem.Margin = new Padding(4, 5, 4, 5);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(349, 327);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 36;
            pbImagem.TabStop = false;
            pbImagem.Click += pbImagem_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(51, 548);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(120, 29);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "Descrição";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(370, 287);
            lblContato.Margin = new Padding(4, 0, 4, 0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(217, 29);
            lblContato.TabIndex = 31;
            lblContato.Text = "Contato: Anônimo";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 19F, FontStyle.Bold);
            lblPreco.Location = new Point(370, 114);
            lblPreco.Margin = new Padding(4, 0, 4, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(213, 49);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "R$8000,00";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdName.Location = new Point(370, 56);
            lblProdName.Margin = new Padding(4, 0, 4, 0);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(161, 44);
            lblProdName.TabIndex = 23;
            lblProdName.Text = "PS4 Slim\r\n";
            // 
            // lblDescricaoProd
            // 
            lblDescricaoProd.AutoSize = true;
            lblDescricaoProd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoProd.Location = new Point(4, 20);
            lblDescricaoProd.Margin = new Padding(4, 0, 4, 0);
            lblDescricaoProd.Name = "lblDescricaoProd";
            lblDescricaoProd.Size = new Size(394, 87);
            lblDescricaoProd.TabIndex = 40;
            lblDescricaoProd.Text = "PS4 do filho do cristiano ronaldo. \r\n\r\nEntrega a combinar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 335);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 29);
            label1.TabIndex = 41;
            label1.Text = "Local:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblDescricaoProd);
            panel1.Location = new Point(51, 590);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 243);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lblProdName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblPreco);
            panel2.Controls.Add(lblContato);
            panel2.Controls.Add(lblLocal);
            panel2.Location = new Point(51, 90);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1019, 425);
            panel2.TabIndex = 43;
            // 
            // UC_paginaCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescricao);
            Controls.Add(btnEntrarEmContato);
            Controls.Add(pbImagem);
            Controls.Add(pnlNavBar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_paginaCompra";
            Size = new Size(1144, 875);
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlNavBar;
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
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
