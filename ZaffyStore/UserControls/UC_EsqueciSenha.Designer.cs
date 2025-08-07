namespace ZaffyStore.UserControls
{
    partial class UC_EsqueciSenha
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            linkLogin = new LinkLabel();
            pbEyeClosed = new PictureBox();
            btnMudarSenha = new Button();
            txtNovaSenha = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pbEyeOpen = new PictureBox();
            pictureBox3 = new PictureBox();
            lblEspecial = new Label();
            lblMinuscula = new Label();
            lblMaiuscula = new Label();
            lblTamanho = new Label();
            txtCodigo = new TextBox();
            btnEnviar = new Button();
            lblCodigo = new Label();
            panelSenha = new Panel();
            linkLogin2 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelSenha.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(115, 76, 191);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(397, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 493);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zaffyBranco;
            pictureBox1.Location = new Point(39, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // linkLogin
            // 
            linkLogin.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.Font = new Font("Segoe UI", 11F);
            linkLogin.LinkColor = Color.Indigo;
            linkLogin.Location = new Point(166, 426);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(46, 20);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // pbEyeClosed
            // 
            pbEyeClosed.Cursor = Cursors.Hand;
            pbEyeClosed.Image = Properties.Resources.icons8_invisível_32;
            pbEyeClosed.Location = new Point(275, 31);
            pbEyeClosed.Name = "pbEyeClosed";
            pbEyeClosed.Size = new Size(31, 28);
            pbEyeClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeClosed.TabIndex = 15;
            pbEyeClosed.TabStop = false;
            pbEyeClosed.Click += pbEyeClosed_Click;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = Color.Indigo;
            btnMudarSenha.FlatStyle = FlatStyle.Popup;
            btnMudarSenha.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnMudarSenha.ForeColor = Color.White;
            btnMudarSenha.Location = new Point(129, 387);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(119, 36);
            btnMudarSenha.TabIndex = 4;
            btnMudarSenha.Text = "Redefinir";
            btnMudarSenha.UseVisualStyleBackColor = false;
            btnMudarSenha.Visible = false;
            btnMudarSenha.Click += btnMudarSenha_Click;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Cursor = Cursors.IBeam;
            txtNovaSenha.Font = new Font("Segoe UI", 12F);
            txtNovaSenha.Location = new Point(15, 31);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(251, 29);
            txtNovaSenha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(15, 5);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(61, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 29);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(61, 99);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(294, 35);
            label1.TabIndex = 0;
            label1.Text = "Atualize sua senha";
            // 
            // pbEyeOpen
            // 
            pbEyeOpen.Cursor = Cursors.Hand;
            pbEyeOpen.Image = Properties.Resources.icons8_visível_32;
            pbEyeOpen.Location = new Point(275, 31);
            pbEyeOpen.Name = "pbEyeOpen";
            pbEyeOpen.Size = new Size(31, 28);
            pbEyeOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeOpen.TabIndex = 16;
            pbEyeOpen.TabStop = false;
            pbEyeOpen.Click += pbEyeOpen_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ondaBaixo1;
            pictureBox3.Location = new Point(-1, 354);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // lblEspecial
            // 
            lblEspecial.AutoSize = true;
            lblEspecial.Location = new Point(118, 87);
            lblEspecial.Name = "lblEspecial";
            lblEspecial.Size = new Size(0, 15);
            lblEspecial.TabIndex = 26;
            // 
            // lblMinuscula
            // 
            lblMinuscula.AutoSize = true;
            lblMinuscula.Location = new Point(12, 87);
            lblMinuscula.Name = "lblMinuscula";
            lblMinuscula.Size = new Size(0, 15);
            lblMinuscula.TabIndex = 25;
            // 
            // lblMaiuscula
            // 
            lblMaiuscula.AutoSize = true;
            lblMaiuscula.Location = new Point(151, 65);
            lblMaiuscula.Name = "lblMaiuscula";
            lblMaiuscula.Size = new Size(0, 15);
            lblMaiuscula.TabIndex = 24;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(12, 65);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(0, 15);
            lblTamanho.TabIndex = 23;
            // 
            // txtCodigo
            // 
            txtCodigo.Cursor = Cursors.IBeam;
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(61, 230);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(103, 29);
            txtCodigo.TabIndex = 27;
            txtCodigo.Visible = false;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Indigo;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(166, 169);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(146, 36);
            btnEnviar.TabIndex = 28;
            btnEnviar.Text = "Enviar Código";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.Indigo;
            lblCodigo.Location = new Point(61, 203);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(83, 24);
            lblCodigo.TabIndex = 29;
            lblCodigo.Text = "Código:";
            lblCodigo.Visible = false;
            // 
            // panelSenha
            // 
            panelSenha.Controls.Add(lblEspecial);
            panelSenha.Controls.Add(lblMinuscula);
            panelSenha.Controls.Add(lblMaiuscula);
            panelSenha.Controls.Add(lblTamanho);
            panelSenha.Controls.Add(pbEyeClosed);
            panelSenha.Controls.Add(label3);
            panelSenha.Controls.Add(pbEyeOpen);
            panelSenha.Controls.Add(txtNovaSenha);
            panelSenha.Location = new Point(47, 267);
            panelSenha.Name = "panelSenha";
            panelSenha.Size = new Size(328, 111);
            panelSenha.TabIndex = 30;
            // 
            // linkLogin2
            // 
            linkLogin2.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            linkLogin2.AutoSize = true;
            linkLogin2.Cursor = Cursors.Hand;
            linkLogin2.Font = new Font("Segoe UI", 11F);
            linkLogin2.LinkColor = Color.Indigo;
            linkLogin2.Location = new Point(267, 207);
            linkLogin2.Name = "linkLogin2";
            linkLogin2.Size = new Size(46, 20);
            linkLogin2.TabIndex = 31;
            linkLogin2.TabStop = true;
            linkLogin2.Text = "Login";
            linkLogin2.LinkClicked += linkLogin2_LinkClicked;
            // 
            // UC_EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLogin2);
            Controls.Add(btnEnviar);
            Controls.Add(panelSenha);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(linkLogin);
            Controls.Add(panel1);
            Controls.Add(btnMudarSenha);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox3);
            Name = "UC_EsqueciSenha";
            Size = new Size(801, 493);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelSenha.ResumeLayout(false);
            panelSenha.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLogin;
        private PictureBox pbEyeClosed;
        private Button btnMudarSenha;
        private TextBox txtNovaSenha;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private PictureBox pbEyeOpen;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox1;
        private Label lblEspecial;
        private Label lblMinuscula;
        private Label lblMaiuscula;
        private Label lblTamanho;
        private TextBox txtCodigo;
        private Button btnEnviar;
        private Label lblCodigo;
        private Panel panelSenha;
        private LinkLabel linkLogin2;
    }
}
