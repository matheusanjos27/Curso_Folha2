using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressaoApp
{
    public abstract class Progressao
    {
        private int primeiro;
        public int Primeiro { get { return primeiro; } set { primeiro = value; } }

        private int razao;
        public int Razao { get { return razao; } set { razao = value; } }

        public abstract int ProximoValor { get;  }

        private int posicao;

        public int Posicao
        {
            get { return posicao; }
        }

        public abstract int TermoAt(int posicao);

        public void Reinicializar()
        {
            this.posicao = 1;
        }

        public Progressao() { }

        public Progressao(int _primeiro, int _razao)
        {
            this.primeiro = _primeiro;
            this.razao = _razao;
        }

    }
}
