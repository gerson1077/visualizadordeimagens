
namespace Aula09.Ativ1
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagemListBox1 = new System.Windows.Forms.ListBox();
            this.favoritosListBox1 = new System.Windows.Forms.ListBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.removerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemListBox1
            // 
            this.imagemListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemListBox1.FormattingEnabled = true;
            this.imagemListBox1.Location = new System.Drawing.Point(12, 12);
            this.imagemListBox1.Name = "imagemListBox1";
            this.imagemListBox1.Size = new System.Drawing.Size(349, 173);
            this.imagemListBox1.TabIndex = 0;
            this.imagemListBox1.SelectedIndexChanged += new System.EventHandler(this.imagemListBox1_SelectedIndexChanged);
            // 
            // favoritosListBox1
            // 
            this.favoritosListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritosListBox1.FormattingEnabled = true;
            this.favoritosListBox1.Location = new System.Drawing.Point(12, 220);
            this.favoritosListBox1.Name = "favoritosListBox1";
            this.favoritosListBox1.Size = new System.Drawing.Size(349, 160);
            this.favoritosListBox1.TabIndex = 1;
            this.favoritosListBox1.SelectedIndexChanged += new System.EventHandler(this.favoritosListBox1_SelectedIndexChanged);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(12, 191);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(148, 23);
            this.adicionarButton.TabIndex = 2;
            this.adicionarButton.Text = "Adicionar aos favoritos";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 217);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(213, 191);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(148, 23);
            this.removerButton.TabIndex = 4;
            this.removerButton.Text = "Remover dos favoritos";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 627);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.favoritosListBox1);
            this.Controls.Add(this.imagemListBox1);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagemListBox1;
        private System.Windows.Forms.ListBox favoritosListBox1;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button removerButton;
    }
}

