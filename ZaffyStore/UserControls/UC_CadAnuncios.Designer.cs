namespace ZaffyStore.UserControls
{
    partial class UC_CadAnuncios
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
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
            lblMessage = new Label();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            lblMessageInfos = new Label();
            lblProductName = new Label();
            txtNome = new TextBox();
            lblPreco = new Label();
            mtxtPreco = new MaskedTextBox();
            lblContato = new Label();
            txtContato = new TextBox();
            txtDesc = new TextBox();
            lblDescricao = new Label();
            lblFoto = new Label();
            pbImagem = new PictureBox();
            txtLocal = new TextBox();
            lblLocal = new Label();
            btnAnunciar = new Button();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(lnkLogout);
            pnlNavBar.Controls.Add(lnkPerfil);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(786, 32);
            pnlNavBar.TabIndex = 2;
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
            lnkPerfil.Location = new Point(360, 9);
            lnkPerfil.Name = "lnkPerfil";
            lnkPerfil.Size = new Size(42, 15);
            lnkPerfil.TabIndex = 5;
            lnkPerfil.TabStop = true;
            lnkPerfil.Text = "PERFIL";
            lnkPerfil.LinkClicked += lnkPerfil_LinkClicked;
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
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(39, 74);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(363, 29);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Olá, o que você quer anunciar?";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(39, 128);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(174, 22);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Selecione a categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(219, 130);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(169, 23);
            cbCategoria.TabIndex = 5;
            // 
            // lblMessageInfos
            // 
            lblMessageInfos.AutoSize = true;
            lblMessageInfos.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessageInfos.Location = new Point(39, 183);
            lblMessageInfos.Name = "lblMessageInfos";
            lblMessageInfos.Size = new Size(394, 29);
            lblMessageInfos.TabIndex = 7;
            lblMessageInfos.Text = "Compartilhe algumas informações";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(39, 241);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(143, 22);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "Nome do Produto";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(39, 282);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(502, 23);
            txtNome.TabIndex = 9;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(580, 241);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(54, 22);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço";
            // 
            // mtxtPreco
            // 
            mtxtPreco.Location = new Point(580, 282);
            mtxtPreco.Name = "mtxtPreco";
            mtxtPreco.Size = new Size(182, 23);
            mtxtPreco.TabIndex = 12;
            mtxtPreco.TextChanged += mtxtPreco_TextChanged;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(580, 315);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(70, 22);
            lblContato.TabIndex = 13;
            lblContato.Text = "Contato";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(580, 347);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(182, 23);
            txtContato.TabIndex = 15;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(39, 356);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(347, 96);
            txtDesc.TabIndex = 17;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(39, 315);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 22);
            lblDescricao.TabIndex = 16;
            lblDescricao.Text = "Descrição";
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.Location = new Point(452, 315);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(44, 22);
            lblFoto.TabIndex = 18;
            lblFoto.Text = "Foto";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.carregarfoto;
            pbImagem.Location = new Point(411, 347);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(130, 105);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 19;
            pbImagem.TabStop = false;
            pbImagem.Click += pictureBox1_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(39, 514);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(502, 23);
            txtLocal.TabIndex = 21;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(39, 473);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(51, 22);
            lblLocal.TabIndex = 20;
            lblLocal.Text = "Local";
            // 
            // btnAnunciar
            // 
            btnAnunciar.BackColor = Color.FromArgb(115, 76, 191);
            btnAnunciar.ForeColor = Color.White;
            btnAnunciar.Location = new Point(606, 504);
            btnAnunciar.Name = "btnAnunciar";
            btnAnunciar.Size = new Size(126, 40);
            btnAnunciar.TabIndex = 22;
            btnAnunciar.Text = "Anunciar";
            btnAnunciar.UseVisualStyleBackColor = false;
            btnAnunciar.Click += btnAnunciar_Click;
            // 
            // UC_CadAnuncios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAnunciar);
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
            Controls.Add(lblMessageInfos);
            Controls.Add(cbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblMessage);
            Controls.Add(pnlNavBar);
            Name = "UC_CadAnuncios";
            Size = new Size(786, 567);
            Load += UC_CadAnuncios_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlNavBar;
        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private LinkLabel lnkHome;
        private Label lblMessage;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Label lblMessageInfos;
        private Label lblProductName;
        private TextBox txtNome;
        private Label lblPreco;
        private MaskedTextBox mtxtPreco;
        private Label lblContato;
        private TextBox txtContato;
        private TextBox txtDesc;
        private Label lblDescricao;
        private Label lblFoto;
        private PictureBox pbImagem;
        private TextBox txtLocal;
        private Label lblLocal;
        private Button btnAnunciar;
    }
}
