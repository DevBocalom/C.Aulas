using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Repository
{
    public class AlunoRepository
    {
        //1. Atrubuto de classe
        List<Aluno> database = new List<Aluno>();

        public AlunoRepository()
        {
            Aluno a1 = new Aluno();
            a1.Ra = "11111";
            a1.Nome = "João";
            a1.Curso = "Nutrição";

            Aluno a2 = new Aluno();
            a2.Ra = "22222";
            a2.Nome = "Joaquim";
            a2.Curso = "Ciencia de Dados";

            Aluno a3 = new Aluno();
            a3.Ra = "33333";
            a3.Nome = "José";
            a3.Curso = "Ciencia da Computação";

            database.Add(a1);
            database.Add(a2);
            database.Add(a3);
        }

        public void insert(Aluno a)
        {
            database.Add(a);
        }

        public void update(Aluno a)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (a.Ra == database[i].Ra)
                {
                    database[i] = a;
                    return;
                }
            }
        }

        public void delete(string ra)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (ra == database[i].Ra)
                {
                    database.RemoveAt(i);
                    return;
                }
            }
        }

        public List<Aluno> getAll()
        {
            return database;
        }

        public Aluno getByRa(string ra)
        {
            for (int i = 0; i < database.Count; i++)
            {
                if (ra == database[i].Ra)
                {
                    return database[i];
                }
            }
            return null;
        }
    }
}
