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
<<<<<<< HEAD
<<<<<<< HEAD
            conteinerCards = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            linkperfil = new LinkLabel();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            conteinerCards.SuspendLayout();
=======
=======
>>>>>>> homeNavBar
            pnlNavBar = new Panel();
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
            dgvAnuncios = new DataGridView();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).BeginInit();
<<<<<<< HEAD
>>>>>>> homeNavBar
=======
>>>>>>> homeNavBar
            SuspendLayout();
            // 
            // panelFotos
            // 
            panelFotos.Controls.Add(pictureBox1);
<<<<<<< HEAD
<<<<<<< HEAD
            panelFotos.Location = new Point(87, 56);
=======
            panelFotos.Location = new Point(76, 74);
>>>>>>> homeNavBar
=======
            panelFotos.Location = new Point(76, 74);
>>>>>>> homeNavBar
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
<<<<<<< HEAD
<<<<<<< HEAD
            // conteinerCards
            // 
            conteinerCards.AutoScroll = true;
            conteinerCards.Controls.Add(tableLayoutPanel1);
            conteinerCards.Location = new Point(77, 257);
            conteinerCards.Margin = new Padding(5);
            conteinerCards.Name = "conteinerCards";
            conteinerCards.Size = new Size(665, 275);
            conteinerCards.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.32051F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.67949F));
            tableLayoutPanel1.Location = new Point(21, 23);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.MaximumSize = new Size(200, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.Size = new Size(10, 10);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // linkperfil
            // 
            linkperfil.AutoSize = true;
            linkperfil.Location = new Point(417, 27);
            linkperfil.Name = "linkperfil";
            linkperfil.Size = new Size(34, 15);
            linkperfil.TabIndex = 2;
            linkperfil.TabStop = true;
            linkperfil.Text = "perfil";
            linkperfil.LinkClicked += linkperfil_LinkClicked;
=======
=======
>>>>>>> homeNavBar
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(115, 76, 191);
            pnlNavBar.Controls.Add(lnkLogout);
            pnlNavBar.Controls.Add(lnkPerfil);
            pnlNavBar.Controls.Add(lnkHome);
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(785, 32);
            pnlNavBar.TabIndex = 1;
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
            lnkPerfil.Location = new Point(360, 9);
            lnkPerfil.Name = "lnkPerfil";
            lnkPerfil.Size = new Size(42, 15);
            lnkPerfil.TabIndex = 5;
            lnkPerfil.TabStop = true;
            lnkPerfil.Text = "PERFIL";
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
            dgvAnuncios.Location = new Point(76, 255);
            dgvAnuncios.Name = "dgvAnuncios";
            dgvAnuncios.Size = new Size(624, 249);
            dgvAnuncios.TabIndex = 3;
<<<<<<< HEAD
>>>>>>> homeNavBar
=======
>>>>>>> homeNavBar
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< HEAD
            Controls.Add(linkperfil);
            Controls.Add(conteinerCards);
=======
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
>>>>>>> homeNavBar
=======
            Controls.Add(dgvAnuncios);
            Controls.Add(pnlNavBar);
>>>>>>> homeNavBar
            Controls.Add(panelFotos);
            Name = "UC_Home";
            Size = new Size(785, 537);
            Load += UC_Home_Load;
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
<<<<<<< HEAD
<<<<<<< HEAD
            conteinerCards.ResumeLayout(false);
            conteinerCards.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
=======
=======
>>>>>>> homeNavBar
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnuncios).EndInit();
            ResumeLayout(false);
<<<<<<< HEAD
>>>>>>> homeNavBar
=======
>>>>>>> homeNavBar

        }

        #endregion

        private System.Windows.Forms.Panel panelFotos;
        private System.Windows.Forms.PictureBox pictureBox1;
<<<<<<< HEAD
<<<<<<< HEAD
        private System.Windows.Forms.Panel conteinerCards;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LinkLabel linkperfil;
=======
=======
>>>>>>> homeNavBar
        private Panel pnlNavBar;
        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private LinkLabel lnkHome;
        private DataGridView dgvAnuncios;
<<<<<<< HEAD
>>>>>>> homeNavBar
=======
>>>>>>> homeNavBar
    }
}
