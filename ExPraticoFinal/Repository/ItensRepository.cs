using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class ItensRepository
    {
        MySqlConnection connection;

        string strConnection = "" +
        "Database=db_comercial;" +
        "Data Source=localhost;" +
        "User id=root;" +
        "Password=root123;" +
        "Port=3306";

        string strGetAll = "SELECT i.* FROM itens_nf i left join nf n on n.nf_codigo = i.ite_nf where n.nf_codigo = @nf";

        public ItensRepository()
        {
            this.connection = new MySqlConnection(strConnection);
        }

        public List<ItensEntities> GetAll(int NF)
        {
            List<ItensEntities> itens = new List<ItensEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strGetAll, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", NF);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ItensEntities i = new ItensEntities();
                    i.IdProduto = Convert.ToInt32(reader["ite_prod"]);
                    i.Descricao = reader["ite_descricao"].ToString();
                    i.Quantidade = Convert.ToInt32(reader["ite_quantidade"]);
                    i.ValorUnitario = Convert.ToDecimal(reader["ite_valor"]);
                    i.ValorTotal = Convert.ToDecimal(reader["ite_total"]);
                    itens.Add(i);
                }
            }
            this.connection.Close();
            return itens;
        }
    }
}
