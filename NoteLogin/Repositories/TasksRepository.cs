using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLogin
{
    internal class TasksRepository
    {

        public static void CriarTarefa(Tasks NovaTarefa)
        {
            int userID = NovaTarefa.ID_user;
        //    string titulo = NovaTarefa.Title;
            string texto = NovaTarefa.description;
         //   bool IsImportant = NovaTarefa.IsImportant;
            DateTime CreateAt = DateTime.Now;
            DateTime UpdateAt = DateTime.Now;


            using var conexao = DataBase.ConexaoBanco();
            {
                string InsertQuery = "INSERT INTO tb_tasks(TEXTO, CreateAt, UpdateAt, ID_Users)" +
                    "VALUES (@texto, @CreateAt, @UpdateAt, @userID)";

                using (var comando = new SQLiteCommand(InsertQuery, conexao))
                {
                    comando.Parameters.AddWithValue("@userID", userID);
                    comando.Parameters.AddWithValue("@texto", texto);
               //     comando.Parameters.AddWithValue("@IsImportant", IsImportant);
                    comando.Parameters.AddWithValue("@CreateAt", CreateAt);
                    comando.Parameters.AddWithValue("@UpdateAt", UpdateAt);

                    comando.ExecuteNonQuery();
                }
            }

        }
    }
}
