using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entities;
using System.Runtime.Remoting.Messaging;

namespace Repository
{
    public class ProdutoRepositorySQL
    {
        MySqlConnection connection;

        string strConnection =""+
            "Database=db_visual_studio;" +
            "Data Source=localhost;" +
            "User id=root;" +
            "Password=root123;" +
            "Port=3306";
        string strGetAll = "SELECT * FROM produto";
        string deleteSQL = "DELETE FROM produto WHERE id = @id";
        string updateSQL = "UPDATE produto SET descricao = @descricao, fornecedor = @fornecedor, " +
             "estoque = @estoque, valor = @valor, status = @status WHERE id = @id";
        string insertSQL = "INSERT INTO produto (descricao, fornecedor, estoque, valor, status) " +
             "VALUES (@descricao, @fornecedor, @estoque, @valor, @status)";

        public ProdutoRepositorySQL()
        {
            this.connection = new MySqlConnection(strConnection);
        }
        public void insert(ProdutoEntities p)
        {
            using (MySqlCommand cmd = new MySqlCommand(insertSQL, this.connection))
            {
                cmd.Parameters.AddWithValue("@descricao", p.Descricao);
                cmd.Parameters.AddWithValue("@fornecedor", p.Fornecedor);
                cmd.Parameters.AddWithValue("@estoque", p.Estoque);
                cmd.Parameters.AddWithValue("@valor", p.Valor);
                cmd.Parameters.AddWithValue("@status", p.Ativo);
                this.connection.Open();
                cmd.ExecuteNonQuery();
                this.connection.Close();
                //long lastId = cmd.LastInsertedId;
            }
        }
        public void update(ProdutoEntities p)
        {
            using (MySqlCommand cmd = new MySqlCommand(updateSQL, this.connection))
            {
                cmd.Parameters.AddWithValue("id", p.Id);
                cmd.Parameters.AddWithValue("@descricao", p.Descricao);
                cmd.Parameters.AddWithValue("@fornecedor", p.Fornecedor);
                cmd.Parameters.AddWithValue("@estoque", p.Estoque);
                cmd.Parameters.AddWithValue("@valor", p.Valor);
                cmd.Parameters.AddWithValue("@status", p.Ativo);
                this.connection.Open();
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
        }
        public void delete(string id)
        {
            using (MySqlCommand cmd = new MySqlCommand(deleteSQL, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                this.connection.Open();
                cmd.ExecuteNonQuery();
                this.connection.Close();
            }
        }
        public List<ProdutoEntities> getAll()
        {
            List<ProdutoEntities> produtos = new List<ProdutoEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strGetAll, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //cada vez quer rodar o while, é uma linha da tabela
                    ProdutoEntities p = new ProdutoEntities();
                    p.Id = reader["id"].ToString();
                    p.Descricao = reader["descricao"].ToString();
                    p.Fornecedor = reader["fornecedor"].ToString();
                    p.Estoque = reader["estoque"].ToString();
                    p.Valor = Convert.ToSingle(reader["valor"]);
                    p.Ativo = Convert.ToBoolean(reader["status"]);
                    produtos.Add(p);
                }
            }
            this.connection.Close();   
            return produtos;
        }
    }
}
