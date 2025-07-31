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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EsqueciSenha));
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
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 99);
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
            pbEyeClosed.Location = new Point(321, 238);
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
            btnMudarSenha.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
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
            txtNovaSenha.Font = new Font("Segoe UI", 12F);
            txtNovaSenha.Location = new Point(61, 238);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(251, 29);
            txtNovaSenha.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(61, 212);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(61, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 29);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(61, 138);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 23F, FontStyle.Bold);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(299, 37);
            label1.TabIndex = 0;
            label1.Text = "Atualize sua senha";
            // 
            // pbEyeOpen
            // 
            pbEyeOpen.Cursor = Cursors.Hand;
            pbEyeOpen.Image = Properties.Resources.icons8_visível_32;
            pbEyeOpen.Location = new Point(321, 238);
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
            pictureBox3.Location = new Point(0, 428);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // lblEspecial
            // 
            lblEspecial.AutoSize = true;
            lblEspecial.Location = new Point(164, 294);
            lblEspecial.Name = "lblEspecial";
            lblEspecial.Size = new Size(0, 15);
            lblEspecial.TabIndex = 26;
            // 
            // lblMinuscula
            // 
            lblMinuscula.AutoSize = true;
            lblMinuscula.Location = new Point(58, 294);
            lblMinuscula.Name = "lblMinuscula";
            lblMinuscula.Size = new Size(0, 15);
            lblMinuscula.TabIndex = 25;
            // 
            // lblMaiuscula
            // 
            lblMaiuscula.AutoSize = true;
            lblMaiuscula.Location = new Point(197, 272);
            lblMaiuscula.Name = "lblMaiuscula";
            lblMaiuscula.Size = new Size(0, 15);
            lblMaiuscula.TabIndex = 24;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(58, 272);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(0, 15);
            lblTamanho.TabIndex = 23;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(61, 341);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(251, 29);
            txtCodigo.TabIndex = 27;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.Indigo;
            btnEnviar.FlatStyle = FlatStyle.Popup;
            btnEnviar.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.White;
            btnEnviar.Location = new Point(129, 387);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(119, 36);
            btnEnviar.TabIndex = 28;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(64, 315);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 29;
            label4.Text = "Código:";
            // 
            // UC_EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(btnEnviar);
            Controls.Add(txtCodigo);
            Controls.Add(lblEspecial);
            Controls.Add(lblMinuscula);
            Controls.Add(linkLogin);
            Controls.Add(lblMaiuscula);
            Controls.Add(panel1);
            Controls.Add(lblTamanho);
            Controls.Add(btnMudarSenha);
            Controls.Add(pbEyeClosed);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(pbEyeOpen);
            Controls.Add(txtNovaSenha);
            Name = "UC_EsqueciSenha";
            Size = new Size(801, 493);
            Load += UC_EsqueciSenha_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label label4;
    }
}
