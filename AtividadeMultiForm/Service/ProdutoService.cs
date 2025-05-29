using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository;

namespace Service
{
    public class ProdutoService
    {
        ProdutoRepositorySQL produtorepository = new ProdutoRepositorySQL();
        
        public List<ProdutoEntities> GetAll()
        {
            List<ProdutoEntities> produtos = produtorepository.getAll();
            return produtos;
        }

        public void Insert(ProdutoEntities p)
        {
            if (p.Descricao == null || p.Descricao == "")
            {
                throw new Exception("Descrição inválida");
            }
            if (p.Fornecedor == null || p.Fornecedor == "")
            {
                throw new Exception("Fornecedor inválido");
            }
            if (p.Estoque == null || p.Estoque == "")
            {
                throw new Exception("Estoque inválido");
            }
            if (p.Valor <= 0)
            {
                throw new Exception("Valor inválido");
            }

            List<ProdutoEntities> produtos = produtorepository.getAll();
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Id == p.Id)
                {
                    this.produtorepository.update(p);
                    return;
                }
            }

            this.produtorepository.insert(p);
        }
        public void Update(ProdutoEntities p)
        {
            this.produtorepository.update(p);
        }
        public void Delete(string Id)
        {
            this.produtorepository.delete(Id);
        }
    }
}
