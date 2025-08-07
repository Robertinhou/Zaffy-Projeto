using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaffyStore
{
    public  class Anuncios
    {

        private string titulo;
        private string descricao;
        private DateOnly data;
        private TimeOnly hora;
        private string nome_usuario;

        public void ListarAnuncios(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    DataTable dt = new DataTable();
                    string busca = "SELECT * FROM anuncios";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(busca, conexao);
                    adapter.Fill(dt);

                    dgv.AllowUserToAddRows = false;
                    dgv.DataSource = dt;
                    dgv.ClearSelection();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar os dados.");
            }
        }


    }
}
