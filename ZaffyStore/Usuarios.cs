using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ZaffyStore;

namespace ZaffyStore
{
    public class Usuarios
    {
        private string nome;
        private string email;
        private string senha;
        private int cep;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        
        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);
                    string sqlInsert = "INSERT into usuarios (nome, email, senha) VALUES (@nome, @email, @senha)";

                    MySqlCommand comando = new MySqlCommand(sqlInsert, conexaoBanco);

                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

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
                MessageBox.Show("Erro ao cadastrar usuário ->" + ex.Message);
                return false;
            }

        }

        public bool verificarLogin()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string consultaUsuarios = "SELECT COUNT(*) FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexao);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

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
                MessageBox.Show("Erro ao verificar login no banco -> " + ex.Message);
                return false;
            }
        }

        public string BuscarNome()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string buscarNome = "SELECT nome FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(buscarNome, conexao);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar o nome do usuário!" + ex.Message);
                return "";
            }
        }


        public bool Login()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string senhaCripto = CriptografarSenha(Senha);

                    string buscarNome = "SELECT * FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(buscarNome, conexao);

                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {

                            Sessao sessao  = new Sessao();

                            Usuarios usuario = new Usuarios
                            {

                                Nome = reader["nome"].ToString(),
                                Email = reader["email"].ToString(),
                                Senha = reader["senha"].ToString(),
                                
                            };

                            sessao.listaLogados.Add(usuario);
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

               MessageBox.Show("Não foi possível buscar os dados do usuário!" + ex.Message);
               return false; // ❌ Falha no login
            }
        }



        public bool MudarSenha()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    if (string.IsNullOrEmpty(Senha))
                        throw new ArgumentNullException(nameof(Senha), "Senha não pode ser nula ou vazia ao atualizar.");

                    string senhaCripto = CriptografarSenha(Senha);
                    string sqlUpdate = "UPDATE usuarios SET senha = @senha WHERE email = @email";

                    MySqlCommand comando = new MySqlCommand(sqlUpdate, conexaoBanco);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);
                    comando.Parameters.AddWithValue("@email", Email);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0) return true;

                    MessageBox.Show("Nenhuma linha foi atualizada. Verifique se o email informado existe.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar senha: " + ex.Message);
                return false;
            }
        }


        // FUNCÕES DE SEGURANÇA
        public static string CriptografarSenha(string senha)
        {
            if (string.IsNullOrEmpty(senha))
                throw new ArgumentNullException(nameof(senha), "A senha não pode ser nula ou vazia antes de criptografar.");

            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }


        public static bool ValidarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public static bool ValidarSenha(string senha)
        {
            // Mínimo 8 caracteres, pelo menos uma letra maiúscula, uma minúscula, um número e um caractere especial
            string senhaValida = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            Regex regex = new Regex(senhaValida);
            return regex.IsMatch(senha);
        }


        public bool verificarEmailExistente()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string sqlconsultaEmail = "SELECT COUNT(*) FROM usuarios WHERE email = @email";
                    MySqlCommand comando = new MySqlCommand(sqlconsultaEmail, conexaoBanco);
                    comando.Parameters.AddWithValue("@email", Email);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());
                    return resultado > 0; // ✅ true se email existe
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar email: " + ex.Message);
                return false;
            }
        }


    }
}
