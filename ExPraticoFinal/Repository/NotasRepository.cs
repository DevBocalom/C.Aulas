using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Google.Protobuf;
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
        string strInsert = "INSERT INTO nf (nf_cliente, nf_dtdigitacao, nf_dtemissao, nf_valor, nf_informacoes, nf_emitida) " +
            "VALUES (@cliente, @dtdigitacao, @dtemissao, @valor, @observacao, @emitida)";
        string strUpdate = "UPDATE nf SET nf_cliente = @cliente, nf_dtdigitacao = @dtdigitacao, nf_dtemissao = @dtemissao, " +
            "nf_valor = @valor, nf_informacoes = @observacao, nf_emitida = @emitida WHERE nf_codigo = @id";
        string strDelete = "DELETE FROM nf  WHERE nf_codigo = @id";
        string strValidaEmissao = "SELECT COUNT(nf_codigo) FROM nf WHERE nf_codigo = @ID AND nf_emitida = '1'";
        string strUltimaNota = "SELECT MAX(nf_codigo) FROM nf";
        string strEmitir = "UPDATE nf SET nf_emitida = @emitida WHERE nf_codigo = @id";
        string strAdicionarValor = "UPDATE nf SET nf_valor = (SELECT IFNULL(SUM(ite_total), 0) FROM itens_nf WHERE ite_nf = @nf)WHERE nf_codigo = @nf;";
        string strAttVaalor = "select nf_valor from nf where nf_codigo = @nf;";
        string strGetbyNF = "SELECT n.*,c.* FROM nf n left join clientes c on c.cli_codigo = n.nf_cliente where n.nf_codigo like @NF";
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
                    n.Valida = Convert.ToBoolean(reader["nf_emitida"]);
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
        public List<NotasEntities> Valida(int id)
        {
            List<NotasEntities> notas = new List<NotasEntities>();
            using (MySqlCommand cmd = new MySqlCommand(strValidaEmissao, this.connection))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int count = Convert.ToInt32(reader["COUNT(nf_codigo)"]);
                    if (count > 0)
                    {
                        NotasEntities n = new NotasEntities();
                        n.Nota = count;
                        notas.Add(n);
                    }
                }
            }
            this.connection.Close();
            return notas;
        }
        public void Insert(NotasEntities notas)
        {
            using (MySqlCommand cmd = new MySqlCommand(strInsert, this.connection))
            {
                cmd.Parameters.AddWithValue("@cliente", notas.IdCliente);
                cmd.Parameters.AddWithValue("@dtdigitacao", notas.DataDigitao);
                cmd.Parameters.AddWithValue("@dtemissao", notas.DataEmissao);
                cmd.Parameters.AddWithValue("@valor", notas.Valor);
                cmd.Parameters.AddWithValue("@observacao", notas.Observacao);
                cmd.Parameters.AddWithValue("@emitida", notas.Valida);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void Update(NotasEntities notas)
        {
            using (MySqlCommand cmd = new MySqlCommand(strUpdate, this.connection))
            {
                cmd.Parameters.AddWithValue("@cliente", notas.IdCliente);
                cmd.Parameters.AddWithValue("@dtdigitacao", notas.DataDigitao);
                cmd.Parameters.AddWithValue("@dtemissao", notas.DataEmissao);
                cmd.Parameters.AddWithValue("@valor", notas.Valor);
                cmd.Parameters.AddWithValue("@observacao", notas.Observacao);
                cmd.Parameters.AddWithValue("@id", notas.Nota);
                cmd.Parameters.AddWithValue("@emitida", notas.Valida);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public int UltimaNota()
        {
            int nota = 0;
            using (MySqlCommand cmd = new MySqlCommand(strUltimaNota, this.connection))
            {
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nota = Convert.ToInt32(reader["MAX(nf_codigo)"]);
                }
            }
            this.connection.Close();
            return nota;
        }
        public void Emitir(int id, bool emitida)
        {
            using (MySqlCommand cmd = new MySqlCommand(strEmitir, this.connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@emitida", emitida);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public void AdicionarValor(int nf)
        {
            using (MySqlCommand cmd = new MySqlCommand(strAdicionarValor, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", nf);
                this.connection.Open();
                cmd.ExecuteNonQuery();
            }
            this.connection.Close();
        }
        public decimal AttValor(int nf)
        {
            decimal valor = 0;
            using (MySqlCommand cmd = new MySqlCommand(strAttVaalor, this.connection))
            {
                cmd.Parameters.AddWithValue("@nf", nf);
                this.connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    valor = Convert.ToDecimal(reader["nf_valor"]);
                }
            }
            this.connection.Close();
            return valor;
        }
        public List<NotasGridDTO> GetByRazaoOrNota(int NF)
        {
            List<NotasGridDTO> notas = new List<NotasGridDTO>();
            using (MySqlCommand cmd = new MySqlCommand(strGetbyNF, this.connection))
            {
                cmd.Parameters.AddWithValue("@NF", NF);
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