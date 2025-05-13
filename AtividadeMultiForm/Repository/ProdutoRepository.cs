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
        List<ProdutoEntities> database = new List<ProdutoEntities>();

        public ProdutoRepository()
        {
            ProdutoEntities p1 = new ProdutoEntities();
            p1.Id = "1";
            p1.Descricao = "Mouse Logitech";
            p1.Fornecedor = "Pichau Informática";
            p1.Estoque = "Central";
            p1.Valor = 150.00f;
            p1.Ativo = true;

            ProdutoEntities p2 = new ProdutoEntities();
            p2.Id = "2";
            p2.Descricao = "Teclado Sem Fio";
            p2.Fornecedor = "Kabum";
            p2.Estoque = "Filial 1";
            p2.Valor = 200.00f;
            p2.Ativo = false;

            ProdutoEntities p3 = new ProdutoEntities();
            p3.Id = "3";
            p3.Descricao = "Headset HyperX 7.1";
            p3.Fornecedor = "HyperX";
            p3.Estoque = "Filial 2";
            p3.Valor = 345.00f;
            p3.Ativo = true;

            ProdutoEntities p4 = new ProdutoEntities();
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

        public void insert(ProdutoEntities p)
        {
            database.Add(p);
        }
        public void update(ProdutoEntities p)
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
        public List<ProdutoEntities> getAll()
        {
            return database;
        }
        public ProdutoEntities getById(string Id)
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

