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
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
            dgvAnuncios = new DataGridView();
            lblWelcome = new Label();
            lnkCadAnuncios = new LinkLabel();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).BeginInit();
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
          //  lnkHome.LinkClicked += this.lnkHome_LinkClicked;
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
            dgvAnuncios.Location = new Point(76, 255);
            dgvAnuncios.Name = "dgvAnuncios";
            dgvAnuncios.Size = new Size(624, 249);
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
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblWelcome);
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
            Controls.Add(panelFotos);
            Name = "UC_Home";
            Size = new Size(785, 537);
            Load += UC_Home_Load;
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).EndInit();
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
    }
}
