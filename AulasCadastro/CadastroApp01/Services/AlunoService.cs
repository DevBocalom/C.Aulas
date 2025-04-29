using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repository;

namespace Services
{
    public class AlunoService
    { 
        AlunoRepository alunoRepository = new AlunoRepository();

        public List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = alunoRepository.getAll();
            return alunos;
        }

        public void Insert(Aluno a)
        {
            // Validação de dados
            if (string.IsNullOrEmpty(a.Ra))
            {
                throw new Exception("RA não pode ser vazio");
            }
            if (string.IsNullOrEmpty(a.Nome))
            {
                throw new Exception("Nome não pode ser vazio");
            }
            if (string.IsNullOrEmpty(a.Curso))
            {
                throw new Exception("Curso não pode ser vazio");
            }
            List<Aluno> alunos = alunoRepository.getAll();
            for (int i = 0; i < alunos.Count; i++)
            {
                if (a.Ra == alunos[i].Ra)
                {
                    this.alunoRepository.update(a);
                    return;
                }
            }
            this.alunoRepository.insert(a);
        }

        public void update(Aluno a)
        {
            this.alunoRepository.update(a);
        }   

        public void delete(string ra)
        {

            this.alunoRepository.delete(ra);
        }

        public Aluno GetByRa(string ra)
        {
            Aluno a = alunoRepository.getByRa(ra);
            return a;
        }
    }
}
