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
    public partial class Tela_Primeiro_Acesso : System.Windows.Forms.Form
    {
        public Tela_Primeiro_Acesso()
        {
            InitializeComponent();
        }

        private void Tela_Primeiro_Acesso_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEstado.Items.Add("AC");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tela_Login login = new Tela_Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string sobrenome = txbSobreNome.Text;
            string login = txbLogin.Text;
            string senha = mtbSenha.Text;
            string confsenha = mtbCSenha.Text;
            string tipo = cbxTipoUsuario.Text;
            string endereco = txbEndereco.Text;
            string cidade = txbCidade.Text;
            string cep = mtbCep.Text;
            string estado = cbxEstado.Text;
            string telRes = mtbTelRes.Text;
            string telCel1 = mtbTelCelA.Text;
            string telCel2 = mtbCelB.Text;

            if (nome == "" || sobrenome == "" || login == "" || senha == "" || confsenha == "" || tipo == "" || endereco == "" || cidade == "" || cep == "" || estado == "" || telRes == "" || telCel1 == "")
            {
                MessageBox.Show("Nao pode haver campos em branco!", "ERRO");
                return;
            }
            if (senha != confsenha)
            {
                MessageBox.Show("As senhas nao sao iguais!", "ERRO");
                return;
            }
            string configuracao = "server=localhost; userid=root; password=eltim325; database=db_Atps";
            MySqlConnection conexao = new MySqlConnection(configuracao);
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO tb_novos_usuarios(nome,sobrenome,login,senha,tipo,endereco,cidade,cep,estado,tel_res,tel_cel1,tel_cel2) " + " values('" + nome + "','" + sobrenome + "','" + login + "','" + senha + "','" + tipo + "','" + endereco + "','" + cidade + "','" + cep + "','" + estado + "','" + telRes + "','" + telCel1 + "','" + telCel2 + "')", conexao);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados enseridos com sucesso!");
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel se conectar ao banco de dados!", "ERRO");
            }
        }
    }
    }

