using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entitties;

namespace Repository
{
    public class ClientesRepository
    {
        MySqlConnection connection;

        string strConnection = "" +
        "Database=db_comercial;" +
        "Data Source=localhost;" +
        "User id=root;" +
        "Password=root123;" +
        "Port=3306";

        string strGetDGV = "SELECT c.* FROM clientes c";
        string strGetById = "SELECT c.* FROM clientes c WHERE c.cli_codigo = @id";
        string strGetByName = "SELECT c.* FROM clientes c WHERE c.cli_razao LIKE '% @nome %' OR c.cli_fantasia LIKE '% @nome %'";
        string strInsert = "INSERT INTO clientes (cli_razao, cli_fantasia, cli_cgc, cli_end, cli_num, cli_bairro, cli_cidade, cli_uf, cli_telefone, cli_status) " +
            "VALUES (@razao, @fantasia, @cgc, @endereco, @numero, @bairro, @cidade, @uf, @telefone, @status)";
        string strUpdate = "UPDATE clientes SET cli_razao = @razao, cli_fantasia = @fantasia, cli_cgc = @cgc, cli_end = @endereco, " +
            "cli_num = @numero, cli_bairro = @bairro, cli_cidade = @cidade, cli_uf = @uf, cli_telefone = @telefone, cli_status = @status WHERE cli_codigo = @id";
        string strDelete = "DELETE FROM clientes WHERE cli_codigo = @id";

        public ClientesRepository()
        {
            this.connection = new MySqlConnection(strConnection);
        }

        public List<ClientesGridDTO> clientesDTO()
        {
            List<ClientesGridDTO> clientes = new List<ClientesGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strGetDGV, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //cada vez quer rodar o while, é uma linha da tabela
                    ClientesGridDTO c = new ClientesGridDTO();

                    c.Id = Convert.ToInt32(reader["cli_codigo"]);
                    c.Razao = reader["cli_razao"].ToString();
                    c.Fantasia = reader["cli_fantasia"].ToString();
                    c.CGC = reader["cli_cgc"].ToString();
                    c.Status = Convert.ToBoolean(reader["cli_status"]);

                    clientes.Add(c);
                }
            }
            this.connection.Close();
            return clientes;
        }
        public List<ClientesGridDTO> GetByName(string nome)
        {
            List<ClientesGridDTO> clientes = new List<ClientesGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strGetByName, this.connection))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ClientesGridDTO c = new ClientesGridDTO();
                    c.Id = Convert.ToInt32(reader["cli_codigo"]);
                    c.Razao = reader["cli_razao"].ToString();
                    c.Fantasia = reader["cli_fantasia"].ToString();
                    c.CGC = reader["cli_cgc"].ToString();
                    c.Status = Convert.ToBoolean(reader["cli_status"]);
                    clientes.Add(c);
                }
            }
            this.connection.Close();
            return clientes;
        }
        public List<ClientesEntities> GetById(int id)
        {
            List<ClientesEntities> clientes = new List<ClientesEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strGetById, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ClientesEntities c = new ClientesEntities();

                    c.Id = Convert.ToInt32(reader["cli_codigo"]);
                    c.Razao = reader["cli_razao"].ToString();
                    c.Fantasia = reader["cli_fantasia"].ToString();
                    c.CGC = reader["cli_cgc"].ToString();
                    c.Endereco = reader["cli_end"].ToString();
                    c.Numero = Convert.ToInt32(reader["cli_num"]);
                    c.Bairro = reader["cli_bairro"].ToString();
                    c.Cidade = reader["cli_cidade"].ToString();
                    c.UF = reader["cli_uf"].ToString();
                    c.Telefone = reader["cli_telefone"].ToString();
                    c.Status = Convert.ToBoolean(reader["cli_status"]);

                    clientes.Add(c);
                }
            }
            this.connection.Close();
            return clientes;
        }
        public void Insert(ClientesEntities cliente)
        {
            using (MySqlCommand cmd = new MySqlCommand(strInsert, this.connection))
            {
                cmd.Parameters.AddWithValue("@razao", cliente.Razao);
                cmd.Parameters.AddWithValue("@fantasia", cliente.Fantasia);
                cmd.Parameters.AddWithValue("@cgc", cliente.CGC);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@uf", cliente.UF);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@status", cliente.Status);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void Update(ClientesEntities cliente)
        {
            using (MySqlCommand cmd = new MySqlCommand(strUpdate, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.Parameters.AddWithValue("@razao", cliente.Razao);
                cmd.Parameters.AddWithValue("@fantasia", cliente.Fantasia);
                cmd.Parameters.AddWithValue("@cgc", cliente.CGC);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@uf", cliente.UF);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@status", cliente.Status);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void Delete(int id)
        {
            using (MySqlCommand cmd = new MySqlCommand(strDelete, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
    }
}
