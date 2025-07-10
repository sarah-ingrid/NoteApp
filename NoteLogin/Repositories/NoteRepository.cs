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
            int IDNote = NovaNota.ID_note;
            int userID = NovaNota.ID_user;
            string titulo = NovaNota.Title;
            string texto = NovaNota.Text;
            int IsImportant = NovaNota.IsImportant;
            DateTime CreateAt = DateTime.Now;
            DateTime UpdateAt = DateTime.Now;


            using var conexao = DataBase.ConexaoBanco();
            {
                string InsertQuery = "INSERT INTO tb_notes( TITULO, TEXTO, IsImportant, CreateAt, UpdateAt, ID_Users)" +
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

                    NovaNota.ID_note = (int)(long)new SQLiteCommand("SELECT last_insert_rowid()", conexao).ExecuteScalar();
                }
            }

        }

        public static void AtualizarNota(Note NotaAtt)
        {
            int IDNote = NotaAtt.ID_note;
            string titulo = NotaAtt.Title;
            string texto = NotaAtt.Text;
            int IsImportant = NotaAtt.IsImportant;
            DateTime CreateAt = DateTime.Now;
            DateTime UpdateAt = DateTime.Now;


            using (var conexao = DataBase.ConexaoBanco())
            {
                string UpdateQuery = "UPDATE tb_notes SET TITULO = @titulo, TEXTO = @texto, IsImportant = @isImportant, " +
                                      "UpdateAt = @updateAt WHERE ID_note = @idNota";

                using (var comando = new SQLiteCommand(UpdateQuery, conexao))
                {
                    comando.Parameters.AddWithValue("@titulo", NotaAtt.Title);
                    comando.Parameters.AddWithValue("@texto", NotaAtt.Text);
                    comando.Parameters.AddWithValue("@isImportant", NotaAtt.IsImportant);
                    comando.Parameters.AddWithValue("@updateAt", DateTime.Now); 
                    comando.Parameters.AddWithValue("@idNota", NotaAtt.ID_note); 
                    comando.ExecuteNonQuery();

                 //   NotaAtt.ID_note = (int)(long)new SQLiteCommand("SELECT last_insert_rowid()", conexao).ExecuteScalar();
                }
            }
        }
    }


}
  

