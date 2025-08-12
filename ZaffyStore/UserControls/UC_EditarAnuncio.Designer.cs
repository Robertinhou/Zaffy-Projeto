namespace ZaffyStore.UserControls
{
    partial class UC_EditarAnuncio
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
            btnSalvar = new Button();
            txtLocal = new TextBox();
            lblLocal = new Label();
            pbImagem = new PictureBox();
            lblFoto = new Label();
            txtDesc = new TextBox();
            lblDescricao = new Label();
            txtContato = new TextBox();
            lblContato = new Label();
            mtxtPreco = new MaskedTextBox();
            lblPreco = new Label();
            txtNome = new TextBox();
            lblProductName = new Label();
            cbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblMessage = new Label();
            pictureBox3 = new PictureBox();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            pnlNavBar.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // linkHome
            // 
            linkHome.AutoSize = true;
            linkHome.Cursor = Cursors.Hand;
            linkHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            linkHome.LinkColor = Color.White;
            linkHome.Location = new Point(93, 16);
            linkHome.Margin = new Padding(4, 0, 4, 0);
            linkHome.Name = "linkHome";
            linkHome.Size = new Size(82, 28);
            linkHome.TabIndex = 42;
            linkHome.TabStop = true;
            linkHome.Text = "HOME";
            linkHome.LinkClicked += linkHome_LinkClicked;
            // 
            // pbLogout
            // 
            pbLogout.Cursor = Cursors.Hand;
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(1086, 0);
            pbLogout.Margin = new Padding(4, 5, 4, 5);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(54, 58);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 41;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pbPerfil
            // 
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(1026, 0);
            pbPerfil.Margin = new Padding(4, 5, 4, 5);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(54, 58);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 40;
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
            lnkCadAnuncios.Location = new Point(195, 16);
            lnkCadAnuncios.Margin = new Padding(4, 0, 4, 0);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(139, 28);
            lnkCadAnuncios.TabIndex = 7;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(115, 76, 191);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(927, 784);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(180, 67);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(44, 828);
            txtLocal.Margin = new Padding(4, 5, 4, 5);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(324, 31);
            txtLocal.TabIndex = 38;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(44, 786);
            lblLocal.Margin = new Padding(4, 0, 4, 0);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(72, 29);
            lblLocal.TabIndex = 37;
            lblLocal.Text = "Local";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.carregarfoto;
            pbImagem.Location = new Point(43, 225);
            pbImagem.Margin = new Padding(4, 5, 4, 5);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(229, 202);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 36;
            pbImagem.TabStop = false;
            pbImagem.Click += pbImagem_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.Location = new Point(44, 183);
            lblFoto.Margin = new Padding(4, 0, 4, 0);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(191, 29);
            lblFoto.TabIndex = 35;
            lblFoto.Text = "Insira uma foto:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(44, 601);
            txtDesc.Margin = new Padding(4, 5, 4, 5);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(494, 157);
            txtDesc.TabIndex = 34;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(43, 559);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(120, 29);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "Descrição";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(594, 722);
            txtContato.Margin = new Padding(4, 5, 4, 5);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(258, 31);
            txtContato.TabIndex = 32;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(594, 681);
            lblContato.Margin = new Padding(4, 0, 4, 0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(103, 29);
            lblContato.TabIndex = 31;
            lblContato.Text = "Contato";
            // 
            // mtxtPreco
            // 
            mtxtPreco.Location = new Point(594, 614);
            mtxtPreco.Margin = new Padding(4, 5, 4, 5);
            mtxtPreco.Mask = "0000000,00";
            mtxtPreco.Name = "mtxtPreco";
            mtxtPreco.Size = new Size(98, 31);
            mtxtPreco.TabIndex = 30;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(594, 572);
            lblPreco.Margin = new Padding(4, 0, 4, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(77, 29);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 491);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(388, 31);
            txtNome.TabIndex = 28;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(43, 450);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(210, 29);
            lblProductName.TabIndex = 27;
            lblProductName.Text = "Nome do Produto";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(613, 491);
            cbCategoria.Margin = new Padding(4, 5, 4, 5);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(240, 33);
            cbCategoria.TabIndex = 25;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(484, 488);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(121, 29);
            lblCategoria.TabIndex = 24;
            lblCategoria.Text = "Categoria";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(33, 100);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(297, 44);
            lblMessage.TabIndex = 23;
            lblMessage.Text = "EDITAR ANÚNCIO";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Protótipo_de_Baixa_Fidelidade;
            pictureBox3.Location = new Point(633, 93);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(436, 413);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 44;
            pictureBox3.TabStop = false;
            // 
            // UC_EditarAnuncio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSalvar);
            Controls.Add(txtLocal);
            Controls.Add(lblLocal);
            Controls.Add(pbImagem);
            Controls.Add(lblFoto);
            Controls.Add(txtDesc);
            Controls.Add(lblDescricao);
            Controls.Add(txtContato);
            Controls.Add(lblContato);
            Controls.Add(mtxtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtNome);
            Controls.Add(lblProductName);
            Controls.Add(cbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblMessage);
            Controls.Add(pnlNavBar);
            Controls.Add(pictureBox3);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_EditarAnuncio";
            Size = new Size(1144, 875);
            Load += UC_EditarAnuncio_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private LinkLabel lnkCadAnuncios;
        private Button btnSalvar;
        private TextBox txtLocal;
        private Label lblLocal;
        private PictureBox pbImagem;
        private Label lblFoto;
        private TextBox txtDesc;
        private Label lblDescricao;
        private TextBox txtContato;
        private Label lblContato;
        private MaskedTextBox mtxtPreco;
        private Label lblPreco;
        private TextBox txtNome;
        private Label lblProductName;
        private ComboBox cbCategoria;
        private Label lblCategoria;
        private Label lblMessage;
        private PictureBox pbPerfil;
        private PictureBox pbLogout;
        private LinkLabel linkHome;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
