namespace Bloco_Notas
{
    partial class Capa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capa));
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.Avanco = new System.Windows.Forms.ProgressBar();
            this.LblAutor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagem.Image = ((System.Drawing.Image)(resources.GetObject("picImagem.Image")));
            this.picImagem.Location = new System.Drawing.Point(0, 0);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(971, 674);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagem.TabIndex = 1;
            this.picImagem.TabStop = false;
            // 
            // Avanco
            // 
            this.Avanco.Location = new System.Drawing.Point(11, 651);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(947, 12);
            this.Avanco.TabIndex = 2;
            // 
            // LblAutor
            // 
            this.LblAutor.BackColor = System.Drawing.Color.White;
            this.LblAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.Image = ((System.Drawing.Image)(resources.GetObject("LblAutor.Image")));
            this.LblAutor.Location = new System.Drawing.Point(306, 239);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(299, 72);
            this.LblAutor.TabIndex = 3;
            this.LblAutor.Text = "DevJoel2025©";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Image = ((System.Drawing.Image)(resources.GetObject("LblTitulo.Image")));
            this.LblTitulo.Location = new System.Drawing.Point(304, 100);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(295, 107);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Bloco De Notas ";
            // 
            // Capa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 674);
            this.ControlBox = false;
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.Avanco);
            this.Controls.Add(this.picImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Capa";
            this.Text = "Capa";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.ProgressBar Avanco;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTitulo;
    }
}

