using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace NoteLogin
{
    internal class User
    {
        public int ID { get; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int ThemeColor { get; set; } = 1;
        public string CaminhoFoto { get; set; }
        public byte[] foto_perfil { get; set; }

        public User(string userName, string password, string email, string login, string gender)
        {
            UserName = userName;
            Password = password;
            Email = email;
            UserName = login;
            Gender = gender;

        }

    }
}
