namespace AtpsEtapa2
{
    partial class BuscarMaterial
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
            this.lblData1 = new System.Windows.Forms.Label();
            this.btnBuscarMaterial = new System.Windows.Forms.Button();
            this.dgBuscarMaterial = new System.Windows.Forms.DataGridView();
            this.mtbData2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbData1 = new System.Windows.Forms.MaskedTextBox();
            this.lblData2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData1.Location = new System.Drawing.Point(44, 52);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(45, 13);
            this.lblData1.TabIndex = 6;
            this.lblData1.Text = "Data1:";
            // 
            // btnBuscarMaterial
            // 
            this.btnBuscarMaterial.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscarMaterial.Location = new System.Drawing.Point(494, 47);
            this.btnBuscarMaterial.Name = "btnBuscarMaterial";
            this.btnBuscarMaterial.Size = new System.Drawing.Size(123, 23);
            this.btnBuscarMaterial.TabIndex = 5;
            this.btnBuscarMaterial.Text = "Buscar";
            this.btnBuscarMaterial.UseVisualStyleBackColor = true;
            this.btnBuscarMaterial.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgBuscarMaterial
            // 
            this.dgBuscarMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarMaterial.Location = new System.Drawing.Point(38, 106);
            this.dgBuscarMaterial.Name = "dgBuscarMaterial";
            this.dgBuscarMaterial.Size = new System.Drawing.Size(596, 150);
            this.dgBuscarMaterial.TabIndex = 4;
            // 
            // mtbData2
            // 
            this.mtbData2.Location = new System.Drawing.Point(327, 52);
            this.mtbData2.Mask = "0000/00/00";
            this.mtbData2.Name = "mtbData2";
            this.mtbData2.Size = new System.Drawing.Size(100, 20);
            this.mtbData2.TabIndex = 7;
            // 
            // mtbData1
            // 
            this.mtbData1.Location = new System.Drawing.Point(95, 52);
            this.mtbData1.Mask = "0000/00/00";
            this.mtbData1.Name = "mtbData1";
            this.mtbData1.Size = new System.Drawing.Size(100, 20);
            this.mtbData1.TabIndex = 8;
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData2.Location = new System.Drawing.Point(272, 59);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(45, 13);
            this.lblData2.TabIndex = 9;
            this.lblData2.Text = "Data2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entre com as datas para a pesquisa!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "aaaa/mm/dd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "aaaa/mm/dd";
            // 
            // BuscarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData2);
            this.Controls.Add(this.mtbData1);
            this.Controls.Add(this.mtbData2);
            this.Controls.Add(this.lblData1);
            this.Controls.Add(this.btnBuscarMaterial);
            this.Controls.Add(this.dgBuscarMaterial);
            this.Name = "BuscarMaterial";
            this.Text = "Buscar Material";
            this.Load += new System.EventHandler(this.BuscarMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Button btnBuscarMaterial;
        private System.Windows.Forms.DataGridView dgBuscarMaterial;
        private System.Windows.Forms.MaskedTextBox mtbData2;
        private System.Windows.Forms.MaskedTextBox mtbData1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}