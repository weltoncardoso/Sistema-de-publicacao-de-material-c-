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
    public partial class Cadastro_departamento : System.Windows.Forms.Form
    {
        public Cadastro_departamento()
        {
            InitializeComponent();
        }

        private void gbxNovoUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Principal tela_principal = new Tela_Principal();
            tela_principal.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string descricao = txbDescricao.Text;
   

            if ( descricao == "" )
            {
                MessageBox.Show("Nao pode estra em branco!", "ERRO");
                return;
            }
         
            string configuracao = "server=localhost; userid=root; password=eltim325; database=db_Atps";
            MySqlConnection conexao = new MySqlConnection(configuracao);
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_departamentos(descricao) " + " value('" + descricao + "')", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Departamento enseridos com sucesso!");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel se conectar ao banco de dados!", "ERRO");
            }
        }
    }
}
