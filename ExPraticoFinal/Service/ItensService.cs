using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Repository;

namespace Service
{
    public class ItensService
    {
        ItensRepository IR = new ItensRepository();

        public List<ItensEntities> GetAll(int NF)
        {
            return IR.GetAll(NF);
        }
        public void Insert(ItensEtitiesAdd item)
        {
            IR.Insert(item);
        }
        public void Update(ItensEtitiesAdd item)
        {
            IR.Update(item);
        }
        public void Delete(int NF, int produto)
        {
            IR.Delete(NF, produto);
        }
        public List<ProdutosGridDTO> AddDGV(int NF)
        {
            return IR.AddDGV(NF);
        }
        public List<ItensEtitiesAdd> GetById(int NF, int produto)
        {
            return IR.GetById(NF, produto);
        }
    }
}
