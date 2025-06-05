using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Repository;

namespace Service
{
    public class NotasService
    {
        NotasRepository NR = new NotasRepository();
        public List<NotasEntities> GetAll(int ID)
        {
            List<NotasEntities> notas = NR.GetAll(ID);
            return notas;
        }
        public List<NotasGridDTO> NotasDTO()
        {
            List<NotasGridDTO> notas = NR.NotasGridDTO();
            return notas;
        }
    }
}
