using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class ProdutosRepository
    {
        MySqlConnection connection;

        string strConnection = "" +
        "Database=db_comercial;" +
        "Data Source=localhost;" +
        "User id=root;" +
        "Password=root123;" +
        "Port=3306";

        string strGetAll = "SELECT p.* FROM produtos p";
        string strGetById = "SELECT p.* FROM produtos p WHERE p.pro_codigo= @id";
        string strGetByName = "SELECT p.* FROM produtos p WHERE p.pro_descricao LIKE @nome";
        string strInsert = "INSERT INTO produtos (pro_descricao, pro_marca, pro_valor, pro_fornecedor, pro_status) " +
            "VALUES (@descricao, @marca, @preco, @fornecedor, @status)";
        string strUpdate = "UPDATE produtos SET pro_descricao = @descricao, pro_marca = @marca, pro_valor = @preco, pro_fornecedor = @fornecedor, pro_status = @status WHERE pro_codigo = @id";
        string strDelete = "DELETE FROM produtos WHERE pro_codigo = @id";

        public ProdutosRepository()
        {
            this.connection = new MySqlConnection(strConnection);
        }
        public List<ProdutosGridDTO> getAll()
        {
            List<ProdutosGridDTO> produtos = new List<ProdutosGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strGetAll, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProdutosGridDTO p = new ProdutosGridDTO();
                    p.Id = Convert.ToInt32(reader["pro_codigo"]);
                    p.Descricao = reader["pro_descricao"].ToString();
                    p.Valor = Convert.ToDecimal(reader["pro_valor"]);
                    p.Status = Convert.ToBoolean(reader["pro_status"]);
                    produtos.Add(p);
                }
            }
            this.connection.Close();
            return produtos;
        }
        public List<ProdutosGridDTO> GetByName(string nome)
        {
            List<ProdutosGridDTO> produtos = new List<ProdutosGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strGetByName, this.connection))
            {
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProdutosGridDTO p = new ProdutosGridDTO();
                    p.Id = Convert.ToInt32(reader["pro_codigo"]);
                    p.Descricao = reader["pro_descricao"].ToString();
                    p.Valor = Convert.ToDecimal(reader["pro_valor"]);
                    p.Status = Convert.ToBoolean(reader["pro_status"]);
                    produtos.Add(p);
                }
            }
            this.connection.Close();
            return produtos;
        }
        public List<ProdutosEntities> GetById(int id)
        {
            List<ProdutosEntities> produtos = new List<ProdutosEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strGetById, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProdutosEntities p = new ProdutosEntities();
                    p.Id = Convert.ToInt32(reader["pro_codigo"]);
                    p.Descricao = reader["pro_descricao"].ToString();
                    p.Marca = reader["pro_marca"].ToString();
                    p.Valor = Convert.ToDecimal(reader["pro_valor"]);
                    p.Fornecedor = reader["pro_fornecedor"].ToString();
                    p.Status = Convert.ToBoolean(reader["pro_status"]);
                    produtos.Add(p);
                }
            }
            this.connection.Close();
            return produtos;
        }
        public void Insert(ProdutosEntities produto)
        {
            using (MySqlCommand cmd = new MySqlCommand(strInsert, this.connection))
            {
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@marca", produto.Marca);
                cmd.Parameters.AddWithValue("@preco", produto.Valor);
                cmd.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@status", produto.Status);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void Update(ProdutosEntities produto)
        {
            using (MySqlCommand cmd = new MySqlCommand(strUpdate, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", produto.Id);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@marca", produto.Marca);
                cmd.Parameters.AddWithValue("@preco", produto.Valor);
                cmd.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@status", produto.Status);
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
