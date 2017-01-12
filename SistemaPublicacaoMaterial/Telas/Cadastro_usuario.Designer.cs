namespace AtpsEtapa2
{
    partial class Cadastro_usuario
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
            this.gbAtualizarUsuario = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cbNovoTipo = new System.Windows.Forms.ComboBox();
            this.mtbConfNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mtbNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.txbNovoLogin = new System.Windows.Forms.TextBox();
            this.txbNovoNome = new System.Windows.Forms.TextBox();
            this.txbCodExist = new System.Windows.Forms.TextBox();
            this.lblNovoTipo = new System.Windows.Forms.Label();
            this.lblConfNovaSenha = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblNovoLogin = new System.Windows.Forms.Label();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.lblCodigoExistente = new System.Windows.Forms.Label();
            this.gbInserirNovoUsuario = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.mtbSenha = new System.Windows.Forms.MaskedTextBox();
            this.mtbConfSenha = new System.Windows.Forms.MaskedTextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbExcluirUsuario = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txbCodExcluir = new System.Windows.Forms.TextBox();
            this.lblCodExcluir = new System.Windows.Forms.Label();
            this.btnVolatr = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgVisualizarUsuarios = new System.Windows.Forms.DataGridView();
            this.btnVisualizarUsuarios = new System.Windows.Forms.Button();
            this.gbAtualizarUsuario.SuspendLayout();
            this.gbInserirNovoUsuario.SuspendLayout();
            this.gbExcluirUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAtualizarUsuario
            // 
            this.gbAtualizarUsuario.Controls.Add(this.btnAtualizar);
            this.gbAtualizarUsuario.Controls.Add(this.cbNovoTipo);
            this.gbAtualizarUsuario.Controls.Add(this.mtbConfNovaSenha);
            this.gbAtualizarUsuario.Controls.Add(this.mtbNovaSenha);
            this.gbAtualizarUsuario.Controls.Add(this.txbNovoLogin);
            this.gbAtualizarUsuario.Controls.Add(this.txbNovoNome);
            this.gbAtualizarUsuario.Controls.Add(this.txbCodExist);
            this.gbAtualizarUsuario.Controls.Add(this.lblNovoTipo);
            this.gbAtualizarUsuario.Controls.Add(this.lblConfNovaSenha);
            this.gbAtualizarUsuario.Controls.Add(this.lblNovaSenha);
            this.gbAtualizarUsuario.Controls.Add(this.lblNovoLogin);
            this.gbAtualizarUsuario.Controls.Add(this.lblNovoNome);
            this.gbAtualizarUsuario.Controls.Add(this.lblCodigoExistente);
            this.gbAtualizarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAtualizarUsuario.Location = new System.Drawing.Point(380, 31);
            this.gbAtualizarUsuario.Name = "gbAtualizarUsuario";
            this.gbAtualizarUsuario.Size = new System.Drawing.Size(330, 221);
            this.gbAtualizarUsuario.TabIndex = 0;
            this.gbAtualizarUsuario.TabStop = false;
            this.gbAtualizarUsuario.Text = "Atualizar Usuario";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ForeColor = System.Drawing.Color.Lime;
            this.btnAtualizar.Location = new System.Drawing.Point(255, 198);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // cbNovoTipo
            // 
            this.cbNovoTipo.FormattingEnabled = true;
            this.cbNovoTipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuario Comun"});
            this.cbNovoTipo.Location = new System.Drawing.Point(147, 171);
            this.cbNovoTipo.Name = "cbNovoTipo";
            this.cbNovoTipo.Size = new System.Drawing.Size(177, 21);
            this.cbNovoTipo.TabIndex = 16;
            // 
            // mtbConfNovaSenha
            // 
            this.mtbConfNovaSenha.Location = new System.Drawing.Point(147, 142);
            this.mtbConfNovaSenha.Name = "mtbConfNovaSenha";
            this.mtbConfNovaSenha.PasswordChar = '*';
            this.mtbConfNovaSenha.Size = new System.Drawing.Size(177, 20);
            this.mtbConfNovaSenha.TabIndex = 15;
            // 
            // mtbNovaSenha
            // 
            this.mtbNovaSenha.Location = new System.Drawing.Point(147, 112);
            this.mtbNovaSenha.Name = "mtbNovaSenha";
            this.mtbNovaSenha.PasswordChar = '*';
            this.mtbNovaSenha.Size = new System.Drawing.Size(177, 20);
            this.mtbNovaSenha.TabIndex = 14;
            // 
            // txbNovoLogin
            // 
            this.txbNovoLogin.Location = new System.Drawing.Point(87, 82);
            this.txbNovoLogin.Name = "txbNovoLogin";
            this.txbNovoLogin.Size = new System.Drawing.Size(237, 20);
            this.txbNovoLogin.TabIndex = 10;
            // 
            // txbNovoNome
            // 
            this.txbNovoNome.Location = new System.Drawing.Point(87, 53);
            this.txbNovoNome.Name = "txbNovoNome";
            this.txbNovoNome.Size = new System.Drawing.Size(237, 20);
            this.txbNovoNome.TabIndex = 9;
            // 
            // txbCodExist
            // 
            this.txbCodExist.Location = new System.Drawing.Point(167, 27);
            this.txbCodExist.Name = "txbCodExist";
            this.txbCodExist.Size = new System.Drawing.Size(157, 20);
            this.txbCodExist.TabIndex = 8;
            // 
            // lblNovoTipo
            // 
            this.lblNovoTipo.AutoSize = true;
            this.lblNovoTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNovoTipo.Location = new System.Drawing.Point(19, 174);
            this.lblNovoTipo.Name = "lblNovoTipo";
            this.lblNovoTipo.Size = new System.Drawing.Size(57, 13);
            this.lblNovoTipo.TabIndex = 5;
            this.lblNovoTipo.Text = "Novo Tipo";
            // 
            // lblConfNovaSenha
            // 
            this.lblConfNovaSenha.AutoSize = true;
            this.lblConfNovaSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfNovaSenha.Location = new System.Drawing.Point(19, 145);
            this.lblConfNovaSenha.Name = "lblConfNovaSenha";
            this.lblConfNovaSenha.Size = new System.Drawing.Size(114, 13);
            this.lblConfNovaSenha.TabIndex = 4;
            this.lblConfNovaSenha.Text = "Confirmar Nova Senha";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNovaSenha.Location = new System.Drawing.Point(19, 115);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.lblNovaSenha.TabIndex = 3;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // lblNovoLogin
            // 
            this.lblNovoLogin.AutoSize = true;
            this.lblNovoLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNovoLogin.Location = new System.Drawing.Point(19, 82);
            this.lblNovoLogin.Name = "lblNovoLogin";
            this.lblNovoLogin.Size = new System.Drawing.Size(62, 13);
            this.lblNovoLogin.TabIndex = 2;
            this.lblNovoLogin.Text = "Novo Login";
            // 
            // lblNovoNome
            // 
            this.lblNovoNome.AutoSize = true;
            this.lblNovoNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNovoNome.Location = new System.Drawing.Point(19, 56);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(64, 13);
            this.lblNovoNome.TabIndex = 1;
            this.lblNovoNome.Text = "Novo Nome";
            // 
            // lblCodigoExistente
            // 
            this.lblCodigoExistente.AutoSize = true;
            this.lblCodigoExistente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoExistente.Location = new System.Drawing.Point(19, 30);
            this.lblCodigoExistente.Name = "lblCodigoExistente";
            this.lblCodigoExistente.Size = new System.Drawing.Size(85, 13);
            this.lblCodigoExistente.TabIndex = 0;
            this.lblCodigoExistente.Text = "Codigo existente";
            // 
            // gbInserirNovoUsuario
            // 
            this.gbInserirNovoUsuario.Controls.Add(this.btnIncluir);
            this.gbInserirNovoUsuario.Controls.Add(this.cbTipo);
            this.gbInserirNovoUsuario.Controls.Add(this.lblConfSenha);
            this.gbInserirNovoUsuario.Controls.Add(this.mtbSenha);
            this.gbInserirNovoUsuario.Controls.Add(this.mtbConfSenha);
            this.gbInserirNovoUsuario.Controls.Add(this.txbLogin);
            this.gbInserirNovoUsuario.Controls.Add(this.txbNome);
            this.gbInserirNovoUsuario.Controls.Add(this.lblTipo);
            this.gbInserirNovoUsuario.Controls.Add(this.lblLogin);
            this.gbInserirNovoUsuario.Controls.Add(this.lblSenha);
            this.gbInserirNovoUsuario.Controls.Add(this.lblNome);
            this.gbInserirNovoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbInserirNovoUsuario.Location = new System.Drawing.Point(23, 31);
            this.gbInserirNovoUsuario.Name = "gbInserirNovoUsuario";
            this.gbInserirNovoUsuario.Size = new System.Drawing.Size(317, 221);
            this.gbInserirNovoUsuario.TabIndex = 1;
            this.gbInserirNovoUsuario.TabStop = false;
            this.gbInserirNovoUsuario.Text = "Inserir Novo Usuario";
            this.gbInserirNovoUsuario.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnIncluir
            // 
            this.btnIncluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnIncluir.Location = new System.Drawing.Point(242, 198);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuario Comun"});
            this.cbTipo.Location = new System.Drawing.Point(134, 171);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(177, 21);
            this.cbTipo.TabIndex = 15;
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConfSenha.Location = new System.Drawing.Point(22, 145);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfSenha.TabIndex = 14;
            this.lblConfSenha.Text = "Confirmar Senha";
            // 
            // mtbSenha
            // 
            this.mtbSenha.Location = new System.Drawing.Point(134, 112);
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.PasswordChar = '*';
            this.mtbSenha.Size = new System.Drawing.Size(177, 20);
            this.mtbSenha.TabIndex = 13;
            // 
            // mtbConfSenha
            // 
            this.mtbConfSenha.Location = new System.Drawing.Point(134, 145);
            this.mtbConfSenha.Name = "mtbConfSenha";
            this.mtbConfSenha.PasswordChar = '*';
            this.mtbConfSenha.Size = new System.Drawing.Size(177, 20);
            this.mtbConfSenha.TabIndex = 12;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(75, 79);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(236, 20);
            this.txbLogin.TabIndex = 9;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(75, 53);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(236, 20);
            this.txbNome.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(22, 174);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogin.Location = new System.Drawing.Point(22, 82);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Location = new System.Drawing.Point(22, 115);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(22, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // gbExcluirUsuario
            // 
            this.gbExcluirUsuario.Controls.Add(this.btnExcluir);
            this.gbExcluirUsuario.Controls.Add(this.txbCodExcluir);
            this.gbExcluirUsuario.Controls.Add(this.lblCodExcluir);
            this.gbExcluirUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbExcluirUsuario.Location = new System.Drawing.Point(23, 270);
            this.gbExcluirUsuario.Name = "gbExcluirUsuario";
            this.gbExcluirUsuario.Size = new System.Drawing.Size(317, 100);
            this.gbExcluirUsuario.TabIndex = 1;
            this.gbExcluirUsuario.TabStop = false;
            this.gbExcluirUsuario.Text = "Excluir Usuario";
            this.gbExcluirUsuario.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(242, 77);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txbCodExcluir
            // 
            this.txbCodExcluir.Location = new System.Drawing.Point(106, 31);
            this.txbCodExcluir.Name = "txbCodExcluir";
            this.txbCodExcluir.Size = new System.Drawing.Size(205, 20);
            this.txbCodExcluir.TabIndex = 1;
            // 
            // lblCodExcluir
            // 
            this.lblCodExcluir.AutoSize = true;
            this.lblCodExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodExcluir.Location = new System.Drawing.Point(7, 34);
            this.lblCodExcluir.Name = "lblCodExcluir";
            this.lblCodExcluir.Size = new System.Drawing.Size(82, 13);
            this.lblCodExcluir.TabIndex = 0;
            this.lblCodExcluir.Text = "Codigo a excluir";
            // 
            // btnVolatr
            // 
            this.btnVolatr.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVolatr.Location = new System.Drawing.Point(453, 574);
            this.btnVolatr.Name = "btnVolatr";
            this.btnVolatr.Size = new System.Drawing.Size(75, 23);
            this.btnVolatr.TabIndex = 2;
            this.btnVolatr.Text = "Voltar";
            this.btnVolatr.UseVisualStyleBackColor = true;
            this.btnVolatr.Click += new System.EventHandler(this.btnVolatr_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(565, 574);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgVisualizarUsuarios
            // 
            this.dgVisualizarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisualizarUsuarios.Location = new System.Drawing.Point(33, 401);
            this.dgVisualizarUsuarios.Name = "dgVisualizarUsuarios";
            this.dgVisualizarUsuarios.Size = new System.Drawing.Size(663, 150);
            this.dgVisualizarUsuarios.TabIndex = 4;
            this.dgVisualizarUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVisualizarUsuarios
            // 
            this.btnVisualizarUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVisualizarUsuarios.Location = new System.Drawing.Point(402, 347);
            this.btnVisualizarUsuarios.Name = "btnVisualizarUsuarios";
            this.btnVisualizarUsuarios.Size = new System.Drawing.Size(273, 23);
            this.btnVisualizarUsuarios.TabIndex = 5;
            this.btnVisualizarUsuarios.Text = "Visualizar todos";
            this.btnVisualizarUsuarios.UseVisualStyleBackColor = true;
            this.btnVisualizarUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastro_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 609);
            this.Controls.Add(this.btnVisualizarUsuarios);
            this.Controls.Add(this.dgVisualizarUsuarios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVolatr);
            this.Controls.Add(this.gbExcluirUsuario);
            this.Controls.Add(this.gbInserirNovoUsuario);
            this.Controls.Add(this.gbAtualizarUsuario);
            this.Name = "Cadastro_usuario";
            this.Text = "Cadastro usuario";
            this.Load += new System.EventHandler(this.Cadastro_usuario_Load);
            this.gbAtualizarUsuario.ResumeLayout(false);
            this.gbAtualizarUsuario.PerformLayout();
            this.gbInserirNovoUsuario.ResumeLayout(false);
            this.gbInserirNovoUsuario.PerformLayout();
            this.gbExcluirUsuario.ResumeLayout(false);
            this.gbExcluirUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisualizarUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAtualizarUsuario;
        private System.Windows.Forms.GroupBox gbInserirNovoUsuario;
        private System.Windows.Forms.GroupBox gbExcluirUsuario;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.MaskedTextBox mtbSenha;
        private System.Windows.Forms.MaskedTextBox mtbConfSenha;
        private System.Windows.Forms.ComboBox cbNovoTipo;
        private System.Windows.Forms.MaskedTextBox mtbConfNovaSenha;
        private System.Windows.Forms.MaskedTextBox mtbNovaSenha;
        private System.Windows.Forms.TextBox txbNovoLogin;
        private System.Windows.Forms.TextBox txbNovoNome;
        private System.Windows.Forms.TextBox txbCodExist;
        private System.Windows.Forms.Label lblNovoTipo;
        private System.Windows.Forms.Label lblConfNovaSenha;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblNovoLogin;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.Label lblCodigoExistente;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txbCodExcluir;
        private System.Windows.Forms.Label lblCodExcluir;
        private System.Windows.Forms.Button btnVolatr;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgVisualizarUsuarios;
        private System.Windows.Forms.Button btnVisualizarUsuarios;
    }
}