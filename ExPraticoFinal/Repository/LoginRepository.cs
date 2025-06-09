using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class LoginRepository
    {
        MySqlConnection connection;

        string strConnection = "" +
        "Database=db_comercial;" +
        "Data Source=localhost;" +
        "User id=root;" +
        "Password=root123;" +
        "Port=3306";

        string strLogin = "SELECT * FROM usuarios WHERE us_nome = @usuario AND us_senha = @senha";

        public LoginRepository()
        {
            this.connection = new MySqlConnection(strConnection);
        }
        public List<LoginEntities> ValidarLogin(string user, string senha)
        {
            List<LoginEntities> login = new List<LoginEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strLogin, this.connection))
            {
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@senha", senha);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LoginEntities l = new LoginEntities();
                    login.Add(l);
                }
            }
            this.connection.Close();
            return login;
        }
    }
}
