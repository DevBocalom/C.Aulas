using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repository
{
    public class ProdutoRepository
    {
        List<Produto> database = new List<Produto>();

        public ProdutoRepository()
        {
            Produto p1 = new Produto();
            p1.Id = "1";
            p1.Descricao = "Mouse Logitech";
            p1.Fornecedor = "Pichau Informática";
            p1.Estoque = "Central";
            p1.Valor = 150.00f;
            p1.Ativo = true;

            Produto p2 = new Produto();
            p2.Id = "2";
            p2.Descricao = "Teclado Sem Fio";
            p2.Fornecedor = "Kabum";
            p2.Estoque = "Filial 1";
            p2.Valor = 200.00f;
            p2.Ativo = false;

            Produto p3 = new Produto();
            p3.Id = "3";
            p3.Descricao = "Headset HyperX 7.1";
            p3.Fornecedor = "HyperX";
            p3.Estoque = "Filial 2";
            p3.Valor = 345.00f;
            p3.Ativo = true;

            Produto p4 = new Produto();
            p4.Id = "4";
            p4.Descricao = "Monito UltraWide 27¨";
            p4.Fornecedor = "LG";
            p4.Estoque = "Central";
            p4.Valor = 899.99f;
            p4.Ativo = true;

            database.Add(p1);
            database.Add(p2);
            database.Add(p3);
            database.Add(p4);
        }

        public void insert(Produto p)
        {
            database.Add(p);
        }
        public void update(Produto p)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (p.Id == database[i].Id)
                {
                    database[i] = p;
                    return;
                }
            }
        }
        public void delete(string Id)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (Id == database[i].Id)
                {
                    database.RemoveAt(i);
                    return;
                }
            }
        }
        public List<Produto> getAll()
        {
            return database;
        }
        public Produto getById(string Id)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (Id == database[i].Id)
                {
                    return database[i];
                }
            }
            return null;
        }
    }
}
