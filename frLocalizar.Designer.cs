namespace Bloco_Notas
{
    partial class frLocalizar
    {
        private System.ComponentModel.IContainer components = null;

        // Definindo os controles do formulário
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.TextBox txtSubestituir;
        private System.Windows.Forms.Button BtnLocalizar;
        private System.Windows.Forms.Button BtnSubstituir;
        private System.Windows.Forms.Button BtnSubstituir_tudo;
        private System.Windows.Forms.CheckBox Chletras;
        private System.Windows.Forms.Button BtnCancelar;

        // Método para limpar e liberar recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método que é chamado para inicializar os componentes (controle do layout)
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLocalizar));
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.txtSubestituir = new System.Windows.Forms.TextBox();
            this.BtnLocalizar = new System.Windows.Forms.Button();
            this.BtnSubstituir = new System.Windows.Forms.Button();
            this.BtnSubstituir_tudo = new System.Windows.Forms.Button();
            this.Chletras = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizar.Location = new System.Drawing.Point(12, 12);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(453, 34);
            this.txtLocalizar.TabIndex = 0;
            // 
            // txtSubestituir
            // 
            this.txtSubestituir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubestituir.Location = new System.Drawing.Point(12, 52);
            this.txtSubestituir.Name = "txtSubestituir";
            this.txtSubestituir.Size = new System.Drawing.Size(453, 34);
            this.txtSubestituir.TabIndex = 1;
            // 
            // BtnLocalizar
            // 
            this.BtnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLocalizar.Location = new System.Drawing.Point(471, 12);
            this.BtnLocalizar.Name = "BtnLocalizar";
            this.BtnLocalizar.Size = new System.Drawing.Size(119, 34);
            this.BtnLocalizar.TabIndex = 2;
            this.BtnLocalizar.Text = "Localizar";
            this.BtnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);
            // 
            // BtnSubstituir
            // 
            this.BtnSubstituir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSubstituir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSubstituir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSubstituir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubstituir.Location = new System.Drawing.Point(471, 52);
            this.BtnSubstituir.Name = "BtnSubstituir";
            this.BtnSubstituir.Size = new System.Drawing.Size(119, 34);
            this.BtnSubstituir.TabIndex = 3;
            this.BtnSubstituir.Text = "Substituir";
            this.BtnSubstituir.Click += new System.EventHandler(this.btnSubstituir_Click);
            // 
            // BtnSubstituir_tudo
            // 
            this.BtnSubstituir_tudo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSubstituir_tudo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnSubstituir_tudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnSubstituir_tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubstituir_tudo.Location = new System.Drawing.Point(471, 92);
            this.BtnSubstituir_tudo.Name = "BtnSubstituir_tudo";
            this.BtnSubstituir_tudo.Size = new System.Drawing.Size(119, 34);
            this.BtnSubstituir_tudo.TabIndex = 4;
            this.BtnSubstituir_tudo.Text = "Substituir Tudo";
            this.BtnSubstituir_tudo.Click += new System.EventHandler(this.BtnSubstituir_tudo_Click);
            // 
            // Chletras
            // 
            this.Chletras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chletras.Location = new System.Drawing.Point(12, 113);
            this.Chletras.Name = "Chletras";
            this.Chletras.Size = new System.Drawing.Size(431, 40);
            this.Chletras.TabIndex = 5;
            this.Chletras.Text = "Considerar letras Maiusculas / Minisculas";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Location = new System.Drawing.Point(471, 132);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(119, 41);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frLocalizar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 178);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.txtSubestituir);
            this.Controls.Add(this.BtnLocalizar);
            this.Controls.Add(this.BtnSubstituir);
            this.Controls.Add(this.BtnSubstituir_tudo);
            this.Controls.Add(this.Chletras);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frLocalizar";
            this.Text = "Localizar e Substituir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
