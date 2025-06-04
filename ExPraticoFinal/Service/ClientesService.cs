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
        public List<ClientesGridDTO> GetByName(string nome)
        {
            List<ClientesGridDTO> clientes = CR.GetByName(nome);
            return clientes;
        }
        public List<ClientesEntities> GetById(int id)
        {
            List<ClientesEntities> clientes = CR.GetById(id);
            return clientes;
        }
        public void Insert(ClientesEntities c)
        {
            if (c.Razao == null || c.Razao.Trim() == "")
            {
                throw new ArgumentException("Razão social é obrigatória.");
            }
            else if (c.CGC == null || c.CGC.Trim() == "")
            {
                throw new ArgumentException("CGC é obrigatório.");
            }
            else if (c.Endereco == null || c.Endereco.Trim() == "")
            {
                throw new ArgumentException("Endereço é obrigatório.");
            }
            else if (c.Numero <= 0)
            {
                throw new ArgumentException("Número é obrigatório e deve ser maior que zero.");
            }
            else if (c.Bairro == null || c.Bairro.Trim() == "")
            {
                throw new ArgumentException("Bairro é obrigatório.");
            }
            else if (c.Cidade == null || c.Cidade.Trim() == "")
            {
                throw new ArgumentException("Cidade é obrigatória.");
            }
            else if (c.UF == null || c.UF.Trim() == "")
            {
                throw new ArgumentException("UF é obrigatória.");
            }
            else if (c.Telefone == null || c.Telefone.Trim() == "")
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }

            CR.Insert(c);
        }
        public void Update(ClientesEntities c)
        {
            if (c.Razao == null || c.Razao.Trim() == "")
            {
                throw new ArgumentException("Razão social é obrigatória.");
            }
            else if (c.CGC == null || c.CGC.Trim() == "")
            {
                throw new ArgumentException("CGC é obrigatório.");
            }
            else if (c.Endereco == null || c.Endereco.Trim() == "")
            {
                throw new ArgumentException("Endereço é obrigatório.");
            }
            else if (c.Numero <= 0)
            {
                throw new ArgumentException("Número é obrigatório e deve ser maior que zero.");
            }
            else if (c.Bairro == null || c.Bairro.Trim() == "")
            {
                throw new ArgumentException("Bairro é obrigatório.");
            }
            else if (c.Cidade == null || c.Cidade.Trim() == "")
            {
                throw new ArgumentException("Cidade é obrigatória.");
            }
            else if (c.UF == null || c.UF.Trim() == "")
            {
                throw new ArgumentException("UF é obrigatória.");
            }
            else if (c.Telefone == null || c.Telefone.Trim() == "")
            {
                throw new ArgumentException("Telefone é obrigatório.");
            }
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
    }
}
