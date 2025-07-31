namespace ZaffyStore.UserControls
{
    partial class UC_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            linkCadastro = new LinkLabel();
            linkEsqueciSenha = new LinkLabel();
            pbEyeClosed = new PictureBox();
            btnLogin = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pbEyeOpen = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(115, 76, 191);
            panel1.Controls.Add(linkEsqueciSenha);
            panel1.Controls.Add(pbEyeClosed);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbEyeOpen);
            panel1.Controls.Add(linkCadastro);
            panel1.Location = new Point(398, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 501);
            panel1.TabIndex = 15;
            // 
            // linkCadastro
            // 
            linkCadastro.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            linkCadastro.AutoSize = true;
            linkCadastro.Cursor = Cursors.Hand;
            linkCadastro.Font = new Font("Segoe UI", 12F);
            linkCadastro.LinkColor = Color.White;
            linkCadastro.Location = new Point(157, 404);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(92, 21);
            linkCadastro.TabIndex = 5;
            linkCadastro.TabStop = true;
            linkCadastro.Text = "Cadastre-se";
            linkCadastro.LinkClicked += linkCadastro_LinkClicked;
            // 
            // linkEsqueciSenha
            // 
            linkEsqueciSenha.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            linkEsqueciSenha.AutoSize = true;
            linkEsqueciSenha.Cursor = Cursors.Hand;
            linkEsqueciSenha.LinkColor = Color.White;
            linkEsqueciSenha.Location = new Point(78, 299);
            linkEsqueciSenha.Name = "linkEsqueciSenha";
            linkEsqueciSenha.Size = new Size(91, 15);
            linkEsqueciSenha.TabIndex = 3;
            linkEsqueciSenha.TabStop = true;
            linkEsqueciSenha.Text = "Esqueci a Senha";
            linkEsqueciSenha.VisitedLinkColor = Color.FromArgb(128, 128, 255);
            linkEsqueciSenha.LinkClicked += linkEsqueciSenha_LinkClicked;
            // 
            // pbEyeClosed
            // 
            pbEyeClosed.Cursor = Cursors.Hand;
            pbEyeClosed.Image = Properties.Resources.icons8_invisível_32;
            pbEyeClosed.Location = new Point(338, 267);
            pbEyeClosed.Name = "pbEyeClosed";
            pbEyeClosed.Size = new Size(31, 28);
            pbEyeClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeClosed.TabIndex = 15;
            pbEyeClosed.TabStop = false;
            pbEyeClosed.Click += pbEyeClosed_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Black;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(149, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Cursor = Cursors.IBeam;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(78, 267);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(251, 29);
            txtSenha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(78, 244);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.Cursor = Cursors.IBeam;
            txtLogin.Font = new Font("Segoe UI", 12F);
            txtLogin.Location = new Point(78, 193);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(251, 29);
            txtLogin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 170);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 78);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindo(a) de volta!";
            // 
            // pbEyeOpen
            // 
            pbEyeOpen.Cursor = Cursors.Hand;
            pbEyeOpen.Image = Properties.Resources.icons8_visível_32;
            pbEyeOpen.Location = new Point(338, 267);
            pbEyeOpen.Name = "pbEyeOpen";
            pbEyeOpen.Size = new Size(31, 28);
            pbEyeOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeOpen.TabIndex = 16;
            pbEyeOpen.TabStop = false;
            pbEyeOpen.Click += pbEyeOpen_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 421);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(49, 265);
            label5.Name = "label5";
            label5.Size = new Size(188, 16);
            label5.TabIndex = 17;
            label5.Text = "anúncios rápidos, negócios certos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Protótipo_de_Baixa_Fidelidade1;
            pictureBox1.Location = new Point(31, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // UC_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Name = "UC_Login";
            Size = new Size(801, 493);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private LinkLabel linkCadastro;
        private LinkLabel linkEsqueciSenha;
        private PictureBox pbEyeClosed;
        private Button btnLogin;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtLogin;
        private Label label2;
        private Label label1;
        private PictureBox pbEyeOpen;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
