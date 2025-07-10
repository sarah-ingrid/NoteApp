using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace NoteLogin
{
    internal class DataBase
    {

       private static SQLiteConnection conexao;



        public static SQLiteConnection ConexaoBanco()
        {
             conexao = new SQLiteConnection(@"Data Source=C:\Users\sarah\Desktop\Projetos\NoteLogin\NoteLogin\database\bd_noteApp.db");
             conexao.Open();
             return conexao;

           /* string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(basePath, "database", "bd_noteApp.db");
            string conexao = $"Data Source={dbPath};";

            return new SQLiteConnection(conexao);*/

            
        }


        public void TrashforDelete(string tabela, int IDNote) 
        {
            using (var conexao = DataBase.ConexaoBanco()) 
            {
                string query = $"DELETE FROM {tabela} WHERE ID_note = @IDNote";

                using (var comando = new SQLiteCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@IDNote", IDNote);

                    comando.ExecuteNonQuery();
                }
            }
        }

        
    }
}
