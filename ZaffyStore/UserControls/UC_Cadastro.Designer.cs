namespace ZaffyStore.UserControls
{
    partial class UC_Cadastro
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
            lblEspecial = new Label();
            lblMinuscula = new Label();
            lblMaiuscula = new Label();
            lblTamanho = new Label();
            linkLogin = new LinkLabel();
            txtSenha = new TextBox();
            label4 = new Label();
            pbEyeClosed = new PictureBox();
            btnCadastrar = new Button();
            txtEmail = new TextBox();
            label3 = new Label();
            txtNomeUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pbEyeOpen = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(115, 76, 191);
            panel1.Controls.Add(lblEspecial);
            panel1.Controls.Add(lblMinuscula);
            panel1.Controls.Add(lblMaiuscula);
            panel1.Controls.Add(lblTamanho);
            panel1.Controls.Add(linkLogin);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pbEyeClosed);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNomeUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbEyeOpen);
            panel1.Location = new Point(-4, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 501);
            panel1.TabIndex = 5;
            // 
            // lblEspecial
            // 
            lblEspecial.AutoSize = true;
            lblEspecial.Location = new Point(73, 389);
            lblEspecial.Name = "lblEspecial";
            lblEspecial.Size = new Size(0, 15);
            lblEspecial.TabIndex = 21;
            // 
            // lblMinuscula
            // 
            lblMinuscula.AutoSize = true;
            lblMinuscula.Location = new Point(73, 368);
            lblMinuscula.Name = "lblMinuscula";
            lblMinuscula.Size = new Size(0, 15);
            lblMinuscula.TabIndex = 20;
            // 
            // lblMaiuscula
            // 
            lblMaiuscula.AutoSize = true;
            lblMaiuscula.Location = new Point(73, 346);
            lblMaiuscula.Name = "lblMaiuscula";
            lblMaiuscula.Size = new Size(0, 15);
            lblMaiuscula.TabIndex = 19;
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Location = new Point(73, 324);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(0, 15);
            lblTamanho.TabIndex = 9;
            // 
            // linkLogin
            // 
            linkLogin.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            linkLogin.AutoSize = true;
            linkLogin.LinkColor = Color.White;
            linkLogin.Location = new Point(157, 458);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(91, 15);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Já possuo conta";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(73, 288);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(251, 29);
            txtSenha.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(73, 266);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 18;
            label4.Text = "Senha";
            // 
            // pbEyeClosed
            // 
            pbEyeClosed.Cursor = Cursors.Hand;
            pbEyeClosed.Image = Properties.Resources.icons8_invisível_32;
            pbEyeClosed.Location = new Point(330, 289);
            pbEyeClosed.Name = "pbEyeClosed";
            pbEyeClosed.Size = new Size(31, 28);
            pbEyeClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeClosed.TabIndex = 15;
            pbEyeClosed.TabStop = false;
            pbEyeClosed.Click += pbEyeClosed_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Black;
            btnCadastrar.FlatStyle = FlatStyle.Popup;
            btnCadastrar.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(140, 419);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(124, 36);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(73, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 29);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(73, 185);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Font = new Font("Segoe UI", 12F);
            txtNomeUsuario.Location = new Point(73, 134);
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(251, 29);
            txtNomeUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 108);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome de Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 39);
            label1.Name = "label1";
            label1.Size = new Size(204, 30);
            label1.TabIndex = 0;
            label1.Text = "Crie sua conta!";
            // 
            // pbEyeOpen
            // 
            pbEyeOpen.Cursor = Cursors.Hand;
            pbEyeOpen.Image = Properties.Resources.icons8_visível_32;
            pbEyeOpen.Location = new Point(330, 289);
            pbEyeOpen.Name = "pbEyeOpen";
            pbEyeOpen.Size = new Size(31, 28);
            pbEyeOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeOpen.TabIndex = 16;
            pbEyeOpen.TabStop = false;
            pbEyeOpen.Click += pbEyeOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoZaffyBranca;
            pictureBox1.Location = new Point(436, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(332, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.waves;
            pictureBox2.Location = new Point(545, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(304, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.waves___Copia;
            pictureBox3.Location = new Point(347, -14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(304, 187);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "UC_Cadastro";
            Size = new Size(801, 493);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private Panel panel1;
        private LinkLabel linkLogin;
        private TextBox txtSenha;
        private Label label4;
        private PictureBox pbEyeClosed;
        private Button btnCadastrar;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtNomeUsuario;
        private Label label2;
        private Label label1;
        private PictureBox pbEyeOpen;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblEspecial;
        private Label lblMinuscula;
        private Label lblMaiuscula;
        private Label lblTamanho;
    }
}
