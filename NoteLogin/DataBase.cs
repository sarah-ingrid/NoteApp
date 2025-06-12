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
        // 1º: criar a variavel de conexão (do tipo sqlite)
        private static SQLiteConnection conexao;

// método para fazer essa conexão 
// dessa forma, em vez de sempre precisar escrever td isso chamaremos apenas o método com td ja escrito e pronto para conectar
        public static SQLiteConnection ConexaoBanco()
        {
            // aqui daremos o CAMINHO de onde está nosso BD:
            conexao = new SQLiteConnection("Data Source =C:\\Users\\sarah\\Desktop\\C#\\NoteLogin\\NoteLogin\\database\\bd_usuarios");
            conexao.Open();
            return conexao;
        }

        
    }
}
