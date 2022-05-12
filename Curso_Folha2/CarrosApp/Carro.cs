using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosApp
{
    public class Carro
    {
        private string placa;
        public string Placa { get { return placa; } }

        private string modelo;
        public string Modelo { get { return modelo; } }

        private Motor motor;  
        public Motor Motor { get { return motor; } set { motor = value; } }

        public Carro(string _placa, string _modelo, Motor _motor)
        {
            this.placa = _placa;
            this.modelo = _modelo;   
            this.motor = _motor;
        }





    }
}
