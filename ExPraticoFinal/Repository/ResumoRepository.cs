using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class ResumoRepository
    {
        MySqlConnection connection;

        string strConnection = "" +
        "Database=db_comercial;" +
        "Data Source=localhost;" +
        "User id=root;" +
        "Password=root123;" +
        "Port=3306";

        string strCountNotas = "SELECT COUNT(nf_codigo) as TotalNotas FROM nf";
        string strCountProdutos = "SELECT COUNT(pro_codigo) as TotalProdutos FROM produtos";
        string strCountClientes = "SELECT COUNT(cli_codigo) as TotalClientes FROM clientes";
        string strNotasEmitidas = "SELECT COUNT(nf_codigo) as NotasEmitidas FROM nf WHERE nf_dtemissao is not null";
        string strNotasNaoEmitidas = "SELECT COUNT(nf_codigo) as NotasNaoEmitidas FROM nf WHERE nf_dtemissao is null";
        string strTotalVendido = "SELECT SUM(nf_valor) as TotalVendido FROM nf WHERE nf_dtemissao is not null";

        public ResumoRepository()
        {
            this.connection = new MySqlConnection(strConnection);
        }

        public ResumoEntities TotalNotas()
        {
            ResumoEntities resumo = new ResumoEntities();
            using (MySqlCommand cmd = new MySqlCommand(strCountNotas, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumo.TotalNotas = Convert.ToInt32(reader["TotalNotas"]);
                }
            }
            this.connection.Close();
            return resumo;
        }
        public ResumoEntities TotalProdutos()
        {
            ResumoEntities resumo = new ResumoEntities();
            using (MySqlCommand cmd = new MySqlCommand(strCountProdutos, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumo.TotalProdutos = Convert.ToInt32(reader["TotalProdutos"]);
                }
            }
            this.connection.Close();
            return resumo;
        }
        public ResumoEntities TotalClientes()
        {
            ResumoEntities resumo = new ResumoEntities();
            using (MySqlCommand cmd = new MySqlCommand(strCountClientes, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumo.TotalClientes = Convert.ToInt32(reader["TotalClientes"]);
                }
            }
            this.connection.Close();
            return resumo;
        }
        public ResumoEntities NotasEmitidas()
        {
            ResumoEntities resumo = new ResumoEntities();
            using (MySqlCommand cmd = new MySqlCommand(strNotasEmitidas, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumo.NotasEmitidas = Convert.ToInt32(reader["NotasEmitidas"]);
                }
            }
            this.connection.Close();
            return resumo;
        }
        public ResumoEntities NotasNaoEmitidas()
        {
            ResumoEntities resumo = new ResumoEntities();
            using (MySqlCommand cmd = new MySqlCommand(strNotasNaoEmitidas, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumo.NotasNaoEmitidas = Convert.ToInt32(reader["NotasNaoEmitidas"]);
                }
            }
            this.connection.Close();
            return resumo;
        }
        public ResumoEntities TotalVendido()
        {
            ResumoEntities resumo = new ResumoEntities();
            using (MySqlCommand cmd = new MySqlCommand(strTotalVendido, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    resumo.TotaVendido = Convert.ToInt32(reader["TotalVendido"]);
                }
            }
            this.connection.Close();
            return resumo;
        }
    }
}
