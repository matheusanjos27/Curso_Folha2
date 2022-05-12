using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoApp
{
    public class Turma
    {
        private string codigo;
        public string Codigo { get { return codigo; } }

        private List<Aluno> alunosTurma;
        public List<Aluno> AlunosTurma { get { return alunosTurma.OrderBy(o => o.Nome).ToList<Aluno>(); } }

        public Turma()
        {
            alunosTurma = new List<Aluno>();
        }


        public Turma(string _codigo)
        {
            this.codigo = _codigo; alunosTurma = new List<Aluno>();
        }
        public bool Igual(Turma turma)
        {
            if (this.codigo == turma.codigo)
            {
                return true;
            }
            return false;
        }
        public bool AddAluno(Aluno aluno)
        {
            for (int i = 0; i < alunosTurma.Count; i++)
            {
                if (alunosTurma[i].AlunoIgual(aluno))
                {
                    return false;
                }
            }
            this.alunosTurma.Add(aluno);
            return true;
        }
        public bool RemoveAluno(Aluno aluno)
        {
            for (int i = 0; i < alunosTurma.Count; i++)
            {
                if (alunosTurma[i].AlunoIgual(aluno))
                {
                    alunosTurma.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}
