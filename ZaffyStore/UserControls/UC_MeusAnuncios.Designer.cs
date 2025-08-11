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
            lnkCadAnuncios = new LinkLabel();
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
            dgvMeusAnuncios = new DataGridView();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnListar = new Button();
            label1 = new Label();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeusAnuncios).BeginInit();
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
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1123, 63);
            pnlNavBar.TabIndex = 6;
            pnlNavBar.Paint += pnlNavBar_Paint;
            // 
            // lnkCadAnuncios
            // 
            lnkCadAnuncios.AutoSize = true;
            lnkCadAnuncios.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkCadAnuncios.LinkColor = Color.White;
            lnkCadAnuncios.Location = new Point(127, 15);
            lnkCadAnuncios.Margin = new Padding(4, 0, 4, 0);
            lnkCadAnuncios.Name = "lnkCadAnuncios";
            lnkCadAnuncios.Size = new Size(101, 25);
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
            lnkHome.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkHome.LinkColor = Color.White;
            lnkHome.Location = new Point(33, 15);
            lnkHome.Margin = new Padding(4, 0, 4, 0);
            lnkHome.Name = "lnkHome";
            lnkHome.Size = new Size(64, 25);
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
            dgvMeusAnuncios.Size = new Size(1115, 415);
            dgvMeusAnuncios.TabIndex = 7;
            dgvMeusAnuncios.CellContentClick += dgvMeusAnuncios_CellContentClick;
            dgvMeusAnuncios.CellDoubleClick += dgvMeusAnuncios_CellDoubleClick;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(323, 647);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(126, 60);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(484, 647);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(126, 60);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(647, 647);
            btnListar.Margin = new Padding(4, 5, 4, 5);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(126, 60);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
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
            // UC_MeusAnuncios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(pnlNavBar);
            Controls.Add(dgvMeusAnuncios);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_MeusAnuncios";
            Size = new Size(1123, 945);
            Load += UC_MeusAnuncios_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeusAnuncios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private LinkLabel lnkCadAnuncios;
        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private LinkLabel lnkHome;
        private DataGridView dgvMeusAnuncios;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnListar;
        private Label label1;
    }
}
