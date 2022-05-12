using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TurmaApp
{
    public class Turma
    {
        public float MediaP1 {
            get
            {
                float mediap1 = 0;
                for (int i = 0; i < alunos.Count; i++)
                {
                    mediap1 += alunos[i].P1;
                }
                mediap1 = mediap1 / alunos.Count;
                return (mediap1);
            }
        }

        public float MediaP2
        {
            get
            {
                float mediap2 = 0;
                for (int i = 0; i < alunos.Count; i++)
                {
                    mediap2 += alunos[i].P2;
                }
                mediap2 = mediap2 / alunos.Count;
                return (mediap2);
            }
        }

        public float MediaNotaFinal
        {
            get
            {
                float medianotafinal = 0;
                medianotafinal = 0;
                for (int i = 0; i < alunos.Count; i++)
                {
                    medianotafinal += alunos[i].Notafinal;
                }
                medianotafinal = medianotafinal / alunos.Count;
                return (medianotafinal);
            }
        }

        public Aluno AlunoMaiorNotaFinal
        {
            get
            {
                Aluno aluno = new Aluno();
                for (int i = 0; i < alunos.Count; i++)
                {
                    if (alunos[i].Notafinal > aluno.Notafinal)
                    {
                        aluno = alunos[i];
                    }
                }
                return (aluno);
            }
        }

        private List<Aluno> alunos;
        public List<Aluno> Alunos { get { return alunos.OrderBy(o => o.NomeAluno).ToList<Aluno>(); } }

        public Turma()
        {
            alunos = new List<Aluno>();
        }

        public bool AddAluno(Aluno _aluno)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Igual(_aluno))
                    return false;
            }
            alunos.Add(_aluno);
            return true;
        }
        public bool RemoverAluno(Aluno _aluno)
        {
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].Igual(_aluno))
                {
                    alunos.Remove(alunos[i]);
                    return true; ;
                }
            }
            return false;
        }   
    }
}
