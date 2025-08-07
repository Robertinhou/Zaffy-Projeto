namespace ZaffyStore.UserControls
{
    partial class UC_Home
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

        private void InitializeComponent()
        {
            panelFotos = new Panel();
            pictureBox1 = new PictureBox();
            pnlNavBar = new Panel();
            lnkMeuAnuncio = new LinkLabel();
            lnkCadAnuncios = new LinkLabel();
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
            dgvAnuncios = new DataGridView();
            lblWelcome = new Label();
            panel1 = new Panel();
            lblPrice = new Label();
            btnVisualizar = new Button();
            lblProductName = new Label();
            cardFoto = new PictureBox();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).BeginInit();
            SuspendLayout();
            // 
            // panelFotos
            // 
            panelFotos.Controls.Add(pictureBox1);
            panelFotos.Location = new Point(76, 74);
            panelFotos.Name = "panelFotos";
            panelFotos.Size = new Size(624, 163);
            panelFotos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MinimumSize = new Size(624, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(lnkMeuAnuncio);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkLogout);
            pnlNavBar.Controls.Add(lnkPerfil);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(785, 32);
            pnlNavBar.TabIndex = 1;
            pnlNavBar.Paint += pnlNavBar_Paint;
            // 
            // lnkMeuAnuncio
            // 
            lnkMeuAnuncio.AutoSize = true;
            lnkMeuAnuncio.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkMeuAnuncio.LinkColor = Color.White;
            lnkMeuAnuncio.Location = new Point(551, 9);
            lnkMeuAnuncio.Name = "lnkMeuAnuncio";
            lnkMeuAnuncio.Size = new Size(101, 15);
            lnkMeuAnuncio.TabIndex = 8;
            lnkMeuAnuncio.TabStop = true;
            lnkMeuAnuncio.Text = "MEUS ANÚNCIOS";
            lnkMeuAnuncio.LinkClicked += lnkMeuAnuncio_LinkClicked;
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
            // 
            // dgvAnuncios
            // 
            dgvAnuncios.AllowUserToAddRows = false;
            dgvAnuncios.AllowUserToDeleteRows = false;
            dgvAnuncios.AllowUserToResizeColumns = false;
            dgvAnuncios.AllowUserToResizeRows = false;
            dgvAnuncios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnuncios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAnuncios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnuncios.Location = new Point(107, 468);
            dgvAnuncios.Name = "dgvAnuncios";
            dgvAnuncios.Size = new Size(576, 211);
            dgvAnuncios.TabIndex = 3;
            dgvAnuncios.CellContentClick += dgvAnuncios_CellContentClick;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(360, 46);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "label1";
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(btnVisualizar);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(cardFoto);
            panel1.Location = new Point(305, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 219);
            panel1.TabIndex = 5;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(96, 162);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "R$ 8000.7";
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.FromArgb(115, 76, 191);
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(11, 180);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(136, 30);
            btnVisualizar.TabIndex = 2;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(4, 137);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(122, 30);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "PS4 SLIM do Cristiano\r\n Ronaldo (Jr)";
            // 
            // cardFoto
            // 
            cardFoto.Image = Properties.Resources.download__1_;
            cardFoto.Location = new Point(4, 5);
            cardFoto.Name = "cardFoto";
            cardFoto.Size = new Size(148, 129);
            cardFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFoto.TabIndex = 0;
            cardFoto.TabStop = false;
            cardFoto.Click += cardFoto_Click;
            cardFoto.MouseLeave += cardFoto_MouseLeave;
            cardFoto.MouseHover += cardFoto_MouseHover;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
            Controls.Add(panelFotos);
            Name = "UC_Home";
            Size = new Size(785, 693);
            Load += UC_Home_Load;
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Panel panelFotos;
        private System.Windows.Forms.PictureBox pictureBox1;

        private Panel pnlNavBar;
        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private LinkLabel lnkHome;
        private DataGridView dgvAnuncios;
        private Label lblWelcome;
        private LinkLabel lnkCadAnuncios;
        private LinkLabel lnkMeuAnuncio;
        private Panel panel1;
        private Button btnVisualizar;
        private Label lblProductName;
        private PictureBox cardFoto;
        private Label lblPrice;
    }
}
