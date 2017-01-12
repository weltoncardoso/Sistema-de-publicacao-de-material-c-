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
    public partial class BuscarUsuario : Form
    {
        public BuscarUsuario()
        {
            InitializeComponent();
        }


        public void mostraResultados()
        {
            string config = "server=localhost; userid=root; password=eltim325; database=db_atps";
            string query = string.Format("Select *from tb_usuario where nome= '"+ txbNome.Text + "'");

            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open();

            MySqlCommand comand = new MySqlCommand(query, conexao);
           MySqlDataAdapter adapter = new MySqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgBuscarNome.DataSource = data;
          
          

        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostraResultados();
        }
    }
}
