using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Repository;

namespace Service
{
    public class ProdutosService
    {
        ProdutosRepository PR = new ProdutosRepository();

        public List<ProdutosGridDTO> GetAll()
        {
            List<ProdutosGridDTO> repository = PR.getAll();
            return repository;
        }

        public List<ProdutosEntities> GetById(int id)
        {
            List<ProdutosEntities> repository = PR.GetById(id);
            return repository;
        }
    }
}
