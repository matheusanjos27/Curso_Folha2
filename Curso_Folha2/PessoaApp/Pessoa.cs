using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaApp
{

    public class Pessoa
    {
        private string nome;
        public string Nome { get { return nome; } }

        private CertidaoNascimento? certidaoNascimento;
        public CertidaoNascimento? CertidaoNascimento { get { return certidaoNascimento; } }

        public Pessoa()
        {
            this.nome = "";
            this.certidaoNascimento = null;
        }

        public void AddPessoa(string _nome)
        {
            if (!string.IsNullOrEmpty(this.nome))
            {
                throw new Exception("Ja existe uma pessoa cadastrada");
            }
            this.nome = _nome;
            this.certidaoNascimento = null;
        }


        public void AddCertidao(CertidaoNascimento _certidao)
        {
            if (this.certidaoNascimento != null)
            {
                throw new Exception("Ja existe uma certidao para essa pessoa");
            }
            this.certidaoNascimento = _certidao;
        }
    }
}
