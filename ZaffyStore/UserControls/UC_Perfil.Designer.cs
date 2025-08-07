namespace ZaffyStore.UserControls
{
    partial class UC_Perfil
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
            label1 = new Label();
            lblNomeUser = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtEmail = new TextBox();
            txtRua = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            pbFotoUsuario = new PictureBox();
            btnEnvFoto = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            btnEditarPerfil = new Button();
            mskdCelular = new MaskedTextBox();
            mskdCpf = new MaskedTextBox();
            mskdDataNascimento = new MaskedTextBox();
            mskdCep = new MaskedTextBox();
            btnBuscarCep = new Button();
            txtBairro = new TextBox();
            Bairro = new Label();
            lblCaminhoFoto = new Label();
            pnlNavBar = new Panel();
            lnkLogout = new LinkLabel();
            lnkPerfil = new LinkLabel();
            lnkHome = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).BeginInit();
            pnlNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 1;
            label1.Text = "PERFIL DO USUÁRIO";
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblNomeUser.Location = new Point(202, 125);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(0, 29);
            lblNomeUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 262);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 332);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 4;
            label4.Text = "Celular:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 397);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 5;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 463);
            label6.Name = "label6";
            label6.Size = new Size(213, 25);
            label6.TabIndex = 6;
            label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(389, 262);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 7;
            label7.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(389, 397);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 8;
            label8.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(553, 462);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 9;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(389, 332);
            label10.Name = "label10";
            label10.Size = new Size(57, 25);
            label10.TabIndex = 10;
            label10.Text = "Rua:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(41, 288);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 29);
            txtEmail.TabIndex = 11;
            // 
            // txtRua
            // 
            txtRua.Enabled = false;
            txtRua.Font = new Font("Segoe UI", 12F);
            txtRua.Location = new Point(389, 358);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(247, 29);
            txtRua.TabIndex = 16;
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Font = new Font("Segoe UI", 12F);
            txtCidade.Location = new Point(389, 423);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(247, 29);
            txtCidade.TabIndex = 17;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.Location = new Point(556, 488);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(80, 29);
            txtEstado.TabIndex = 18;
            // 
            // pbFotoUsuario
            // 
            pbFotoUsuario.Enabled = false;
            pbFotoUsuario.ErrorImage = Properties.Resources.icons8_usuário_30;
            pbFotoUsuario.Image = Properties.Resources.icons8_usuário_96;
            pbFotoUsuario.InitialImage = Properties.Resources.icons8_usuário_30;
            pbFotoUsuario.Location = new Point(36, 81);
            pbFotoUsuario.Name = "pbFotoUsuario";
            pbFotoUsuario.Size = new Size(142, 119);
            pbFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoUsuario.TabIndex = 19;
            pbFotoUsuario.TabStop = false;
            pbFotoUsuario.Click += pbFotoUsuario_Click;
            // 
            // btnEnvFoto
            // 
            btnEnvFoto.BackColor = Color.Indigo;
            btnEnvFoto.Enabled = false;
            btnEnvFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnvFoto.ForeColor = Color.White;
            btnEnvFoto.Location = new Point(62, 206);
            btnEnvFoto.Name = "btnEnvFoto";
            btnEnvFoto.Size = new Size(90, 23);
            btnEnvFoto.TabIndex = 20;
            btnEnvFoto.Text = "Enviar Foto";
            btnEnvFoto.UseVisualStyleBackColor = false;
            btnEnvFoto.Click += btnEnvFoto_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Indigo;
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(663, 62);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 42);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(388, 206);
            label2.Name = "label2";
            label2.Size = new Size(258, 25);
            label2.TabIndex = 22;
            label2.Text = "Informações de Endereço";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BackColor = Color.Indigo;
            btnEditarPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPerfil.ForeColor = Color.White;
            btnEditarPerfil.Location = new Point(542, 62);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(105, 42);
            btnEditarPerfil.TabIndex = 23;
            btnEditarPerfil.Text = "Editar";
            btnEditarPerfil.UseVisualStyleBackColor = false;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
            // 
            // mskdCelular
            // 
            mskdCelular.Enabled = false;
            mskdCelular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdCelular.Location = new Point(41, 358);
            mskdCelular.Mask = "(00) 00000-0000";
            mskdCelular.Name = "mskdCelular";
            mskdCelular.Size = new Size(137, 29);
            mskdCelular.TabIndex = 24;
            // 
            // mskdCpf
            // 
            mskdCpf.Enabled = false;
            mskdCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdCpf.Location = new Point(41, 423);
            mskdCpf.Mask = "000,000,000-00";
            mskdCpf.Name = "mskdCpf";
            mskdCpf.Size = new Size(137, 29);
            mskdCpf.TabIndex = 25;
            // 
            // mskdDataNascimento
            // 
            mskdDataNascimento.Enabled = false;
            mskdDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdDataNascimento.Location = new Point(41, 489);
            mskdDataNascimento.Mask = "00/00/0000";
            mskdDataNascimento.Name = "mskdDataNascimento";
            mskdDataNascimento.Size = new Size(132, 29);
            mskdDataNascimento.TabIndex = 26;
            mskdDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mskdCep
            // 
            mskdCep.Enabled = false;
            mskdCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdCep.Location = new Point(389, 288);
            mskdCep.Mask = "00000-000";
            mskdCep.Name = "mskdCep";
            mskdCep.Size = new Size(137, 29);
            mskdCep.TabIndex = 27;
            // 
            // btnBuscarCep
            // 
            btnBuscarCep.BackColor = Color.Indigo;
            btnBuscarCep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCep.ForeColor = Color.White;
            btnBuscarCep.Location = new Point(542, 283);
            btnBuscarCep.Name = "btnBuscarCep";
            btnBuscarCep.Size = new Size(93, 34);
            btnBuscarCep.TabIndex = 28;
            btnBuscarCep.Text = "Buscar";
            btnBuscarCep.UseVisualStyleBackColor = false;
            btnBuscarCep.Click += btnBuscarCep_Click;
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Font = new Font("Segoe UI", 12F);
            txtBairro.Location = new Point(389, 488);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(147, 29);
            txtBairro.TabIndex = 30;
            // 
            // Bairro
            // 
            Bairro.AutoSize = true;
            Bairro.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bairro.Location = new Point(389, 462);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(76, 25);
            Bairro.TabIndex = 29;
            Bairro.Text = "Bairro:";
            // 
            // lblCaminhoFoto
            // 
            lblCaminhoFoto.AutoSize = true;
            lblCaminhoFoto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblCaminhoFoto.Location = new Point(53, 230);
            lblCaminhoFoto.Name = "lblCaminhoFoto";
            lblCaminhoFoto.Size = new Size(0, 15);
            lblCaminhoFoto.TabIndex = 31;
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
            pnlNavBar.TabIndex = 2;
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
            lnkHome.LinkClicked += lnkHome_LinkClicked;
            // 
            // UC_Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(pnlNavBar);
            Controls.Add(lblCaminhoFoto);
            Controls.Add(txtBairro);
            Controls.Add(Bairro);
            Controls.Add(btnBuscarCep);
            Controls.Add(mskdCep);
            Controls.Add(mskdDataNascimento);
            Controls.Add(mskdCpf);
            Controls.Add(mskdCelular);
            Controls.Add(btnEditarPerfil);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(btnEnvFoto);
            Controls.Add(pbFotoUsuario);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtRua);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNomeUser);
            Controls.Add(label1);
            Name = "UC_Perfil";
            Size = new Size(786, 567);
            Load += UC_Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).EndInit();
            pnlNavBar.ResumeLayout(false);
            pnlNavBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblNomeUser;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtEmail;
        private TextBox txtRua;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private PictureBox pbFotoUsuario;
        private Button btnEnvFoto;
        private Button btnSalvar;
        private Label label2;
        private Button btnEditarPerfil;
        private MaskedTextBox mskdCelular;
        private MaskedTextBox mskdCpf;
        private MaskedTextBox mskdDataNascimento;
        private MaskedTextBox mskdCep;
        private Button btnBuscarCep;
        private TextBox txtBairro;
        private Label Bairro;
        private Label lblCaminhoFoto;
        private Panel pnlNavBar;
        private LinkLabel lnkLogout;
        private LinkLabel lnkPerfil;
        private LinkLabel lnkHome;
    }
}
