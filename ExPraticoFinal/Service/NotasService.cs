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
        public void Delete(int id)
        {
            NR.Delete(id);
        }
        public List<NotasEntities> Valida(int id)
        {
            List<NotasEntities> val = NR.Valida(id);
            return val;
        }
        public void Insert(NotasEntities n)
        {
            NR.Insert(n);
        }
        public void Update(NotasEntities n)
        {
            NR.Update(n);
        }
        public int NovaNota()
        {
            return NR.UltimaNota();
        }
        public void Emitir(int id, bool emitida)
        {
            NR.Emitir(id, emitida);
        }
        public void AdicionarvValor(int id)
        {
            NR.AdicionarValor(id);
        }
        public decimal attValor(int id)
        {
            return NR.AttValor(id);
        }
    }
}
