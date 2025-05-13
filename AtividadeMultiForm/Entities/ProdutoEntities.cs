using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProdutoEntities
    {
        public string Id { set; get; }
        public string Descricao { set; get; }
        public string Fornecedor { set; get; }
        public string Estoque { set; get; }
        public float Valor { set; get; }
        public bool Ativo { set; get; }
    }
}
