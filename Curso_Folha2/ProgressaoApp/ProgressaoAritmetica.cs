using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressaoApp
{
    public class ProgressaoAritmetica : Progressao
    {
        public override int ProximoValor { get { return (Primeiro + (Posicao - 1) * Razao); } }

        public override int TermoAt(int posicao)
        {
            throw new NotImplementedException();
        }
    }
}
