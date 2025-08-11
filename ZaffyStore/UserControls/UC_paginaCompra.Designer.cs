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
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(786, 38);
            pnlNavBar.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
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
            linkHome.Location = new Point(77, 9);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(55, 19);
            linkHome.TabIndex = 47;
            linkHome.TabStop = true;
            linkHome.Text = "HOME";
            linkHome.LinkClicked += linkHome_LinkClicked;
            // 
            // pbLogout
            // 
            pbLogout.Cursor = Cursors.Hand;
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(745, 1);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(38, 35);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 46;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pbPerfil
            // 
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(699, 1);
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
            lnkCadAnuncios.Cursor = Cursors.Hand;
            lnkCadAnuncios.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(150, 9);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(92, 19);
            lnkCadAnuncios.TabIndex = 44;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // btnEntrarEmContato
            // 
            btnEntrarEmContato.BackColor = Color.FromArgb(115, 76, 191);
            btnEntrarEmContato.ForeColor = Color.White;
            btnEntrarEmContato.Location = new Point(611, 222);
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
            lblLocal.Location = new Point(295, 252);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(273, 22);
            lblLocal.TabIndex = 37;
            lblLocal.Text = "Casa do Cristiano Ronaldo - Lisboa\r\n";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.download__1_;
            pbImagem.Location = new Point(36, 76);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(244, 196);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 36;
            pbImagem.TabStop = false;
            pbImagem.Click += pbImagem_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(36, 329);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 22);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "Descrição";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(295, 178);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(148, 22);
            lblContato.TabIndex = 31;
            lblContato.Text = "Contato: Anônimo";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 19F, FontStyle.Bold);
            lblPreco.Location = new Point(295, 129);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(146, 33);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "R$8000,00";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdName.Location = new Point(295, 76);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(107, 29);
            lblProdName.TabIndex = 23;
            lblProdName.Text = "PS4 Slim\r\n";
            // 
            // lblDescricaoProd
            // 
            lblDescricaoProd.AutoSize = true;
            lblDescricaoProd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoProd.Location = new Point(3, 12);
            lblDescricaoProd.Name = "lblDescricaoProd";
            lblDescricaoProd.Size = new Size(269, 66);
            lblDescricaoProd.TabIndex = 40;
            lblDescricaoProd.Text = "PS4 do filho do cristiano ronaldo. \r\n\r\nEntrega a combinar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 230);
            label1.Name = "label1";
            label1.Size = new Size(57, 22);
            label1.TabIndex = 41;
            label1.Text = "Local:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblDescricaoProd);
            panel1.Location = new Point(36, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 146);
            panel1.TabIndex = 42;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(36, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 255);
            panel2.TabIndex = 43;
            // 
            // UC_paginaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescricao);
            Controls.Add(label1);
            Controls.Add(btnEntrarEmContato);
            Controls.Add(lblLocal);
            Controls.Add(pbImagem);
            Controls.Add(lblContato);
            Controls.Add(lblPreco);
            Controls.Add(lblProdName);
            Controls.Add(pnlNavBar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UC_paginaCompra";
            Size = new Size(786, 567);
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
