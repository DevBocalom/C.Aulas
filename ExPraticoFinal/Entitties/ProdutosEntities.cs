using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties
{
    public class ProdutosEntities
    {
        public int Id { set; get; }
        public string Descricao { set; get; }
        public string Marca { set; get; }
        public decimal Valor { set; get; }
        public string Fornecedor { set; get; }
        public bool Status { set; get; }
    }
    public class ProdutosGridDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }
}
