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
    public partial class Tela_material : System.Windows.Forms.Form
    {
        public Tela_material()
        {
            InitializeComponent();
        }
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDataSet;

        public void mostraResultados()
        {
            string config = "server=localhost; userid=root; password=eltim325; database=db_atps";
            string query = string.Format("Select * from {0}", " tb_material");

            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open();

            MySqlCommand comand = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgMaterial.DataSource = data;

        }

        private void lblConteudo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarMaterial_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltarMaterial_Click(object sender, EventArgs e)
        {
            Tela_Principal tela_principal = new Tela_Principal();
            tela_principal.Show();
        }

        private void mtbDataMaterial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRegistrarMaterial_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbxMaterial_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            mConn = new MySqlConnection("server=localhost; userid=root; password=eltim325; database=db_Atps");

            // Abre a conexão
            mConn.Open();

            //Query SQL
            MySqlCommand command = new MySqlCommand("INSERT INTO tb_material (data, titulo, descricao, tb_usuario_codigo, tb_departamento_codigo)" +
            "VALUES('" + mtbData.Text + "','" + txbTitulo.Text + "','" + txbDescicao.Text + "','" + txbCodUsuario.Text + "','" + txtCodDpto.Text + "')", mConn);

            //Executa a Query SQL
            command.ExecuteNonQuery();

            // Fecha a conexão
            mConn.Close();

            //Mensagem de Sucesso
            MessageBox.Show("Gravado com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Método criado para que quando o registo é gravado, automaticamente a dataGridView efectue um "Refresh"
            mostraResultados();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            mostraResultados();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtbData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Tela_material_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Principal telaPrincipal = new Tela_Principal();
            telaPrincipal.ShowDialog();
        }
    }
}
