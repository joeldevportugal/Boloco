namespace Bloco_Notas
{
    partial class frProcurar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frProcurar));
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.BtnProcurar = new System.Windows.Forms.Button();
            this.grDireção = new System.Windows.Forms.GroupBox();
            this.rdBaixo = new System.Windows.Forms.RadioButton();
            this.RCima = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ChLetras = new System.Windows.Forms.CheckBox();
            this.grDireção.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(9, 11);
            this.txtProcurar.Multiline = true;
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(489, 34);
            this.txtProcurar.TabIndex = 0;
            // 
            // BtnProcurar
            // 
            this.BtnProcurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnProcurar.FlatAppearance.BorderSize = 0;
            this.BtnProcurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnProcurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProcurar.Location = new System.Drawing.Point(504, 11);
            this.BtnProcurar.Name = "BtnProcurar";
            this.BtnProcurar.Size = new System.Drawing.Size(109, 36);
            this.BtnProcurar.TabIndex = 1;
            this.BtnProcurar.Text = "Procurar";
            this.BtnProcurar.UseVisualStyleBackColor = true;
            this.BtnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // grDireção
            // 
            this.grDireção.Controls.Add(this.rdBaixo);
            this.grDireção.Controls.Add(this.RCima);
            this.grDireção.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDireção.Location = new System.Drawing.Point(286, 57);
            this.grDireção.Name = "grDireção";
            this.grDireção.Size = new System.Drawing.Size(199, 101);
            this.grDireção.TabIndex = 2;
            this.grDireção.TabStop = false;
            this.grDireção.Text = "Direção";
            // 
            // rdBaixo
            // 
            this.rdBaixo.AutoSize = true;
            this.rdBaixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBaixo.Location = new System.Drawing.Point(106, 32);
            this.rdBaixo.Name = "rdBaixo";
            this.rdBaixo.Size = new System.Drawing.Size(82, 29);
            this.rdBaixo.TabIndex = 1;
            this.rdBaixo.TabStop = true;
            this.rdBaixo.Text = "Baixo";
            this.rdBaixo.UseVisualStyleBackColor = true;
            // 
            // RCima
            // 
            this.RCima.AutoSize = true;
            this.RCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCima.Location = new System.Drawing.Point(21, 32);
            this.RCima.Name = "RCima";
            this.RCima.Size = new System.Drawing.Size(79, 29);
            this.RCima.TabIndex = 0;
            this.RCima.TabStop = true;
            this.RCima.Text = "Cima";
            this.RCima.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(504, 58);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ChLetras
            // 
            this.ChLetras.AutoSize = true;
            this.ChLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChLetras.Location = new System.Drawing.Point(13, 58);
            this.ChLetras.Name = "ChLetras";
            this.ChLetras.Size = new System.Drawing.Size(248, 29);
            this.ChLetras.TabIndex = 4;
            this.ChLetras.Text = "Maiusculas / Minusculas";
            this.ChLetras.UseVisualStyleBackColor = true;
            // 
            // frProcurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 165);
            this.Controls.Add(this.ChLetras);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grDireção);
            this.Controls.Add(this.BtnProcurar);
            this.Controls.Add(this.txtProcurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frProcurar";
            this.Text = "Procurar";
            this.grDireção.ResumeLayout(false);
            this.grDireção.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button BtnProcurar;
        private System.Windows.Forms.GroupBox grDireção;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton RCima;
        private System.Windows.Forms.CheckBox ChLetras;
        private System.Windows.Forms.RadioButton rdBaixo;
    }
}