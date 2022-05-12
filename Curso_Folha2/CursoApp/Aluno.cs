using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoApp
{
    public class Aluno
    {
        private string nome;
        public string Nome { get { return nome; } }

        private string matricula;
        public string Matricula { get { return matricula; } }    

        public Aluno(string _nome)
        {
            this.nome = _nome;
            this.matricula = DateTime.Now.ToString("yyyy") + new Random().Next(9999).ToString().PadLeft(4, '0') + DateTime.Now.ToString("ss");
        }
        public bool AlunoIgual(Aluno aluno)
        {
            if (this.matricula == aluno.matricula)
            {
                return true;
            }
            return false;
        }
    }

}
