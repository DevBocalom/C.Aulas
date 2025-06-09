using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties
{
    public class NotasEntities
    {
        public int Nota { get; set; }
        public int IdCliente { get; set; }
        public string Razao { get; set; }
        public string Fantasia { set; get; }
        public string CGC { set; get; }
        public string Endereco { set; get; }
        public int Numero { set; get; }
        public string Bairro { set; get; }
        public string Cidade { set; get; }
        public string UF { set; get; }
        public string Telefone { set; get; }
        public decimal Valor { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataDigitao { get; set; }
        public string Observacao { get; set; }
        public bool Valida { get; set; }
    }

    public class NotasGridDTO
    {
        public int Nota { get; set; }
        public int IdCliente { get; set; }
        public string Razao { get; set; }
        public string CGC { get; set; }
        public decimal Valor { get; set; }
    }
}