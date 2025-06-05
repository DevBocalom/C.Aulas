using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class NotasRepository
    {
        MySqlConnection connection;

        string strConnection = "" +
        "Database=db_comercial;" +
        "Data Source=localhost;" +
        "User id=root;" +
        "Password=root123;" +
        "Port=3306";

        string strGetAll = "SELECT n.*,c.* FROM nf n left join clientes c on c.cli_codigo = n.nf_cliente";
        string strGetbyID = "SELECT n.*,c.* FROM nf n left join clientes c on c.cli_codigo = n.nf_cliente where n.nf_codigo  = @ID";

        public NotasRepository()
        {
            this.connection = new MySqlConnection(strConnection);
        }

        public List<NotasEntities> GetAll(int id)
        {
            List<NotasEntities> notas = new List<NotasEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strGetbyID, this.connection))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NotasEntities n = new NotasEntities();
                    n.Nota = Convert.ToInt32(reader["nf_codigo"]);
                    n.IdCliente = Convert.ToInt32(reader["nf_cliente"]);
                    n.Razao = reader["cli_razao"].ToString();
                    n.Fantasia = reader["cli_fantasia"].ToString();
                    n.CGC = reader["cli_cgc"].ToString();
                    n.Endereco = reader["cli_end"].ToString();
                    n.Numero = Convert.ToInt32(reader["cli_num"]);
                    n.Bairro = reader["cli_bairro"].ToString();
                    n.Cidade = reader["cli_cidade"].ToString();
                    n.UF = reader["cli_uf"].ToString();
                    n.Telefone = reader["cli_telefone"].ToString();
                    n.DataDigitao = Convert.ToDateTime(reader["nf_dtdigitacao"]);
                    n.DataEmissao = Convert.ToDateTime(reader["nf_dtemissao"]);
                    n.Valor = Convert.ToDecimal(reader["nf_valor"]);
                    n.Observacao = reader["nf_informacoes"].ToString();
                    notas.Add(n);
                }
            }
            this.connection.Close();
            return notas;
        }
        public List<NotasGridDTO> NotasGridDTO()
        {
            List<NotasGridDTO> notas = new List<NotasGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strGetAll, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NotasGridDTO n = new NotasGridDTO();
                    n.Nota = Convert.ToInt32(reader["nf_codigo"]);
                    n.IdCliente = Convert.ToInt32(reader["nf_cliente"]);
                    n.Razao = reader["cli_razao"].ToString();
                    n.CGC = reader["cli_cgc"].ToString();
                    n.Valor = Convert.ToDecimal(reader["nf_valor"]);
                    notas.Add(n);
                }
            }
            this.connection.Close();
            return notas;
        }
    }
}
