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

            Aluno a4 = new Aluno();
            a4.Ra = "44444";
            a4.Nome = "Maria";
            a4.Curso = "Engenharia Civil";

            Aluno a5 = new Aluno();
            a5.Ra = "55555";
            a5.Nome = "Ana";
            a5.Curso = "Psicologia";

            Aluno a6 = new Aluno();
            a6.Ra = "66666";
            a6.Nome = "Carlos";
            a6.Curso = "Administração";

            Aluno a7 = new Aluno();
            a7.Ra = "77777";
            a7.Nome = "Fernanda";
            a7.Curso = "Medicina";

            Aluno a8 = new Aluno();
            a8.Ra = "88888";
            a8.Nome = "Luciana";
            a8.Curso = "Arquitetura";

            Aluno a9 = new Aluno();
            a9.Ra = "99999";
            a9.Nome = "Rafael";
            a9.Curso = "Engenharia Mecânica";

            Aluno a10 = new Aluno();
            a10.Ra = "10101";
            a10.Nome = "Bruno";
            a10.Curso = "Design Gráfico";

            Aluno a11 = new Aluno();
            a11.Ra = "12121";
            a11.Nome = "Patrícia";
            a11.Curso = "Moda";

            Aluno a12 = new Aluno();
            a12.Ra = "13131";
            a12.Nome = "Juliana";
            a12.Curso = "Biomedicina";

            Aluno a13 = new Aluno();
            a13.Ra = "14141";
            a13.Nome = "Eduardo";
            a13.Curso = "Sistemas de Informação";

            Aluno a14 = new Aluno();
            a14.Ra = "15151";
            a14.Nome = "Tatiane";
            a14.Curso = "Engenharia de Produção";

            Aluno a15 = new Aluno();
            a15.Ra = "16161";
            a15.Nome = "Leonardo";
            a15.Curso = "Economia";

            Aluno a16 = new Aluno();
            a16.Ra = "17171";
            a16.Nome = "Camila";
            a16.Curso = "Direito";

            Aluno a17 = new Aluno();
            a17.Ra = "18181";
            a17.Nome = "Marcos";
            a17.Curso = "Fisioterapia";

            Aluno a18 = new Aluno();
            a18.Ra = "19191";
            a18.Nome = "Isabela";
            a18.Curso = "Farmácia";

            database.Add(a1);
            database.Add(a2);
            database.Add(a3);
            database.Add(a4);
            database.Add(a5);
            database.Add(a6);
            database.Add(a7);
            database.Add(a8);
            database.Add(a9);
            database.Add(a10);
            database.Add(a11);
            database.Add(a12);
            database.Add(a13);
            database.Add(a14);
            database.Add(a15);
            database.Add(a16);
            database.Add(a17);
            database.Add(a18);
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
