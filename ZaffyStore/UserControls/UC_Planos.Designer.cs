namespace ZaffyStore.UserControls
{
    partial class UC_Planos
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
            lnkCadAnuncios = new LinkLabel();
            lnkHome = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
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
            pnlNavBar.TabIndex = 12;
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
            lnkCadAnuncios.AutoSize = true;
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
            // 
            // lnkHome
            // 
            lnkHome.AutoSize = true;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 90);
            label1.Name = "label1";
            label1.Size = new Size(226, 43);
            label1.TabIndex = 14;
            label1.Text = "Planos Zaffy";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(76, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 533);
            panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = Properties.Resources.plano_STARTER;
            pictureBox1.Location = new Point(26, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 339);
            label2.Name = "label2";
            label2.Size = new Size(172, 47);
            label2.TabIndex = 1;
            label2.Text = "STARTER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 405);
            label3.Name = "label3";
            label3.Size = new Size(127, 34);
            label3.TabIndex = 2;
            label3.Text = "R$ 24,99";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 456);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // UC_Planos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pnlNavBar);
            Controls.Add(label1);
            Name = "UC_Planos";
            Size = new Size(1144, 875);
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private PictureBox pbLogout;
        private PictureBox pbPerfil;
        private PictureBox pictureBox2;
        private LinkLabel lnkCadAnuncios;
        private LinkLabel lnkHome;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
