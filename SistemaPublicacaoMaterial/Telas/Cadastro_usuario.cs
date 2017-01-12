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
    public partial class Cadastro_usuario : Form
    {
        public Cadastro_usuario()
        {
            InitializeComponent();
        }

        public void mostraResultados()
        {
            string config = "server=localhost; userid=root; password=eltim325; database=db_atps";
            string query = string.Format("Select *from tb_usuario ");

            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open();

            MySqlCommand comand = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgVisualizarUsuarios.DataSource = data;



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolatr_Click(object sender, EventArgs e)
        {
            Tela_Principal tela_principal = new Tela_Principal();
            tela_principal.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
           
            string nome = txbNome.Text;
            string login = txbLogin.Text;
            string senha = mtbSenha.Text;
            string csenha = mtbConfSenha.Text;
            int tipo = cbTipo.SelectedIndex;

            if ( nome == "" || login == "" || senha == "" || csenha == "" || tipo <0 )
            {
                MessageBox.Show("Nao pode haver campos em branco!", "ERRO");
                return;
            }
            if (senha != csenha)
            {
                MessageBox.Show("As senhas nao sao iguais!", "ERRO");
                return;
            }
            string configuracao = "server=localhost; userid=root; password=eltim325; database=db_Atps";
            MySqlConnection conexao = new MySqlConnection(configuracao);
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_usuario(nome,login,senha, tipo) " + " values('" + nome + "','" + login + "','" + senha + "','" + tipo + "')", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados enseridos com sucesso!");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel se conectar ao banco de dados!", "ERRO");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string codigo = txbCodExist.Text;
            string nome = txbNovoNome.Text;
            string login = txbNovoLogin.Text;
            string senha = mtbNovaSenha.Text;
            string csenha = mtbConfNovaSenha.Text;
            int tipo = cbNovoTipo.SelectedIndex;

            if (codigo == "" || nome == "" || login == "" || senha == "" || csenha == "" || tipo <0)
            {
                MessageBox.Show("Nao pode haver campos em branco!", "ERRO");
                return;
            }
            if (senha != csenha)
            {
                MessageBox.Show("As senhas nao sao iguais!", "ERRO");
                return;
            }
   
            MySqlConnection conexao = new MySqlConnection("server=localhost; userid=root; password=eltim325; database=db_Atps");
            MySqlCommand sql = new MySqlCommand("UPDATE tb_usuario SET nome='" + nome + "',login= '"
                    + login + "',senha= '" + senha + "',tipo='" + tipo + "'WHERE codigo='" + codigo + "'", conexao);
            try
            {
                conexao.Open();
                sql.ExecuteNonQuery();
                MessageBox.Show("Usuario Atualizado com sucesso!");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel se conectar ao banco de dados!", "ERRO");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string codigo = txbCodExcluir.Text;
            //DELETE FROM-bt_excluiTecnico
            MySqlConnection apaga = new MySqlConnection("server=localhost; userid=root; password=eltim325; database=db_Atps");

            try
            {
                apaga.Open();
                string mSQL = "DELETE FROM tb_usuario WHERE codigo = @codigo";
                MySqlCommand comand_apaga = new MySqlCommand(mSQL, apaga);
                comand_apaga.Parameters.Add(new MySqlParameter("@codigo", codigo));

                //Aqui vc exclui o registro
                comand_apaga.ExecuteNonQuery();
                MessageBox.Show("usuario excluido com sucesso!");
                apaga.Close();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel se conectar ao banco de dados!", "ERRO");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cadastro_usuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostraResultados();
        }
    }
    }
    
    

 