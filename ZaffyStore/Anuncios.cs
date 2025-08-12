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
    public class Anuncios
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

        public bool AtualizarAnuncio()
        {
            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string sql = @"UPDATE anuncios SET 
                        nome = @nome,
                        descricao = @descricao,
                        categoria = @categoria,
                        preco = @preco,
                        localidade = @localidade,
                        contato = @contato,
                        foto = @foto,
                        horario = @horario
                       WHERE id_anuncio = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@nome", this.Nome);
                comando.Parameters.AddWithValue("@descricao", this.Descricao);
                comando.Parameters.AddWithValue("@categoria", this.Categoria);
                comando.Parameters.AddWithValue("@preco", this.Preco);
                comando.Parameters.AddWithValue("@localidade", this.Localidade);
                comando.Parameters.AddWithValue("@contato", this.Contato);
                comando.Parameters.AddWithValue("@foto", this.Foto ?? "");
                comando.Parameters.AddWithValue("@horario", this.Horario);
                comando.Parameters.AddWithValue("@id", this.Id_Anuncio);

                return comando.ExecuteNonQuery() > 0;
            }
        }

        public bool DeletarAnuncio()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string sql = "DELETE FROM anuncios WHERE id_anuncio = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", Id_Anuncio);

                    int result = cmd.ExecuteNonQuery();

                    return result > 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro fatal! Verifique sua conexão!");
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
                    string busca = "SELECT nome, descricao, preco, categoria, dataPost FROM anuncios";
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


        public void ListarMeusAnuncios(DataGridView dgv)
        {
            try
            {


                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "SELECT id_anuncio, nome, descricao, categoria, preco, dataPost, horario, localidade, contato, foto FROM anuncios WHERE id_user = @id";

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@id", Convert.ToInt32(Sessao.UsuarioAtual.Id));

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(comando))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgv.DataSource = dt;
                            dgv.AllowUserToAddRows = false;
                            dgv.ClearSelection();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
        }

        public bool BuscarInformaçõesAnuncio()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {


                    string buscarNome = "SELECT * FROM anuncios WHERE nome = @nome and id = @id";
                    MySqlCommand comando = new MySqlCommand(buscarNome, conexao);

                    comando.Parameters.AddWithValue("@nome", nome);
                    //comando.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {


                        if (reader.Read())
                        {
                            Anuncios anuncio = new Anuncios
                            {
                                Nome = reader["nome"].ToString(),
                                Descricao = reader["descricao"].ToString(),
                            };

                            return true; // ✅ Login bem-sucedido

                        }
                        else
                        {
                            return false; // ❌ Login falhou, email ou senha incorretos
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                return false; // ❌ Login falhou, email ou senha incorretos;                
            }

        }


    }
}
