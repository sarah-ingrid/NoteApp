using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLogin
{
    internal class UserRepository
    {
        public static bool CadastrarUsuario(string nome, string username, string email, string senha, string genero)
        {
            try
            {

                using var conexao = DataBase.ConexaoBanco();
                {
                    string InsertQuerry = "INSERT INTO tb_users(T_NOME, T_username, T_EMAIL, T_SENHA, T_genero) " +
                            "VALUES (@nome, @username, @email, @senha, @genero)";

                    using (var comando = new SQLiteCommand(InsertQuerry, conexao))
                    {
                        if (UsuarioJaExiste(username)) 
                        {
                            MessageBox.Show("LOGIN JÁ EXISTENTE\n\nPor favor escolha outro", "INVÁLIDO", MessageBoxButtons.OK);
                        }
                        else
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@username", username);
                        comando.Parameters.AddWithValue("@email", email);
                        comando.Parameters.AddWithValue("@senha", senha);
                        comando.Parameters.AddWithValue("@genero", genero);

                        comando.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }


        public static bool VerificarLogin(string username, string senha)
        {
            using (var conexao = DataBase.ConexaoBanco())
            {
                string query = "SELECT COUNT(*) FROM tb_users WHERE T_username = @username AND T_SENHA = @senha";

                using (var comando = new SQLiteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@username", username);
                    comando.Parameters.AddWithValue("@senha", senha);

                    long resultado = (long)comando.ExecuteScalar();

                    return resultado > 0;
                }
            }
        }


        public static bool UsuarioJaExiste(string username)
        {
            using (var conexao = DataBase.ConexaoBanco())
            {
                string query = "SELECT COUNT(*) FROM tb_users WHERE T_username = @username";
                using (var comando = new SQLiteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@username", username);
                    long resultado = (long)comando.ExecuteScalar();
                    return resultado > 0;
                }
            }


        }
    }
}
