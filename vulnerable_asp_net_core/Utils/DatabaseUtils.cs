using System.Data.SQLite;
using System.IO;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace vulnerable_asp_net_core.Utils
{
    public class DatabaseUtils
    {
        private static string _db = "dummy.db";
        
        // Alterado por GFT AI Impact Bot: tornou o campo privado e encapsulou-o em uma propriedade pública.
        private static SQLiteConnection _con;
        public static SQLiteConnection Con
        {
            get { return _con; }
            private set { _con = value; } // Alterado por GFT AI Impact Bot: adicionado setter privado para encapsulamento.
        }

        public static string GetConnectionString()
        {
            return "DataSource=" +_db + ";" ;
        }

        // Alterado por GFT AI Impact Bot: adicionado construtor protegido.
        protected DatabaseUtils() {}

        public static void init()
        {
            if(File.Exists(_db))
                File.Delete(_db);
            
            SQLiteConnection.CreateFile(_db);
            
            _con = new SQLiteConnection(GetConnectionString());
            _con.Open();
            new SQLiteCommand("create table users(id INT, name varchar(20), pw varchar(20))", _con).ExecuteNonQuery();
            new SQLiteCommand("INSERT INTO users(id, name, pw) VALUES (1, \"alice\", \"alicepw\")", _con).ExecuteNonQuery();
            new SQLiteCommand("INSERT INTO users(id, name, pw) VALUES (2, \"bob\", \"bobpw\")", _con).ExecuteNonQuery();
            new SQLiteCommand("INSERT INTO users(id, name, pw) VALUES (3, \"claire\", \"clairepw\")", _con).ExecuteNonQuery();
            // Alterado por GFT AI Impact Bot: removido código comentado.
        }
    }
}