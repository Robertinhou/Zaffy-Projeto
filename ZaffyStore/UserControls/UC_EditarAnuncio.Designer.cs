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
            lnkCadAnuncios = new LinkLabel();
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
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
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkLogout);
            pnlNavBar.Controls.Add(lnkPerfil);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(786, 32);
            pnlNavBar.TabIndex = 7;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(89, 9);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(67, 15);
            lnkCadAnuncios.TabIndex = 7;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // lnkLogout
            // 
            lnkLogout.AutoSize = true;
            lnkLogout.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLogout.LinkColor = Color.White;
            lnkLogout.Location = new Point(715, 9);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(47, 15);
            lnkLogout.TabIndex = 6;
            lnkLogout.TabStop = true;
            lnkLogout.Text = "LogOut";
            lnkLogout.LinkClicked += lnkLogout_LinkClicked;
            // 
            // lnkPerfil
            // 
            lnkPerfil.AutoSize = true;
            lnkPerfil.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkPerfil.LinkColor = Color.White;
            lnkPerfil.Location = new Point(658, 9);
            lnkPerfil.Name = "lnkPerfil";
            lnkPerfil.Size = new Size(42, 15);
            lnkPerfil.TabIndex = 5;
            lnkPerfil.TabStop = true;
            lnkPerfil.Text = "PERFIL";
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(23, 9);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(42, 15);
            lnkHome.TabIndex = 4;
            lnkHome.TabStop = true;
            lnkHome.Text = "HOME";
            lnkHome.LinkClicked += lnkHome_LinkClicked;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(115, 76, 191);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(599, 478);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(126, 40);
            btnSalvar.TabIndex = 39;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(32, 488);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(502, 23);
            txtLocal.TabIndex = 38;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(32, 447);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(51, 22);
            lblLocal.TabIndex = 37;
            lblLocal.Text = "Local";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.carregarfoto;
            pbImagem.Location = new Point(404, 321);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(130, 105);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 36;
            pbImagem.TabStop = false;
            pbImagem.Click += pbImagem_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.Location = new Point(445, 289);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(44, 22);
            lblFoto.TabIndex = 35;
            lblFoto.Text = "Foto";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(32, 330);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(347, 96);
            txtDesc.TabIndex = 34;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(32, 289);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 22);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "Descrição";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(573, 321);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(182, 23);
            txtContato.TabIndex = 32;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(573, 289);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(70, 22);
            lblContato.TabIndex = 31;
            lblContato.Text = "Contato";
            // 
            // mtxtPreco
            // 
            mtxtPreco.Location = new Point(573, 256);
            mtxtPreco.Name = "mtxtPreco";
            mtxtPreco.Size = new Size(182, 23);
            mtxtPreco.TabIndex = 30;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(573, 215);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(54, 22);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 256);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 23);
            txtNome.TabIndex = 28;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(32, 215);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(143, 22);
            lblProductName.TabIndex = 27;
            lblProductName.Text = "Nome do Produto";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(143, 104);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(169, 23);
            cbCategoria.TabIndex = 25;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(32, 102);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 22);
            lblCategoria.TabIndex = 24;
            lblCategoria.Text = "Categoria";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(32, 48);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(200, 29);
            lblMessage.TabIndex = 23;
            lblMessage.Text = "EDITAR ANÚNCIO";
            // 
            // UC_EditarAnuncio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "UC_EditarAnuncio";
            Size = new Size(786, 567);
            Load += UC_EditarAnuncio_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private LinkLabel lnkCadAnuncios;
        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private LinkLabel lnkHome;
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
    }
}
