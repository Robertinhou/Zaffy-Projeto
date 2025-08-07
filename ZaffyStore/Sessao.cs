
﻿using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ZaffyStore
{
    public class Sessao
    {
        public static List<Usuarios> listaLogados = new List<Usuarios>();

        public static Usuarios UsuarioAtual { get; set; }

        

        public static bool RemoverUsuarioLogado(Usuarios user)
        {


            try
            {

                // Usa a senha do objeto passado como parâmetro


                int IndexUser = listaLogados.IndexOf(Sessao.UsuarioAtual);

                if (IndexUser != null)
                {
                    MessageBox.Show($"Usuário {UsuarioAtual.Nome} removido com sucesso!", "Usuário removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaLogados.Remove(UsuarioAtual);
                    UsuarioAtual = null; // Limpa a sessão do usuário atual

                    return true;
                }
                else
                {
                    MessageBox.Show($"Usuário {UsuarioAtual.Nome} não encontrado na lista de logados!", "Usuário não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                    

                    
                            
                        
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar os dados do usuário! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool BuscarLogado(Usuarios userLogged)
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    // Usa a senha do objeto passado como parâmetro
                    string senhaCripto = Usuarios.CriptografarSenha(userLogged.Senha);

                    string buscarNome = "SELECT * FROM usuarios WHERE email = @email and senha = @senha";
                    MySqlCommand comando = new MySqlCommand(buscarNome, conexao);

                    comando.Parameters.AddWithValue("@email", userLogged.Email);
                    comando.Parameters.AddWithValue("@senha", senhaCripto);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuarios usuario = new Usuarios
                            {
                                Nome = reader["nome"].ToString(),
                                Email = reader["email"].ToString(),
                                Senha = reader["senha"].ToString(),
                            };

                            // Atualiza o objeto passado com os dados encontrados
                            userLogged.Nome = usuario.Nome;
                            userLogged.Email = usuario.Email;
                            userLogged.Senha = usuario.Senha;

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível buscar os dados desse usuário!", "Erro de busca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar os dados do usuário! " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

}
