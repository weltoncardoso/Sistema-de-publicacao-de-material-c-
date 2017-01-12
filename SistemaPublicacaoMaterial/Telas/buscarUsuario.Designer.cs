namespace AtpsEtapa2
{
    partial class BuscarUsuario
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
            this.dgBuscarNome = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarNome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBuscarNome
            // 
            this.dgBuscarNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarNome.Location = new System.Drawing.Point(27, 99);
            this.dgBuscarNome.Name = "dgBuscarNome";
            this.dgBuscarNome.Size = new System.Drawing.Size(596, 150);
            this.dgBuscarNome.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Location = new System.Drawing.Point(491, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(78, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(379, 20);
            this.txbNome.TabIndex = 3;
            // 
            // BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 261);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgBuscarNome);
            this.Name = "BuscarUsuario";
            this.Text = "Buscar Usuario";
            this.Load += new System.EventHandler(this.BuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarNome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBuscarNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
    }
}