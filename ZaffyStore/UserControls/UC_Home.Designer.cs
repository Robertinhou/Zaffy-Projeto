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
            this.panelFotos = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.conteinerCards = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.conteinerCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFotos
            // 
            this.panelFotos.Controls.Add(this.pictureBox1);
            this.panelFotos.Location = new System.Drawing.Point(87, 56);
            this.panelFotos.Name = "panelFotos";
            this.panelFotos.Size = new System.Drawing.Size(624, 163);
            this.panelFotos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(624, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // conteinerCards
            // 
            this.conteinerCards.AutoScroll = true;
            this.conteinerCards.Controls.Add(this.tableLayoutPanel1);
            this.conteinerCards.Location = new System.Drawing.Point(87, 253);
            this.conteinerCards.Name = "conteinerCards";
            this.conteinerCards.Size = new System.Drawing.Size(624, 174);
            this.conteinerCards.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.32051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67949F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 0; // Começa vazio, as linhas serão adicionadas dinamicamente
            this.tableLayoutPanel1.RowStyles.Clear();
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.MaximumSize = new Size(conteinerCards.ClientSize.Width - 20, 0);

            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.conteinerCards);
            this.Controls.Add(this.panelFotos);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(785, 454);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panelFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.conteinerCards.ResumeLayout(false);
            this.conteinerCards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFotos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel conteinerCards;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
