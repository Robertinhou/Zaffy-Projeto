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

        private void InitializeComponent()
        {
            panelFotos = new Panel();
            pictureBox1 = new PictureBox();
            conteinerCards = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            conteinerCards.SuspendLayout();
            SuspendLayout();
            // 
            // panelFotos
            // 
            panelFotos.Controls.Add(pictureBox1);
            panelFotos.Location = new Point(87, 56);
            panelFotos.Name = "panelFotos";
            panelFotos.Size = new Size(624, 163);
            panelFotos.TabIndex = 0;
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
            // conteinerCards
            // 
            conteinerCards.AutoScroll = true;
            conteinerCards.Controls.Add(tableLayoutPanel1);
            conteinerCards.Location = new Point(77, 257);
            conteinerCards.Margin = new Padding(5);
            conteinerCards.Name = "conteinerCards";
            conteinerCards.Size = new Size(665, 275);
            conteinerCards.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.32051F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.67949F));
            tableLayoutPanel1.Location = new Point(21, 23);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.MaximumSize = new Size(200, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.Size = new Size(10, 10);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(conteinerCards);
            Controls.Add(panelFotos);
            Name = "UC_Home";
            Size = new Size(785, 537);
            Load += UC_Home_Load;
            panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            conteinerCards.ResumeLayout(false);
            conteinerCards.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFotos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel conteinerCards;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
