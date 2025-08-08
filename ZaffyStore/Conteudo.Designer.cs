namespace ZaffyStore
{
    partial class Conteudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conteudo));
            panelTop = new Panel();
            pbMinimize = new PictureBox();
            pbClose = new PictureBox();
            panel1 = new Panel();
            panelCentral = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Indigo;
            panelTop.Controls.Add(pbMinimize);
            panelTop.Controls.Add(pbClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1144, 53);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            panelTop.MouseMove += panelTop_MouseMove;
            panelTop.MouseUp += panelTop_MouseUp;
            // 
            // pbMinimize
            // 
            pbMinimize.Cursor = Cursors.Hand;
            pbMinimize.Image = Properties.Resources.minimize;
            pbMinimize.Location = new Point(1053, 5);
            pbMinimize.Margin = new Padding(4, 5, 4, 5);
            pbMinimize.Name = "pbMinimize";
            pbMinimize.Size = new Size(40, 43);
            pbMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMinimize.TabIndex = 3;
            pbMinimize.TabStop = false;
            pbMinimize.Click += pbMinimize_Click;
            // 
            // pbClose
            // 
            pbClose.Cursor = Cursors.Hand;
            pbClose.Image = Properties.Resources.icons8_excluir_48__1_;
            pbClose.Location = new Point(1101, 5);
            pbClose.Margin = new Padding(4, 5, 4, 5);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(37, 43);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 2;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 53);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 1;
            // 
            // panelCentral
            // 
            panelCentral.AutoScroll = true;
            panelCentral.AutoSize = true;
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 53);
            panelCentral.Margin = new Padding(4, 5, 4, 5);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1144, 822);
            panelCentral.TabIndex = 2;
            // 
            // Conteudo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 875);
            Controls.Add(panelCentral);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1144, 1167);
            MinimumSize = new Size(1144, 875);
            Name = "Conteudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Conteudo_Load;
            Scroll += Conteudo_Scroll;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Panel panelTop;
        private Panel panel1;
        private PictureBox pbMinimize;
        private PictureBox pbClose;
        private Panel panelCentral;
    }
}
