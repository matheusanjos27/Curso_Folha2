using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurmaApp
{
    public class Aluno
    {
        private string nomealuno;
        public string NomeAluno { get { return nomealuno; } }

        private string matricula;
        public string Matricula { get { return matricula; } }

        private float p1;
        public float P1 { get { return p1; } }

        private float p2;
        public float P2 { get { return p2; } }

        public float Notafinal { get { return (p1 + p2) / 2; } }

        public Aluno() { }

        public Aluno(string _nomealuno, string _matricula, float _p1, float _p2)
        {
            this.nomealuno = _nomealuno;
            this.matricula = _matricula;
            this.p1 = _p1;
            this.p2 = _p2;
        }
        public bool Igual(Aluno _aluno)
        {
            if (this.matricula == _aluno.Matricula && this.nomealuno == _aluno.nomealuno)
            {
                return true;
            }
            return false;
        }
    }
}

