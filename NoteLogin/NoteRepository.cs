using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteLogin
{


    internal class NoteRepository
    {


        public static void CriarNota(Note NovaNota)
        {
            int userID = NovaNota.ID_user;
            string titulo = NovaNota.Title;
            string texto = NovaNota.Text;
            bool IsImportant = NovaNota.IsImportant;
            DateTime CreateAt = DateTime.Now;
            DateTime UpdateAt = DateTime.Now;


            using var conexao = DataBase.ConexaoBanco();
            {
                string InsertQuery = "INSERT INTO tb_notes(TITULO, TEXTO, IsImportant, CreateAt, UpdateAt, ID_Users)" +
                    "VALUES (@titulo, @texto, @IsImportant, @CreateAt, @UpdateAt, @userID)";

                using (var comando = new SQLiteCommand(InsertQuery, conexao))
                {
                    comando.Parameters.AddWithValue("@userID", userID);
                    comando.Parameters.AddWithValue("@titulo", titulo);
                    comando.Parameters.AddWithValue("@texto", texto);
                    comando.Parameters.AddWithValue("@IsImportant", IsImportant);
                    comando.Parameters.AddWithValue("@CreateAt", CreateAt);
                    comando.Parameters.AddWithValue("@UpdateAt", UpdateAt);

                    
                    comando.ExecuteNonQuery();
                }
            }

        }




        }
    }

