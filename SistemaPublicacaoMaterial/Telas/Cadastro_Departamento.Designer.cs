namespace AtpsEtapa2
{
    partial class Cadastro_departamento
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
            this.gbxNovoDeparatmento = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbxNovoDeparatmento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxNovoDeparatmento
            // 
            this.gbxNovoDeparatmento.BackgroundImage = global::AtpsEtapa2.Properties.Resources.Folder_icon;
            this.gbxNovoDeparatmento.Controls.Add(this.btnVoltar);
            this.gbxNovoDeparatmento.Controls.Add(this.txbDescricao);
            this.gbxNovoDeparatmento.Controls.Add(this.lblDescricao);
            this.gbxNovoDeparatmento.Controls.Add(this.btnCancelar);
            this.gbxNovoDeparatmento.Controls.Add(this.btnRegistrar);
            this.gbxNovoDeparatmento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNovoDeparatmento.Location = new System.Drawing.Point(2, 12);
            this.gbxNovoDeparatmento.Name = "gbxNovoDeparatmento";
            this.gbxNovoDeparatmento.Size = new System.Drawing.Size(379, 270);
            this.gbxNovoDeparatmento.TabIndex = 1;
            this.gbxNovoDeparatmento.TabStop = false;
            this.gbxNovoDeparatmento.Text = "Novo departamento";
            this.gbxNovoDeparatmento.Enter += new System.EventHandler(this.gbxNovoUsuario_Enter);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(225, 222);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(69, 23);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(10, 67);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(357, 130);
            this.txbDescricao.TabIndex = 12;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(149, 37);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(70, 16);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descricao";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(155, 222);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(64, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Cadastro_departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 279);
            this.Controls.Add(this.gbxNovoDeparatmento);
            this.Name = "Cadastro_departamento";
            this.Text = "Cadastro_Departamento";
            this.gbxNovoDeparatmento.ResumeLayout(false);
            this.gbxNovoDeparatmento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNovoDeparatmento;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}