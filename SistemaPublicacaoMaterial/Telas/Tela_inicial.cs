﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtpsEtapa2
{
    public partial class Tela_inicial : System.Windows.Forms.Form
    {
        public Tela_inicial()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value+2;
            }
            else
            {
                timer1.Enabled = false;
                Tela_Login tela_login = new Tela_Login();
                tela_login.Show();
                this.Visible = false;
            }
        }

        private void pbxInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
