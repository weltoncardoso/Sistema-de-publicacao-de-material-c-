namespace AtpsEtapa2
{
    partial class Tela_material
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbDescicao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgMaterial = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblCod_depto = new System.Windows.Forms.Label();
            this.lbl_cod_usuario = new System.Windows.Forms.Label();
            this.txtCodDpto = new System.Windows.Forms.TextBox();
            this.txbCodUsuario = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(35, 368);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 329);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(12, 345);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(437, 20);
            this.txbTitulo.TabIndex = 2;
            // 
            // txbDescicao
            // 
            this.txbDescicao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txbDescicao.Location = new System.Drawing.Point(12, 384);
            this.txbDescicao.Multiline = true;
            this.txbDescicao.Name = "txbDescicao";
            this.txbDescicao.Size = new System.Drawing.Size(926, 161);
            this.txbDescicao.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSalvar.Location = new System.Drawing.Point(668, 562);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 32);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Green;
            this.btnVoltar.Location = new System.Drawing.Point(762, 562);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(79, 32);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(857, 562);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(79, 32);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgMaterial
            // 
            this.dgMaterial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaterial.Location = new System.Drawing.Point(12, 12);
            this.dgMaterial.Name = "dgMaterial";
            this.dgMaterial.Size = new System.Drawing.Size(926, 229);
            this.dgMaterial.TabIndex = 7;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(379, 254);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblCod_depto
            // 
            this.lblCod_depto.AutoSize = true;
            this.lblCod_depto.Location = new System.Drawing.Point(665, 348);
            this.lblCod_depto.Name = "lblCod_depto";
            this.lblCod_depto.Size = new System.Drawing.Size(64, 13);
            this.lblCod_depto.TabIndex = 9;
            this.lblCod_depto.Text = "cod.depto";
            this.lblCod_depto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_cod_usuario
            // 
            this.lbl_cod_usuario.AutoSize = true;
            this.lbl_cod_usuario.Location = new System.Drawing.Point(809, 348);
            this.lbl_cod_usuario.Name = "lbl_cod_usuario";
            this.lbl_cod_usuario.Size = new System.Drawing.Size(73, 13);
            this.lbl_cod_usuario.TabIndex = 10;
            this.lbl_cod_usuario.Text = "cod.usuario";
            // 
            // txtCodDpto
            // 
            this.txtCodDpto.Location = new System.Drawing.Point(735, 345);
            this.txtCodDpto.Name = "txtCodDpto";
            this.txtCodDpto.Size = new System.Drawing.Size(48, 20);
            this.txtCodDpto.TabIndex = 11;
            // 
            // txbCodUsuario
            // 
            this.txbCodUsuario.Location = new System.Drawing.Point(883, 345);
            this.txbCodUsuario.Name = "txbCodUsuario";
            this.txbCodUsuario.Size = new System.Drawing.Size(55, 20);
            this.txbCodUsuario.TabIndex = 12;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(484, 348);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Data";
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(524, 344);
            this.mtbData.Mask = "0000/00/00";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(125, 20);
            this.mtbData.TabIndex = 14;
            this.mtbData.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbData_MaskInputRejected);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Tela_material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtpsEtapa2.Properties.Resources.Departamento_Pessoal_619x331;
            this.ClientSize = new System.Drawing.Size(950, 606);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbCodUsuario);
            this.Controls.Add(this.txtCodDpto);
            this.Controls.Add(this.lbl_cod_usuario);
            this.Controls.Add(this.lblCod_depto);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgMaterial);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbDescicao);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Tela_material";
            this.Text = "Material";
            this.Load += new System.EventHandler(this.Tela_material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbDescicao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgMaterial;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblCod_depto;
        private System.Windows.Forms.Label lbl_cod_usuario;
        private System.Windows.Forms.TextBox txtCodDpto;
        private System.Windows.Forms.TextBox txbCodUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}