using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaApp
{
    public class CertidaoNascimento
    {
        private DateTime data;

        public DateTime Data { get { return data; } }

        public CertidaoNascimento() { }

        public CertidaoNascimento(DateTime _data)
        {
            data = _data;
        }

    }
}
