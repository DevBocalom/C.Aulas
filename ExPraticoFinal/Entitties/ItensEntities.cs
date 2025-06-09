using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties
{
    public class ItensEntities
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
    }

    public class ItensEtitiesAdd
    {
        public int IdNota { get; set; }
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public string Marca { get; set; }
        public string Fornecedor { get; set; }
    }
}
