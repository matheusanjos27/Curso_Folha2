using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoApp
{
    public class Curso
    {
        private string nome;
        public string Nome { get { return nome; } }

        private List<Aluno> alunos;
        public List<Aluno> Alunos { get { return alunos; } }

        private List<Turma> turmas;
        public List<Turma> Turmas { get { return turmas.OrderBy(o => o.Codigo).ToList<Turma>(); } }

        public Curso(string _nome)
        {
            this.nome = _nome;
            this.alunos = new List<Aluno>();
            this.turmas = new List<Turma>();
        }

        public string AddAluno(string nomeAluno)
        {
            Aluno aluno = new Aluno(nomeAluno);
            this.alunos.Add(aluno);
            return aluno.Matricula;
        }
        public bool AddTurma(string codigoTurma)
        {
            Turma turma = new Turma(codigoTurma);
            for (int i = 0; i < turmas.Count; i++)
            {
                if (turmas[i].Igual(turma))
                {
                    return false;
                }                
            }
            this.turmas.Add(turma);
            return true;
        }
        public bool RemoveTurma(Turma turma)
        {
            for (int i = 0; i < turmas.Count; i++)
            {
                if (turmas[i].Igual(turma))
                {
                    turmas.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }

        public Turma GetTurma(string codigoTurma)
        {
            for (int i = 0; i < turmas.Count; i++)
            {
                if (turmas[i].Codigo.Equals(codigoTurma))
                {
                    return turmas[i];
                }
            }
            return null;
        }
        public Aluno GetAluno(string matricula)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Matricula.Equals(matricula))
                {
                    return alunos[i];
                }
            }
            return null;
        }
    }

}
