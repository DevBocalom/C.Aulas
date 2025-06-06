using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Repository;

namespace Service
{
    public class ResumoService
    {
        public ResumoRepository R = new ResumoRepository();
        public ResumoEntities TotalNotas()
        {
            ResumoEntities resumo = R.TotalNotas();
            return resumo;
        }
        public ResumoEntities TotalProdutos()
        {
            ResumoEntities resumo = R.TotalProdutos();
            return resumo;
        }
        public ResumoEntities TotalClientes()
        {
            ResumoEntities resumo = R.TotalClientes();
            return resumo;
        }
        public ResumoEntities NotasEmitidas()
        {
            ResumoEntities resumo = R.NotasEmitidas();
            return resumo;
        }
        public ResumoEntities NotasNaoEmitidas()
        {
            ResumoEntities resumo = R.NotasNaoEmitidas();
            return resumo;
        }
        public ResumoEntities TotalVendido()
        {
            ResumoEntities resumo = R.TotalVendido();
            return resumo;
        }
    }
}
