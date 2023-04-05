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

namespace AppContatoForm
{
    public partial class FormCarregarDados : Form
    {
        private MySqlConnection conexao;
        
        private MySqlCommand comando;

        public FormCarregarDados()
        {
            InitializeComponent();
            Conexao();
            carregarDados();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3306";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }



        private void carregarDados()
        {
            MySqlCommand cmd = new MySqlCommand ("Select * from contato_con", conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            dgvContato.DataSource = tabela;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carregarDados();
        }
    }
}
