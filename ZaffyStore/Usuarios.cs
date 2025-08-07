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



        private string cep;
        private string celular;
        private string cpf;
        private DateOnly data_nascimento;
        private string rua;
        private string cidade;
        private string bairro;
        private string estado;
        private string caminho_Foto;

        

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



      

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }



        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateOnly Data_Nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Caminho_Foto
        {
            get { return caminho_Foto; }
            set { caminho_Foto = value; }
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


        public bool CadastroInformacoes(string caminho)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string sqlInsert = "UPDATE usuarios SET celular = @celular, cpf = @cpf, data_nascimento = @data_nascimento, cep = @cep, rua = @rua, cidade = @cidade, bairro = @bairro, estado = @estado, caminho_Foto = @caminho_Foto WHERE email = @Email";

                    MySqlCommand comando = new MySqlCommand(sqlInsert, conexaoBanco);

                    comando.Parameters.AddWithValue("@celular", Celular);
                    comando.Parameters.AddWithValue("@cpf", Cpf);
                    comando.Parameters.AddWithValue("@data_nascimento", Data_Nascimento.ToString("yyyy-MM-dd"));
                    comando.Parameters.AddWithValue("@cep", Cep);
                    comando.Parameters.AddWithValue("@rua", Rua);
                    comando.Parameters.AddWithValue("@cidade", Cidade);
                    comando.Parameters.AddWithValue("@bairro", Bairro);
                    comando.Parameters.AddWithValue("@estado", Estado);
                    comando.Parameters.AddWithValue("@caminho_Foto", caminho);
                    comando.Parameters.AddWithValue("@Email", Email); // Muito importante!

                    int resultado = comando.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método: " + ex.Message);
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


                                
                           

                            Sessao.UsuarioAtual = usuario;
                           
 

                                
                            

                            Sessao.UsuarioAtual = usuario;
                           

                            Sessao.listaLogados.Add(usuario);
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


        public static string CriptografarSenha(string senha)
        {
            
                
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



        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }


    }
}
