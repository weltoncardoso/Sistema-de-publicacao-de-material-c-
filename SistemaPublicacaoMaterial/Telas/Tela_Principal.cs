using System;
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
    public partial class Tela_Principal : System.Windows.Forms.Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_usuario cadastro_usuario = new Cadastro_usuario();
            cadastro_usuario.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void cadastroDeDptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_departamento cadastro_departamento = new Cadastro_departamento();
            cadastro_departamento.ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_material tela_material = new Tela_material();
            tela_material.ShowDialog();  
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUsuario buscaUsuario = new BuscarUsuario();
            buscaUsuario.ShowDialog();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMaterial buscarMaterial = new BuscarMaterial();
            buscarMaterial.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre Sobre = new sobre();
            Sobre.ShowDialog();
        }
    }
}
