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
    }
}
