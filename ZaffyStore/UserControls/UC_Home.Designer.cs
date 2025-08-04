namespace ZaffyStore.UserControls
{
    partial class UC_Home
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
            conteinerCards = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelFotos = new Panel();
            pictureBox1 = new PictureBox();
            conteinerCards.SuspendLayout();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // conteinerCards
            // 
            conteinerCards.AutoScroll = true;
            conteinerCards.Controls.Add(tableLayoutPanel1);
            conteinerCards.Location = new Point(80, 239);
            conteinerCards.Name = "conteinerCards";
            conteinerCards.Size = new Size(624, 174);
            conteinerCards.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.32051F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.67949F));
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.MaximumSize = new Size(200, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.Size = new Size(10, 10);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelFotos
            // 
            panelFotos.Controls.Add(pictureBox1);
            panelFotos.Location = new Point(80, 42);
            panelFotos.Name = "panelFotos";
            panelFotos.Size = new Size(624, 163);
            panelFotos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MinimumSize = new Size(624, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(conteinerCards);
            Controls.Add(panelFotos);
            Name = "UC_Home";
            Size = new Size(785, 454);
            Load += UC_Home_Load;
            conteinerCards.ResumeLayout(false);
            conteinerCards.PerformLayout();
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel conteinerCards;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelFotos;
        private PictureBox pictureBox1;
    }
}
