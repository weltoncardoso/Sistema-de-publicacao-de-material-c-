using MySql.Data.MySqlClient;
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
    public partial class BuscarMaterial : Form
    {
        public BuscarMaterial()
        {
            InitializeComponent();
        }
        public void mostraMaterial()
        {
            string config = "server=localhost; userid=root; password=eltim325; database=db_atps";
            string query = string.Format("SELECT * FROM tb_material WHERE data BETWEEN  '"+mtbData1.Text+"' AND '" + mtbData2.Text+ "'");

            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open();

            MySqlCommand comand = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comand);

            DataTable data = new DataTable();
            adapter.Fill(data);
            dgBuscarMaterial.DataSource = data;



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            mostraMaterial();
        }

        private void BuscarMaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
