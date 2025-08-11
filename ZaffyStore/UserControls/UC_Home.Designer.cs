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
            pictureBox2 = new PictureBox();
            pbPerfil = new PictureBox();
            pbLogout = new PictureBox();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            SuspendLayout();
            // 
            // panelFotos
            // 
            panelFotos.Controls.Add(pictureBox1);
            panelFotos.Location = new Point(109, 123);
            panelFotos.Margin = new Padding(4, 5, 4, 5);
            panelFotos.Name = "panelFotos";
            panelFotos.Size = new Size(891, 272);
            panelFotos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.MinimumSize = new Size(891, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(891, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(lnkMeuAnuncio);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkLogout);
            pnlNavBar.Controls.Add(lnkPerfil);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1121, 63);
            pnlNavBar.TabIndex = 1;
            pnlNavBar.Paint += pnlNavBar_Paint;
            // 
            // lnkMeuAnuncio
            // 
            lnkMeuAnuncio.AutoSize = true;
            lnkMeuAnuncio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkMeuAnuncio.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkMeuAnuncio.LinkColor = Color.White;
            lnkMeuAnuncio.Location = new Point(366, 15);
            lnkMeuAnuncio.Margin = new Padding(4, 0, 4, 0);
            lnkMeuAnuncio.Name = "lnkMeuAnuncio";
            lnkMeuAnuncio.Size = new Size(207, 28);
            lnkMeuAnuncio.TabIndex = 8;
            lnkMeuAnuncio.TabStop = true;
            lnkMeuAnuncio.Text = "MEUS ANÚNCIOS";
            lnkMeuAnuncio.LinkClicked += lnkMeuAnuncio_LinkClicked;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(202, 15);
            lnkCadAnuncios.Margin = new Padding(4, 0, 4, 0);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(139, 28);
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
            lnkLogout.Location = new Point(1021, 15);
            lnkLogout.Margin = new Padding(4, 0, 4, 0);
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Size = new Size(72, 25);
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
            lnkPerfil.Location = new Point(940, 15);
            lnkPerfil.Margin = new Padding(4, 0, 4, 0);
            lnkPerfil.Name = "lnkPerfil";
            lnkPerfil.Size = new Size(64, 25);
            lnkPerfil.TabIndex = 5;
            lnkPerfil.TabStop = true;
            lnkPerfil.Text = "PERFIL";
            lnkPerfil.LinkClicked += lnkPerfil_LinkClicked;
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
            lnkHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(95, 15);
            lnkHome.Margin = new Padding(4, 0, 4, 0);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(82, 28);
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
            dgvAnuncios.Location = new Point(153, 780);
            dgvAnuncios.Margin = new Padding(4, 5, 4, 5);
            dgvAnuncios.Name = "dgvAnuncios";
            dgvAnuncios.RowHeadersWidth = 62;
            dgvAnuncios.Size = new Size(823, 352);
            dgvAnuncios.TabIndex = 3;
            dgvAnuncios.CellContentClick += dgvAnuncios_CellContentClick;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(514, 77);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(59, 25);
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
            panel1.Location = new Point(436, 405);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 365);
            panel1.TabIndex = 5;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(137, 270);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(92, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "R$ 8000.7";
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.FromArgb(115, 76, 191);
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(16, 300);
            btnVisualizar.Margin = new Padding(4, 5, 4, 5);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(194, 50);
            btnVisualizar.TabIndex = 2;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(6, 228);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(187, 50);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "PS4 SLIM do Cristiano\r\n Ronaldo (Jr)";
            // 
            // cardFoto
            // 
            cardFoto.Image = Properties.Resources.download__1_;
            cardFoto.Location = new Point(6, 8);
            cardFoto.Margin = new Padding(4, 5, 4, 5);
            cardFoto.Name = "cardFoto";
            cardFoto.Size = new Size(211, 215);
            cardFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFoto.TabIndex = 0;
            cardFoto.TabStop = false;
            cardFoto.Click += cardFoto_Click;
            cardFoto.MouseLeave += cardFoto_MouseLeave;
            cardFoto.MouseHover += cardFoto_MouseHover;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pbPerfil
            // 
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(811, 4);
            pbPerfil.Margin = new Padding(4, 5, 4, 5);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(54, 58);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 44;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // pbLogout
            // 
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(871, 4);
            pbLogout.Margin = new Padding(4, 5, 4, 5);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(54, 58);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 45;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
            Controls.Add(panelFotos);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Home";
            Size = new Size(1121, 1155);
            Load += UC_Home_Load;
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pbLogout;
        private PictureBox pbPerfil;
    }
}
