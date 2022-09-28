using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08Ejercicio01Herencia
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadDeRuedas, short cantidadPuertas, EColores color) : base(cantidadDeRuedas, cantidadPuertas, color)
        {
            this.cilindrada = 0;
        }

        public Moto(short cantidadDeRuedas, short cantidadPuertas, EColores color,short cilindrada) : base(cantidadDeRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }



    }
}
