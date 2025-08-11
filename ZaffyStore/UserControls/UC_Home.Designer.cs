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
            panel4 = new Panel();
            label5 = new Label();
            button3 = new Button();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cardFoto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(lnkMeuAnuncio);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(785, 38);
            pnlNavBar.TabIndex = 1;
            // 
            // pbLogout
            // 
            pbLogout.Cursor = Cursors.Hand;
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(744, 1);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(38, 35);
            pbLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogout.TabIndex = 45;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zaffyNav;
            pictureBox2.Location = new Point(1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // pbPerfil
            // 
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(702, 1);
            pbPerfil.Name = "pbPerfil";
            pbPerfil.Size = new Size(38, 35);
            pbPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPerfil.TabIndex = 44;
            pbPerfil.TabStop = false;
            pbPerfil.Click += pbPerfil_Click;
            // 
            // lnkMeuAnuncio
            // 
            lnkMeuAnuncio.AutoSize = true;
            lnkMeuAnuncio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkMeuAnuncio.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkMeuAnuncio.LinkColor = Color.White;
            lnkMeuAnuncio.Location = new Point(256, 9);
            lnkMeuAnuncio.Name = "lnkMeuAnuncio";
            lnkMeuAnuncio.Size = new Size(157, 20);
            lnkMeuAnuncio.TabIndex = 8;
            lnkMeuAnuncio.TabStop = true;
            lnkMeuAnuncio.Text = "MEUS ANÚNCIOS";
            lnkMeuAnuncio.LinkClicked += lnkMeuAnuncio_LinkClicked;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(141, 9);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(101, 20);
            lnkCadAnuncios.TabIndex = 7;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
            lnkHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(66, 9);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(61, 20);
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
            dgvAnuncios.Location = new Point(24, 468);
            dgvAnuncios.Name = "dgvAnuncios";
            dgvAnuncios.RowHeadersWidth = 62;
            dgvAnuncios.Size = new Size(736, 211);
            dgvAnuncios.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(10, 47);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(64, 22);
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
            panel1.Location = new Point(400, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 219);
            panel1.TabIndex = 5;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(92, 162);
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(582, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 219);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 162);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "R$ 8000.7";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(115, 76, 191);
            button1.ForeColor = Color.White;
            button1.Location = new Point(11, 180);
            button1.Name = "button1";
            button1.Size = new Size(136, 30);
            button1.TabIndex = 2;
            button1.Text = "Visualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 137);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 1;
            label2.Text = "PS4 SLIM do Cristiano\r\n Ronaldo (Jr)";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download__1_;
            pictureBox3.Location = new Point(4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 129);
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
            panel3.Location = new Point(223, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(156, 219);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 162);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "R$ 8000.7";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(115, 76, 191);
            button2.ForeColor = Color.White;
            button2.Location = new Point(11, 180);
            button2.Name = "button2";
            button2.Size = new Size(136, 30);
            button2.TabIndex = 2;
            button2.Text = "Visualizar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 137);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 1;
            label4.Text = "PS4 SLIM do Cristiano\r\n Ronaldo (Jr)";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.download__1_;
            pictureBox4.Location = new Point(4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 129);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox5);
            panel4.Location = new Point(46, 243);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 219);
            panel4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 162);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 3;
            label5.Text = "R$ 8000.7";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(115, 76, 191);
            button3.ForeColor = Color.White;
            button3.Location = new Point(11, 180);
            button3.Name = "button3";
            button3.Size = new Size(136, 30);
            button3.TabIndex = 2;
            button3.Text = "Visualizar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 137);
            label6.Name = "label6";
            label6.Size = new Size(122, 30);
            label6.TabIndex = 1;
            label6.Text = "PS4 SLIM do Cristiano\r\n Ronaldo (Jr)";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.download__1_;
            pictureBox5.Location = new Point(4, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(148, 129);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
            Controls.Add(panelFotos);
            Name = "UC_Home";
            Size = new Size(788, 693);
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Panel panel4;
        private Label label5;
        private Button button3;
        private Label label6;
        private PictureBox pictureBox5;
    }
}
