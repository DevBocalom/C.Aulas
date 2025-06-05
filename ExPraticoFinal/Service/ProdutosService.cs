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
        public List<ProdutosGridDTO> GetByName(string nome)
        {
            List<ProdutosGridDTO> repository = PR.GetByName(nome);
            return repository;
        }
        public void Insert(ProdutosEntities produto)
        {
            PR.Insert(produto);
        }
        public void Update(ProdutosEntities produto)
        {
            PR.Update(produto);
        }
        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID inválido.");
            }
            PR.Delete(id);
        }
    }
}
