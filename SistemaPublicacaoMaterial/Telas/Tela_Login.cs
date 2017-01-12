using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AtpsEtapa2
{
    public partial class Tela_Login : System.Windows.Forms.Form
    {
        public Tela_Login()
        {
            InitializeComponent();
        }
        private MySqlConnection conexao;
        private DataSet conexaoDataSet;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)

        {

            conexaoDataSet = new DataSet();
            conexao = new MySqlConnection("server=localhost; userid=root; password=eltim325; database=db_Atps");
            try
            {
                conexao.Open();
                
                MySqlCommand verifica = new MySqlCommand("SELECT * FROM tb_usuario WHERE login = '" + txbLogin.Text + "' AND senha = '" + txbSenha.Text +"' AND tipo = '" + 
                    cbxTipo.SelectedIndex + "'", conexao);
                bool resultado = verifica.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    Tela_Principal tela_principal = new Tela_Principal();
                    tela_principal.ShowDialog();
                   Hide();
                }
                else
                {
                    MessageBox.Show("usuario ou senha invalidos!");
                    conexao.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERRO NA CONEXAO COM O BANCO DE DADOS!");
                conexao.Close();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_Primeiro_Acesso primeiroAcesso = new Tela_Primeiro_Acesso();
            primeiroAcesso.ShowDialog();
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
