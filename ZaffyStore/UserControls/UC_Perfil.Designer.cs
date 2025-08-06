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
            pnlNavBar = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(4, 5, 4, 5);
            pnlNavBar.MaximumSize = new Size(1121, 70);
            pnlNavBar.MinimumSize = new Size(1121, 70);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1121, 70);
            pnlNavBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 1;
            label1.Text = "PERFIL DO USUÁRIO";
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblNomeUser.Location = new Point(289, 208);
            lblNomeUser.Margin = new Padding(4, 0, 4, 0);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(0, 43);
            lblNomeUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 437);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 37);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 553);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 37);
            label4.TabIndex = 4;
            label4.Text = "Celular:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(59, 662);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 37);
            label5.TabIndex = 5;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 772);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(324, 37);
            label6.TabIndex = 6;
            label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(556, 437);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 37);
            label7.TabIndex = 7;
            label7.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(556, 662);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(134, 37);
            label8.TabIndex = 8;
            label8.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(790, 770);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(122, 37);
            label9.TabIndex = 9;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(556, 553);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(80, 37);
            label10.TabIndex = 10;
            label10.Text = "Rua:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(59, 480);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 39);
            txtEmail.TabIndex = 11;
            // 
            // txtRua
            // 
            txtRua.Enabled = false;
            txtRua.Font = new Font("Segoe UI", 12F);
            txtRua.Location = new Point(556, 597);
            txtRua.Margin = new Padding(4, 5, 4, 5);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(351, 39);
            txtRua.TabIndex = 16;
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Font = new Font("Segoe UI", 12F);
            txtCidade.Location = new Point(556, 705);
            txtCidade.Margin = new Padding(4, 5, 4, 5);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(351, 39);
            txtCidade.TabIndex = 17;
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Font = new Font("Segoe UI", 12F);
            txtEstado.Location = new Point(794, 813);
            txtEstado.Margin = new Padding(4, 5, 4, 5);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(113, 39);
            txtEstado.TabIndex = 18;
            // 
            // pbFotoUsuario
            // 
            pbFotoUsuario.Enabled = false;
            pbFotoUsuario.ErrorImage = Properties.Resources.icons8_usuário_30;
            pbFotoUsuario.Image = Properties.Resources.icons8_usuário_96;
            pbFotoUsuario.InitialImage = Properties.Resources.icons8_usuário_30;
            pbFotoUsuario.Location = new Point(51, 135);
            pbFotoUsuario.Margin = new Padding(4, 5, 4, 5);
            pbFotoUsuario.Name = "pbFotoUsuario";
            pbFotoUsuario.Size = new Size(203, 198);
            pbFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoUsuario.TabIndex = 19;
            pbFotoUsuario.TabStop = false;
            // 
            // btnEnvFoto
            // 
            btnEnvFoto.BackColor = Color.Indigo;
            btnEnvFoto.Enabled = false;
            btnEnvFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnvFoto.ForeColor = Color.White;
            btnEnvFoto.Location = new Point(89, 343);
            btnEnvFoto.Margin = new Padding(4, 5, 4, 5);
            btnEnvFoto.Name = "btnEnvFoto";
            btnEnvFoto.Size = new Size(129, 38);
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
            btnSalvar.Location = new Point(947, 103);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 70);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(554, 343);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(393, 37);
            label2.TabIndex = 22;
            label2.Text = "Informações de Endereço";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BackColor = Color.Indigo;
            btnEditarPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPerfil.ForeColor = Color.White;
            btnEditarPerfil.Location = new Point(774, 103);
            btnEditarPerfil.Margin = new Padding(4, 5, 4, 5);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(150, 70);
            btnEditarPerfil.TabIndex = 23;
            btnEditarPerfil.Text = "Editar";
            btnEditarPerfil.UseVisualStyleBackColor = false;
            btnEditarPerfil.Click += btnEditarPerfil_Click;
            // 
            // mskdCelular
            // 
            mskdCelular.Enabled = false;
            mskdCelular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdCelular.Location = new Point(59, 597);
            mskdCelular.Margin = new Padding(4, 5, 4, 5);
            mskdCelular.Mask = "(00) 00000-0000";
            mskdCelular.Name = "mskdCelular";
            mskdCelular.Size = new Size(194, 39);
            mskdCelular.TabIndex = 24;
            // 
            // mskdCpf
            // 
            mskdCpf.Enabled = false;
            mskdCpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdCpf.Location = new Point(59, 705);
            mskdCpf.Margin = new Padding(4, 5, 4, 5);
            mskdCpf.Mask = "000,000,000-00";
            mskdCpf.Name = "mskdCpf";
            mskdCpf.Size = new Size(194, 39);
            mskdCpf.TabIndex = 25;
            // 
            // mskdDataNascimento
            // 
            mskdDataNascimento.Enabled = false;
            mskdDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdDataNascimento.Location = new Point(59, 815);
            mskdDataNascimento.Margin = new Padding(4, 5, 4, 5);
            mskdDataNascimento.Mask = "00/00/0000";
            mskdDataNascimento.Name = "mskdDataNascimento";
            mskdDataNascimento.Size = new Size(187, 39);
            mskdDataNascimento.TabIndex = 26;
            mskdDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // mskdCep
            // 
            mskdCep.Enabled = false;
            mskdCep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskdCep.Location = new Point(556, 480);
            mskdCep.Margin = new Padding(4, 5, 4, 5);
            mskdCep.Mask = "00000-000";
            mskdCep.Name = "mskdCep";
            mskdCep.Size = new Size(194, 39);
            mskdCep.TabIndex = 27;
            // 
            // btnBuscarCep
            // 
            btnBuscarCep.BackColor = Color.Indigo;
            btnBuscarCep.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCep.ForeColor = Color.White;
            btnBuscarCep.Location = new Point(774, 472);
            btnBuscarCep.Margin = new Padding(4, 5, 4, 5);
            btnBuscarCep.Name = "btnBuscarCep";
            btnBuscarCep.Size = new Size(133, 56);
            btnBuscarCep.TabIndex = 28;
            btnBuscarCep.Text = "Buscar";
            btnBuscarCep.UseVisualStyleBackColor = false;
            btnBuscarCep.Click += btnBuscarCep_Click;
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Font = new Font("Segoe UI", 12F);
            txtBairro.Location = new Point(556, 813);
            txtBairro.Margin = new Padding(4, 5, 4, 5);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(208, 39);
            txtBairro.TabIndex = 30;
            // 
            // Bairro
            // 
            Bairro.AutoSize = true;
            Bairro.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bairro.Location = new Point(556, 770);
            Bairro.Margin = new Padding(4, 0, 4, 0);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(108, 37);
            Bairro.TabIndex = 29;
            Bairro.Text = "Bairro:";
            // 
            // lblCaminhoFoto
            // 
            lblCaminhoFoto.AutoSize = true;
            lblCaminhoFoto.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaminhoFoto.Location = new Point(39, 135);
            lblCaminhoFoto.Margin = new Padding(4, 0, 4, 0);
            lblCaminhoFoto.Name = "lblCaminhoFoto";
            lblCaminhoFoto.Size = new Size(0, 37);
            lblCaminhoFoto.TabIndex = 31;
            lblCaminhoFoto.Visible = false;
            // 
            // UC_Perfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            Controls.Add(pnlNavBar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_Perfil";
            Size = new Size(1123, 945);
            Load += UC_Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
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
    }
}
