namespace ZaffyStore.UserControls
{
    partial class UC_paginaCompra
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
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            pnlNavBar = new Panel();
            lnkHome = new LinkLabel();
            btnEntrarEmContato = new Button();
            lblLocal = new Label();
            pbImagem = new PictureBox();
            lblDescricao = new Label();
            lblContato = new Label();
            lblPreco = new Label();
            lblProdName = new Label();
            lblDescricaoProd = new Label();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).BeginInit();
            SuspendLayout();
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
            pnlNavBar.TabIndex = 3;
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
            // btnEntrarEmContato
            // 
            btnEntrarEmContato.BackColor = Color.FromArgb(115, 76, 191);
            btnEntrarEmContato.ForeColor = Color.White;
            btnEntrarEmContato.Location = new Point(589, 419);
            btnEntrarEmContato.Name = "btnEntrarEmContato";
            btnEntrarEmContato.Size = new Size(126, 40);
            btnEntrarEmContato.TabIndex = 39;
            btnEntrarEmContato.Text = "Contatar";
            btnEntrarEmContato.UseVisualStyleBackColor = false;
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocal.Location = new Point(32, 447);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(325, 22);
            lblLocal.TabIndex = 37;
            lblLocal.Text = "Local: Casa do Cristiano Ronaldo - Lisboa\r\n";
            // 
            // pbImagem
            // 
            pbImagem.Image = Properties.Resources.download__1_;
            pbImagem.Location = new Point(277, 58);
            pbImagem.Name = "pbImagem";
            pbImagem.Size = new Size(257, 179);
            pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagem.TabIndex = 36;
            pbImagem.TabStop = false;
            pbImagem.Click += pbImagem_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(32, 305);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 22);
            lblDescricao.TabIndex = 33;
            lblDescricao.Text = "Descrição";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.Location = new Point(580, 379);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(148, 22);
            lblContato.TabIndex = 31;
            lblContato.Text = "Contato: Anônimo";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(580, 337);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(135, 22);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Preço: R$8000.7";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdName.Location = new Point(32, 256);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(393, 29);
            lblProdName.TabIndex = 23;
            lblProdName.Text = "PS4 slim do Cristiano Ronaldo (Jr)";
            // 
            // lblDescricaoProd
            // 
            lblDescricaoProd.AutoSize = true;
            lblDescricaoProd.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescricaoProd.Location = new Point(32, 337);
            lblDescricaoProd.Name = "lblDescricaoProd";
            lblDescricaoProd.Size = new Size(404, 22);
            lblDescricaoProd.TabIndex = 40;
            lblDescricaoProd.Text = "PS4 do filho do cristiano ronaldo. Busca a combinar";
            // 
            // UC_paginaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescricaoProd);
            Controls.Add(btnEntrarEmContato);
            Controls.Add(lblLocal);
            Controls.Add(pbImagem);
            Controls.Add(lblDescricao);
            Controls.Add(lblContato);
            Controls.Add(lblPreco);
            Controls.Add(lblProdName);
            Controls.Add(pnlNavBar);
            Name = "UC_paginaCompra";
            Size = new Size(786, 567);
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private Panel pnlNavBar;
        private LinkLabel lnkHome;
        private Button btnEntrarEmContato;
        private Label lblLocal;
        private PictureBox pbImagem;
        private Label lblDescricao;
        private Label lblContato;
        private Label lblPreco;
        private Label lblProdName;
        private Label lblDescricaoProd;
    }
}
