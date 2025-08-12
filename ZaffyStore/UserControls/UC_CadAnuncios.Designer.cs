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
            pbLogout = new PictureBox();
            pbPerfil = new PictureBox();
            pictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1144, 63);
            pnlNavBar.TabIndex = 2;
            // 
            // pbLogout
            // 
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(1080, 3);
            pbLogout.Margin = new Padding(4, 5, 4, 5);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(54, 58);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 47;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pbPerfil
            // 
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(1020, 3);
            pbPerfil.Margin = new Padding(4, 5, 4, 5);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(54, 58);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 46;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
            lnkHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(91, 15);
            lnkHome.Margin = new Padding(4, 0, 4, 0);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(82, 28);
            lnkHome.TabIndex = 4;
            lnkHome.TabStop = true;
            lnkHome.Text = "HOME";
            lnkHome.LinkClicked += lnkHome_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(39, 90);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(542, 44);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Olá, o que você quer anunciar?";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(61, 183);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(253, 29);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Selecione a categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(318, 183);
            cbCategoria.Margin = new Padding(4, 5, 4, 5);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(240, 33);
            cbCategoria.TabIndex = 5;
            // 
            // lblMessageInfos
            // 
            lblMessageInfos.AutoSize = true;
            lblMessageInfos.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessageInfos.Location = new Point(39, 292);
            lblMessageInfos.Margin = new Padding(4, 0, 4, 0);
            lblMessageInfos.Name = "lblMessageInfos";
            lblMessageInfos.Size = new Size(587, 44);
            lblMessageInfos.TabIndex = 7;
            lblMessageInfos.Text = "Compartilhe algumas informações";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(53, 365);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(210, 29);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "Nome do Produto";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(58, 399);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(594, 31);
            txtNome.TabIndex = 9;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(826, 365);
            lblPreco.Margin = new Padding(4, 0, 4, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(77, 29);
            lblPreco.TabIndex = 10;
            lblPreco.Text = "Preço";
            // 
            // mtxtPreco
            // 
            mtxtPreco.Location = new Point(826, 399);
            mtxtPreco.Margin = new Padding(4, 5, 4, 5);
            mtxtPreco.Mask = "0000000,00";
            mtxtPreco.Name = "mtxtPreco";
            mtxtPreco.Size = new Size(150, 31);
            mtxtPreco.TabIndex = 12;
            mtxtPreco.TextChanged += mtxtPreco_TextChanged;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(826, 488);
            lblContato.Margin = new Padding(4, 0, 4, 0);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(103, 29);
            lblContato.TabIndex = 13;
            lblContato.Text = "Contato";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(826, 517);
            txtContato.Margin = new Padding(4, 5, 4, 5);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(258, 31);
            txtContato.TabIndex = 15;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(53, 517);
            txtDesc.Margin = new Padding(4, 5, 4, 5);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(494, 157);
            txtDesc.TabIndex = 17;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(53, 483);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(120, 29);
            lblDescricao.TabIndex = 16;
            lblDescricao.Text = "Descrição";
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.Location = new Point(588, 483);
            lblFoto.Margin = new Padding(4, 0, 4, 0);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(64, 29);
            lblFoto.TabIndex = 18;
            lblFoto.Text = "Foto";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.carregarfoto;
            pbImagem.Location = new Point(582, 517);
            pbImagem.Margin = new Padding(4, 5, 4, 5);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(186, 157);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 19;
            pbImagem.TabStop = false;
            pbImagem.Click += pictureBox1_Click;
            // 
            // txtLocal
            // 
            txtLocal.Location = new Point(53, 777);
            txtLocal.Margin = new Padding(4, 5, 4, 5);
            txtLocal.Name = "txtLocal";
            txtLocal.Size = new Size(494, 31);
            txtLocal.TabIndex = 21;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(53, 735);
            lblLocal.Margin = new Padding(4, 0, 4, 0);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(72, 29);
            lblLocal.TabIndex = 20;
            lblLocal.Text = "Local";
            // 
            // btnAnunciar
            // 
            btnAnunciar.BackColor = Color.FromArgb(115, 76, 191);
            btnAnunciar.ForeColor = Color.White;
            btnAnunciar.Location = new Point(904, 759);
            btnAnunciar.Margin = new Padding(4, 5, 4, 5);
            btnAnunciar.Name = "btnAnunciar";
            btnAnunciar.Size = new Size(180, 67);
            btnAnunciar.TabIndex = 22;
            btnAnunciar.Text = "Anunciar";
            btnAnunciar.UseVisualStyleBackColor = false;
            btnAnunciar.Click += btnAnunciar_Click;
            // 
            // UC_CadAnuncios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_CadAnuncios";
            Size = new Size(1144, 875);
            Load += UC_CadAnuncios_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlNavBar;
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
        private PictureBox pictureBox2;
        private PictureBox pbLogout;
        private PictureBox pbPerfil;
    }
}
