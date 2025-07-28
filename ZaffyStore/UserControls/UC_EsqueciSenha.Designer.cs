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
            linkLogin = new LinkLabel();
            pbEyeClosed = new PictureBox();
            btnMudarSenha = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pbEyeOpen = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(115, 76, 191);
            panel1.Controls.Add(linkLogin);
            panel1.Controls.Add(pbEyeClosed);
            panel1.Controls.Add(btnMudarSenha);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbEyeOpen);
            panel1.Location = new Point(395, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 493);
            panel1.TabIndex = 13;
            // 
            // linkLogin
            // 
            linkLogin.ActiveLinkColor = Color.FromArgb(192, 255, 255);
            linkLogin.AutoSize = true;
            linkLogin.Font = new Font("Segoe UI", 11F);
            linkLogin.LinkColor = Color.White;
            linkLogin.Location = new Point(182, 408);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(46, 20);
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            // 
            // pbEyeClosed
            // 
            pbEyeClosed.Cursor = Cursors.Hand;
            pbEyeClosed.Location = new Point(338, 267);
            pbEyeClosed.Name = "pbEyeClosed";
            pbEyeClosed.Size = new Size(31, 28);
            pbEyeClosed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeClosed.TabIndex = 15;
            pbEyeClosed.TabStop = false;
            // 
            // btnMudarSenha
            // 
            btnMudarSenha.BackColor = Color.Black;
            btnMudarSenha.FlatStyle = FlatStyle.Popup;
            btnMudarSenha.Font = new Font("Century Gothic", 13F, FontStyle.Bold);
            btnMudarSenha.ForeColor = Color.White;
            btnMudarSenha.Location = new Point(144, 369);
            btnMudarSenha.Name = "btnMudarSenha";
            btnMudarSenha.Size = new Size(119, 36);
            btnMudarSenha.TabIndex = 4;
            btnMudarSenha.Text = "Redefinir";
            btnMudarSenha.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
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
            label1.Location = new Point(81, 73);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 0;
            label1.Text = "Atualize sua senha";
            // 
            // pbEyeOpen
            // 
            pbEyeOpen.Cursor = Cursors.Hand;
            pbEyeOpen.Location = new Point(338, 267);
            pbEyeOpen.Name = "pbEyeOpen";
            pbEyeOpen.Size = new Size(31, 28);
            pbEyeOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEyeOpen.TabIndex = 16;
            pbEyeOpen.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Protótipo_de_Baixa_Fidelidade1;
            pictureBox1.Location = new Point(42, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // UC_EsqueciSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "UC_EsqueciSenha";
            Size = new Size(800, 493);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEyeClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEyeOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLogin;
        private PictureBox pbEyeClosed;
        private Button btnMudarSenha;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtLogin;
        private Label label2;
        private Label label1;
        private PictureBox pbEyeOpen;
        private PictureBox pictureBox1;
    }
}
