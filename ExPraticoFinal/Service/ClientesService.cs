using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitties;
using Repository;

namespace Service
{
    public class ClientesService
    {
        ClientesRepository CR = new ClientesRepository();

        public List<ClientesGridDTO> ClientesDTO()
        {
            List<ClientesGridDTO> clientes = CR.clientesDTO();
            return clientes;
        }
        public List<ClientesGridDTO> GetByName(string nome, string fantasia)
        {
            List<ClientesGridDTO> clientes = CR.GetByName(nome, fantasia);
            return clientes;
        }
        public List<ClientesEntities> GetById(int id)
        {
            List<ClientesEntities> clientes = CR.GetById(id);
            return clientes;
        }
        public void Insert(ClientesEntities c)
        {
            CR.Insert(c);
        }
        public void Update(ClientesEntities c)
        {
            CR.Update(c);
        }
        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID inválido.");
            }
            CR.Delete(id);
        }
        public int CountCli(int id)
        {
            return CR.CountClientes(id);
        }
    }
}
