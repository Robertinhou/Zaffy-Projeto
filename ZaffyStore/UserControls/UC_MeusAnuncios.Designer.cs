namespace ZaffyStore.UserControls
{
    partial class UC_MeusAnuncios
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
            linkPlanos = new LinkLabel();
            pbLogout = new PictureBox();
            pbPerfil = new PictureBox();
            pictureBox2 = new PictureBox();
            lnkCadAnuncios = new LinkLabel();
            lnkHome = new LinkLabel();
            dgvMeusAnuncios = new DataGridView();
            btnExcluir = new Button();
            btnListar = new Button();
            label1 = new Label();
            label2 = new Label();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeusAnuncios).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(linkPlanos);
            pnlNavBar.Controls.Add(pbLogout);
            pnlNavBar.Controls.Add(pbPerfil);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(lnkCadAnuncios);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1144, 63);
            pnlNavBar.TabIndex = 6;
            // 
            // linkPlanos
            // 
            linkPlanos.ActiveLinkColor = Color.White;
            linkPlanos.AutoSize = true;
            linkPlanos.Cursor = Cursors.Hand;
            linkPlanos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkPlanos.LinkBehavior = LinkBehavior.HoverUnderline;
            linkPlanos.LinkColor = Color.White;
            linkPlanos.Location = new Point(330, 15);
            linkPlanos.Margin = new Padding(4, 0, 4, 0);
            linkPlanos.Name = "linkPlanos";
            linkPlanos.Size = new Size(116, 29);
            linkPlanos.TabIndex = 51;
            linkPlanos.TabStop = true;
            linkPlanos.Text = "PLANOS";
            linkPlanos.LinkClicked += linkPlanos_LinkClicked;
            // 
            // pbLogout
            // 
            pbLogout.Cursor = Cursors.Hand;
            pbLogout.Image = Properties.Resources.ondaBaixo2;
            pbLogout.Location = new Point(1082, 3);
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
            pbPerfil.Cursor = Cursors.Hand;
            pbPerfil.Image = Properties.Resources.icons8_usuário_482;
            pbPerfil.Location = new Point(1022, 3);
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
            pictureBox2.Size = new Size(62, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.ActiveLinkColor = Color.White;
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.Cursor = Cursors.Hand;
            lnkCadAnuncios.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(183, 15);
            lnkCadAnuncios.Margin = new Padding(4, 0, 4, 0);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(139, 28);
            lnkCadAnuncios.TabIndex = 7;
            lnkCadAnuncios.TabStop = true;
            lnkCadAnuncios.Text = "ANUNCIAR";
            lnkCadAnuncios.LinkClicked += lnkCadAnuncios_LinkClicked;
            // 
            // lnkHome
            // 
            lnkHome.ActiveLinkColor = Color.White;
            lnkHome.AutoSize = true;
            lnkHome.Cursor = Cursors.Hand;
            lnkHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(93, 15);
            lnkHome.Margin = new Padding(4, 0, 4, 0);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(82, 28);
            lnkHome.TabIndex = 4;
            lnkHome.TabStop = true;
            lnkHome.Text = "HOME";
            lnkHome.LinkClicked += lnkHome_LinkClicked;
            // 
            // dgvMeusAnuncios
            // 
            dgvMeusAnuncios.AllowUserToAddRows = false;
            dgvMeusAnuncios.AllowUserToDeleteRows = false;
            dgvMeusAnuncios.AllowUserToResizeColumns = false;
            dgvMeusAnuncios.AllowUserToResizeRows = false;
            dgvMeusAnuncios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMeusAnuncios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMeusAnuncios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeusAnuncios.Location = new Point(4, 163);
            dgvMeusAnuncios.Margin = new Padding(4, 5, 4, 5);
            dgvMeusAnuncios.Name = "dgvMeusAnuncios";
            dgvMeusAnuncios.RowHeadersWidth = 62;
            dgvMeusAnuncios.Size = new Size(1132, 527);
            dgvMeusAnuncios.TabIndex = 7;
            dgvMeusAnuncios.CellDoubleClick += dgvMeusAnuncios_CellDoubleClick;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Indigo;
            btnExcluir.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = SystemColors.Control;
            btnExcluir.Location = new Point(1010, 708);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(126, 60);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = Color.Indigo;
            btnListar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListar.ForeColor = SystemColors.Control;
            btnListar.Location = new Point(1022, 106);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(114, 47);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 88);
            label1.Name = "label1";
            label1.Size = new Size(286, 43);
            label1.TabIndex = 8;
            label1.Text = "Meus Anúncios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 708);
            label2.Name = "label2";
            label2.Size = new Size(301, 23);
            label2.TabIndex = 11;
            label2.Text = "Clique duas vezes para editar";
            // 
            // UC_MeusAnuncios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(pnlNavBar);
            Controls.Add(dgvMeusAnuncios);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_MeusAnuncios";
            Size = new Size(1144, 875);
            Load += UC_MeusAnuncios_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeusAnuncios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private LinkLabel lnkCadAnuncios;
        private LinkLabel lnkHome;
        private DataGridView dgvMeusAnuncios;
        private Button btnExcluir;
        private Button btnListar;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pbLogout;
        private PictureBox pbPerfil;
        private Label label2;
        private LinkLabel linkPlanos;
    }
}
