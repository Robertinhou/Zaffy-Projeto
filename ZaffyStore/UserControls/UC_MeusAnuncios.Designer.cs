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
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(786, 38);
            pnlNavBar.TabIndex = 6;
            pnlNavBar.Paint += pnlNavBar_Paint;
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
            dgvMeusAnuncios.Location = new Point(76, 98);
            dgvMeusAnuncios.Name = "dgvMeusAnuncios";
            dgvMeusAnuncios.Size = new Size(624, 249);
            dgvMeusAnuncios.TabIndex = 7;
            dgvMeusAnuncios.CellContentClick += dgvMeusAnuncios_CellContentClick;
            dgvMeusAnuncios.CellDoubleClick += dgvMeusAnuncios_CellDoubleClick;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(226, 388);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 36);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(339, 388);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 36);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(453, 388);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(88, 36);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // UC_MeusAnuncios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnListar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(pnlNavBar);
            Controls.Add(dgvMeusAnuncios);
            Name = "UC_MeusAnuncios";
            Size = new Size(786, 567);
            Load += UC_MeusAnuncios_Load;
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMeusAnuncios).EndInit();
            ResumeLayout(false);
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
    }
}
