using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosApp
{
    public class Motor
    {
        private string cilindrada;

        public string Cilindrada { get { return cilindrada; } set { cilindrada = value; } }


        public Motor()
        {
        }
        public bool Igual(Motor motor)
        {
            if (this.cilindrada == motor.cilindrada)
            {
                return true;
            }
            return false;
        }
    }

}
