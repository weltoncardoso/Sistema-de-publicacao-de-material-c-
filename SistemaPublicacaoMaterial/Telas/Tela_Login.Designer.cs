namespace AtpsEtapa2
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lklPrimeiroAcesso = new System.Windows.Forms.LinkLabel();
            this.lblPrimeiroAcesso = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblMenssagenAcesso = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxTipo);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.lklPrimeiroAcesso);
            this.panel1.Controls.Add(this.lblPrimeiroAcesso);
            this.panel1.Controls.Add(this.txbSenha);
            this.panel1.Controls.Add(this.txbLogin);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lbllogin);
            this.panel1.Controls.Add(this.lblMenssagenAcesso);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 260);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuario Comum"});
            this.cbxTipo.Location = new System.Drawing.Point(206, 64);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(169, 21);
            this.cbxTipo.TabIndex = 11;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(211, 45);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(97, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Usuario";
            // 
            // lklPrimeiroAcesso
            // 
            this.lklPrimeiroAcesso.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.lklPrimeiroAcesso.AutoSize = true;
            this.lklPrimeiroAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklPrimeiroAcesso.ForeColor = System.Drawing.Color.Red;
            this.lklPrimeiroAcesso.LinkColor = System.Drawing.Color.Red;
            this.lklPrimeiroAcesso.Location = new System.Drawing.Point(145, 217);
            this.lklPrimeiroAcesso.Name = "lklPrimeiroAcesso";
            this.lklPrimeiroAcesso.Size = new System.Drawing.Size(35, 13);
            this.lklPrimeiroAcesso.TabIndex = 9;
            this.lklPrimeiroAcesso.TabStop = true;
            this.lklPrimeiroAcesso.Text = "aqui!";
            this.lklPrimeiroAcesso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPrimeiroAcesso
            // 
            this.lblPrimeiroAcesso.AutoSize = true;
            this.lblPrimeiroAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimeiroAcesso.ForeColor = System.Drawing.Color.Aqua;
            this.lblPrimeiroAcesso.Location = new System.Drawing.Point(21, 217);
            this.lblPrimeiroAcesso.Name = "lblPrimeiroAcesso";
            this.lblPrimeiroAcesso.Size = new System.Drawing.Size(127, 13);
            this.lblPrimeiroAcesso.TabIndex = 8;
            this.lblPrimeiroAcesso.Text = "Primeiro acesso click";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(206, 152);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(169, 20);
            this.txbSenha.TabIndex = 7;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(206, 104);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(169, 20);
            this.txbLogin.TabIndex = 6;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(208, 136);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(47, 13);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(208, 88);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(42, 13);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "Login";
            // 
            // lblMenssagenAcesso
            // 
            this.lblMenssagenAcesso.AutoSize = true;
            this.lblMenssagenAcesso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenssagenAcesso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMenssagenAcesso.Location = new System.Drawing.Point(213, 23);
            this.lblMenssagenAcesso.Name = "lblMenssagenAcesso";
            this.lblMenssagenAcesso.Size = new System.Drawing.Size(147, 18);
            this.lblMenssagenAcesso.TabIndex = 3;
            this.lblMenssagenAcesso.Text = "Login de acesso";
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Crimson;
            this.btnSair.Location = new System.Drawing.Point(326, 200);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnEntrar.Location = new System.Drawing.Point(262, 200);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(52, 23);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 260);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblMenssagenAcesso;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lklPrimeiroAcesso;
        private System.Windows.Forms.Label lblPrimeiroAcesso;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}