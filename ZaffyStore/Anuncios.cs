using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ZaffyStore
{
    public  class Anuncios
    {

        private int id_anuncio;
        private string nome;
        private string descricao;
        private string categoria;
        private double preco;
        private DateTime dataPost;
        private TimeSpan horario;
        private string localidade;
        private string contato;
        private int id_user;
        private string foto;

        public int Id_Anuncio
        {
            get { return id_anuncio; }
            set { id_anuncio = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public DateTime DataPost
        {
            get { return dataPost; }
            set { dataPost = value; }
        }

        public TimeSpan Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public string Localidade
        {
            get { return localidade; }
            set { localidade = value; }
        }

        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        public int Id_User
        {
            get { return id_user; }
            set { id_user = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }


        public bool CadastrarAnuncio()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    
                    string sqlInsert = "INSERT into anuncios (nome, descricao, categoria, preco, dataPost, horario, localidade, contato, id_user, foto) " +
                                       "VALUES (@nome, @descricao, @categoria, @preco, @dataPost, @horario, @localidade, @contato, @id_user, @foto)";


                    MySqlCommand comando = new MySqlCommand(sqlInsert, conexaoBanco);

                    comando.Parameters.AddWithValue("nome", Nome);
                    comando.Parameters.AddWithValue("descricao", Descricao);
                    comando.Parameters.AddWithValue("categoria", Categoria);
                    comando.Parameters.AddWithValue("preco", Preco);
                    comando.Parameters.AddWithValue("dataPost", DataPost);
                    comando.Parameters.AddWithValue("horario", Horario);
                    comando.Parameters.AddWithValue("localidade", Localidade);
                    comando.Parameters.AddWithValue("contato", Contato);
                    comando.Parameters.AddWithValue("id_user", Id_User);
                    comando.Parameters.AddWithValue("foto", Foto);



                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o anúncio ->" + ex.Message);
                return false;
            }

        }

        public void ListarAnuncios(DataGridView dgv)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    DataTable dt = new DataTable();
                    string busca = "SELECT nome, dataPost FROM anuncios";
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
