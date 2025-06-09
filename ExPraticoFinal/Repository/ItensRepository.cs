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
        string strInsert = "INSERT INTO itens_nf (ite_nf, ite_prod, ite_descricao, ite_quantidade, ite_valor) " +
            "VALUES (@nf, @produto, @descricao, @quantidade, @valorUnitariosd)";
        string strUpdate = "UPDATE itens_nf SET ite_quantidade = @quantidade, ite_valor = @valorUnitariosd WHERE ite_nf = @nf AND ite_prod = @produto";
        string strDelete = "DELETE FROM itens_nf WHERE ite_nf = @nf AND ite_prod = @produto";
        string strAddDGV = "SELECT p.* FROM produtos p where p.pro_codigo not in (select i.ite_prod from itens_nf i where i.ite_nf = @nf) and p.pro_status = 1 ";
        string strGetById = "SELECT i.*, p.pro_marca, p.pro_fornecedor FROM itens_nf i left join produtos p on p.pro_codigo = i.ite_prod WHERE i.ite_nf = @nf AND i.ite_prod = @produto";
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
        public void Insert(ItensEtitiesAdd item)
        {
            using (MySqlCommand cmd = new MySqlCommand(strInsert, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", item.IdNota);
                cmd.Parameters.AddWithValue("@produto", item.IdProduto);
                cmd.Parameters.AddWithValue("@descricao", item.Descricao);
                cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                cmd.Parameters.AddWithValue("@valorUnitariosd", item.ValorUnitario);

                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void Update(ItensEtitiesAdd item)
        {
            using (MySqlCommand cmd = new MySqlCommand(strUpdate, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", item.IdNota);
                cmd.Parameters.AddWithValue("@produto", item.IdProduto);
                cmd.Parameters.AddWithValue("@quantidade", item.Quantidade);
                cmd.Parameters.AddWithValue("@valorUnitariosd", item.ValorUnitario);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void Delete(int NF, int produto)
        {
            using (MySqlCommand cmd = new MySqlCommand(strDelete, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", NF);
                cmd.Parameters.AddWithValue("@produto", produto);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public List<ProdutosGridDTO> AddDGV(int NF)
        {
            List<ProdutosGridDTO> produtos = new List<ProdutosGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strAddDGV, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", NF);
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
        public List<ItensEtitiesAdd> GetById(int NF, int produto)
        {
            List<ItensEtitiesAdd> item = new List<ItensEtitiesAdd>();
            using (MySqlCommand cmd = new MySqlCommand(strGetById, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", NF);
                cmd.Parameters.AddWithValue("@produto", produto);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ItensEtitiesAdd i = new ItensEtitiesAdd();
                    i.IdProduto = Convert.ToInt32(reader["ite_prod"]);
                    i.Descricao = reader["ite_descricao"].ToString();
                    i.Quantidade = Convert.ToInt32(reader["ite_quantidade"]);
                    i.ValorUnitario = Convert.ToDecimal(reader["ite_valor"]);
                    i.Marca = reader["pro_marca"].ToString();
                    i.Fornecedor = reader["pro_fornecedor"].ToString();
                    item.Add(i);
                }
            }
            this.connection.Close();
            return item;
        }
    }
}
