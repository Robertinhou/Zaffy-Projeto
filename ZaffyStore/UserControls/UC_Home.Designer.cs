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
            linkPlanos = new LinkLabel();
            pbLogout = new PictureBox();
            pictureBox2 = new PictureBox();
            pbPerfil = new PictureBox();
            lnkMeuAnuncio = new LinkLabel();
            lnkCadAnuncios = new LinkLabel();
            lnkHome = new LinkLabel();
            dgvAnuncios = new DataGridView();
            lblWelcome = new Label();
            panel1 = new Panel();
            lblPrice = new Label();
            btnVisualizar = new Button();
            lblProductName = new Label();
            cardFoto = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            pnlNavBar.Controls.Add(linkPlanos);
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(lnkMeuAnuncio);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1144, 63);
            pnlNavBar.TabIndex = 1;
            // 
            // linkPlanos
            // 
            linkPlanos.ActiveLinkColor = Color.White;
            linkPlanos.AutoSize = true;
            linkPlanos.Cursor = Cursors.Hand;
            linkPlanos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkPlanos.LinkBehavior = LinkBehavior.HoverUnderline;
            linkPlanos.LinkColor = Color.White;
            linkPlanos.Location = new Point(601, 15);
            linkPlanos.Margin = new Padding(4, 0, 4, 0);
            linkPlanos.Name = "linkPlanos";
            linkPlanos.Size = new Size(116, 29);
            linkPlanos.TabIndex = 46;
            linkPlanos.TabStop = true;
            linkPlanos.Text = "PLANOS";
            linkPlanos.LinkClicked += linkPlanos_LinkClicked;
            // 
            // pbLogout
            // 
            pbLogout.Cursor = Cursors.Hand;
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(1083, 2);
            pbLogout.Margin = new Padding(4, 5, 4, 5);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(54, 58);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 45;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(1, -2);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pbPerfil
            // 
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(1023, 2);
            pbPerfil.Margin = new Padding(4, 5, 4, 5);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(54, 58);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 44;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // lnkMeuAnuncio
            // 
            lnkMeuAnuncio.ActiveLinkColor = Color.White;
            lnkMeuAnuncio.AutoSize = true;
            lnkMeuAnuncio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkMeuAnuncio.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkMeuAnuncio.LinkColor = Color.White;
            lnkMeuAnuncio.Location = new Point(366, 15);
            lnkMeuAnuncio.Margin = new Padding(4, 0, 4, 0);
            lnkMeuAnuncio.Name = "lnkMeuAnuncio";
            lnkMeuAnuncio.Size = new Size(227, 29);
            lnkMeuAnuncio.TabIndex = 8;
            lnkMeuAnuncio.TabStop = true;
            lnkMeuAnuncio.Text = "MEUS ANÚNCIOS";
            lnkMeuAnuncio.LinkClicked += lnkMeuAnuncio_LinkClicked;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.ActiveLinkColor = Color.White;
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(201, 15);
            lnkCadAnuncios.Margin = new Padding(4, 0, 4, 0);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(144, 29);
            lnkCadAnuncios.TabIndex = 7;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // lnkHome
            // 
            lnkHome.ActiveLinkColor = Color.White;
            lnkHome.AutoSize = true;
            lnkHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(94, 15);
            lnkHome.Margin = new Padding(4, 0, 4, 0);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(89, 29);
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
            dgvAnuncios.Location = new Point(43, 740);
            dgvAnuncios.Margin = new Padding(4, 5, 4, 5);
            dgvAnuncios.Name = "dgvAnuncios";
            dgvAnuncios.RowHeadersWidth = 62;
            dgvAnuncios.Size = new Size(1051, 179);
            dgvAnuncios.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(14, 73);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 30);
            lblWelcome.TabIndex = 4;
            lblWelcome.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(btnVisualizar);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(cardFoto);
            panel1.Location = new Point(571, 405);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 325);
            panel1.TabIndex = 5;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(127, 232);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(92, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "R$ 8000.7";
            // 
            // btnVisualizar
            // 
            btnVisualizar.BackColor = Color.FromArgb(115, 76, 191);
            btnVisualizar.Cursor = Cursors.Hand;
            btnVisualizar.ForeColor = Color.White;
            btnVisualizar.Location = new Point(16, 262);
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
            lblProductName.Location = new Point(6, 190);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(187, 50);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "PS4 SLIM do Cristiano\r\n Ronaldo (Jr)";
            // 
            // cardFoto
            // 
            cardFoto.Image = Properties.Resources.download__1_;
            cardFoto.Location = new Point(9, 8);
            cardFoto.Margin = new Padding(4, 5, 4, 5);
            cardFoto.Name = "cardFoto";
            cardFoto.Size = new Size(204, 177);
            cardFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFoto.TabIndex = 0;
            cardFoto.TabStop = false;
            cardFoto.Click += cardFoto_Click;
            cardFoto.MouseLeave += cardFoto_MouseLeave;
            cardFoto.MouseHover += cardFoto_MouseHover;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(66, 405);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(223, 325);
            panel4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 232);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 3;
            label5.Text = "R$ 80.79";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(115, 76, 191);
            button3.ForeColor = Color.White;
            button3.Location = new Point(16, 262);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(194, 50);
            button3.TabIndex = 2;
            button3.Text = "Visualizar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 190);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 25);
            label6.TabIndex = 1;
            label6.Text = "Chave de Fenda";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.chave_de_fena;
            pictureBox5.Location = new Point(8, 8);
            pictureBox5.Margin = new Padding(4, 5, 4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(204, 177);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(319, 405);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 325);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 232);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 3;
            label1.Text = "R$ 65,00";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(115, 76, 191);
            button1.ForeColor = Color.White;
            button1.Location = new Point(16, 262);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(194, 50);
            button1.TabIndex = 2;
            button1.Text = "Visualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 190);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 25);
            label2.TabIndex = 1;
            label2.Text = "Caminhao de brinquedo";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.trator;
            pictureBox3.Location = new Point(8, 8);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 177);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(829, 405);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(223, 325);
            panel3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 232);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 3;
            label3.Text = "R$ 200.99";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(115, 76, 191);
            button2.ForeColor = Color.White;
            button2.Location = new Point(16, 262);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(194, 50);
            button2.TabIndex = 2;
            button2.Text = "Visualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 190);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 50);
            label4.TabIndex = 1;
            label4.Text = "Camisa do Melhor \r\ndo Mundo";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.camisaCreuzeiro;
            pictureBox4.Location = new Point(10, 8);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 177);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
            Controls.Add(panelFotos);
            Margin = new Padding(0);
            Name = "UC_Home";
            Size = new Size(1144, 984);
            Load += UC_Home_Load;
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Panel panelFotos;
        private System.Windows.Forms.PictureBox pictureBox1;

        private Panel pnlNavBar;
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
        private Panel panel4;
        private Label label5;
        private Button button3;
        private Label label6;
        private PictureBox pictureBox5;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label3;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox4;
        private LinkLabel linkPlanos;
    }
}
