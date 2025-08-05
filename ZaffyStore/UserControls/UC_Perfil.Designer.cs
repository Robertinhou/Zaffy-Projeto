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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            pbFotoUsuario = new PictureBox();
            btnEnvFoto = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFotoUsuario).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.MaximumSize = new Size(785, 42);
            pnlNavBar.MinimumSize = new Size(785, 42);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(785, 42);
            pnlNavBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 1;
            label1.Text = "PERFIL DO USUÁRIO";
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            lblNomeUser.Location = new Point(202, 129);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(0, 28);
            lblNomeUser.TabIndex = 2;
            lblNomeUser.Click += lblNomeUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 254);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 329);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 4;
            label4.Text = "Celular:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 391);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 5;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 454);
            label6.Name = "label6";
            label6.Size = new Size(218, 23);
            label6.TabIndex = 6;
            label6.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(358, 254);
            label7.Name = "label7";
            label7.Size = new Size(53, 23);
            label7.TabIndex = 7;
            label7.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(358, 391);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 8;
            label8.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(358, 454);
            label9.Name = "label9";
            label9.Size = new Size(80, 23);
            label9.TabIndex = 9;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(358, 329);
            label10.Name = "label10";
            label10.Size = new Size(47, 23);
            label10.TabIndex = 10;
            label10.Text = "Rua";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(41, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 29);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(41, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 29);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(41, 417);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 29);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(41, 480);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 29);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(358, 280);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 29);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 12F);
            textBox6.Location = new Point(358, 355);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 29);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 12F);
            textBox7.Location = new Point(358, 417);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(274, 29);
            textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 12F);
            textBox8.Location = new Point(358, 480);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(274, 29);
            textBox8.TabIndex = 18;
            // 
            // pbFotoUsuario
            // 
            pbFotoUsuario.Enabled = false;
            pbFotoUsuario.ErrorImage = Properties.Resources.icons8_usuário_30;
            pbFotoUsuario.InitialImage = Properties.Resources.icons8_usuário_30;
            pbFotoUsuario.Location = new Point(36, 85);
            pbFotoUsuario.Name = "pbFotoUsuario";
            pbFotoUsuario.Size = new Size(142, 119);
            pbFotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotoUsuario.TabIndex = 19;
            pbFotoUsuario.TabStop = false;
            // 
            // btnEnvFoto
            // 
            btnEnvFoto.Location = new Point(71, 210);
            btnEnvFoto.Name = "btnEnvFoto";
            btnEnvFoto.Size = new Size(75, 23);
            btnEnvFoto.TabIndex = 20;
            btnEnvFoto.Text = "Enviar Foto";
            btnEnvFoto.UseVisualStyleBackColor = true;
            btnEnvFoto.Click += btnEnvFoto_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Indigo;
            btnSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(668, 391);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 42);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(358, 210);
            label2.Name = "label2";
            label2.Size = new Size(264, 23);
            label2.TabIndex = 22;
            label2.Text = "Informações de Endereço";
            // 
            // UC_Perfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(btnEnvFoto);
            Controls.Add(pbFotoUsuario);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            MaximumSize = new Size(980, 571);
            MinimumSize = new Size(785, 571);
            Name = "UC_Perfil";
            Size = new Size(785, 571);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private PictureBox pbFotoUsuario;
        private Button btnEnvFoto;
        private Button btnSalvar;
        private Label label2;
    }
}
