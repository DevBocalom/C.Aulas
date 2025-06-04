using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties
{
    public class ClientesEntities
    {
        public int Id { set; get; }
        public string Razao { set; get; }
        public string Fantasia { set; get; }
        public string CGC { set; get; }
        public string Endereco { set; get; }
        public int Numero { set; get; }
        public string Bairro { set; get; }
        public string Cidade { set; get; }
        public string UF { set; get; }
        public string Telefone { set; get; }
        public bool Status { set; get; }
    }
    public class ClientesGridDTO
    {
        public int Id { get; set; }
        public string Razao { get; set; }
        public string Fantasia { get; set; }
        public string CGC { get; set; }
        public bool Status { get; set; }
    }
}
