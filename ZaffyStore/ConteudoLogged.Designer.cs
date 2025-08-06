
namespace ZaffyStore
{
    partial class ConteudoLogged
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTopL = new Panel();
            pbMinimize = new PictureBox();
            pbClose = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlContentLogged = new Panel();
            lblNomeLogado = new Label();
            pnlTopL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContentLogged.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTopL
            // 
            pnlTopL.BackColor = Color.FromArgb(115, 76, 191);
            pnlTopL.Controls.Add(pbMinimize);
            pnlTopL.Controls.Add(pbClose);
            pnlTopL.Controls.Add(pictureBox1);
            pnlTopL.Dock = DockStyle.Top;
            pnlTopL.Location = new Point(0, 0);
            pnlTopL.Name = "pnlTopL";
            pnlTopL.Size = new Size(785, 32);
            pnlTopL.TabIndex = 1;
            pnlTopL.MouseDown += pnlTopL_MouseDown;
            pnlTopL.MouseUp += pnlTopL_MouseUp;
            // 
            // pbMinimize
            // 
            pbMinimize.Image = Properties.Resources.minimize;
            pbMinimize.Location = new Point(715, 3);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(31, 27);
            pbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMinimize.TabIndex = 3;
            pbMinimize.TabStop = false;
            pbMinimize.Click += pbMinimize_Click_1;
            pbMinimize.MouseEnter += pbMinimize_MouseEnter;
            pbMinimize.MouseLeave += pbMinimize_MouseLeave_1;
            // 
            // pbClose
            // 
            pbClose.Image = Properties.Resources.icons8_excluir_48__1_;
            pbClose.Location = new Point(752, 2);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(31, 27);
            pbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClose.TabIndex = 1;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            pbClose.MouseEnter += pbClose_MouseEnter;
            pbClose.MouseLeave += pbClose_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlContentLogged
            // 
            pnlContentLogged.Controls.Add(lblNomeLogado);
            pnlContentLogged.Dock = DockStyle.Fill;
            pnlContentLogged.Location = new Point(0, 32);
            pnlContentLogged.Name = "pnlContentLogged";
            pnlContentLogged.Size = new Size(785, 454);
            pnlContentLogged.TabIndex = 2;
            // 
            // lblNomeLogado
            // 
            lblNomeLogado.AutoSize = true;
            lblNomeLogado.Location = new Point(388, 13);
            lblNomeLogado.Name = "lblNomeLogado";
            lblNomeLogado.Size = new Size(0, 15);
            lblNomeLogado.TabIndex = 0;
            // 
            // ConteudoLogged
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 486);
            Controls.Add(pnlContentLogged);
            Controls.Add(pnlTopL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConteudoLogged";
            Text = "Form1";
            Load += Conteudo_Load;
            pnlTopL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContentLogged.ResumeLayout(false);
            pnlContentLogged.PerformLayout();
            ResumeLayout(false);
        }





        #endregion

        private Panel pnlTopL;
        private Panel pnlContentLogged;
        private PictureBox pbClose;
        private PictureBox pictureBox1;
        private PictureBox pbMinimize;
        private Label lblNomeLogado;
    }
}
